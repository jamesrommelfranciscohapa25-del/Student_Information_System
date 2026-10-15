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
        private readonly string connectionString = "server=localhost;port=330;database=stud_db;uid=root;pwd=powerRangers;charset=utf8mb4;";

        public Form1()
        {

            InitializeComponent();
            this.ResizeRedraw = true;
        }


        private void ClearForm()
        {
            InputStudentID.Clear();
            InputFullName.Clear();
            InputGender.Clear();
            InputYearLevel.Clear();
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

        private void ButtonAdd_Click(object sender, EventArgs e)
        {

        }

        private void ButtonEdit_Click(object sender, EventArgs e)
        {

        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {


        }

        private void ClearFieldsButton_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        // empty event handlers in case textboxes are accidentally double-clicked in the designer
        private void InputStudentID_TextChanged(object sender, EventArgs e) { }
        private void InputFullName_TextChanged(object sender, EventArgs e) { }
        private void InputGender_TextChanged(object sender, EventArgs e) { }
        private void InputYearLevel_TextChanged(object sender, EventArgs e) { }
        private void InputProgram_TextChanged(object sender, EventArgs e) { }
        private void InputContactNumber_TextChanged(object sender, EventArgs e) { }
    }
}
