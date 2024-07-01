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
    public partial class AdminRegister : Form
    {


        private const string ConnectionString = "Data Source=DESKTOP-NJFG0UQ\\SQLEXPRESS;Initial Catalog=final;Integrated Security=True"; // Replace with your actual connection string

        public AdminRegister()
        {
            InitializeComponent();
        }

        private void AdminRegister_Load(object sender, EventArgs e)
        {

        }

        private void BtnAdminSignup_Click(object sender, EventArgs e)
        {
            // Retrieve entered admin details from textboxes
            string adminName = txtAdminName.Text;
            string username = txtAdminUserName.Text;
            string password = txtAdminPassword.Text;
            string email = txtAdminEmail.Text;
            string adminId = txtAdminId.Text;

            // Check if the username or adminId already exists
            if (UsernameOrAdminIdExists(username, adminId))
            {
                MessageBox.Show("Username or AdminId already exists. Please choose a different one.");
                return; // Exit the method to prevent further processing
            }

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                // Insert data into UserRole table
                string userRoleInsertQuery = "INSERT INTO UserRole (RoleId, RoleName, Password, Username1) VALUES (@RoleId, 'Admin', @Password, @Username)";
                using (SqlCommand userRoleCommand = new SqlCommand(userRoleInsertQuery, connection))
                {
                    userRoleCommand.Parameters.AddWithValue("@RoleId", adminId);
                    userRoleCommand.Parameters.AddWithValue("@Password", password);
                    userRoleCommand.Parameters.AddWithValue("@Username", username);
                    userRoleCommand.ExecuteNonQuery();
                }

                // Insert data into Administrator table
                string adminInsertQuery = "INSERT INTO Administrator (AdminId, AName, Email, RoleId) VALUES (@AdminId, @AdminName, @Email, @RoleId)";
                using (SqlCommand adminCommand = new SqlCommand(adminInsertQuery, connection))
                {
                    adminCommand.Parameters.AddWithValue("@AdminId", adminId);
                    adminCommand.Parameters.AddWithValue("@AdminName", adminName);
                    adminCommand.Parameters.AddWithValue("@Email", email);
                    adminCommand.Parameters.AddWithValue("@RoleId", adminId);
                    adminCommand.ExecuteNonQuery();
                }

                MessageBox.Show("Admin registration successful!");


                // Hide the current form (AdminRegister)
                this.Hide();

                // Show Form1
                Form1 form1 = new Form1();
                form1.Show();
            }
        }



        private bool UsernameOrAdminIdExists(string username, string adminId)
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

                // Check if the adminId exists in Administrator table
                string adminIdExistsQuery = "SELECT COUNT(*) FROM Administrator WHERE AdminId = @AdminId";
                using (SqlCommand adminIdExistsCommand = new SqlCommand(adminIdExistsQuery, connection))
                {
                    adminIdExistsCommand.Parameters.AddWithValue("@AdminId", adminId);
                    int adminIdCount = Convert.ToInt32(adminIdExistsCommand.ExecuteScalar());
                    if (adminIdCount > 0)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}



