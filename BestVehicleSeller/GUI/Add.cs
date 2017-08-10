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
    public partial class frmAdd : Form
    {
        public frmAdd()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rbCar_Click(object sender, EventArgs e)
        {
            lblText.Visible = true;
            lbltype.Visible = true;
            cmbType.Visible = true;
            cmbtype2.Visible = true;
        }

        private void frmAdd_Load(object sender, EventArgs e)
        {

        }

        private void rbCar_CheckedChanged(object sender, EventArgs e)
        {
            lblText.Visible = false;
            lbltype.Visible = false;
            cmbType.Visible = false;
            cmbtype2.Visible = false;
        }

        private void rbMotor_Click(object sender, EventArgs e)
        {
            lblText.Visible = true;
            lbltype.Visible = true;
            cmbType.Visible = true;
            cmbtype2.Visible = true;
        }

        private void rbMotor_CheckedChanged(object sender, EventArgs e)
        {
            lblText.Visible = false;
            lbltype.Visible = false;
            cmbType.Visible = false;
            cmbtype2.Visible = false;
        }
    }
}
