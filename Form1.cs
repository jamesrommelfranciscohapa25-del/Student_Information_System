using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;

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
    public partial class Form1 : Form
    {
        // magkaiba tabi ang key natun, palitan nyo nalang kapag diri kamo naka connect sa db
        // maraming salamat
        private readonly string connectionString = "server=127.0.0.1;port=3307;database=stud_db;uid=root;pwd=Je197@du;charset=utf8mb4;";

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
        }

        private void LoadStudentRecords()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT stud_id AS 'Student ID', stud_full_name AS 'Full Name', stud_gender AS 'Gender', stud_year_level AS 'Year Level', stud_program AS 'Program', stud_contact_number AS 'Contact Number' FROM stud_data ORDER BY stud_id ASC";

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
                using (MySqlConnection conn = new MySqlConnection(connectionString))
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
                        "(stud_id, stud_full_name, stud_gender, " +
                        "stud_year_level, stud_program, stud_contact_number) " +
                        "VALUES (@id, @name, @gender, @yearLevel, " +
                        "@program, @contactNumber)";

                    using (MySqlCommand cmd = new MySqlCommand(insertQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", InputStudentID.Text.Trim());
                        cmd.Parameters.AddWithValue("@name", InputFullName.Text.Trim());
                        cmd.Parameters.AddWithValue("@gender", InputGender.Text.Trim());
                        cmd.Parameters.AddWithValue("@yearLevel", InputYearLevel.Text.Trim());
                        cmd.Parameters.AddWithValue("@program", InputProgram.Text.Trim());
                        cmd.Parameters.AddWithValue("@contactNumber", InputContactNumber.Text.Trim());

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
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    string updateQuery = "UPDATE stud_data SET " +
                        "stud_full_name = @name, " +
                        "stud_gender = @gender, " +
                        "stud_year_level = @yearLevel, " +
                        "stud_program = @program, " +
                        "stud_contact_number = @contactNumber " +
                        "WHERE stud_id = @id";

                    using (MySqlCommand cmd = new MySqlCommand(updateQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", InputStudentID.Text.Trim());
                        cmd.Parameters.AddWithValue("@name", InputFullName.Text.Trim());
                        cmd.Parameters.AddWithValue("@gender", InputGender.Text.Trim());
                        cmd.Parameters.AddWithValue("@yearLevel", InputYearLevel.Text.Trim());
                        cmd.Parameters.AddWithValue("@program", InputProgram.Text.Trim());
                        cmd.Parameters.AddWithValue("@contactNumber", InputContactNumber.Text.Trim());

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
                using (MySqlConnection conn = new MySqlConnection(connectionString))
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