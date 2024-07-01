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
    public partial class Registeration : Form
    {
        public Registeration()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SupervisorRegister registr = new SupervisorRegister();
            registr.Show();
            this.Hide(); // Optionally hide the login form
        }

        private void btnAdminRegister_Click(object sender, EventArgs e)
        {
            //AdminRegister registr = new AdminRegister();
            //registr.Show();
            //this.Hide(); // Optionally hide the login form
        }

        private void BtnPMRegister_Click(object sender, EventArgs e)
        {
            PMRegister registr = new PMRegister();
            registr.Show();
            this.Hide(); // Optionally hide the login form
        }

        private void Registeration_Load(object sender, EventArgs e)
        {

        }

        private void BtnStudentRegister_Click(object sender, EventArgs e)
        {
            StudentRegister registr = new StudentRegister();
            registr.Show();
            this.Hide(); // Optionally hide the login form
        }
    }
}
