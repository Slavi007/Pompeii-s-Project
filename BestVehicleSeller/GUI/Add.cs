using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VehicleShop.Enums;

namespace GUI
{
    public partial class frmAdd : Form
    {
        public frmAdd()
        {
            InitializeComponent();
        }

        private void frmAdd_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to close the window?", "Important", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }

        private void rbCar_Click(object sender, EventArgs e)
        {
            gbType.Text = "What type of Car do you want to add?";
            radioButton1.Text = "Electric";
            radioButton2.Text = "Internal Combustion";
            gbType.Visible = true;
            radioButton1.Visible = true;
            radioButton2.Visible = true;
            radioButton3.Visible = false;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            RemoveValues();
        }

        

        private void rbMotor_Click(object sender, EventArgs e)
        {
            gbType.Text = "What type of Motorcycle do you want to add?";
            radioButton1.Text = "Cruiser";
            radioButton2.Text = "Scooter";
            gbType.Visible = true;
            radioButton1.Visible = true;
            radioButton2.Visible = true;
            radioButton3.Visible = true;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            RemoveValues();
            gbtype3.Visible = false;
            radioButton8.Visible = false;
            radioButton9.Visible = false;
            radioButton10.Visible = false;
            gbtype2.Visible = false;
            radioButton4.Visible = false;
            radioButton5.Visible = false;
            radioButton6.Visible = false;
            radioButton7.Visible = false;
        }       
                      
        public void SetMotorValues()
        {
            cmbBrand.DataSource = Enum.GetValues(typeof(Brand));
            lblbrand.Visible = true;
            lblmodel.Visible = true;
            cmbBrand.Visible = true;
            txtModel.Visible = true;
            lblmaxspeed.Visible = true;
            txtMaxSpeed.Visible = true;
            lblspeedunit.Visible = true;
            lblacceleration.Visible = true;
            txtAcceleration.Visible = true;
            lblunit.Visible = true;
            lblcolor.Visible = true;
            txtColor.Visible = true;
            lbldate.Visible = true;
            dtpDate.Visible = true;
            lblprice.Visible = true;
            txtPrice.Visible = true;
            lblcurrency.Visible = true;
        }

        public void SetCarValues()
        {
            cmbBrand.DataSource = Enum.GetValues(typeof(Brand));
            lblbrand.Visible = true;
            lblmodel.Visible = true;
            cmbBrand.Visible = true;
            txtModel.Visible = true;
            lblmaxspeed.Visible = true;
            txtMaxSpeed.Visible = true;
            lblspeedunit.Visible = true;
            lblacceleration.Visible = true;
            txtAcceleration.Visible = true;
            lblunit.Visible = true;
            lblcolor.Visible = true;
            txtColor.Visible = true;
            lbldate.Visible = true;
            dtpDate.Visible = true;
            lblprice.Visible = true;
            txtPrice.Visible = true;
            lblcurrency.Visible = true;
        }

        public void RemoveValues()
        {           
            lblbrand.Visible = false;
            lblmodel.Visible = false;
            cmbBrand.Visible = false;
            txtModel.Visible = false;
            lblmaxspeed.Visible = false;
            txtMaxSpeed.Visible = false;
            lblspeedunit.Visible = false;
            lblacceleration.Visible = false;
            txtAcceleration.Visible = false;
            lblunit.Visible = false;
            lblcolor.Visible = false;
            txtColor.Visible = false;
            lbldate.Visible = false;
            dtpDate.Visible = false;
            lblprice.Visible = false;
            txtPrice.Visible = false;
            lblcurrency.Visible = false;
        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Text == "Electric")
            {
                gbtype3.Visible = false;
                radioButton8.Visible = false;
                radioButton9.Visible = false;
                radioButton10.Visible = false;
                RemoveValues();
                gbtype2.Text = "What type of electric car do you want to add?";
                radioButton4.Text = "Urban";
                radioButton5.Text = "Cruiser";
                gbtype2.Visible = true;
                radioButton4.Visible = true;
                radioButton5.Visible = true;
                radioButton6.Visible = false;
                radioButton7.Visible = false;
                radioButton4.Checked = false;
                radioButton5.Checked = false;
                radioButton6.Checked = false;
                radioButton7.Checked = false;
            }
            else SetMotorValues();
        }

        private void radioButton2_Click(object sender, EventArgs e)
        {
            if (radioButton2.Text == "Internal Combustion")
            {
                RemoveValues();
                gbtype2.Text = "What type of IC car do you want to add?";
                radioButton4.Text = "Luxury";
                radioButton5.Text = "Off-Roader";
                gbtype2.Visible = true;
                radioButton4.Visible = true;
                radioButton5.Visible = true;
                radioButton6.Visible = true;
                radioButton7.Visible = true;
                radioButton4.Checked = false;
                radioButton5.Checked = false;
            }
            else SetMotorValues();
        }

