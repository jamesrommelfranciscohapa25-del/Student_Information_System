using System;
using MySql.Data.MySqlClient;

namespace Student_Information_System.Database
{
    public static class DatabaseConnection
    {
        // magkaiba tabi ang key natun, palitan nyo nalang kapag diri kamo naka connect sa db
        // maraming salamat
        private static readonly string connectionString =
            "server=127.0.0.1;" + // palitan niyo sang sa hostname niyo
            "port=3307;" +
            "database=stud_db;" + // check comment sa pinakababa (code sa mysql kung gusto niyo i try)
            "uid=root;" +
            "pwd=Je197@du;" + // palitan niyo sang password niyo sa mysql
            "charset=utf8mb4;";

        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }

        public static bool TestConnection(out string message)
        {
            try
            {
                using (MySqlConnection conn = GetConnection())
                {
                    conn.Open();
                    message = "Connected to MySQL successfully!";
                    return true;
                }
            }
            catch (MySqlException ex)
            {
                message = "MySQL Error " + ex.Number + ": " + ex.Message;
                return false;
            }
            catch (Exception ex)
            {
                message = "Error: " + ex.Message;
                return false;
            }
        }
    }
}

// code sa mysql (ayuson niyo na lang indention
/*
 * 
query 1:

-- create a database named stud_db
CREATE DATABASE IF NOT EXISTS stud_db;
USE stud_db;

-- a table to store student records (Student ID, Name, Gender, Year Level, Program, Contact Number).
CREATE TABLE IF NOT EXISTS stud_data(
    stud_id VARCHAR(20) NOT NULL PRIMARY KEY,
    stud_full_name VARCHAR(100) NOT NULL,
    stud_gender ENUM('Male', 'Female', 'Other', 'Prefer not to say') NOT NULL,
    stud_year_level INT NOT NULL CHECK (stud_year_level BETWEEN 1 AND 5),
    stud_program VARCHAR(50) NOT NULL,
    stud_contact_number VARCHAR(16) NOT NULL CHECK (stud_contact_number REGEXP '^[+]63 [0-9]{3} [0-9]{3} [0-9]{4}$'),
    stud_photo MEDIUMBLOB NULL
);

-- sample student info for the students table
INSERT INTO stud_data(
    stud_id,
    stud_full_name, 
    stud_gender, 
    stud_year_level, 
    stud_program, 
    stud_contact_number)
VALUES(
    '2025-23-12345', 
    'James Rommel Harapa', 
    'Other', 
    4, 
    'BS Biology', 
    '+63 123 456 7890')
ON DUPLICATE KEY UPDATE stud_full_name = VALUES(stud_full_name);

-- display sample data
SELECT * FROM stud_data;

-- ALTER USER 'root'@'localhost' 
-- IDENTIFIED BY 'powerRangers';

-- FLUSH PRIVILEGES;

------------------------------------------
query 2:
USE stud_db;
   ALTER TABLE stud_data ADD COLUMN stud_photo MEDIUMBLOB NULL;

 
 */
