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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Final_prj
{
    public partial class EditProposalStudentFoam : Form
    {
        string username;
        private const string ConnectionString = "Data Source=DESKTOP-NJFG0UQ\\SQLEXPRESS;Initial Catalog=final;Integrated Security=True"; // Replace with your actual connection string

        public EditProposalStudentFoam()
        {
            InitializeComponent();
        }

        private void EditProposalStudentFoam_Load(object sender, EventArgs e)
        {

        }

        public void SetWelcomeMessage(string welcomeMessage)
        {

            txtNameStudentEP.Text = welcomeMessage; // Assuming lblWelcome is a Label control to display the welcome message
            username = welcomeMessage;
        }

        private void btnEditProposal_Click(object sender, EventArgs e)
        {
            // Step 1: Get StudentID using the username
            int studentID = GetStudentID(username);

            // Step 2: Match StudentID in ThesisProposal table
            int proposalID = GetProposalIDByStudentID(studentID);

            if (proposalID != -1)
            {
                // Step 3: Update the proposal in the ThesisProposal table
                UpdateProposal(proposalID);
                MessageBox.Show("Proposal updated successfully!");
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
            string query = "SELECT ProposalID FROM ThesisProposal WHERE StudentID = @StudentID AND Title = @PreviousTitle";

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@StudentID", studentID);
                    command.Parameters.AddWithValue("@PreviousTitle", txtPreviousTitle.Text);

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

        private void UpdateProposal(int proposalID)
        {
            // Update the existing proposal in the ThesisProposal table using the gathered information

            // Implement the SQL query to update the proposal
            string query = "UPDATE ThesisProposal SET Title = @Title, Description = @Description, SubmissionDate = @SubmissionDate " +
                           "WHERE ProposalID = @ProposalID";

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Set parameters for the query using the values from your form controls
                    command.Parameters.AddWithValue("@ProposalID", proposalID);
                    command.Parameters.AddWithValue("@Title", txttitle.Text);
                    command.Parameters.AddWithValue("@Description", txtDescription.Text);
                    command.Parameters.AddWithValue("@SubmissionDate", DateTime.Parse(TxtsubmissionDate.Text));

                    // Execute the query
                    command.ExecuteNonQuery();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StudentMenu stdmnu = new StudentMenu();
            stdmnu.Show();
            this.Hide();
        }
    }
}