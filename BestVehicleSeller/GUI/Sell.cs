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

        private void button1_Click(object sender, EventArgs e)
        {
            if ((rbCar.Checked == false && rbMotor.Checked == false) || cmbVehicle.SelectedItem == null)
            {
                CustomException.SellException();
            }
            else
            {
                if (rbCar.Checked == true)
                {
                    string curr = cmbVehicle.SelectedItem.ToString();
                    char i = curr.First();
                    Global.Param.DeleteCar(int.Parse(i.ToString()));
                    MessageBox.Show($"The car is sold! Cars left: {Global.Param.PrintCar()}",
                        "Success",
                        MessageBoxButtons.OK);
                    lblbrand.Visible = false;
                    lblmodel.Visible = false;
                    lbldate.Visible = false;
                    lblmax.Visible = false;
                    lbltop.Visible = false;
                    lblprice.Visible = false;
                    lblcolor.Visible = false;
                    if (Global.Param.SellCarValues().Count == 0)
                    {
                        cmbVehicle.Items.Clear();
                        cmbVehicle.SelectedIndex = -1;
                        cmbVehicle.SelectedText = "There are no Cars left!";
                    }
                    else cmbVehicle.DataSource = Global.Param.SellCarValues();                   
                }
                else
                {
                    string curr = cmbVehicle.SelectedItem.ToString();
                    char i = curr.First();
                    Global.Param.DeleteMotor(int.Parse(i.ToString()));
                    MessageBox.Show($"The motorcycle is sold! Motorcycles left: {Global.Param.PrintMotor()}",
                        "Success",
                        MessageBoxButtons.OK);
                    lblbrand.Visible = false;
                    lblmodel.Visible = false;
                    lbldate.Visible = false;
                    lblmax.Visible = false;
                    lbltop.Visible = false;
                    lblprice.Visible = false;
                    lblcolor.Visible = false;
                    if (Global.Param.SellMotorValues().Count == 0)
                    {
                        cmbVehicle.SelectedText = "There are no Motorcycles left!";
                    }
                    else cmbVehicle.DataSource = Global.Param.SellMotorValues();
                }
            }
        }

        private void cmbVehicle_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (rbCar.Checked == true)
            {
                lblbrand.Visible = true;
                lblmodel.Visible = true;
                lbldate.Visible = true;
                lblmax.Visible = true;
                lbltop.Visible = true;
                lblprice.Visible = true;
                lblcolor.Visible = true;
                string curr = cmbVehicle.SelectedItem.ToString();
                char i = curr.First();
                var item = Global.Param.CarValue(int.Parse(i.ToString()));
                lblbrand.Text = $"Brand: {item.Brand}";
                lblmodel.Text = $"Model: {item.CarModel}";
                lblcolor.Text = $"Colour: {item.Colour}";
                lblprice.Text = $"Price: {item.Price.ToString()}BGN";
                lbldate.Text = $"Date: {item.OriginDate.ToShortDateString().ToString()}";
                lblmax.Text = $"Max speed: {item.MaxSpeed.ToString()}km/h";
                lbltop.Text = $"Acceleration: {item.Acceleration.ToString()}sec";
            }
            else
            {
                lblbrand.Visible = true;
                lblmodel.Visible = true;
                lbldate.Visible = true;
                lblmax.Visible = true;
                lbltop.Visible = true;
                lblprice.Visible = true;
                lblcolor.Visible = true;
                string curr = cmbVehicle.SelectedItem.ToString();
                char i = curr.First();
                var item = Global.Param.MotorValue(int.Parse(i.ToString()));
                lblbrand.Text = $"Brand: {item.Brand}";
                lblmodel.Text = $"Model: {item.CarModel}";
                lblcolor.Text = $"Colour: {item.Colour}";
                lblprice.Text = $"Price: {item.Price.ToString()}BGN";
                lbldate.Text = $"Date: {item.OriginDate.ToShortDateString().ToString()}";
                lblmax.Text = $"Max speed: {item.MaxSpeed.ToString()}km/h";
                lbltop.Text = $"Acceleration: {item.Acceleration.ToString()}sec";
            }
        }
    }
}
