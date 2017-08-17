namespace GUI
{
    partial class frmAdd
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdd));
            this.btSave = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.gbVehicle = new System.Windows.Forms.GroupBox();
            this.rbCar = new System.Windows.Forms.RadioButton();
            this.rbMotor = new System.Windows.Forms.RadioButton();
            this.cmbBrand = new System.Windows.Forms.ComboBox();
            this.lblbrand = new System.Windows.Forms.Label();
            this.lblmodel = new System.Windows.Forms.Label();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.lblmaxspeed = new System.Windows.Forms.Label();
            this.lblacceleration = new System.Windows.Forms.Label();
            this.txtMaxSpeed = new System.Windows.Forms.TextBox();
            this.txtAcceleration = new System.Windows.Forms.TextBox();
            this.lblspeedunit = new System.Windows.Forms.Label();
            this.lblunit = new System.Windows.Forms.Label();
            this.lblcolor = new System.Windows.Forms.Label();
            this.lbldate = new System.Windows.Forms.Label();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lblprice = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblcurrency = new System.Windows.Forms.Label();
            this.gbType = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.gbtype2 = new System.Windows.Forms.GroupBox();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.gbtype3 = new System.Windows.Forms.GroupBox();
            this.radioButton10 = new System.Windows.Forms.RadioButton();
            this.radioButton9 = new System.Windows.Forms.RadioButton();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.txtPower = new System.Windows.Forms.TextBox();
            this.txtVolume = new System.Windows.Forms.TextBox();
            this.txtValves = new System.Windows.Forms.TextBox();
            this.lblpower = new System.Windows.Forms.Label();
            this.lblvolume = new System.Windows.Forms.Label();
            this.lblvalve = new System.Windows.Forms.Label();
            this.txtfuel = new System.Windows.Forms.TextBox();
            this.txtconsumption = new System.Windows.Forms.TextBox();
            this.lblfuel = new System.Windows.Forms.Label();
            this.lblrazhod = new System.Windows.Forms.Label();
            this.txtseats = new System.Windows.Forms.TextBox();
            this.lblseats = new System.Windows.Forms.Label();
            this.txtdoors = new System.Windows.Forms.TextBox();
            this.txtboot = new System.Windows.Forms.TextBox();
            this.lbldoors = new System.Windows.Forms.Label();
            this.lblboot = new System.Windows.Forms.Label();
            this.bthelp = new System.Windows.Forms.Button();
            this.gbVehicle.SuspendLayout();
            this.gbType.SuspendLayout();
            this.gbtype2.SuspendLayout();
            this.gbtype3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btSave
            // 
            this.btSave.BackColor = System.Drawing.Color.Transparent;
            this.btSave.BackgroundImage = global::GUI.Properties.Resources.Button;
            this.btSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btSave.Font = new System.Drawing.Font("Comic Sans MS", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btSave.Location = new System.Drawing.Point(483, 648);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(181, 93);
            this.btSave.TabIndex = 0;
            this.btSave.Text = "Save";
            this.btSave.UseVisualStyleBackColor = false;
            this.btSave.Visible = false;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // btCancel
            // 
            this.btCancel.BackColor = System.Drawing.Color.Transparent;
            this.btCancel.BackgroundImage = global::GUI.Properties.Resources.Button;
            this.btCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btCancel.Font = new System.Drawing.Font("Comic Sans MS", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btCancel.Location = new System.Drawing.Point(873, 648);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(181, 93);
            this.btCancel.TabIndex = 1;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = false;
            this.btCancel.Click += new System.EventHandler(this.button2_Click);
            // 
            // gbVehicle
            // 
            this.gbVehicle.BackColor = System.Drawing.Color.Transparent;
            this.gbVehicle.Controls.Add(this.rbCar);
            this.gbVehicle.Controls.Add(this.rbMotor);
            this.gbVehicle.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbVehicle.ForeColor = System.Drawing.Color.Red;
            this.gbVehicle.Location = new System.Drawing.Point(12, 12);
            this.gbVehicle.Name = "gbVehicle";
            this.gbVehicle.Size = new System.Drawing.Size(465, 106);
            this.gbVehicle.TabIndex = 2;
            this.gbVehicle.TabStop = false;
            this.gbVehicle.Text = "What vehicle do you want to add?";
            // 
            // rbCar
            // 
            this.rbCar.AutoSize = true;
            this.rbCar.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbCar.ForeColor = System.Drawing.Color.Red;
            this.rbCar.Location = new System.Drawing.Point(291, 51);
            this.rbCar.Name = "rbCar";
            this.rbCar.Size = new System.Drawing.Size(80, 42);
            this.rbCar.TabIndex = 1;
            this.rbCar.TabStop = true;
            this.rbCar.Text = "Car";
            this.rbCar.UseVisualStyleBackColor = true;
            this.rbCar.CheckedChanged += new System.EventHandler(this.rbCar_CheckedChanged);
            this.rbCar.Click += new System.EventHandler(this.rbCar_Click);
            // 
            // rbMotor
            // 
            this.rbMotor.AutoSize = true;
            this.rbMotor.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbMotor.ForeColor = System.Drawing.Color.Red;
            this.rbMotor.Location = new System.Drawing.Point(68, 51);
            this.rbMotor.Name = "rbMotor";
            this.rbMotor.Size = new System.Drawing.Size(178, 42);
            this.rbMotor.TabIndex = 0;
            this.rbMotor.TabStop = true;
            this.rbMotor.Text = "Motorcycle";
            this.rbMotor.UseVisualStyleBackColor = true;
            this.rbMotor.CheckedChanged += new System.EventHandler(this.rbMotor_CheckedChanged);
            this.rbMotor.Click += new System.EventHandler(this.rbMotor_Click);
            // 
            // cmbBrand
            // 
            this.cmbBrand.FormattingEnabled = true;
            this.cmbBrand.Location = new System.Drawing.Point(518, 63);
            this.cmbBrand.Name = "cmbBrand";
            this.cmbBrand.Size = new System.Drawing.Size(186, 21);
            this.cmbBrand.TabIndex = 3;
            this.cmbBrand.Visible = false;
            // 
            // lblbrand
            // 
            this.lblbrand.AutoSize = true;
            this.lblbrand.BackColor = System.Drawing.Color.Transparent;
            this.lblbrand.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblbrand.ForeColor = System.Drawing.Color.Red;
            this.lblbrand.Location = new System.Drawing.Point(511, 16);
            this.lblbrand.Name = "lblbrand";
            this.lblbrand.Size = new System.Drawing.Size(118, 38);
            this.lblbrand.TabIndex = 5;
            this.lblbrand.Text = "*Brand:";
            this.lblbrand.Visible = false;
            // 
            // lblmodel
            // 
            this.lblmodel.AutoSize = true;
            this.lblmodel.BackColor = System.Drawing.Color.Transparent;
            this.lblmodel.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblmodel.ForeColor = System.Drawing.Color.Red;
            this.lblmodel.Location = new System.Drawing.Point(777, 16);
            this.lblmodel.Name = "lblmodel";
            this.lblmodel.Size = new System.Drawing.Size(106, 35);
            this.lblmodel.TabIndex = 6;
            this.lblmodel.Text = "*Model:";
            this.lblmodel.Visible = false;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(783, 63);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(200, 20);
            this.txtModel.TabIndex = 7;
            this.txtModel.Visible = false;
            // 
            // lblmaxspeed
            // 
            this.lblmaxspeed.AutoSize = true;
            this.lblmaxspeed.BackColor = System.Drawing.Color.Transparent;
            this.lblmaxspeed.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblmaxspeed.ForeColor = System.Drawing.Color.Red;
            this.lblmaxspeed.Location = new System.Drawing.Point(501, 109);
            this.lblmaxspeed.Name = "lblmaxspeed";
            this.lblmaxspeed.Size = new System.Drawing.Size(166, 35);
            this.lblmaxspeed.TabIndex = 8;
            this.lblmaxspeed.Text = "*Max Speed:";
            this.lblmaxspeed.Visible = false;
            // 
            // lblacceleration
            // 
            this.lblacceleration.AutoSize = true;
            this.lblacceleration.BackColor = System.Drawing.Color.Transparent;
            this.lblacceleration.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblacceleration.ForeColor = System.Drawing.Color.Red;
            this.lblacceleration.Location = new System.Drawing.Point(767, 111);
            this.lblacceleration.Name = "lblacceleration";
            this.lblacceleration.Size = new System.Drawing.Size(248, 70);
            this.lblacceleration.TabIndex = 9;
            this.lblacceleration.Text = "*Acceleration from \r\n    0-100km/h:";
            this.lblacceleration.Visible = false;
            // 
            // txtMaxSpeed
            // 
            this.txtMaxSpeed.Location = new System.Drawing.Point(508, 167);
            this.txtMaxSpeed.Name = "txtMaxSpeed";
            this.txtMaxSpeed.Size = new System.Drawing.Size(116, 20);
            this.txtMaxSpeed.TabIndex = 10;
            this.txtMaxSpeed.Visible = false;
            // 
            // txtAcceleration
            // 
            this.txtAcceleration.Location = new System.Drawing.Point(813, 190);
            this.txtAcceleration.Name = "txtAcceleration";
            this.txtAcceleration.Size = new System.Drawing.Size(91, 20);
            this.txtAcceleration.TabIndex = 11;
            this.txtAcceleration.Visible = false;
            // 
            // lblspeedunit
            // 
            this.lblspeedunit.AutoSize = true;
            this.lblspeedunit.BackColor = System.Drawing.Color.Transparent;
            this.lblspeedunit.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblspeedunit.ForeColor = System.Drawing.Color.Red;
            this.lblspeedunit.Location = new System.Drawing.Point(630, 160);
            this.lblspeedunit.Name = "lblspeedunit";
            this.lblspeedunit.Size = new System.Drawing.Size(58, 27);
            this.lblspeedunit.TabIndex = 12;
            this.lblspeedunit.Text = "km/h";
            this.lblspeedunit.Visible = false;
            // 
            // lblunit
            // 
            this.lblunit.AutoSize = true;
            this.lblunit.BackColor = System.Drawing.Color.Transparent;
            this.lblunit.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblunit.ForeColor = System.Drawing.Color.Red;
            this.lblunit.Location = new System.Drawing.Point(910, 181);
            this.lblunit.Name = "lblunit";
            this.lblunit.Size = new System.Drawing.Size(46, 30);
            this.lblunit.TabIndex = 13;
            this.lblunit.Text = "sec";
            this.lblunit.Visible = false;
            // 
            // lblcolor
            // 
            this.lblcolor.AutoSize = true;
            this.lblcolor.BackColor = System.Drawing.Color.Transparent;
            this.lblcolor.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblcolor.ForeColor = System.Drawing.Color.Red;
            this.lblcolor.Location = new System.Drawing.Point(515, 230);
            this.lblcolor.Name = "lblcolor";
            this.lblcolor.Size = new System.Drawing.Size(98, 35);
            this.lblcolor.TabIndex = 14;
            this.lblcolor.Text = "*Color:";
            this.lblcolor.Visible = false;
            // 
            // lbldate
            // 
            this.lbldate.AutoSize = true;
            this.lbldate.BackColor = System.Drawing.Color.Transparent;
            this.lbldate.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbldate.ForeColor = System.Drawing.Color.Red;
            this.lbldate.Location = new System.Drawing.Point(709, 230);
            this.lbldate.Name = "lbldate";
            this.lbldate.Size = new System.Drawing.Size(286, 35);
            this.lbldate.TabIndex = 15;
            this.lbldate.Text = "Date of manufacturing:";
            this.lbldate.Visible = false;
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(518, 273);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(116, 20);
            this.txtColor.TabIndex = 16;
            this.txtColor.Visible = false;
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(770, 273);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(200, 20);
            this.dtpDate.TabIndex = 17;
            this.dtpDate.Visible = false;
            // 
            // lblprice
            // 
            this.lblprice.AutoSize = true;
            this.lblprice.BackColor = System.Drawing.Color.Transparent;
            this.lblprice.Font = new System.Drawing.Font("Comic Sans MS", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblprice.ForeColor = System.Drawing.Color.Red;
            this.lblprice.Location = new System.Drawing.Point(586, 586);
            this.lblprice.Name = "lblprice";
            this.lblprice.Size = new System.Drawing.Size(140, 49);
            this.lblprice.TabIndex = 18;
            this.lblprice.Text = "*Price:";
            this.lblprice.Visible = false;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(724, 608);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(136, 20);
            this.txtPrice.TabIndex = 19;
            this.txtPrice.Visible = false;
            // 
            // lblcurrency
            // 
            this.lblcurrency.AutoSize = true;
            this.lblcurrency.BackColor = System.Drawing.Color.Transparent;
            this.lblcurrency.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblcurrency.ForeColor = System.Drawing.Color.Red;
            this.lblcurrency.Location = new System.Drawing.Point(865, 602);
            this.lblcurrency.Name = "lblcurrency";
            this.lblcurrency.Size = new System.Drawing.Size(57, 30);
            this.lblcurrency.TabIndex = 20;
            this.lblcurrency.Text = "BGN";
            this.lblcurrency.Visible = false;
            // 
            // gbType
            // 
            this.gbType.BackColor = System.Drawing.Color.Transparent;
            this.gbType.Controls.Add(this.radioButton3);
            this.gbType.Controls.Add(this.radioButton2);
            this.gbType.Controls.Add(this.radioButton1);
            this.gbType.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold);
            this.gbType.ForeColor = System.Drawing.Color.Red;
            this.gbType.Location = new System.Drawing.Point(12, 124);
            this.gbType.Name = "gbType";
            this.gbType.Size = new System.Drawing.Size(465, 208);
            this.gbType.TabIndex = 21;
            this.gbType.TabStop = false;
            this.gbType.Text = "What type of Motorcycle do you want to add?";
            this.gbType.Visible = false;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(17, 158);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(166, 34);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Street Sport";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.Visible = false;
            this.radioButton3.Click += new System.EventHandler(this.radioButton3_Click);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(17, 105);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(111, 34);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Scooter";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.Visible = false;
            this.radioButton2.Click += new System.EventHandler(this.radioButton2_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(17, 66);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(103, 34);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Cruiser";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.Visible = false;
            this.radioButton1.Click += new System.EventHandler(this.radioButton1_Click);
            // 
            // gbtype2
            // 
            this.gbtype2.BackColor = System.Drawing.Color.Transparent;
            this.gbtype2.Controls.Add(this.radioButton7);
            this.gbtype2.Controls.Add(this.radioButton6);
            this.gbtype2.Controls.Add(this.radioButton5);
            this.gbtype2.Controls.Add(this.radioButton4);
            this.gbtype2.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold);
            this.gbtype2.ForeColor = System.Drawing.Color.Red;
            this.gbtype2.Location = new System.Drawing.Point(12, 353);
            this.gbtype2.Name = "gbtype2";
            this.gbtype2.Size = new System.Drawing.Size(465, 143);
            this.gbtype2.TabIndex = 22;
            this.gbtype2.TabStop = false;
            this.gbtype2.Text = "What type of electric car do you want to add?";
            this.gbtype2.Visible = false;
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Location = new System.Drawing.Point(244, 109);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(88, 34);
            this.radioButton7.TabIndex = 3;
            this.radioButton7.TabStop = true;
            this.radioButton7.Text = "Sport";
            this.radioButton7.UseVisualStyleBackColor = true;
            this.radioButton7.Visible = false;
            this.radioButton7.Click += new System.EventHandler(this.radioButton7_Click);
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(244, 65);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(96, 34);
            this.radioButton6.TabIndex = 2;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "Family";
            this.radioButton6.UseVisualStyleBackColor = true;
            this.radioButton6.Visible = false;
            this.radioButton6.Click += new System.EventHandler(this.radioButton6_Click);
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(17, 105);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(103, 34);
            this.radioButton5.TabIndex = 1;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "Cruiser";
            this.radioButton5.UseVisualStyleBackColor = true;
            this.radioButton5.Visible = false;
            this.radioButton5.Click += new System.EventHandler(this.radioButton5_Click);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(17, 65);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(91, 34);
            this.radioButton4.TabIndex = 0;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Urban";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.Visible = false;
            this.radioButton4.Click += new System.EventHandler(this.radioButton4_Click);
            // 
            // gbtype3
            // 
            this.gbtype3.BackColor = System.Drawing.Color.Transparent;
            this.gbtype3.Controls.Add(this.radioButton10);
            this.gbtype3.Controls.Add(this.radioButton9);
            this.gbtype3.Controls.Add(this.radioButton8);
            this.gbtype3.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold);
            this.gbtype3.ForeColor = System.Drawing.Color.Red;
            this.gbtype3.Location = new System.Drawing.Point(12, 521);
            this.gbtype3.Name = "gbtype3";
            this.gbtype3.Size = new System.Drawing.Size(465, 178);
            this.gbtype3.TabIndex = 23;
            this.gbtype3.TabStop = false;
            this.gbtype3.Text = "What type of Family car do you want to add?";
            this.gbtype3.Visible = false;
            // 
            // radioButton10
            // 
            this.radioButton10.AutoSize = true;
            this.radioButton10.Location = new System.Drawing.Point(17, 138);
            this.radioButton10.Name = "radioButton10";
            this.radioButton10.Size = new System.Drawing.Size(98, 34);
            this.radioButton10.TabIndex = 2;
            this.radioButton10.TabStop = true;
            this.radioButton10.Text = "Wagon";
            this.radioButton10.UseVisualStyleBackColor = true;
            this.radioButton10.Visible = false;
            this.radioButton10.Click += new System.EventHandler(this.radioButton10_Click);
            // 
            // radioButton9
            // 
            this.radioButton9.AutoSize = true;
            this.radioButton9.Location = new System.Drawing.Point(17, 101);
            this.radioButton9.Name = "radioButton9";
            this.radioButton9.Size = new System.Drawing.Size(75, 34);
            this.radioButton9.TabIndex = 1;
            this.radioButton9.TabStop = true;
            this.radioButton9.Text = "SUV";
            this.radioButton9.UseVisualStyleBackColor = true;
            this.radioButton9.Visible = false;
            this.radioButton9.Click += new System.EventHandler(this.radioButton9_Click);
            // 
            // radioButton8
            // 
            this.radioButton8.AutoSize = true;
            this.radioButton8.Location = new System.Drawing.Point(17, 65);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(93, 34);
            this.radioButton8.TabIndex = 0;
            this.radioButton8.TabStop = true;
            this.radioButton8.Text = "Sedan";
            this.radioButton8.UseVisualStyleBackColor = true;
            this.radioButton8.Visible = false;
            this.radioButton8.Click += new System.EventHandler(this.radioButton8_Click);
            // 
            // txtPower
            // 
            this.txtPower.Location = new System.Drawing.Point(515, 399);
            this.txtPower.Name = "txtPower";
            this.txtPower.Size = new System.Drawing.Size(116, 20);
            this.txtPower.TabIndex = 24;
            this.txtPower.Visible = false;
            // 
            // txtVolume
            // 
            this.txtVolume.Location = new System.Drawing.Point(713, 399);
            this.txtVolume.Name = "txtVolume";
            this.txtVolume.Size = new System.Drawing.Size(116, 20);
            this.txtVolume.TabIndex = 25;
            this.txtVolume.Visible = false;
            // 
            // txtValves
            // 
            this.txtValves.Location = new System.Drawing.Point(910, 399);
            this.txtValves.Name = "txtValves";
            this.txtValves.Size = new System.Drawing.Size(116, 20);
            this.txtValves.TabIndex = 26;
            this.txtValves.Visible = false;
            // 
            // lblpower
            // 
            this.lblpower.AutoSize = true;
            this.lblpower.BackColor = System.Drawing.Color.Transparent;
            this.lblpower.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblpower.ForeColor = System.Drawing.Color.Red;
            this.lblpower.Location = new System.Drawing.Point(500, 358);
            this.lblpower.Name = "lblpower";
            this.lblpower.Size = new System.Drawing.Size(150, 30);
            this.lblpower.TabIndex = 27;
            this.lblpower.Text = "*Horsepower:";
            this.lblpower.Visible = false;
            // 
            // lblvolume
            // 
            this.lblvolume.AutoSize = true;
            this.lblvolume.BackColor = System.Drawing.Color.Transparent;
            this.lblvolume.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblvolume.ForeColor = System.Drawing.Color.Red;
            this.lblvolume.Location = new System.Drawing.Point(680, 320);
            this.lblvolume.Name = "lblvolume";
            this.lblvolume.Size = new System.Drawing.Size(202, 70);
            this.lblvolume.TabIndex = 28;
            this.lblvolume.Text = "*Engine Volume \r\nin cm3:";
            this.lblvolume.Visible = false;
            // 
            // lblvalve
            // 
            this.lblvalve.AutoSize = true;
            this.lblvalve.BackColor = System.Drawing.Color.Transparent;
            this.lblvalve.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblvalve.ForeColor = System.Drawing.Color.Red;
            this.lblvalve.Location = new System.Drawing.Point(885, 358);
            this.lblvalve.Name = "lblvalve";
            this.lblvalve.Size = new System.Drawing.Size(170, 30);
            this.lblvalve.TabIndex = 29;
            this.lblvalve.Text = "*Engine Valves:";
            this.lblvalve.Visible = false;
            // 
            // txtfuel
            // 
            this.txtfuel.Location = new System.Drawing.Point(564, 490);
            this.txtfuel.Name = "txtfuel";
            this.txtfuel.Size = new System.Drawing.Size(74, 20);
            this.txtfuel.TabIndex = 30;
            this.txtfuel.Visible = false;
            // 
            // txtconsumption
            // 
            this.txtconsumption.Location = new System.Drawing.Point(710, 490);
            this.txtconsumption.Name = "txtconsumption";
            this.txtconsumption.Size = new System.Drawing.Size(116, 20);
            this.txtconsumption.TabIndex = 31;
            this.txtconsumption.Visible = false;
            // 
            // lblfuel
            // 
            this.lblfuel.AutoSize = true;
            this.lblfuel.BackColor = System.Drawing.Color.Transparent;
            this.lblfuel.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblfuel.ForeColor = System.Drawing.Color.Red;
            this.lblfuel.Location = new System.Drawing.Point(509, 448);
            this.lblfuel.Name = "lblfuel";
            this.lblfuel.Size = new System.Drawing.Size(129, 30);
            this.lblfuel.TabIndex = 32;
            this.lblfuel.Text = "*Fuel type:";
            this.lblfuel.Visible = false;
            // 
            // lblrazhod
            // 
            this.lblrazhod.AutoSize = true;
            this.lblrazhod.BackColor = System.Drawing.Color.Transparent;
            this.lblrazhod.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblrazhod.ForeColor = System.Drawing.Color.Red;
            this.lblrazhod.Location = new System.Drawing.Point(689, 450);
            this.lblrazhod.Name = "lblrazhod";
            this.lblrazhod.Size = new System.Drawing.Size(154, 30);
            this.lblrazhod.TabIndex = 33;
            this.lblrazhod.Text = "*Consumption:";
            this.lblrazhod.Visible = false;
            // 
            // txtseats
            // 
            this.txtseats.Location = new System.Drawing.Point(976, 490);
            this.txtseats.Name = "txtseats";
            this.txtseats.Size = new System.Drawing.Size(60, 20);
            this.txtseats.TabIndex = 34;
            this.txtseats.Visible = false;
            // 
            // lblseats
            // 
            this.lblseats.AutoSize = true;
            this.lblseats.BackColor = System.Drawing.Color.Transparent;
            this.lblseats.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblseats.ForeColor = System.Drawing.Color.Red;
            this.lblseats.Location = new System.Drawing.Point(879, 481);
            this.lblseats.Name = "lblseats";
            this.lblseats.Size = new System.Drawing.Size(92, 30);
            this.lblseats.TabIndex = 35;
            this.lblseats.Text = "*Seats:";
            this.lblseats.Visible = false;
            // 
            // txtdoors
            // 
            this.txtdoors.Location = new System.Drawing.Point(643, 546);
            this.txtdoors.Name = "txtdoors";
            this.txtdoors.Size = new System.Drawing.Size(60, 20);
            this.txtdoors.TabIndex = 36;
            this.txtdoors.Visible = false;
            // 
            // txtboot
            // 
            this.txtboot.Location = new System.Drawing.Point(915, 553);
            this.txtboot.Name = "txtboot";
            this.txtboot.Size = new System.Drawing.Size(60, 20);
            this.txtboot.TabIndex = 37;
            this.txtboot.Visible = false;
            // 
            // lbldoors
            // 
            this.lbldoors.AutoSize = true;
            this.lbldoors.BackColor = System.Drawing.Color.Transparent;
            this.lbldoors.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbldoors.ForeColor = System.Drawing.Color.Red;
            this.lbldoors.Location = new System.Drawing.Point(551, 537);
            this.lbldoors.Name = "lbldoors";
            this.lbldoors.Size = new System.Drawing.Size(90, 30);
            this.lbldoors.TabIndex = 38;
            this.lbldoors.Text = "*Doors:";
            this.lbldoors.Visible = false;
            // 
            // lblboot
            // 
            this.lblboot.AutoSize = true;
            this.lblboot.BackColor = System.Drawing.Color.Transparent;
            this.lblboot.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblboot.ForeColor = System.Drawing.Color.Red;
            this.lblboot.Location = new System.Drawing.Point(788, 546);
            this.lblboot.Name = "lblboot";
            this.lblboot.Size = new System.Drawing.Size(121, 30);
            this.lblboot.TabIndex = 39;
            this.lblboot.Text = "*Boot cap:";
            this.lblboot.Visible = false;
            // 
            // bthelp
            // 
            this.bthelp.BackColor = System.Drawing.Color.Transparent;
            this.bthelp.BackgroundImage = global::GUI.Properties.Resources.Button;
            this.bthelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bthelp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bthelp.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bthelp.Location = new System.Drawing.Point(504, 482);
            this.bthelp.Name = "bthelp";
            this.bthelp.Size = new System.Drawing.Size(54, 31);
            this.bthelp.TabIndex = 40;
            this.bthelp.Text = "Help";
            this.bthelp.UseVisualStyleBackColor = false;
            this.bthelp.Click += new System.EventHandler(this.bthelp_Click);
            // 
            // frmAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GUI.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1069, 753);
            this.ControlBox = false;
            this.Controls.Add(this.bthelp);
            this.Controls.Add(this.lblboot);
            this.Controls.Add(this.lbldoors);
            this.Controls.Add(this.txtboot);
            this.Controls.Add(this.txtdoors);
            this.Controls.Add(this.lblseats);
            this.Controls.Add(this.txtseats);
            this.Controls.Add(this.lblrazhod);
            this.Controls.Add(this.lblfuel);
            this.Controls.Add(this.txtconsumption);
            this.Controls.Add(this.txtfuel);
            this.Controls.Add(this.lblvalve);
            this.Controls.Add(this.lblvolume);
            this.Controls.Add(this.lblpower);
            this.Controls.Add(this.txtValves);
            this.Controls.Add(this.txtVolume);
            this.Controls.Add(this.txtPower);
            this.Controls.Add(this.gbtype3);
            this.Controls.Add(this.gbtype2);
            this.Controls.Add(this.gbType);
            this.Controls.Add(this.txtAcceleration);
            this.Controls.Add(this.lblcurrency);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.lblprice);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.txtColor);
            this.Controls.Add(this.lbldate);
            this.Controls.Add(this.lblcolor);
            this.Controls.Add(this.lblunit);
            this.Controls.Add(this.lblspeedunit);
            this.Controls.Add(this.txtMaxSpeed);
            this.Controls.Add(this.lblacceleration);
            this.Controls.Add(this.lblmaxspeed);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.lblmodel);
            this.Controls.Add(this.lblbrand);
            this.Controls.Add(this.cmbBrand);
            this.Controls.Add(this.gbVehicle);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btSave);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Vehicle";
            this.Load += new System.EventHandler(this.frmAdd_Load);
            this.gbVehicle.ResumeLayout(false);
            this.gbVehicle.PerformLayout();
            this.gbType.ResumeLayout(false);
            this.gbType.PerformLayout();
            this.gbtype2.ResumeLayout(false);
            this.gbtype2.PerformLayout();
            this.gbtype3.ResumeLayout(false);
            this.gbtype3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.GroupBox gbVehicle;
        private System.Windows.Forms.RadioButton rbCar;
        private System.Windows.Forms.RadioButton rbMotor;
        private System.Windows.Forms.ComboBox cmbBrand;
        private System.Windows.Forms.Label lblbrand;
        private System.Windows.Forms.Label lblmodel;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Label lblmaxspeed;
        private System.Windows.Forms.Label lblacceleration;
        private System.Windows.Forms.TextBox txtMaxSpeed;
        private System.Windows.Forms.TextBox txtAcceleration;
        private System.Windows.Forms.Label lblspeedunit;
        private System.Windows.Forms.Label lblunit;
        private System.Windows.Forms.Label lblcolor;
        private System.Windows.Forms.Label lbldate;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label lblprice;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblcurrency;
        private System.Windows.Forms.GroupBox gbType;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.GroupBox gbtype2;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.GroupBox gbtype3;
        private System.Windows.Forms.RadioButton radioButton10;
        private System.Windows.Forms.RadioButton radioButton9;
        private System.Windows.Forms.RadioButton radioButton8;
        private System.Windows.Forms.TextBox txtPower;
        private System.Windows.Forms.TextBox txtVolume;
        private System.Windows.Forms.TextBox txtValves;
        private System.Windows.Forms.Label lblpower;
        private System.Windows.Forms.Label lblvolume;
        private System.Windows.Forms.Label lblvalve;
        private System.Windows.Forms.TextBox txtfuel;
        private System.Windows.Forms.TextBox txtconsumption;
        private System.Windows.Forms.Label lblfuel;
        private System.Windows.Forms.Label lblrazhod;
        private System.Windows.Forms.TextBox txtseats;
        private System.Windows.Forms.Label lblseats;
        private System.Windows.Forms.TextBox txtdoors;
        private System.Windows.Forms.TextBox txtboot;
        private System.Windows.Forms.Label lbldoors;
        private System.Windows.Forms.Label lblboot;
        private System.Windows.Forms.Button bthelp;
    }
}