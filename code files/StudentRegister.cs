using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_prj
{


    public partial class StudentRegister : Form
    {

        private const string ConnectionString = "Data Source=DESKTOP-NJFG0UQ\\SQLEXPRESS;Initial Catalog=final;Integrated Security=True"; // Replace with your actual connection string

        public StudentRegister()
        {
            InitializeComponent();
        }

        private void StudentRegister_Load(object sender, EventArgs e)
        {

        }

        private void BtnAdminSignup_Click(object sender, EventArgs e)
        {
            // Retrieve entered student details from textboxes
            string studentName = txtStudentName.Text;
            string username = txtStudentUserName.Text;
            string password = txtStudentPassword.Text;
            string email = txtStudentEmail.Text;
            string studentId = txtStudentId.Text;
            string dob = txtStudentDOB.Text; // Assuming txtStudentDOB is a DateTimePicker
            string phone = txtStudentPhone.Text;

            // Validate the phone number (you can add more validations as needed)
            if (!IsValidPhoneNumber(phone))
            {
                MessageBox.Show("Invalid phone number format. Please enter a valid phone number.");
                return;
            }

            // Check if the username or studentId already exists
            if (UsernameOrStudentIdExists(username, studentId))
            {
                MessageBox.Show("Username or StudentId already exists. Please choose a different one.");
                return; // Exit the method to prevent further processing
            }

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                // Insert data into UserRole table
                string userRoleInsertQuery = "INSERT INTO UserRole (RoleId, RoleName, Password, Username1) VALUES (@RoleId, 'Student', @Password, @Username)";
                using (SqlCommand userRoleCommand = new SqlCommand(userRoleInsertQuery, connection))
                {
                    userRoleCommand.Parameters.AddWithValue("@RoleId", studentId);
                    userRoleCommand.Parameters.AddWithValue("@Password", password);
                    userRoleCommand.Parameters.AddWithValue("@Username", username);
                    userRoleCommand.ExecuteNonQuery();
                }

                // Randomly select a supervisor from the Supervisor table
                string randomSupervisorQuery = "SELECT TOP 1 SupervisorID FROM Supervisor ORDER BY NEWID()";
                string supervisorId;
                using (SqlCommand randomSupervisorCommand = new SqlCommand(randomSupervisorQuery, connection))
                {
                    supervisorId = randomSupervisorCommand.ExecuteScalar().ToString();
                }

                // Insert data into Student table
                string studentInsertQuery = "INSERT INTO Student (StudentID, SName, Email, DOB, Phone, RoleID, SupervisorID) VALUES (@StudentID, @SName, @Email, @DOB, @Phone, @RoleID, @SupervisorID)";
                using (SqlCommand studentCommand = new SqlCommand(studentInsertQuery, connection))
                {
                    studentCommand.Parameters.AddWithValue("@StudentID", studentId);
                    studentCommand.Parameters.AddWithValue("@SName", studentName);
                    studentCommand.Parameters.AddWithValue("@Email", email);
                    studentCommand.Parameters.AddWithValue("@DOB", dob);
                    studentCommand.Parameters.AddWithValue("@Phone", phone);
                    studentCommand.Parameters.AddWithValue("@RoleID", studentId);
                    studentCommand.Parameters.AddWithValue("@SupervisorID", supervisorId);
                    studentCommand.ExecuteNonQuery();
                }

                MessageBox.Show("Student registration successful!");

                // Hide the current form (StudentRegister)
                this.Hide();

                // Show Form1 (or any other form you want to navigate to)
                Form1 form1 = new Form1();
                form1.Show();
            }



        }



        private bool UsernameOrStudentIdExists(string username, string studentId)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                // Check if the username exists in UserRole table
                string usernameExistsQuery = "SELECT COUNT(*) FROM UserRole WHERE Username1 = @Username";
                using (SqlCommand usernameExistsCommand = new SqlCommand(usernameExistsQuery, connection))
                {
                    usernameExistsCommand.Parameters.AddWithValue("@Username", username);
                    int usernameCount = Convert.ToInt32(usernameExistsCommand.ExecuteScalar());
                    if (usernameCount > 0)
                    {
                        return true;
                    }
                }

                // Check if the studentId exists in Student table
                string studentIdExistsQuery = "SELECT COUNT(*) FROM Student WHERE StudentID = @StudentID";
                using (SqlCommand studentIdExistsCommand = new SqlCommand(studentIdExistsQuery, connection))
                {
                    studentIdExistsCommand.Parameters.AddWithValue("@StudentID", studentId);
                    int studentIdCount = Convert.ToInt32(studentIdExistsCommand.ExecuteScalar());
                    if (studentIdCount > 0)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        private bool IsValidPhoneNumber(string phone)
        {
            // Implement your phone number validation logic here
            // For example, you can use regular expressions to validate the format
            // For simplicity, let's assume any non-empty string is considered valid
            return !string.IsNullOrWhiteSpace(phone);
        }
    }
}

