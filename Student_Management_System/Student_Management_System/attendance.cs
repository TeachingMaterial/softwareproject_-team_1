using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Management_System
{
    public partial class Attendance : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        public Attendance()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.16.0;Data Source=C:\Users\Asus\Downloads\Attendance.accdb;Persist Security Info=False;";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home homeform = new Home();
            this.Hide();
            homeform.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void show_btn2_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "select Modules,Class1,Class2,Class3,Class4,Class5  from Attendance";
                command.CommandText = query;

                OleDbDataAdapter da = new OleDbDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                Attendance_dataGridView.DataSource = dt;

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
