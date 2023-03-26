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
    public partial class Student_Profile : Form
    {
        public Student_Profile()
        {
            InitializeComponent();
        }

        private void Profile_Click(object sender, EventArgs e)
        {
            Student_Profile profileForm = new Student_Profile();
            this.Hide();
            profileForm.Show();
        }

        private void Student_Profile_Load(object sender, EventArgs e)
        {

        }

        private void Backbtn_Click(object sender, EventArgs e)
        {
            Home homeform = new Home();
            this.Hide();
            homeform.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
