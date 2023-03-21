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
    public partial class Timetable : Form
    {
        public Timetable()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.Rows.Add("9.00-11.00", "F1", "L1", 10);
            dataGridView1.Rows.Add("11.00-1.00", "F1", "L1", 10);
            dataGridView1.Rows.Add("1.00-2.00", "F1", "L1", 10);
            dataGridView1.Rows.Add("2.00-4.00", "F1", "L1", 10);
            dataGridView1.AllowUserToAddRows= false;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void back_button3_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.Hide();
            f.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
