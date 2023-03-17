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
    public partial class Mod2compeng : Form
    {
        public Mod2compeng()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            CE010 home = new CE010();
            this.Hide();
            home.Show();
        }

        private void Mod2compeng_Load(object sender, EventArgs e)
        {

        }
    }
}
