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
    public partial class PMMenu : Form
    {
        string username;
        public PMMenu()
        {
            InitializeComponent();
        }

        private void PMMenu_Load(object sender, EventArgs e)
        {

        }
        public void SetWelcomeMessage(string welcomeMessage)
        {
            txtPMwelcomeMsg.Text = welcomeMessage; // Assuming lblWelcome is a Label control to display the welcome message
            username = welcomeMessage;
        
        }

        private void btnViewProposal_Click(object sender, EventArgs e)
        {
            SupervisorViewProposalFoam ViewProposal = new SupervisorViewProposalFoam();
            //this.Hide();
            ViewProposal.Show();
        }

        private void btnApproveProposal_Click(object sender, EventArgs e)
        {
            PMApproveProposal approveProposal = new PMApproveProposal();
            approveProposal.SetWelcomeMessage(username); // SetWelcomeMessage is an example method to set the welcome message
            this.Hide();
            approveProposal.Show(); 
        }

        private void btnReviewProposal_Click(object sender, EventArgs e)
        {
            PMReviewProposal pmReviewProposal = new PMReviewProposal();
            pmReviewProposal.SetWelcomeMessage(username); // SetWelcomeMessage is an example method to set the welcome message
            this.Hide();
            pmReviewProposal.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            // Hide the current form (StudentMenu)
            this.Hide();

            // Create a new instance of Form1 (login page)
            Form1 loginForm = new Form1();

            // Show the login form
            loginForm.Show();
        }

        private void btnRetrieveInfo_Click(object sender, EventArgs e)
        {
            PMRetrieveInfo pmRetrieveInfo = new PMRetrieveInfo();
            this.Hide();
            pmRetrieveInfo.Show();
        }
    }
}
