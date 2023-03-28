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
    public partial class Mod2_COMPENG : Form
    {
        public Mod2_COMPENG()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            COMPENG home = new COMPENG();
            this.Hide();
            home.Show();
        }
    }
}
