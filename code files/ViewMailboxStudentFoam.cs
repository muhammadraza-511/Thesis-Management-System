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
    public partial class ViewMailboxStudentFoam : Form
    {
        public ViewMailboxStudentFoam()
        {
            InitializeComponent();
        }

        private void ViewMailboxStudentFoam_Load(object sender, EventArgs e)
        {

        }

        public void SetWelcomeMessage(string welcomeMessage)
        {

            txtNameStudentMailbox.Text = welcomeMessage; // Assuming lblWelcome is a Label control to display the welcome message
            //username = welcomeMessage;
        }
    }
}
