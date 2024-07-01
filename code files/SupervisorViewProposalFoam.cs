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
    public partial class SupervisorViewProposalFoam : Form
    {

        private const string ConnectionString = "Data Source=DESKTOP-NJFG0UQ\\SQLEXPRESS;Initial Catalog=final;Integrated Security=True"; // Replace with your actual connection string

        public SupervisorViewProposalFoam()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void SupervisorViewProposalFoam_Load(object sender, EventArgs e)
        {
            // Load data into the DataGridView when the form is loaded
            LoadThesisProposals();
        }

        private void LoadThesisProposals()
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                // Query to select specific columns from the ThesisProposal table
                string query = "SELECT ProposalID, Title, Description, Status, SubmissionDate, StudentID, SupervisorID FROM ThesisProposal";

                using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                {
                    DataTable thesisProposalTable = new DataTable();
                    adapter.Fill(thesisProposalTable);

                    // Bind the DataTable to the DataGridView
                    DataGridViewProposal.DataSource = thesisProposalTable;
                }
            }
        }

        private void SupervisorViewProposalFoam_Load_1(object sender, EventArgs e)
        {

        }

        private void btnViewThesisProposal_Click(object sender, EventArgs e)
        {
            // Reload data when the "View" button is pressed
            LoadThesisProposals();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //PMMenu pmmnu = new PMMenu();
            this.Hide();
            //pmmnu.Show();
        }
    }
}
