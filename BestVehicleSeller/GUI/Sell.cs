using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VehicleShop.Core;

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
            
        }

        private void rbMotor_Click(object sender, EventArgs e)
        {
            cmbVehicle.DataSource = Global.Param.SellMotorValues();
            lblvehicle.Text = "Select which Motorcycle do you want to sell?";
            cmbVehicle.Visible = true;
            lblvehicle.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
        }

        private void rbCar_Click(object sender, EventArgs e)
        {
            cmbVehicle.DataSource = Global.Param.SellCarValues();
            lblvehicle.Text = "Select which Car do you want to sell?";
            cmbVehicle.Visible = true;
            lblvehicle.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((rbCar.Checked == false && rbMotor.Checked == false) || cmbVehicle.SelectedItem == null)
            {
                CustomException.SellException();
            }
            else
            {
                Global.Param.DeleteMotor(1);
            }
        }
    }
}
