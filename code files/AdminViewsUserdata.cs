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
    public partial class AdminViewsUserdata : Form
    {

        private const string ConnectionString = "Data Source=DESKTOP-NJFG0UQ\\SQLEXPRESS;Initial Catalog=final;Integrated Security=True"; // Replace with your actual connection string

        public AdminViewsUserdata()
        {
            InitializeComponent();
        }

        private void DataGridMailbox_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnViewdata_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    // report that shows details about thesis proposals, including information
                    // about the student, supervisor, panel member, and the review comments.
                    string query = "SELECT TP.ProposalID, TP.Title AS ProposalTitle, TP.Description AS ProposalDescription, TP.Status AS ProposalStatus, " +
                                   "TP.SubmissionDate, S.SName AS StudentName, SV.Name AS SupervisorName, PM.PM_Name AS PanelMemberName, " +
                                   "R.Comments AS ReviewComments, R.Remarks AS ReviewRemarks " +
                                   "FROM ThesisProposal TP " +
                                   "JOIN Student S ON TP.StudentID = S.StudentID " +
                                   "JOIN Supervisor SV ON TP.SupervisorID = SV.SupervisorID " +
                                   "LEFT JOIN PanelMember PM ON TP.ProposalID = PM.ProposalID " +
                                   "LEFT JOIN Review R ON TP.ProposalID = R.ProposalID";

                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        // Bind the DataTable to the DataGridView
                        DataGridMailbox.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AdminViewsUserdata_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminMenu admnmnu = new AdminMenu();
            admnmnu.Show();
            this.Hide();
        }
    }
}
