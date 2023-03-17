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
    public partial class Mod2electeng : Form
    {
        public Mod2electeng()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            EE321 home = new EE321();
            this.Hide();
            home.Show();
        }
    }
}
