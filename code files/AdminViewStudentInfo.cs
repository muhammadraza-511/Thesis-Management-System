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
    public partial class AdminViewStudentInfo : Form
    {

        private const string ConnectionString = "Data Source=DESKTOP-NJFG0UQ\\SQLEXPRESS;Initial Catalog=final;Integrated Security=True";

        public AdminViewStudentInfo()
        {
            InitializeComponent();
        }

        private void btnViewdata_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();


                    //left join to retrieve information about students, including their
                    //username and password, along with the supervisors associated with them.
                    string query = @"
                        SELECT
                            S.StudentID,
                            S.SName,
                            S.Email AS StudentEmail,
                            U.UserName1,
                            U.Password,
                            SV.Name AS SupervisorName,
                            SV.Email AS SupervisorEmail
                        FROM
                            Student S
                        JOIN
                            UserRole U ON S.RoleID = U.RoleID
                        LEFT JOIN
                            Supervisor SV ON S.SupervisorID = SV.SupervisorID;
                    ";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
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

        private void button1_Click(object sender, EventArgs e)
        {
            AdminMenu admnmnu = new AdminMenu();
            admnmnu.Show();
            this.Hide();
        }
    }
    
}
