using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Student_Information_System.Database;
using Student_Information_System.Forms.App;
using MySql.Data.MySqlClient;
/*
design:
InputUsername
InputUserPassword
BtnLogin_Click

sql:
login_data (table)
login_username
login_password

-----------------------------------------------------------

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

namespace Student_Information_System.Forms.Auth
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

            // "-=" first so the handler can never run twice if the designer also wired it
            BtnLogin.Click -= BtnLogin_Click;
            BtnLogin.Click += BtnLogin_Click;
        }

        // ---------- Helpers for the Cyber controls ----------

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

        // Real value of an input control (trimmed). Cyber text boxes keep what you type
        // in an inner TextBox, so the outer .Text can be empty.
        private static string GetValue(Control c)
        {
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

        //clear input fields
        private void ClearForm()
        {
            SetText(usernameIput, string.Empty);
            SetText(passwordInput, string.Empty);
        }

        //fetch login info from database
        private void LoadLoginInfo()
        {
            try
            {
                using (MySqlConnection connection =
                        LoginDatabaseConnection.GetConnection())
                {
                    connection.Open();

                    string query =
                        "SELECT login_username AS 'Login Username', " +
                        "login_password AS 'Login Password' " +
                        "FROM login_data ORDER BY login_username ASC;";

                    using (MySqlDataAdapter adapter =
                        new MySqlDataAdapter(query, connection))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(
                    "Database error (" + ex.Number + "): " + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "An error occurred: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            LoadLoginInfo();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string username = GetValue(usernameIput);
            string password = GetValue(passwordInput);

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter both username and password.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (MySqlConnection connection = LoginDatabaseConnection.GetConnection())
                {
                    connection.Open();

                    string query = "SELECT COUNT(*) FROM login_data WHERE login_username = @username AND login_password = @password;";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@username", username);
                        command.Parameters.AddWithValue("@password", password);

                        int count = Convert.ToInt32(command.ExecuteScalar());

                        if (count > 0)
                        {
                            MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            Dashboard mainForm = new Dashboard();
                            // Login is only hidden, so close the whole app when the Dashboard closes.
                            // Without this the process keeps running and locks the .exe on the next build.
                            mainForm.FormClosed += (s, args) => Application.Exit();
                            mainForm.Show();

                            ClearForm();
                            this.Hide();
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