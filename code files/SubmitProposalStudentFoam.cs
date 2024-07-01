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


    public partial class SubmitProposalStudentFoam : Form
    {

        private const string ConnectionString = "Data Source=DESKTOP-NJFG0UQ\\SQLEXPRESS;Initial Catalog=final;Integrated Security=True"; // Replace with your actual connection string

        string username;
        public SubmitProposalStudentFoam()
        {
            InitializeComponent();
        }

        private void SubmitProposalStudentFoam_Load(object sender, EventArgs e)
        {

        }

        public void SetWelcomeMessage(string welcomeMessage)
        {

            txtNameStudentSP.Text = welcomeMessage; // Assuming lblWelcome is a Label control to display the welcome message
            username = welcomeMessage;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnSubmitProposal_Click(object sender, EventArgs e)
        {
            // Step 1: Auto-increment ProposalID
            int nextProposalID = GetNextProposalID();

            // Step 2: Get StudentID using the username
            int studentID = GetStudentID(username);

            // Step 3: Randomly assign SupervisorID
            int supervisorID = GetRandomSupervisorID();

            // Step 4: Insert the new proposal into the ThesisProposal table
            InsertProposal(nextProposalID, studentID, supervisorID);

            // Inform the user that the proposal has been submitted
            MessageBox.Show("Proposal submitted successfully!");

            // Optionally, close the form or perform other actions as needed
            this.Close();
        }


        private int GetNextProposalID()
        {
            // Retrieve the current maximum ProposalID from the ThesisProposal table
            // Increment the value to get the next ProposalID for the new submission

            // Implement the SQL query to get the maximum ProposalID
            string query = "SELECT MAX(ProposalID) FROM ThesisProposal";

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Handle the case where the table is empty
                    object result = command.ExecuteScalar();
                    if (result == DBNull.Value)
                    {
                        return 1;
                    }

                    return Convert.ToInt32(result) + 1;
                }
            }
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




        private int GetRandomSupervisorID()
        {
            // Retrieve a random SupervisorID from the Supervisor table

            // Implement the SQL query to get a random SupervisorID
            string query = "SELECT TOP 1 SupervisorID FROM Supervisor ORDER BY NEWID()";

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    object result = command.ExecuteScalar();
                    if (result == DBNull.Value)
                    {
                        // Handle the case where there are no supervisors
                        // You may want to display an error message or log the issue
                        return -1;
                    }

                    return Convert.ToInt32(result);
                }
            }
        }



        private void InsertProposal(int proposalID, int studentID, int supervisorID)
        {
            // Insert the new proposal into the ThesisProposal table using the gathered information

            // Implement the SQL query to insert the new proposal
            string query = "INSERT INTO ThesisProposal (ProposalID, Title, Description, Status, SubmissionDate, StudentID, SupervisorID) " +
                           "VALUES (@ProposalID, @Title, @Description, @Status, @SubmissionDate, @StudentID, @SupervisorID)";

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Set parameters for the query using the values from your form controls
                    command.Parameters.AddWithValue("@ProposalID", proposalID);
                    command.Parameters.AddWithValue("@Title", txttitle.Text);
                    command.Parameters.AddWithValue("@Description", txtDescription.Text);
                    command.Parameters.AddWithValue("@Status", "Pending"); // Status is always "Pending" for a new submission
                    command.Parameters.AddWithValue("@SubmissionDate", DateTime.Parse(TxtsubmissionDate.Text));
                    command.Parameters.AddWithValue("@StudentID", studentID);
                    command.Parameters.AddWithValue("@SupervisorID", supervisorID);

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
