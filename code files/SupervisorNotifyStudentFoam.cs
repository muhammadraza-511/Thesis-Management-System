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
    public partial class SupervisorNotifyStudentFoam : Form
    {

        private const string ConnectionString = "Data Source=DESKTOP-NJFG0UQ\\SQLEXPRESS;Initial Catalog=final;Integrated Security=True"; // Replace with your actual connection string

        public SupervisorNotifyStudentFoam()
        {
            InitializeComponent();
        }

        private void SupervisorNotifyStudentFoam_Load(object sender, EventArgs e)
        {

        }

        private void btnSendNotification_Click(object sender, EventArgs e)
        {
            // Retrieve values from the textboxes
            string recipientId = txtRecepentId.Text;
            string notifyContent = txtNotifyContent.Text;

            // Check if the recipient exists in the ThesisProposal table
            if (!IsRecipientValid(recipientId))
            {
                MessageBox.Show("Invalid recipient. Please enter a valid StudentID.");
                return;
            }

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                // Get the last NotificationID and increment by 1
                int notificationId = GetNextNotificationID(connection);

                // Insert data into the Notification table
                string query = "INSERT INTO Notification (NotificationID, Content, Recipient, Timestamp) " +
                               "VALUES (@NotificationID, @Content, @Recipient, @Timestamp)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@NotificationID", notificationId);
                    command.Parameters.AddWithValue("@Content", notifyContent);
                    command.Parameters.AddWithValue("@Recipient", recipientId);
                    command.Parameters.AddWithValue("@Timestamp", DateTime.Now);

                    command.ExecuteNonQuery();
                }

                MessageBox.Show("Notification sent successfully!");
            }
        }



        private bool IsRecipientValid(string recipientId)
        {
            // Check if the recipient exists in the ThesisProposal table

            // Implement the SQL query to check if the recipient exists
            string query = "SELECT COUNT(*) FROM ThesisProposal WHERE StudentID = @Recipient";

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Recipient", recipientId);

                    int count = Convert.ToInt32(command.ExecuteScalar());
                    return count > 0;
                }
            }
        }

        private int GetNextNotificationID(SqlConnection connection)
        {
            // Get the last NotificationID and increment by 1

            // Implement the SQL query to get the last NotificationID
            string query = "SELECT TOP 1 NotificationID FROM Notification ORDER BY NotificationID DESC";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                object result = command.ExecuteScalar();
                if (result == DBNull.Value)
                {
                    // If there are no existing notifications, start with 1
                    return 1;
                }

                int lastNotificationId = Convert.ToInt32(result);
                return lastNotificationId + 1;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}

