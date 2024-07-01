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
    public partial class txtSupervisorMenu : Form
    {
        public txtSupervisorMenu()
        {
            InitializeComponent();
        }

        private void txtSupervisorMenu_Load(object sender, EventArgs e)
        {

        }

        public void SetWelcomeMessage(string welcomeMessage)
        {
            txtSupervisorwelcomeMsg.Text = welcomeMessage; // Assuming lblWelcome is a Label control to display the welcome message
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            // Close the current form (SupervisorMenu) and show the login form (Form1)
            Form1 loginForm = new Form1();
            loginForm.Show();
            this.Close();
        }

        private void btnViewThesisProposal_Click(object sender, EventArgs e)
        {
            // Open the SupervisorViewProposalFoam form when "View Proposals" button is clicked
            SupervisorViewProposalFoam viewProposalForm = new SupervisorViewProposalFoam();
            viewProposalForm.Show();
        }

        private void btnNotifyStudent_Click(object sender, EventArgs e)
        {
            // Open the SupervisorNotifyStudent form when "Notify Students" button is clicked
            SupervisorNotifyStudentFoam notifyStudentForm = new SupervisorNotifyStudentFoam();
            notifyStudentForm.Show();
        }
    }
}
