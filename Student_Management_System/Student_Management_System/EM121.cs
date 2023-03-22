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
    public partial class EM121 : Form
    {
        public EM121()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Mod1engmangmnt module = new Mod1engmangmnt();
            this.Hide();
            module.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Mod2engmangmnt module = new Mod2engmangmnt();
            this.Hide();
            module.Show();
        }
    }
}
