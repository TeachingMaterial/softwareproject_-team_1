﻿using System;
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
    public partial class Mod2civieng : Form
    {
        public Mod2civieng()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            CV002 home = new CV002();
            this.Hide();
            home.Show();
        }
    }
}
