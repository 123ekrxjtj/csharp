﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ch10
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txResult.Text = txName.Text;
            
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txName.Text = txResult.Text = "";
        }

        private void tx_Click(object sender, EventArgs e)
        {
            txName.Text = "";
        }
    }
}
