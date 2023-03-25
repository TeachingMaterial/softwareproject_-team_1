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
    public partial class OTPform : Form
    {
        public OTPform()
        {
            InitializeComponent();
        }

        private void HomePageLink_Click(object sender, EventArgs e)
        {
            Home homeform = new Home();
            this.Hide();
            homeform.Show();
        }
    }
}
