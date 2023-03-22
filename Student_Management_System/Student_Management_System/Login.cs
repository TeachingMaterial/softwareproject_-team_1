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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
      
        }

        private void button2_MouseClick(object sender, MouseEventArgs e)
        {
            Form2 f = new Form2();
            this.Close();
            f.Show();
           
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        { 
            string username = Username.Text;
            string password = Password.Text;
            if (username != password)
            {
                OTPform x = new OTPform();
                this.Hide();
                x.Show();
            }
        }
    }
}