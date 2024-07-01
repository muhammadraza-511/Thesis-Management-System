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
    public partial class AdminViewDataFoam : Form
    {


        private const string ConnectionString = "Data Source=DESKTOP-NJFG0UQ\\SQLEXPRESS;Initial Catalog=final;Integrated Security=True";


        public AdminViewDataFoam()
        {
            InitializeComponent();
        }

        private void btnTableName_Click(object sender, EventArgs e)
        {
            // Get the table name entered by the admin
            string tableName = txtTableName.Text.Trim();

            // Validate that the table name is not empty
            if (string.IsNullOrEmpty(tableName))
            {
                MessageBox.Show("Please enter a table name.");
                return;
            }

            // Use the entered table name to query the database for its schema and data
            DataTable tableData = GetTableData(tableName);

            // Display the table schema and data in the DataGridView
            DataGridForTables.DataSource = tableData;
        }

        private DataTable GetTableData(string tableName)
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand($"SELECT * FROM {tableName}", connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        // Fill the DataTable with the data from the specified table
                        adapter.Fill(dataTable);
                    }
                }
            }

            return dataTable;
        }

        private void DataGridForTables_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AdminViewDataFoam_Load(object sender, EventArgs e)
        {

        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            AdminMenu admnmnu = new AdminMenu();
            admnmnu.Show();
            this.Hide();
        }
    }

    //private DataTable GetTableSchema(string tableName)
    //    {
    //        DataTable schemaTable = new DataTable();

    //        using (SqlConnection connection = new SqlConnection(ConnectionString))
    //        {
    //            connection.Open();

    //            using (SqlCommand command = new SqlCommand($"SELECT TOP 0 * FROM {tableName}", connection))
    //            {
    //                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
    //                {
    //                    adapter.FillSchema(schemaTable, SchemaType.Source);
    //                }
    //            }
    //        }

    //        return schemaTable;
    //    }
    
}