        private void radioButton3_Click(object sender, EventArgs e)
        {
            SetMotorValues();
        }

        private void rbCar_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void rbMotor_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButton4_Click(object sender, EventArgs e)
        {
            gbtype3.Visible = false;
            radioButton8.Visible = false;
            radioButton9.Visible = false;
            radioButton10.Visible = false;
            SetCarValues();
        }

        private void radioButton5_Click(object sender, EventArgs e)
        {
            gbtype3.Visible = false;
            radioButton8.Visible = false;
            radioButton9.Visible = false;
            radioButton10.Visible = false;
            SetCarValues();
        }

        private void radioButton6_Click(object sender, EventArgs e)
        {
            RemoveValues();
            gbtype3.Text = "What type of Family car do you want to add?";
            radioButton8.Text = "Sedan";
            radioButton9.Text = "SUV";
            radioButton8.Checked = false;
            radioButton9.Checked = false;
            gbtype3.Visible = true;
            radioButton8.Visible = true;
            radioButton9.Visible = true;
            radioButton10.Visible = true;
        }

        private void radioButton7_Click(object sender, EventArgs e)
        {
            RemoveValues();
            gbtype3.Text = "What type of Sport car do you want to add?";
            radioButton8.Text = "Coupe";
            radioButton9.Text = "Roadster";
            radioButton8.Checked = false;
            radioButton9.Checked = false;
            radioButton10.Checked = false;
            gbtype3.Visible = true;
            radioButton8.Visible = true;
            radioButton9.Visible = true;
            radioButton10.Visible = false;
        }

        private void radioButton8_Click(object sender, EventArgs e)
        {
            SetCarValues();
        }

        private void radioButton9_Click(object sender, EventArgs e)
        {
            SetCarValues();
        }

        private void radioButton10_Click(object sender, EventArgs e)
        {
            SetCarValues();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            if (cmbBrand.SelectedItem.ToString().Equals("None") || txtModel.Text.Length == 0 || txtMaxSpeed.Text.Length == 0 ||
                txtAcceleration.Text.Length == 0 || txtColor.Text.Length == 0 || txtPrice.Text.Length == 0)
            {
              MessageBox.Show("Please fill all mandatory fields starting with * ",
                    "Error",
                    MessageBoxButtons.OK);
            }
            else
            {
                Engine Save = new Engine();
                string model = txtModel.Text.ToString();
                string brand = cmbBrand.SelectedItem.ToString();
                double maxspeed = double.Parse(txtMaxSpeed.Text.ToString());
                double acc = double.Parse(txtAcceleration.Text.ToString());
                DateTime date = dtpDate.Value.Date;
                decimal price = decimal.Parse(txtPrice.Text.ToString());
                string color = txtColor.Text.ToString();
                string type = "";
                int doors = 1;
                int seats = 1;
                int boot = 1;
                double enginePower=1;
                int engineVolume=1;
                int ValveNumber=1;
                string Fuel="";
                double Consumption = 1;
                if (rbCar.Checked == true)
                {
                    if (radioButton1.Checked == true)
                    {
                        if (radioButton4.Checked == true)
                        {
                            type = "CityCarElectric";
                        }
                        else type = "CruiseCarElectric";
                    }
                    if (radioButton2.Checked == true)
                    {
                        if (radioButton4.Checked == true)
                        {
                            type = "Luxury";
                        }
                        else if (radioButton5.Checked == true)
                        {
                            type = "Off-Roader";
                        }
                        else if (radioButton6.Checked == true)
                        {
                            if (radioButton8.Checked == true)
                            {
                                type = "Sedan";
                            }
                            else if (radioButton9.Checked == true)
                            {
                                type = "SUV";
                            }
                            else type = "Wagon";
                        }
                        else if (radioButton7.Checked == true)
                        {
                            if (radioButton8.Checked == true)
                            {
                                type = "Coupe";
                            }
                            else type = "Roadster";
                        }
                    }
                    Save.AddCar( type, model, brand, maxspeed, acc, date, price, color, doors, seats, boot, enginePower, engineVolume, ValveNumber, Fuel, Consumption);
                }
                else
                {
                    if (radioButton1.Checked == true)
                    {
                        type = "Cruiser";
                    }
                    else if (radioButton2.Checked == true)
                    {
                        type = "Scooter";
                    }
                    else type = "StreetSport";
                    Save.AddMotor(type, model, brand, maxspeed, acc, date, price, color, enginePower, engineVolume, ValveNumber, Fuel, Consumption);
                }
            }
                
                MessageBox.Show("The vehicle is added succesfully",
                    "Success",
                    MessageBoxButtons.OK);
                cmbBrand.SelectedIndex = cmbBrand.FindStringExact("None");
                txtModel.Text = "";
                txtMaxSpeed.Text = "";
                txtAcceleration.Text = "";
                txtColor.Text = "";
                txtPrice.Text = "";
            }
        }
    }
