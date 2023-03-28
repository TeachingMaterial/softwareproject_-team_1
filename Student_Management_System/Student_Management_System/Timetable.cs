using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Student_Management_System
{
    public partial class Timetable : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        public Timetable()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.16.0;Data Source=C:\Users\Asus\Downloads\Timetable.accdb;Persist Security Info=False;";
        }

        private void Backbtn_Click(object sender, EventArgs e)
        {
            Home homeform = new Home();
            this.Hide();
            homeform.Show();
        }

        private void show_btn_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "select Time,Monday,Tuesday,Wednesday,Thursday,Friday from Timetable";
                command.CommandText = query;

                OleDbDataAdapter da = new OleDbDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                Time_dataGridView.DataSource = dt;

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }
    }
}
