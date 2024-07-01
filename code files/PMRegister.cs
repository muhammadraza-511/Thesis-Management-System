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
    public partial class PMRegister : Form
    {

        private const string ConnectionString = "Data Source=DESKTOP-NJFG0UQ\\SQLEXPRESS;Initial Catalog=final;Integrated Security=True"; // Replace with your actual connection string


        public PMRegister()
        {
            InitializeComponent();
        }

        private void PMRegister_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnPMSignUp_Click(object sender, EventArgs e)
        {
            // Retrieve entered panel member details from textboxes
            string pmName = txtPMName.Text;
            string username = txtPMUserName.Text;
            string password = txtPMPassword.Text;
            string email = txtPMEmail.Text;
            string pmId = txtPMId.Text;
            string dob = txtPMDOB.Text; // Assuming txtPMDOB is a DateTimePicker

            // Check if the username or pmId already exists
            if (UsernameOrPMIdExists(username, pmId))
            {
                MessageBox.Show("Username or PanelMemberID already exists. Please choose a different one.");
                return; // Exit the method to prevent further processing
            }

            // Randomly select a proposal from the ThesisProposal table
            string randomProposalQuery = "SELECT TOP 1 ProposalID FROM ThesisProposal ORDER BY NEWID()";
            string proposalId;
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                using (SqlCommand randomProposalCommand = new SqlCommand(randomProposalQuery, connection))
                {
                    proposalId = randomProposalCommand.ExecuteScalar().ToString();
                }
            }

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                // Insert data into UserRole table
                string userRoleInsertQuery = "INSERT INTO UserRole (RoleId, RoleName, Password, Username1) VALUES (@RoleId, 'PanelMember', @Password, @Username)";
                using (SqlCommand userRoleCommand = new SqlCommand(userRoleInsertQuery, connection))
                {
                    userRoleCommand.Parameters.AddWithValue("@RoleId", pmId);
                    userRoleCommand.Parameters.AddWithValue("@Password", password);
                    userRoleCommand.Parameters.AddWithValue("@Username", username);
                    userRoleCommand.ExecuteNonQuery();
                }

                // Insert data into PanelMember table
                string panelMemberInsertQuery = "INSERT INTO PanelMember (PanelMemberID, PM_Name, Email, DOB, ProposalID, RoleID) VALUES (@PanelMemberID, @PM_Name, @Email, @DOB, @ProposalID, @RoleID)";
                using (SqlCommand panelMemberCommand = new SqlCommand(panelMemberInsertQuery, connection))
                {
                    panelMemberCommand.Parameters.AddWithValue("@PanelMemberID", pmId);
                    panelMemberCommand.Parameters.AddWithValue("@PM_Name", pmName);
                    panelMemberCommand.Parameters.AddWithValue("@Email", email);
                    panelMemberCommand.Parameters.AddWithValue("@DOB", dob);
                    panelMemberCommand.Parameters.AddWithValue("@ProposalID", proposalId);
                    panelMemberCommand.Parameters.AddWithValue("@RoleID", pmId);
                    panelMemberCommand.ExecuteNonQuery();
                }

                MessageBox.Show("Panel member registration successful!");

                // Hide the current form (PMRegister)
                this.Hide();

                // Show Form1 (or any other form you want to navigate to)
                Form1 form1 = new Form1();
                form1.Show();
            }
        }

        private bool UsernameOrPMIdExists(string username, string pmId)
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

                // Check if the pmId exists in PanelMember table
                string pmIdExistsQuery = "SELECT COUNT(*) FROM PanelMember WHERE PanelMemberID = @PanelMemberID";
                using (SqlCommand pmIdExistsCommand = new SqlCommand(pmIdExistsQuery, connection))
                {
                    pmIdExistsCommand.Parameters.AddWithValue("@PanelMemberID", pmId);
                    int pmIdCount = Convert.ToInt32(pmIdExistsCommand.ExecuteScalar());
                    if (pmIdCount > 0)
                    {
                        return true;
                    }
                }
            }

            return false;
        }
    }
}

