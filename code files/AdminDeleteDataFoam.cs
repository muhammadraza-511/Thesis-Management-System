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
    public partial class AdminDeleteDataFoam : Form
    {

        private const string ConnectionString = "Data Source=DESKTOP-NJFG0UQ\\SQLEXPRESS;Initial Catalog=final;Integrated Security=True";


        public AdminDeleteDataFoam()
        {
            InitializeComponent();
        }

        private void txtTableName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPrimaryKey_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDeleteData_Click(object sender, EventArgs e)
        {
            // Get the table name and row number entered by the admin
            string tableName = txtTableName.Text.Trim();
            string rowNumberValue = txtPrimaryKey.Text.Trim();

            // Validate that both fields are not empty
            if (string.IsNullOrEmpty(tableName) || string.IsNullOrEmpty(rowNumberValue))
            {
                MessageBox.Show("Please enter both table name and row number value.");
                return;
            }

            // Ensure that the row number value is a valid integer
            if (!int.TryParse(rowNumberValue, out int rowNumberInt))
            {
                MessageBox.Show("Please enter a valid integer for the row number.");
                return;
            }

            // Delete the row with the specified row number from the table
            if (DeleteRow(tableName, rowNumberInt))
            {
                MessageBox.Show($"Row number {rowNumberValue} deleted successfully from table {tableName}.");
            }
            else
            {
                MessageBox.Show($"Error deleting row from table {tableName}.");
            }
        }


        private bool DeleteRow(string tableName, int rowNumber)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                // Use ROW_NUMBER() to get the row number in the result set
                string deleteQuery = $@"
                    WITH NumberedRows AS (
                        SELECT *, ROW_NUMBER() OVER (ORDER BY (SELECT NULL)) AS RowNum FROM {tableName}
                    )
                    DELETE FROM NumberedRows WHERE RowNum = @RowNumber";

                using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                {
                    command.Parameters.AddWithValue("@RowNumber", rowNumber);

                    try
                    {
                        // Execute the DELETE query
                        int rowsAffected = command.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                    catch (Exception ex)
                    {
                        // Handle any exceptions that may occur during the delete operation
                        MessageBox.Show($"Error: {ex.Message}");
                        return false;
                    }
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void AdminDeleteDataFoam_Load(object sender, EventArgs e)
        {

        }

        private void btnGoback_Click(object sender, EventArgs e)
        {
            AdminMenu admnmnu = new AdminMenu();
            admnmnu.Show();
            this.Hide();
            
        }
    }
}

