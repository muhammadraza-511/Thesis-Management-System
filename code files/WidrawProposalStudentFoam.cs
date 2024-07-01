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
    public partial class WidrawProposalStudentFoam : Form
    {

        string username;
        private const string ConnectionString = "Data Source=DESKTOP-NJFG0UQ\\SQLEXPRESS;Initial Catalog=final;Integrated Security=True"; // Replace with your actual connection string

        public WidrawProposalStudentFoam()
        {
            InitializeComponent();
        }

        private void WidrawProposalStudentFoam_Load(object sender, EventArgs e)
        {

        }

        public void SetWelcomeMessage(string welcomeMessage)
        {

            txtStudentNameWidraw.Text = welcomeMessage; // Assuming lblWelcome is a Label control to display the welcome message
            username = welcomeMessage;
        }

        private void btnWidrawproposal_Click(object sender, EventArgs e)
        {
            // Step 1: Get StudentID using the username
            int studentID = GetStudentID(username);

            // Step 2: Match StudentID in ThesisProposal table
            int proposalID = GetProposalIDByStudentID(studentID);

            if (proposalID != -1)
            {
                // Step 3: Check if the Proposal is made by the same student
                if (IsProposalCreatedByStudent(proposalID, studentID))
                {
                    // Step 4: Withdraw the proposal
                    WithdrawProposal(proposalID);
                    MessageBox.Show("Proposal withdrawn successfully!");
                }
                else
                {
                    MessageBox.Show("You can only withdraw your own proposals.");
                }
            }
            else
            {
                MessageBox.Show("Unable to find a matching proposal for the given student.");
            }

            // Optionally, close the form or perform other actions as needed
            this.Close();
        }



        private int GetStudentID(string username)
        {
            // Use the provided username to find the corresponding StudentID from the UserRole table

            // Implement the SQL query to get the StudentID
            string query = "SELECT RoleID FROM UserRole WHERE Username1 = @Username";

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);

                    object result = command.ExecuteScalar();
                    if (result == DBNull.Value)
                    {
                        // Handle the case where the username is not found
                        // You may want to display an error message or log the issue
                        return -1;
                    }

                    return Convert.ToInt32(result);
                }
            }
        }

        private int GetProposalIDByStudentID(int studentID)
        {
            // Retrieve the corresponding ProposalID from the ThesisProposal table based on the found StudentID

            // Implement the SQL query to get the ProposalID
            string query = "SELECT ProposalID FROM ThesisProposal WHERE StudentID = @StudentID AND Status = 'Pending'";

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@StudentID", studentID);

                    object result = command.ExecuteScalar();
                    if (result == DBNull.Value)
                    {
                        // Handle the case where there is no matching ProposalID
                        // You may want to display an error message or log the issue
                        return -1;
                    }

                    return Convert.ToInt32(result);
                }
            }
        }

        private bool IsProposalCreatedByStudent(int proposalID, int studentID)
        {
            // Check if the Proposal is made by the same student

            // Implement the SQL query to check if the Proposal is made by the same student
            string query = "SELECT COUNT(*) FROM ThesisProposal WHERE ProposalID = @ProposalID AND StudentID = @StudentID";

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ProposalID", proposalID);
                    command.Parameters.AddWithValue("@StudentID", studentID);

                    int count = Convert.ToInt32(command.ExecuteScalar());
                    return count > 0;
                }
            }
        }

        private void WithdrawProposal(int proposalID)
        {
            // Withdraw the proposal by updating the Status column in the ThesisProposal table

            // Implement the SQL query to withdraw the proposal
            string query = "DELETE FROM ThesisProposal WHERE ProposalID = @ProposalID AND Status = 'Pending'";

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Set parameters for the query
                    command.Parameters.AddWithValue("@ProposalID", proposalID);

                    // Execute the query
                    command.ExecuteNonQuery();
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StudentMenu stdmnu = new StudentMenu();
            this.Hide();
            stdmnu.Show();
        }
    }
}
