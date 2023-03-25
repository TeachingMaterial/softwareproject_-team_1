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
    public partial class COMPENG : Form
    {
        public COMPENG()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Mod1_COMPENG module = new Mod1_COMPENG();
            this.Hide();
            module.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Mod2_COMPENG module = new Mod2_COMPENG();
            this.Hide();
            module.Show();
        }
    }
}
