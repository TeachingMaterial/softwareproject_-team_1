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
    public partial class CV002 : Form
    {
        public CV002()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Mod1civieng module = new Mod1civieng();
            this.Hide();
            module.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Mod2civieng module = new Mod2civieng();
            this.Hide();
            module.Show();
        }
    }
}
