﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWorld
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHello_Click(object sender, EventArgs e)
        {
            //lblHello.Text = "Hello World!";
            MessageBox.Show("Hello World", "Fist Project", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
