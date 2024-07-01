using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_prj
{
    public partial class AdminMenu : Form
    {
        public AdminMenu()
        {
            InitializeComponent();
        }

        private void AdminMenu_Load(object sender, EventArgs e)
        {

        }

        public void SetWelcomeMessage(string welcomeMessage)
        {
            txtAdminMenuMsg.Text = welcomeMessage; // Assuming lblWelcome is a Label control to display the welcome message
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnViewData_Click(object sender, EventArgs e)
        {

            // Hide the current form (assuming this is the AdminMenu form)
            this.Hide();

            // Create a new instance of AdminViewDataFoam
            AdminViewDataFoam adminViewDataFoam = new AdminViewDataFoam();

            // Show the AdminViewDataFoam form
            adminViewDataFoam.Show();
        }

        private void txtDeleteData_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminDeleteDataFoam admindeletedata = new AdminDeleteDataFoam();
            admindeletedata.Show();
        }

        private void txtLogout_Click(object sender, EventArgs e)
        {
            // Hide the current form (StudentMenu)
            this.Hide();

            // Create a new instance of Form1 (login page)
            Form1 loginForm = new Form1();

            // Show the login form
            loginForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AdminRegisterStudent registr = new AdminRegisterStudent();
            registr.Show();
            //this.Hide(); // Optionally hide the login form
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdminRegisterPanelMember adminRegisterPanelMember = new AdminRegisterPanelMember();
            adminRegisterPanelMember.Show();
           // this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminRegisterSupervisor adminRegisterSupervisor = new AdminRegisterSupervisor();
            adminRegisterSupervisor.Show();
            //this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnUserData_Click(object sender, EventArgs e)
        {
            AdminViewsUserdata adminviewuserdata = new AdminViewsUserdata();
            adminviewuserdata.Show();
            this.Hide();
        }

        private void btnAdminViewStudentInfo_Click(object sender, EventArgs e)
        {
            AdminViewStudentInfo adminviewstudentinfo = new AdminViewStudentInfo();
            adminviewstudentinfo.Show();
            this.Hide();
        }

        private void btnAdminViewPMInfo_Click(object sender, EventArgs e)
        {
            AdminViewPMInfo adminviewpminfo = new AdminViewPMInfo();
            adminviewpminfo.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AdminRegister registr = new AdminRegister();
            registr.Show();
            this.Hide(); // Optionally hide the login form
        }
    }
}
