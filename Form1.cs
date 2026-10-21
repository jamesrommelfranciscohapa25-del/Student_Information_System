using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Versioning;
using MySql.Data.MySqlClient;
using System.Drawing.Imaging;
using Student_Information_System.Database;
using System.Drawing.Drawing2D;

/*
INPUT FIELDS:
    Takes in strings:

    InputStudentID
    InputFullName
    InputGender
    InputYearLevel
    InputProgram
    InputContactNumber

BUTTONS:
    ClearFieldsButton
    ButtonAdd
    ButtonDelete
    ButtonEdit

DATA GRID VIEW:
    dataGridView1

*/

namespace Student_Information_System
{
    [SupportedOSPlatform("windows")]
    public partial class Form1 : Form
    {
        private byte[] _photoBytes;
        public Form1()
        {
            InitializeComponent();
            this.ResizeRedraw = true;
            this.Load += Form1_Load;
        }

        private void ClearForm()
        {
            InputStudentID.Clear();
            InputFullName.Clear();
            InputYearLevel.Clear();
            InputGender.SelectedIndex = -1; // resets the dropdown selecetion stuff
            InputProgram.Clear();
            InputContactNumber.Clear();
            InputStudentID.ReadOnly = false; // allow editing of Student ID after clearing the form
            InputStudentID.Focus(); // set focus to the Student ID field after clearing the form
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

                        dataGridView1.DataSource = dataTable;
                        StyleGrid();
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

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadStudentRecords();
        }

        private void StyleGrid()
        {
            var g = dataGridView1;

            // Layout
            g.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;   // columns fill the width
            g.RowHeadersVisible = false;           // removes the empty left column
            g.AllowUserToAddRows = false;          // removes the blank "*" row
            g.AllowUserToResizeRows = false;
            g.ReadOnly = true;                     // edits go through your Edit button
            g.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            g.MultiSelect = false;
            g.BorderStyle = BorderStyle.None;
            g.BackgroundColor = Color.White;
            g.GridColor = Color.Gainsboro;
            g.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;  // horizontal lines only

            // Header
            g.EnableHeadersVisualStyles = false;   // required, or the header colors are ignored
            g.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            g.ColumnHeadersHeight = 60;
            g.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
            g.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            g.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            g.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.Black;

            // Rows
            g.RowTemplate.Height = 32;
            g.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 10F);
            g.DefaultCellStyle.Padding = new Padding(4, 0, 0, 0);
            g.DefaultCellStyle.SelectionBackColor = Color.FromArgb(60, 60, 60);
            g.DefaultCellStyle.SelectionForeColor = Color.White;
            g.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 245);
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(InputStudentID.Text) ||
                string.IsNullOrWhiteSpace(InputFullName.Text) ||
                string.IsNullOrWhiteSpace(InputGender.Text) ||
                string.IsNullOrWhiteSpace(InputYearLevel.Text) ||
                string.IsNullOrWhiteSpace(InputProgram.Text) ||
                string.IsNullOrWhiteSpace(InputContactNumber.Text))
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
                        checkCmd.Parameters.AddWithValue("@id", InputStudentID.Text.Trim());

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
                        cmd.Parameters.AddWithValue("@id", InputStudentID.Text.Trim());
                        cmd.Parameters.AddWithValue("@name", InputFullName.Text.Trim());
                        cmd.Parameters.AddWithValue("@gender", InputGender.Text.Trim());
                        cmd.Parameters.AddWithValue("@yearLevel", InputYearLevel.Text.Trim());
                        cmd.Parameters.AddWithValue("@program", InputProgram.Text.Trim());
                        cmd.Parameters.AddWithValue("@contactNumber", InputContactNumber.Text.Trim());
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
            if (string.IsNullOrWhiteSpace(InputStudentID.Text))
            {
                MessageBox.Show("Please select a student record to edit.");
                return;
            }

            if (string.IsNullOrWhiteSpace(InputFullName.Text) ||
                string.IsNullOrWhiteSpace(InputGender.Text) ||
                string.IsNullOrWhiteSpace(InputYearLevel.Text) ||
                string.IsNullOrWhiteSpace(InputProgram.Text) ||
                string.IsNullOrWhiteSpace(InputContactNumber.Text))
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
                        cmd.Parameters.AddWithValue("@id", InputStudentID.Text.Trim());
                        cmd.Parameters.AddWithValue("@name", InputFullName.Text.Trim());
                        cmd.Parameters.AddWithValue("@gender", InputGender.Text.Trim());
                        cmd.Parameters.AddWithValue("@yearLevel", InputYearLevel.Text.Trim());
                        cmd.Parameters.AddWithValue("@program", InputProgram.Text.Trim());
                        cmd.Parameters.AddWithValue("@contactNumber", InputContactNumber.Text.Trim());
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
            if (string.IsNullOrWhiteSpace(InputStudentID.Text))
            {
                MessageBox.Show("Please select a student record to delete.");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete the student record with ID '" +
                InputStudentID.Text.Trim() + "'?",
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
                        cmd.Parameters.AddWithValue("@id", InputStudentID.Text.Trim());

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
            if (e.RowIndex < 0 || e.RowIndex >= dataGridView1.Rows.Count)
            {
                return;
            }

            DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

            if (selectedRow.IsNewRow)
                return;

            InputStudentID.Text = Convert.ToString(selectedRow.Cells["Student ID"].Value);
            InputFullName.Text = Convert.ToString(selectedRow.Cells["Full Name"].Value);
            InputGender.Text = Convert.ToString(selectedRow.Cells["Gender"].Value);
            InputYearLevel.Text = Convert.ToString(selectedRow.Cells["Year Level"].Value);
            InputProgram.Text = Convert.ToString(selectedRow.Cells["Program"].Value);
            InputContactNumber.Text = Convert.ToString(selectedRow.Cells["Contact Number"].Value);

            InputStudentID.ReadOnly = true;

            using (MySqlConnection conn = DatabaseConnection.GetConnection())
            using (MySqlCommand cmd = new MySqlCommand("SELECT stud_photo FROM stud_data WHERE stud_id = @id", conn))
            {
                cmd.Parameters.AddWithValue("@id", InputStudentID.Text);
                conn.Open();
                _photoBytes = cmd.ExecuteScalar() as byte[];
                ShowPhoto(_photoBytes);
            }
        }

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

                // scale so the image covers the whole box, then trim the overflow from the center
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