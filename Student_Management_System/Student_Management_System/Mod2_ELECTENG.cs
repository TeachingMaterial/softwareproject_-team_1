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
    public partial class Mod2_ELECTENG : Form
    {
        public Mod2_ELECTENG()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ELECTENG home = new ELECTENG();
            this.Hide();
            home.Show();
        }
    }
}
