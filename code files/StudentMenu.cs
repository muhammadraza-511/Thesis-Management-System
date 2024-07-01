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
    public partial class StudentMenu : Form
    {
        string username;
        public StudentMenu()
        {
            InitializeComponent();
        }

        private void StudentMenu_Load(object sender, EventArgs e)
        {

        }

        public void SetWelcomeMessage(string welcomeMessage)
        {

            txtstudentwelcomeMsg.Text = welcomeMessage; // Assuming lblWelcome is a Label control to display the welcome message
            username = welcomeMessage;
        }

        private void btnSubmitpropStudent_Click(object sender, EventArgs e)
        {
            SubmitProposalStudentFoam submitProposal = new SubmitProposalStudentFoam();
            submitProposal.SetWelcomeMessage(username); // SetWelcomeMessage is an example method to set the welcome message
            this.Hide();
            submitProposal.Show();
        }

        private void btnEditPropStudent_Click(object sender, EventArgs e)
        {
            EditProposalStudentFoam EditProposal = new EditProposalStudentFoam();
            EditProposal.SetWelcomeMessage(username); // SetWelcomeMessage is an example method to set the welcome message
            this.Hide();
            EditProposal.Show();
        }

        private void btnWidrawPropStudent_Click(object sender, EventArgs e)
        {
            WidrawProposalStudentFoam WidrawProposal = new WidrawProposalStudentFoam();
            WidrawProposal.SetWelcomeMessage(username); // SetWelcomeMessage is an example method to set the welcome message
            this.Hide();
            WidrawProposal.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Hide the current form (StudentMenu)
            this.Hide();

            // Create a new instance of Form1 (login page)
            Form1 loginForm = new Form1();

            // Show the login form
            loginForm.Show();

        }

        private void btnCheckMailBox_Click(object sender, EventArgs e)
        {
            StudentMailBoxCheckFoam CheckMail = new StudentMailBoxCheckFoam();
            this.Hide();
            CheckMail.SetWelcomeMessage(username);
            CheckMail.Show();

        }

        //private void btnMailboxstudent_Click(object sender, EventArgs e)
        //{
        //    WidrawProposalStudentFoam ViewMailbox = new WidrawProposalStudentFoam();
        //    ViewMailbox.SetWelcomeMessage(username); // SetWelcomeMessage is an example method to set the welcome message
        //    ViewMailbox.Show();
        //}
    }
}
