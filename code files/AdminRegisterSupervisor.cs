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
    public partial class AdminRegisterSupervisor : Form
    {

        private const string ConnectionString = "Data Source=DESKTOP-NJFG0UQ\\SQLEXPRESS;Initial Catalog=final;Integrated Security=True"; // Replace with your actual connection string



        public AdminRegisterSupervisor()
        {
            InitializeComponent();
        }

        private void txtSupervisorName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSupervisorUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSupervisorEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSupervisorPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSupervisorId_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSupervisorDOB_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSignUpSupervisor_Click(object sender, EventArgs e)
        {
            // Retrieve entered supervisor details from textboxes
            string supervisorName = txtSupervisorName.Text;
            string username = txtSupervisorUserName.Text;
            string password = txtSupervisorPassword.Text;
            string email = txtSupervisorEmail.Text;
            string supervisorId = txtSupervisorId.Text;
            string dob = txtSupervisorDOB.Text; // Assuming txtSupervisorDOB is a DateTimePicker

            // Check if the username or supervisorId already exists
            if (UsernameOrSupervisorIdExists(username, supervisorId))
            {
                MessageBox.Show("Username or SupervisorId already exists. Please choose a different one.");
                return; // Exit the method to prevent further processing
            }

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                // Insert data into UserRole table
                string userRoleInsertQuery = "INSERT INTO UserRole (RoleId, RoleName, Password, Username1) VALUES (@RoleId, 'Supervisor', @Password, @Username)";
                using (SqlCommand userRoleCommand = new SqlCommand(userRoleInsertQuery, connection))
                {
                    userRoleCommand.Parameters.AddWithValue("@RoleId", supervisorId);
                    userRoleCommand.Parameters.AddWithValue("@Password", password);
                    userRoleCommand.Parameters.AddWithValue("@Username", username);
                    userRoleCommand.ExecuteNonQuery();
                }

                // Insert data into Supervisor table
                string supervisorInsertQuery = "INSERT INTO Supervisor (SupervisorID, Name, Email, DOB, RoleID) VALUES (@SupervisorID, @Name, @Email, @DOB, @RoleID)";
                using (SqlCommand supervisorCommand = new SqlCommand(supervisorInsertQuery, connection))
                {
                    supervisorCommand.Parameters.AddWithValue("@SupervisorID", supervisorId);
                    supervisorCommand.Parameters.AddWithValue("@Name", supervisorName);
                    supervisorCommand.Parameters.AddWithValue("@Email", email);
                    supervisorCommand.Parameters.AddWithValue("@DOB", dob);
                    supervisorCommand.Parameters.AddWithValue("@RoleID", supervisorId);
                    supervisorCommand.ExecuteNonQuery();
                }

                MessageBox.Show("Supervisor registration successful!");

                // Hide the current form (SupervisorRegister)
                this.Hide();

                // Show Form1 (or any other form you want to navigate to)
                //Form1 form1 = new Form1();
                //form1.Show();
            }



        }




        private bool UsernameOrSupervisorIdExists(string username, string supervisorId)
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

                // Check if the supervisorId exists in Supervisor table
                string supervisorIdExistsQuery = "SELECT COUNT(*) FROM Supervisor WHERE SupervisorID = @SupervisorID";
                using (SqlCommand supervisorIdExistsCommand = new SqlCommand(supervisorIdExistsQuery, connection))
                {
                    supervisorIdExistsCommand.Parameters.AddWithValue("@SupervisorID", supervisorId);
                    int supervisorIdCount = Convert.ToInt32(supervisorIdExistsCommand.ExecuteScalar());
                    if (supervisorIdCount > 0)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        private void AdminRegisterSupervisor_Load(object sender, EventArgs e)
        {

        }
    }
}
