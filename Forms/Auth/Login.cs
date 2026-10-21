using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Student_Information_System.Database;

/*
design:
InputUsername
InputUserPassword
BtnLogin_Click

sql:
login_data (table)
login_username
login_password

--------------------------------------------------------

CREATE DATABASE IF NOT EXISTS login_db;
USE login_db;

CREATE TABLE IF NOT EXISTS login_data(
    login_username VARCHAR(50) NOT NULL PRIMARY KEY,
    login_password VARCHAR(50) NOT NULL
);

INSERT INTO login_data (
    login_username, 
    login_password) 
VALUES (
'Andrei Duran',
'admin123')
ON DUPLICATE KEY UPDATE login_password = VALUES(login_password);

SELECT * FROM login_data;
*/

namespace Student_Information_System.Forms
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        //clear input fieldss
        private void ClearForm()
        {
            InputUsername.Clear();
            InputUserPassword.Clear();
        }

        //fetch login info from database
        private void LoadLoginInfo()
        {
            try
            {
                using (MySqlConnection connection = DatabaseConnection.GetConnection())
                {
                    connection.Open();

                    string query =
                        "SELECT login_username AS 'Login Username', " +
                        "login_password AS 'Login Password' FROM login_data ORDER BY login_username ASC;";
                }

                using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    //StyleGrid();
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

        private void Login_Load(object sender, EventArgs e)
        {
            LoadLoginInfo();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string username = InputUsername.Text.Trim();
            string password = InputUserPassword.Text.Trim();

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter both username and password.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (MySqlConnection connection = DatabaseConnection.GetConnection())
                {
                    connection.Open();

                    string query = "SELECT COUNT(*) FROM login_data WHERE login_username = @username AND login_password = @password;";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@username", InputUsername.Text.Trim());
                        command.Parameters.AddWithValue("@password", InputUserPassword.Text.Trim());

                        int count = Convert.ToInt32(command.ExecuteScalar());

                        if (count > 0)
                        {
                            MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            // Proceed to the next form or main application window
                        }
                        else
                        {
                            MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
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
    }
}