﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmSell : Form
    {
        public frmSell()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmSell_Load(object sender, EventArgs e)
        {
            Engine print = new Engine();
            label1.Text = print.PrintCar();
        }
    }
}
