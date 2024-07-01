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
    public partial class PMReviewProposal : Form
    {

        string username;
        private const string ConnectionString = "Data Source=DESKTOP-NJFG0UQ\\SQLEXPRESS;Initial Catalog=final;Integrated Security=True";

        public PMReviewProposal()
        {
            InitializeComponent();
        }

        public void SetWelcomeMessage(string welcomeMessage)
        {
            txtPMwelcomeMsg.Text = welcomeMessage; // Assuming lblWelcome is a Label control to display the welcome message
            username = welcomeMessage;

        }

        private void PMReviewProposal_Load(object sender, EventArgs e)
        {
            // Load data into the ComboBox when the form is loaded
            LoadPendingProposals();
        }



        private void LoadPendingProposals()
        {
            int panelMemberID = GetPanelMemberID(username);

            if (panelMemberID != -1)
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();

                    // Query to select specific columns from the PanelMember table
                    string query = "SELECT ProposalID FROM PanelMember WHERE PanelMemberID = @PanelMemberID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@PanelMemberID", panelMemberID);

                        object result = command.ExecuteScalar();

                        if (result != null && result != DBNull.Value)
                        {
                            int proposalID = Convert.ToInt32(result);

                            // Populate the ProposalID in a ComboBox or TextBox, depending on your UI design
                            txtProposalID.Text = proposalID.ToString();
                        }
                        else
                        {
                            MessageBox.Show("Panel member not found.");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Panel member not found.");
            }
        }

        private int GetPanelMemberID(string username)
        {
            //string query = "SELECT RoleID FROM UserRole WHERE Username1 = @Username";

            //using (SqlConnection connection = new SqlConnection(ConnectionString))
            //{
            //    connection.Open();

            //    using (SqlCommand command = new SqlCommand(query, connection))
            //    {
            //        command.Parameters.AddWithValue("@Username", username);

            //        object result = command.ExecuteScalar();
            //        if (result == DBNull.Value)
            //        {
            //            return -1;
            //        }

            //        return Convert.ToInt32(result);
            //    }
            //}



            string query = "SELECT RoleID FROM UserRole WHERE Username1 = @Username";

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);

                    object result = command.ExecuteScalar();
                    if (result == null || result == DBNull.Value)
                    {
                        return -1;
                    }

                    return Convert.ToInt32(result);
                }
            }
        }

        private void btnSavereview_Click(object sender, EventArgs e)
        {
            // Submit the review when the "Submit Review" button is pressed
            SubmitReview();
        }


        private void SubmitReview()
        {
            // Get the ReviewID for the new review
            int reviewID = GetNextReviewID();

            // Get the ProposalID from the TextBox or ComboBox, depending on your UI design
            int proposalID = Convert.ToInt32(txtProposalID.Text);

            // Get the PanelMemberID using the username
            int panelMemberID = GetPanelMemberID(username);

            if (panelMemberID != -1)
            {
                // Get the Comments and Remarks from the TextBoxes
                string comments = txtComments.Text;
                string remarks = txtRemarks.Text;

                // Insert the new review into the Review table
                InsertReview(reviewID, comments, remarks, proposalID, panelMemberID);

                MessageBox.Show("Review submitted successfully!");
            }
            else
            {
                MessageBox.Show("Panel member not found.");
            }
        }



        private int GetNextReviewID()
        {
            // Get the next ReviewID for the new review
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                // Query to get the maximum ReviewID from the Review table
                string query = "SELECT ISNULL(MAX(ReviewID), 0) + 1 FROM Review";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    return Convert.ToInt32(command.ExecuteScalar());
                }
            }
        }


        private void InsertReview(int reviewID, string comments, string remarks, int proposalID, int panelMemberID)
        {
            // Insert the new review into the Review table
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                // Query to insert a new review into the Review table
                string query = "INSERT INTO Review (ReviewID, Comments, Remarks, ProposalID, PanelMemberID) VALUES (@ReviewID, @Comments, @Remarks, @ProposalID, @PanelMemberID)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Set parameters for the query
                    command.Parameters.AddWithValue("@ReviewID", reviewID);
                    command.Parameters.AddWithValue("@Comments", comments);
                    command.Parameters.AddWithValue("@Remarks", remarks);
                    command.Parameters.AddWithValue("@ProposalID", proposalID);
                    command.Parameters.AddWithValue("@PanelMemberID", panelMemberID);

                    // Execute the query
                    command.ExecuteNonQuery();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PMMenu pmmnu = new PMMenu();
            pmmnu.Show();
            this.Hide();
        }
    }
}
