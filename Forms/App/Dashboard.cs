using MySql.Data.MySqlClient;
using Student_Information_System.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Information_System.Forms.App
{
    [SupportedOSPlatform("windows")]
    public partial class Dashboard : Form
    {
        private byte[] _photoBytes;
        private DataTable _studentTable;

        public Dashboard()
        {
            InitializeComponent();
            this.ResizeRedraw = true;
            WireEvents();
        }

        private void WireEvents()
        {
            this.Load -= Dashboard_Load;
            this.Load += Dashboard_Load;

            ButtonAdd.Click -= ButtonAdd_Click;
            ButtonAdd.Click += ButtonAdd_Click;

            ButtonEdit.Click -= ButtonEdit_Click;
            ButtonEdit.Click += ButtonEdit_Click;

            ButtonDelete.Click -= ButtonDelete_Click;
            ButtonDelete.Click += ButtonDelete_Click;

            ClearFieldsButton.Click -= ClearFieldsButton_Click;
            ClearFieldsButton.Click += ClearFieldsButton_Click;

            TestButton.Click -= TestButton_Click;      // "Change Photo" button
            TestButton.Click += TestButton_Click;

            dataGridView1.CellClick -= dataGridView1_CellClick;
            dataGridView1.CellClick += dataGridView1_CellClick;

            sortProgram.SelectedIndexChanged -= SortChanged;
            sortProgram.SelectedIndexChanged += SortChanged;

            sortYearLevel.SelectedIndexChanged -= SortChanged;
            sortYearLevel.SelectedIndexChanged += SortChanged;

            HookSearchBar();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            EnsureAllItem(sortProgram, "All Programs");
            EnsureAllItem(sortYearLevel, "All Years");

            LoadStudentRecords();
        }

        private static void EnsureAllItem(ComboBox combo, string allText)
        {
            bool hasAll = combo.Items.Count > 0 &&
                          Convert.ToString(combo.Items[0]).StartsWith("All", StringComparison.OrdinalIgnoreCase);

            if (!hasAll)
                combo.Items.Insert(0, allText);

            combo.SelectedIndex = 0;
        }

        // ---------- Reading / writing Cyber controls ----------

        // Returns the real value of an input control (trimmed).
        // Cyber text boxes keep what you type in an inner TextBox, so the outer .Text can be empty.
        private static string GetValue(Control c)
        {
            if (c is ComboBox cb)
            {
                if (cb.SelectedItem != null)
                    return Convert.ToString(cb.SelectedItem).Trim();
                return (cb.Text ?? string.Empty).Trim();
            }

            System.Windows.Forms.TextBox inner = FindTextBox(c);
            if (inner != null && !string.IsNullOrWhiteSpace(inner.Text))
                return inner.Text.Trim();

            return (c.Text ?? string.Empty).Trim();
        }

        // Sets the control's Text and also any inner TextBox, then forces a redraw
        private void SetText(Control c, string value)
        {
            c.Text = value;
            System.Windows.Forms.TextBox inner = FindTextBox(c);
            if (inner != null) inner.Text = value;
            c.Invalidate();
            c.Update();
        }

        private void ClearForm()
        {
            SetText(InputStudentID, string.Empty);
            SetText(InputFullName, string.Empty);
            SetText(InputYearLevel, string.Empty);
            SetText(InputContactNumber, string.Empty);

            InputGender.SelectedIndex = -1;
            InputGender.Text = string.Empty;
            InputProgram.SelectedIndex = -1;
            InputProgram.Text = string.Empty;

            InputStudentID.Enabled = true;
            InputStudentID.Focus();

            _photoBytes = null;
            ShowPhoto(null);
        }

        private void LoadStudentRecords()
        {
            try
            {
                using (MySqlConnection connection = DatabaseConnection.GetConnection())
                {
                    connection.Open();

                    string query =
                        "SELECT stud_id AS 'Student ID', " +
                        "stud_full_name AS 'Full Name', " +
                        "stud_gender AS 'Gender', " +
                        "stud_year_level AS 'Year Level', " +
                        "stud_program AS 'Program', " +
                        "stud_contact_number AS 'Contact Number' FROM stud_data ORDER BY stud_id ASC";

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        _studentTable = dataTable;
                        ApplyFilters();
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Unable to connect to the database (" + ex.Number + "): " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ApplyFilters()
        {
            if (_studentTable == null) return;

            var filters = new List<string>();

            string program = GetValue(sortProgram);
            if (sortProgram.SelectedIndex > 0 && !string.IsNullOrEmpty(program))
                filters.Add("[Program] = '" + program.Replace("'", "''") + "'");

            string year = GetValue(sortYearLevel);
            if (sortYearLevel.SelectedIndex > 0 && !string.IsNullOrEmpty(year))
                filters.Add("Convert([Year Level], 'System.String') = '" + year.Replace("'", "''") + "'");

            string search = GetValue(searchBar);
            if (!string.IsNullOrEmpty(search))
            {
                string s = EscapeLike(search);
                filters.Add("([Full Name] LIKE '%" + s + "%' OR [Student ID] LIKE '%" + s + "%')");
            }

            DataView view = _studentTable.DefaultView;
            view.RowFilter = string.Join(" AND ", filters);

            dataGridView1.DataSource = view;
            StyleGrid();
        }

        private void SortChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void HookSearchBar()
        {
            System.Windows.Forms.TextBox inner = FindTextBox(searchBar);
            if (inner == null)
            {
                MessageBox.Show("searchBar has no inner TextBox to hook. Replace it with a plain WinForms TextBox named searchBar.");
                return;
            }

            inner.TextChanged -= SortChanged;
            inner.TextChanged += SortChanged;
        }

        private static System.Windows.Forms.TextBox FindTextBox(Control parent)
        {
            foreach (Control c in parent.Controls)
            {
                if (c is System.Windows.Forms.TextBox tb) return tb;
                System.Windows.Forms.TextBox nested = FindTextBox(c);
                if (nested != null) return nested;
            }
            return null;
        }

        private static string EscapeLike(string value)
        {
            var sb = new StringBuilder();
            foreach (char c in value)
            {
                switch (c)
                {
                    case '\'': sb.Append("''"); break;
                    case '[':
                    case ']':
                    case '%':
                    case '*': sb.Append('[').Append(c).Append(']'); break;
                    default: sb.Append(c); break;
                }
            }
            return sb.ToString();
        }

        private void StyleGrid()
        {
            var g = dataGridView1;

            Color navy = ColorTranslator.FromHtml("#0F2A4A");
            Color selection = ColorTranslator.FromHtml("#DBEAFE");
            Color text = ColorTranslator.FromHtml("#1E293B");
            Color altRow = ColorTranslator.FromHtml("#F8FAFC");
            Color line = ColorTranslator.FromHtml("#E2E8F0");

            g.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            g.RowHeadersVisible = false;
            g.AllowUserToAddRows = false;
            g.AllowUserToResizeRows = false;
            g.ReadOnly = true;
            g.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            g.MultiSelect = false;
            g.BorderStyle = BorderStyle.None;
            g.BackgroundColor = Color.White;
            g.GridColor = line;
            g.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;

            g.EnableHeadersVisualStyles = false;
            g.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            g.ColumnHeadersHeight = 48;
            g.ColumnHeadersDefaultCellStyle.BackColor = navy;
            g.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            g.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            g.ColumnHeadersDefaultCellStyle.SelectionBackColor = navy;

            g.RowTemplate.Height = 36;
            g.DefaultCellStyle.Font = new Font("Segoe UI", 10F);
            g.DefaultCellStyle.ForeColor = text;
            g.DefaultCellStyle.Padding = new Padding(4, 0, 0, 0);
            g.DefaultCellStyle.SelectionBackColor = selection;
            g.DefaultCellStyle.SelectionForeColor = text;
            g.AlternatingRowsDefaultCellStyle.BackColor = altRow;
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            string id = GetValue(InputStudentID);
            string name = GetValue(InputFullName);
            string gender = GetValue(InputGender);
            string yearLevel = GetValue(InputYearLevel);
            string program = GetValue(InputProgram);
            string contact = GetValue(InputContactNumber);

            if (string.IsNullOrWhiteSpace(id) ||
                string.IsNullOrWhiteSpace(name) ||
                string.IsNullOrWhiteSpace(gender) ||
                string.IsNullOrWhiteSpace(yearLevel) ||
                string.IsNullOrWhiteSpace(program) ||
                string.IsNullOrWhiteSpace(contact))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            try
            {
                using (MySqlConnection conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();

                    string checkQuery = "SELECT COUNT(*) FROM stud_data WHERE stud_id = @id";

                    using (MySqlCommand checkCmd = new MySqlCommand(checkQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@id", id);

                        long count = Convert.ToInt64(checkCmd.ExecuteScalar());

                        if (count > 0)
                        {
                            MessageBox.Show("This Student ID already exists.");
                            return;
                        }
                    }

                    string insertQuery = "INSERT INTO stud_data " +
                    "(stud_id, stud_full_name, stud_gender, stud_year_level, stud_program, stud_contact_number, stud_photo) " +
                    "VALUES (@id, @name, @gender, @yearLevel, @program, @contactNumber, @photo)";

                    using (MySqlCommand cmd = new MySqlCommand(insertQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.Parameters.AddWithValue("@name", name);
                        cmd.Parameters.AddWithValue("@gender", gender);
                        cmd.Parameters.AddWithValue("@yearLevel", yearLevel);
                        cmd.Parameters.AddWithValue("@program", program);
                        cmd.Parameters.AddWithValue("@contactNumber", contact);
                        cmd.Parameters.Add("@photo", MySqlDbType.MediumBlob).Value = (object)_photoBytes ?? DBNull.Value;

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Student registered successfully!");
                LoadStudentRecords();
                ClearForm();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Database Error: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            string id = GetValue(InputStudentID);
            string name = GetValue(InputFullName);
            string gender = GetValue(InputGender);
            string yearLevel = GetValue(InputYearLevel);
            string program = GetValue(InputProgram);
            string contact = GetValue(InputContactNumber);

            if (string.IsNullOrWhiteSpace(id))
            {
                MessageBox.Show("Please select a student record to edit.");
                return;
            }

            if (string.IsNullOrWhiteSpace(name) ||
                string.IsNullOrWhiteSpace(gender) ||
                string.IsNullOrWhiteSpace(yearLevel) ||
                string.IsNullOrWhiteSpace(program) ||
                string.IsNullOrWhiteSpace(contact))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            try
            {
                using (MySqlConnection conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();

                    string updateQuery = "UPDATE stud_data SET " +
                        "stud_full_name = @name, " +
                        "stud_gender = @gender, " +
                        "stud_year_level = @yearLevel, " +
                        "stud_program = @program, " +
                        "stud_contact_number = @contactNumber, " +
                        "stud_photo = @photo " +
                        "WHERE stud_id = @id";

                    using (MySqlCommand cmd = new MySqlCommand(updateQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.Parameters.AddWithValue("@name", name);
                        cmd.Parameters.AddWithValue("@gender", gender);
                        cmd.Parameters.AddWithValue("@yearLevel", yearLevel);
                        cmd.Parameters.AddWithValue("@program", program);
                        cmd.Parameters.AddWithValue("@contactNumber", contact);
                        cmd.Parameters.Add("@photo", MySqlDbType.MediumBlob).Value = (object)_photoBytes ?? DBNull.Value;

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Student record updated successfully!");
                            LoadStudentRecords();
                            ClearForm();
                        }
                        else
                        {
                            MessageBox.Show("No record found with the provided Student ID.");
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Database Error: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            string id = GetValue(InputStudentID);

            if (string.IsNullOrWhiteSpace(id))
            {
                MessageBox.Show("Please select a student record to delete.");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete the student record with ID '" + id + "'?",
                "Confirm Deletion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
                return;

            try
            {
                using (MySqlConnection conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();

                    string deleteQuery = "DELETE FROM stud_data WHERE stud_id = @id";

                    using (MySqlCommand cmd = new MySqlCommand(deleteQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Student record deleted successfully!");
                            LoadStudentRecords();
                            ClearForm();
                        }
                        else
                        {
                            MessageBox.Show("No record found with the provided Student ID.");
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Database Error: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void ClearFieldsButton_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= dataGridView1.Rows.Count) return;

            try
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                if (row.IsNewRow) return;

                string studentId = Convert.ToString(row.Cells["Student ID"].Value);

                SetText(InputStudentID, studentId);
                SetText(InputFullName, Convert.ToString(row.Cells["Full Name"].Value));
                SetText(InputYearLevel, Convert.ToString(row.Cells["Year Level"].Value));
                SetText(InputContactNumber, Convert.ToString(row.Cells["Contact Number"].Value));

                string gender = Convert.ToString(row.Cells["Gender"].Value);
                string program = Convert.ToString(row.Cells["Program"].Value);
                InputGender.SelectedIndex = InputGender.FindStringExact(gender);
                InputProgram.SelectedIndex = InputProgram.FindStringExact(program);

                InputStudentID.Enabled = false;

                using (MySqlConnection conn = DatabaseConnection.GetConnection())
                using (MySqlCommand cmd = new MySqlCommand("SELECT stud_photo FROM stud_data WHERE stud_id = @id", conn))
                {
                    cmd.Parameters.AddWithValue("@id", studentId);
                    conn.Open();
                    _photoBytes = cmd.ExecuteScalar() as byte[];
                    ShowPhoto(_photoBytes);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Row click failed: " + ex.Message);
            }
        }

        // "Change Photo" button
        private void TestButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Images|*.jpg;*.jpeg;*.png;*.bmp";
                if (ofd.ShowDialog() != DialogResult.OK) return;

                if (new FileInfo(ofd.FileName).Length > 2 * 1024 * 1024)
                {
                    MessageBox.Show("Please choose an image under 2MB, pwease :>");
                    return;
                }

                _photoBytes = File.ReadAllBytes(ofd.FileName);
                ShowPhoto(_photoBytes);
            }
        }

        private void ShowPhoto(byte[] data)
        {
            pictureBox1.Image?.Dispose();
            if (data == null) { pictureBox1.Image = null; return; }

            using (MemoryStream ms = new MemoryStream(data))
            using (Image img = Image.FromStream(ms))
            {
                pictureBox1.Image = new Bitmap(img);
            }
        }

        private byte[] ResizeToFit(byte[] original, int targetW, int targetH, long quality = 85L)
        {
            using (MemoryStream input = new MemoryStream(original))
            using (Image src = Image.FromStream(input))
            using (Bitmap bmp = new Bitmap(targetW, targetH))
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                g.SmoothingMode = SmoothingMode.HighQuality;
                g.PixelOffsetMode = PixelOffsetMode.HighQuality;
                g.Clear(Color.White);

                float scale = Math.Max((float)targetW / src.Width, (float)targetH / src.Height);
                int srcW = (int)(targetW / scale);
                int srcH = (int)(targetH / scale);
                int srcX = (src.Width - srcW) / 2;
                int srcY = (src.Height - srcH) / 2;

                g.DrawImage(src,
                    new Rectangle(0, 0, targetW, targetH),
                    new Rectangle(srcX, srcY, srcW, srcH),
                    GraphicsUnit.Pixel);

                ImageCodecInfo jpeg = ImageCodecInfo.GetImageEncoders()
                    .First(c => c.FormatID == ImageFormat.Jpeg.Guid);
                EncoderParameters p = new EncoderParameters(1);
                p.Param[0] = new EncoderParameter(System.Drawing.Imaging.Encoder.Quality, quality);

                using (MemoryStream output = new MemoryStream())
                {
                    bmp.Save(output, jpeg, p);
                    return output.ToArray();
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void InputStudentID_TextChanged(object sender, EventArgs e) { }
        private void InputFullName_TextChanged(object sender, EventArgs e) { }
        private void InputGender_TextChanged(object sender, EventArgs e) { }
        private void InputYearLevel_TextChanged(object sender, EventArgs e) { }
        private void InputProgram_TextChanged(object sender, EventArgs e) { }
        private void InputContactNumber_TextChanged(object sender, EventArgs e) { }
    }
}