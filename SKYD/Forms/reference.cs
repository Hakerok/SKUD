﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SKYD.Forms
{
    public partial class reference : Form
    {
        public reference()
        {
            InitializeComponent();
        }

        private void reference_Load(object sender, EventArgs e)
        {
            Form1 main = new Form1();
            main.Hide();
        }
    }
}
