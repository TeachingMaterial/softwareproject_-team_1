using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Management_System
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void LoginButton_MouseClick(object sender, MouseEventArgs e)
        {
            OTPform f= new OTPform();
            f.Show();
            this.Hide();
        }

        private void NewAccButton_MouseClick(object sender, MouseEventArgs e)
        {
            NewAccount x= new NewAccount();
            x.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
