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
    public partial class ELECTENG : Form
    {
        public ELECTENG()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Mod1_ELECTENG module = new Mod1_ELECTENG();
            this.Hide();
            module.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Mod2_ELECTENG module = new Mod2_ELECTENG();
            this.Hide();
            module.Show();
        }
    }
}
