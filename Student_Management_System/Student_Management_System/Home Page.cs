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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Coursebtn_Click(object sender, EventArgs e)
        {

        }

        private void Timetablebtn_Click(object sender, EventArgs e)
        {
            Timetable timetableForm = new Timetable();
            this.Hide();
            timetableForm.Show();
        }

        private void Attendancebtn_Click(object sender, EventArgs e)
        {

        }

        private void Feesbtn_Click(object sender, EventArgs e)
        {
            Fees feesForm = new Fees();
            this.Hide();
            feesForm.Show();
        }

        private void Profilebtn_Click(object sender, EventArgs e)
        {
            Student_Profile profileForm = new Student_Profile();
            this.Hide();
            profileForm.Show();
        }

        private void Logoutbtn_Click(object sender, EventArgs e)
        {

        }
    }
}
