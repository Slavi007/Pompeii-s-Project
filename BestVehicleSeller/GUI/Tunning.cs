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
    public partial class frmTunning : Form
    {
        public frmTunning()
        {
            InitializeComponent();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gpQuestion_Enter(object sender, EventArgs e)
        {

        }

        private void rbCar_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Event for tunning goes here : 
        }

        private void rbMotor_Click(object sender, EventArgs e)
        {
            cmbVehicle.DataSource = Global.Param.SellMotorValues();
            lbltext.Text = "Select which Motorcycle do you want to sell?";
            cmbVehicle.Visible = true;
            lbltext.Visible = true;
        }

        private void rbCar_Click(object sender, EventArgs e)
        {
            cmbVehicle.DataSource = Global.Param.SellCarValues();
            lbltext.Text = "Select which Car do you want to sell?";
            cmbVehicle.Visible = true;
            lbltext.Visible = true;
        }

        private void cmbVehicle_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }
    }
}
