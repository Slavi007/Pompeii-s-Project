namespace GUI
{
    partial class frmSell
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSell));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.rbCar = new System.Windows.Forms.RadioButton();
            this.rbMotor = new System.Windows.Forms.RadioButton();
            this.gpQuestion = new System.Windows.Forms.GroupBox();
            this.lbltext = new System.Windows.Forms.Label();
            this.lblmodel = new System.Windows.Forms.Label();
            this.cmbVehicle = new System.Windows.Forms.ComboBox();
            this.lbldate = new System.Windows.Forms.Label();
            this.lblprice = new System.Windows.Forms.Label();
            this.lblmax = new System.Windows.Forms.Label();
            this.lbltop = new System.Windows.Forms.Label();
            this.lblcolor = new System.Windows.Forms.Label();
            this.lblbrand = new System.Windows.Forms.Label();
            this.gpQuestion.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(12, 572);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 77);
            this.button1.TabIndex = 0;
            this.button1.Text = "Sell";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(507, 572);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(165, 77);
            this.button2.TabIndex = 1;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // rbCar
            // 
            this.rbCar.AutoSize = true;
            this.rbCar.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbCar.ForeColor = System.Drawing.Color.Red;
            this.rbCar.Location = new System.Drawing.Point(298, 51);
            this.rbCar.Name = "rbCar";
            this.rbCar.Size = new System.Drawing.Size(80, 42);
            this.rbCar.TabIndex = 1;
            this.rbCar.TabStop = true;
            this.rbCar.Text = "Car";
            this.rbCar.UseVisualStyleBackColor = true;
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
            this.rbMotor.Click += new System.EventHandler(this.rbMotor_Click);
            // 
            // gpQuestion
            // 
            this.gpQuestion.BackColor = System.Drawing.Color.Transparent;
            this.gpQuestion.Controls.Add(this.rbCar);
            this.gpQuestion.Controls.Add(this.rbMotor);
            this.gpQuestion.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gpQuestion.ForeColor = System.Drawing.Color.Red;
            this.gpQuestion.Location = new System.Drawing.Point(103, 23);
            this.gpQuestion.Name = "gpQuestion";
            this.gpQuestion.Size = new System.Drawing.Size(465, 99);
            this.gpQuestion.TabIndex = 3;
            this.gpQuestion.TabStop = false;
            this.gpQuestion.Text = "What vehicle do you want to sell?";
            // 
            // lbltext
            // 
            this.lbltext.AutoSize = true;
            this.lbltext.BackColor = System.Drawing.Color.Transparent;
            this.lbltext.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbltext.ForeColor = System.Drawing.Color.Red;
            this.lbltext.Location = new System.Drawing.Point(57, 154);
            this.lbltext.Name = "lbltext";
            this.lbltext.Size = new System.Drawing.Size(93, 38);
            this.lbltext.TabIndex = 4;
            this.lbltext.Text = "label1";
            this.lbltext.Visible = false;
            // 
            // lblmodel
            // 
            this.lblmodel.AutoSize = true;
            this.lblmodel.BackColor = System.Drawing.Color.Transparent;
            this.lblmodel.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblmodel.ForeColor = System.Drawing.Color.Red;
            this.lblmodel.Location = new System.Drawing.Point(244, 285);
            this.lblmodel.Name = "lblmodel";
            this.lblmodel.Size = new System.Drawing.Size(64, 27);
            this.lblmodel.TabIndex = 5;
            this.lblmodel.Text = "model";
            this.lblmodel.Visible = false;
            // 
            // cmbVehicle
            // 
            this.cmbVehicle.FormattingEnabled = true;
            this.cmbVehicle.Location = new System.Drawing.Point(183, 204);
            this.cmbVehicle.Name = "cmbVehicle";
            this.cmbVehicle.Size = new System.Drawing.Size(298, 21);
            this.cmbVehicle.TabIndex = 6;
            this.cmbVehicle.Visible = false;
            this.cmbVehicle.SelectionChangeCommitted += new System.EventHandler(this.cmbVehicle_SelectionChangeCommitted);
            // 
            // lbldate
            // 
            this.lbldate.AutoSize = true;
            this.lbldate.BackColor = System.Drawing.Color.Transparent;
            this.lbldate.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbldate.ForeColor = System.Drawing.Color.Red;
            this.lbldate.Location = new System.Drawing.Point(435, 285);
            this.lbldate.Name = "lbldate";
            this.lbldate.Size = new System.Drawing.Size(54, 27);
            this.lbldate.TabIndex = 7;
            this.lbldate.Text = "date";
            this.lbldate.Visible = false;
            // 
            // lblprice
            // 
            this.lblprice.AutoSize = true;
            this.lblprice.BackColor = System.Drawing.Color.Transparent;
            this.lblprice.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblprice.ForeColor = System.Drawing.Color.Red;
            this.lblprice.Location = new System.Drawing.Point(60, 464);
            this.lblprice.Name = "lblprice";
            this.lblprice.Size = new System.Drawing.Size(72, 35);
            this.lblprice.TabIndex = 8;
            this.lblprice.Text = "price";
            this.lblprice.Visible = false;
            // 
            // lblmax
            // 
            this.lblmax.AutoSize = true;
            this.lblmax.BackColor = System.Drawing.Color.Transparent;
            this.lblmax.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblmax.ForeColor = System.Drawing.Color.Red;
            this.lblmax.Location = new System.Drawing.Point(60, 377);
            this.lblmax.Name = "lblmax";
            this.lblmax.Size = new System.Drawing.Size(49, 27);
            this.lblmax.TabIndex = 9;
            this.lblmax.Text = "max";
            this.lblmax.Visible = false;
            // 
            // lbltop
            // 
            this.lbltop.AutoSize = true;
            this.lbltop.BackColor = System.Drawing.Color.Transparent;
            this.lbltop.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbltop.ForeColor = System.Drawing.Color.Red;
            this.lbltop.Location = new System.Drawing.Point(326, 377);
            this.lbltop.Name = "lbltop";
            this.lbltop.Size = new System.Drawing.Size(41, 27);
            this.lbltop.TabIndex = 10;
            this.lbltop.Text = "top";
            this.lbltop.Visible = false;
            // 
            // lblcolor
            // 
            this.lblcolor.AutoSize = true;
            this.lblcolor.BackColor = System.Drawing.Color.Transparent;
            this.lblcolor.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblcolor.ForeColor = System.Drawing.Color.Red;
            this.lblcolor.Location = new System.Drawing.Point(516, 377);
            this.lblcolor.Name = "lblcolor";
            this.lblcolor.Size = new System.Drawing.Size(56, 27);
            this.lblcolor.TabIndex = 11;
            this.lblcolor.Text = "color";
            this.lblcolor.Visible = false;
            // 
            // lblbrand
            // 
            this.lblbrand.AutoSize = true;
            this.lblbrand.BackColor = System.Drawing.Color.Transparent;
            this.lblbrand.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblbrand.ForeColor = System.Drawing.Color.Red;
            this.lblbrand.Location = new System.Drawing.Point(53, 285);
            this.lblbrand.Name = "lblbrand";
            this.lblbrand.Size = new System.Drawing.Size(64, 27);
            this.lblbrand.TabIndex = 12;
            this.lblbrand.Text = "brand";
            this.lblbrand.Visible = false;
            // 
            // frmSell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GUI.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(701, 661);
            this.ControlBox = false;
            this.Controls.Add(this.lblbrand);
            this.Controls.Add(this.lblcolor);
            this.Controls.Add(this.lbltop);
            this.Controls.Add(this.lblmax);
            this.Controls.Add(this.lblprice);
            this.Controls.Add(this.lbldate);
            this.Controls.Add(this.cmbVehicle);
            this.Controls.Add(this.lblmodel);
            this.Controls.Add(this.lbltext);
            this.Controls.Add(this.gpQuestion);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmSell";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sell";
            this.Load += new System.EventHandler(this.frmSell_Load);
            this.gpQuestion.ResumeLayout(false);
            this.gpQuestion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RadioButton rbCar;
        private System.Windows.Forms.RadioButton rbMotor;
        private System.Windows.Forms.GroupBox gpQuestion;
        private System.Windows.Forms.Label lbltext;
        private System.Windows.Forms.Label lblmodel;
        private System.Windows.Forms.ComboBox cmbVehicle;
        private System.Windows.Forms.Label lbldate;
        private System.Windows.Forms.Label lblprice;
        private System.Windows.Forms.Label lblmax;
        private System.Windows.Forms.Label lbltop;
        private System.Windows.Forms.Label lblcolor;
        private System.Windows.Forms.Label lblbrand;
    }
}