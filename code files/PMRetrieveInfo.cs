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
    public partial class PMRetrieveInfo : Form
    {
        private const string ConnectionString = "Data Source=DESKTOP-NJFG0UQ\\SQLEXPRESS;Initial Catalog=final;Integrated Security=True";

        public PMRetrieveInfo()
        {
            InitializeComponent();
        }

        private void btnRetrieveInfo_Click(object sender, EventArgs e)
        {
            try
            {
                // Create a SqlConnection using the connection string
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    // Open the connection
                    connection.Open();

                    // Create a SqlCommand with the SQL query
                    using (SqlCommand command = new SqlCommand(@"
                        SELECT
                            TP.ProposalID,
                            TP.Title AS ProposalTitle,
                            TP.Description AS ProposalDescription,
                            TP.Status AS ProposalStatus,
                            TP.SubmissionDate,
                            S.StudentID,
                            S.SName AS StudentName,
                            S.Email AS StudentEmail,
                            S.DOB AS StudentDOB,
                            S.Phone AS StudentPhone,
                            SV.SupervisorID,
                            SV.Name AS SupervisorName,
                            SV.Email AS SupervisorEmail,
                            SV.DOB AS SupervisorDOB,
                            R.ReviewID,
                            R.Comments AS ReviewComments,
                            R.Remarks AS ReviewRemarks
                        FROM
                            ThesisProposal TP
                        JOIN
                            Student S ON TP.StudentID = S.StudentID
                        JOIN
                            Supervisor SV ON TP.SupervisorID = SV.SupervisorID
                        LEFT JOIN
                            Review R ON TP.ProposalID = R.ProposalID;
                    ", connection))
                    {
                        // Create a DataTable to hold the result
                        DataTable resultDataTable = new DataTable();

                        // Use a SqlDataAdapter to fill the DataTable
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            adapter.Fill(resultDataTable);
                        }

                        // Bind the DataTable to the DataGridView
                        DataGridRetrieveInfo.DataSource = resultDataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PMRetrieveInfo_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            PMMenu pMMen = new PMMenu();
            pMMen.Show();
            this.Hide();
        }
    }
    
}
