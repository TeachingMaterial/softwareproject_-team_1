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
    public partial class Mod2_CHEMENG : Form
    {
        public Mod2_CHEMENG()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            CHEMENG home = new CHEMENG();
            this.Hide();
            home.Show();
        }
    }
}
