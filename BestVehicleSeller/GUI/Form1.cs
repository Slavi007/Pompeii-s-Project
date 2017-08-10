using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToShortDateString();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            frmAdd Add = new frmAdd();
            Add.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            frmTunning Tunning = new frmTunning();
            Tunning.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            frmSell Sell = new frmSell();
            Sell.Show();
        }
    }
}
