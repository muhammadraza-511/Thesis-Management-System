using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Final_prj
{
    public partial class Form1 : Form
    {
        private const string ConnectionString = "Data Source=DESKTOP-NJFG0UQ\\SQLEXPRESS;Initial Catalog=final;Integrated Security=True"; // Replace with your actual connection string

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //// Retrieve entered username, password, and user type from textboxes
            //string enteredUsername = txtUserName.Text;
            //string enteredPassword = txtPassword.Text;
            //string enteredUserType = txtUserType.Text;

            //using (SqlConnection connection = new SqlConnection(ConnectionString))
            //{
            //    connection.Open();

            //    // Check if the user exists in the UserRole table
            //    string query = "SELECT RoleName, Password FROM UserRole WHERE Username1 = @Username";
            //    using (SqlCommand command = new SqlCommand(query, connection))
            //    {
            //        command.Parameters.AddWithValue("@Username", enteredUsername);

            //        using (SqlDataReader reader = command.ExecuteReader())
            //        {
            //            if (reader.Read())
            //            {
            //                // User found, check the password
            //                string storedPassword = reader["Password"].ToString();
            //                string userRole = reader["RoleName"].ToString();

            //                if (enteredPassword == storedPassword)
            //                {
            //                    // Password is correct
            //                    MessageBox.Show("Login successful!");

            //                    // Navigate to the appropriate form based on the user type
            //                    switch (userRole)
            //                    {
            //                        case "Admin":
            //                        //case "Admin":
            //                            AdminMenu adminMenu = new AdminMenu();
            //                            adminMenu.SetWelcomeMessage(enteredUsername); // SetWelcomeMessage is an example method to set the welcome message
            //                            adminMenu.Show();
            //                            break;

            //                        case "Supervisor":
            //                            txtSupervisorMenu supervisorForm = new txtSupervisorMenu();
            //                            supervisorForm.SetWelcomeMessage(enteredUsername);
            //                            supervisorForm.Show();
            //                            break;

            //                        case "Student":
            //                            StudentMenu studentMenu = new StudentMenu();
            //                            studentMenu.SetWelcomeMessage(enteredUsername);
            //                            studentMenu.Show();
            //                            break;

            //                        case "PanelMember":
            //                            PMMenu pmMenu = new PMMenu();
            //                            pmMenu.SetWelcomeMessage(enteredUsername);
            //                            pmMenu.Show();
            //                            break;

            //                        default:
            //                            MessageBox.Show("Invalid user type.");
            //                            break;
            //                    }

            //                    // Hide the login form (Form1)
            //                    this.Hide();
            //                }
            //                else
            //                {
            //                    // Password is incorrect
            //                    MessageBox.Show("Invalid password. Please try again.");
            //                }
            //            }
            //            else
            //            {
            //                // User not found
            //                MessageBox.Show("User not found. Please check your username.");
            //            }
            //        }


            //    }
            //}





            // Retrieve entered username, password, and user type from textboxes
            string enteredUsername = txtUserName.Text;
            string enteredPassword = txtPassword.Text;
            string enteredUserType = txtUserType.Text;

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                // Check if the user exists in the UserRole table
                string query = "SELECT RoleName, Password FROM UserRole WHERE Username1 = @Username AND RoleName = @UserType";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", enteredUsername);
                    command.Parameters.AddWithValue("@UserType", enteredUserType);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // User found, check the password
                            string storedPassword = reader["Password"].ToString();
                            string userRole = reader["RoleName"].ToString();

                            if (enteredPassword == storedPassword)
                            {
                                // Password is correct
                                MessageBox.Show("Login successful!");

                                // Navigate to the appropriate form based on the user type
                                switch (userRole)
                                {
                                    case "Admin":
                                        AdminMenu adminMenu = new AdminMenu();
                                        adminMenu.SetWelcomeMessage(enteredUsername);
                                        adminMenu.Show();
                                        break;

                                    case "Supervisor":
                                        txtSupervisorMenu supervisorForm = new txtSupervisorMenu();
                                        supervisorForm.SetWelcomeMessage(enteredUsername);
                                        supervisorForm.Show();
                                        break;

                                    case "Student":
                                        StudentMenu studentMenu = new StudentMenu();
                                        studentMenu.SetWelcomeMessage(enteredUsername);
                                        studentMenu.Show();
                                        break;

                                    case "PanelMember":
                                        PMMenu pmMenu = new PMMenu();
                                        pmMenu.SetWelcomeMessage(enteredUsername);
                                        pmMenu.Show();
                                        break;

                                    default:
                                        MessageBox.Show("Invalid user type.");
                                        break;
                                }

                                // Hide the login form (Form1)
                                this.Hide();
                            }
                            else
                            {
                                // Password is incorrect
                                MessageBox.Show("Invalid password. Please try again.");
                            }
                        }
                        else
                        {
                            // User not found
                            MessageBox.Show("User not found or invalid user type. Please check your credentials.");
                        }
                    }
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblUsertype_Click(object sender, EventArgs e)
        {

        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUserType_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void linkCreateAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //// Open the registration form
            //Registeration registr = new Registeration();
            //registr.Show();
            //this.Hide(); // Optionally hide the login form
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            Registeration registr = new Registeration();
            registr.Show();
            this.Hide(); // Optionally hide the login form
        }
    }
}
