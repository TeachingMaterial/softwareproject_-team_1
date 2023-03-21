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
    public partial class CE010 : Form
    {
        public CE010()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Mod1compeng module = new Mod1compeng();
            this.Hide();
            module.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Mod2compeng module = new Mod2compeng();
            this.Hide();
            module.Show();
        }
    }
}
