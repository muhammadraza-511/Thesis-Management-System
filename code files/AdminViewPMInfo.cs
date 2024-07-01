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


    public partial class AdminViewPMInfo : Form
    {

        private const string ConnectionString = "Data Source=DESKTOP-NJFG0UQ\\SQLEXPRESS;Initial Catalog=final;Integrated Security=True";

        public AdminViewPMInfo()
        {
            InitializeComponent();
        }

        private void AdminViewPMInfo_Load(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();

                    //information about panel members, including their username
                    //and password, along with the proposals they are associated with. 
                    string query = @"
                        SELECT
                            P.PanelMemberID,
                            P.PM_Name,
                            P.Email AS PanelMemberEmail,
                            U.UserName1,
                            U.Password,
                            TP.Title AS ProposalTitle,
                            TP.Status AS ProposalStatus
                        FROM
                            PanelMember P
                        JOIN
                            UserRole U ON P.RoleID = U.RoleID
                        RIGHT JOIN
                            ThesisProposal TP ON P.ProposalID = TP.ProposalID;
                    ";

                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                    {
                        var dataTable = new System.Data.DataTable();
                        adapter.Fill(dataTable);

                        // Assuming you have a DataGridView named dataGridViewPanelMembers
                        DataGridMailbox.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGoback_Click(object sender, EventArgs e)
        {
            AdminMenu admnmnu = new AdminMenu();
            admnmnu.Show();
            this.Hide();
        }
    }
    
}
