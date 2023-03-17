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
    public partial class Mod2engmangmnt : Form
    {
        public Mod2engmangmnt()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            EM121 home = new EM121();
            this.Hide();
            home.Show();
        }
    }
}
