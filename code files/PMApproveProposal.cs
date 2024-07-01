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
    public partial class PMApproveProposal : Form
    {
        private const string ConnectionString = "Data Source=DESKTOP-NJFG0UQ\\SQLEXPRESS;Initial Catalog=final;Integrated Security=True";

        string username;
        public PMApproveProposal()
        {
            InitializeComponent();
        }


        public void SetWelcomeMessage(string welcomeMessage)
        {
            txtPMwelcomeMsg.Text = welcomeMessage; // Assuming lblWelcome is a Label control to display the welcome message
            username = welcomeMessage;

        }

        private void PMApproveProposal_Load(object sender, EventArgs e)
        {
            // Load data into the DataGridView when the form is loaded
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

                            // Query to select specific columns from the ThesisProposal table for a specific ProposalID
                            string proposalQuery = "SELECT ProposalID, Title, Description, Status, SubmissionDate, StudentID, SupervisorID FROM ThesisProposal WHERE ProposalID = @ProposalID AND Status = 'Pending'";

                            using (SqlDataAdapter adapter = new SqlDataAdapter(proposalQuery, connection))
                            {
                                adapter.SelectCommand.Parameters.AddWithValue("@ProposalID", proposalID);

                                DataTable proposalsTable = new DataTable();
                                adapter.Fill(proposalsTable);

                                // Bind the DataTable to the DataGridView
                                datGridApproveProp.DataSource = proposalsTable;

                                if (proposalsTable.Rows.Count == 0)
                                {
                                    MessageBox.Show("No pending proposals found for the panel member.");
                                }
                            }
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

                    // If the result is null or DBNull.Value, return -1; otherwise, return the converted integer value
                    return result == null || result == DBNull.Value ? -1 : Convert.ToInt32(result);
                }
            }
        }


        private void datGridApproveProp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            // Approve the selected proposal when the "Approve" button is pressed
            ApproveProposal();
        }


        private void ApproveProposal()
        {

            int selectedRowIndex = datGridApproveProp.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = datGridApproveProp.Rows[selectedRowIndex];
            int proposalID = Convert.ToInt32(selectedRow.Cells["ProposalID"].Value);

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                // Update the Status column in the ThesisProposal table to 'Approved' for the selected ProposalID
                string query = "UPDATE ThesisProposal SET Status = 'Approved' WHERE ProposalID = @ProposalID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ProposalID", proposalID);
                    command.ExecuteNonQuery();

                    MessageBox.Show("Proposal approved successfully!");
                }
            }

            // Reload data after approving the proposal
            LoadPendingProposals();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PMMenu pMMen = new PMMenu();
            pMMen.Show();
            this.Hide();
        }
    }
}

