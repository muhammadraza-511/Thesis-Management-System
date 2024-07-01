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
    public partial class StudentMailBoxCheckFoam : Form
    {


        private const string ConnectionString = "Data Source=DESKTOP-NJFG0UQ\\SQLEXPRESS;Initial Catalog=final;Integrated Security=True";


        string username;
        public StudentMailBoxCheckFoam()
        {
            InitializeComponent();
        }
        public void SetWelcomeMessage(string welcomeMessage)
        {

            txtstudentwelcomeMsg.Text = welcomeMessage; // Assuming lblWelcome is a Label control to display the welcome message
            username = welcomeMessage;
        }
        private void StudentMailBoxCheckFoam_Load(object sender, EventArgs e)
        {
            LoadMailboxData();
        }




        private void DataGridMailbox_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnViewMail_Click(object sender, EventArgs e)
        {
            LoadMailboxData();

        }




        private void LoadMailboxData()
        {
            int studentID = GetStudentID(username);

            if (studentID != -1)
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();

                    // Query to select specific columns from the Notification table for a specific student
                    string query = "SELECT NotificationID, Content, Recipient, TimeStamp FROM Notification WHERE Recipient = @StudentID";

                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                    {
                        adapter.SelectCommand.Parameters.AddWithValue("@StudentID", studentID);

                        DataTable mailboxTable = new DataTable();
                        adapter.Fill(mailboxTable);

                        // Bind the DataTable to the DataGridView
                        DataGridMailbox.DataSource = mailboxTable;

                        if (mailboxTable.Rows.Count == 0)
                        {
                            MessageBox.Show("No notifications found for the student.");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Student not found.");
            }
        }



        private int GetStudentID(string username)
        {
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
                        return -1;
                    }

                    return Convert.ToInt32(result);
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
