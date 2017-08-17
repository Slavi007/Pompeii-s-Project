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
            this.lblvehicle = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbVehicle = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
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
            // lblvehicle
            // 
            this.lblvehicle.AutoSize = true;
            this.lblvehicle.BackColor = System.Drawing.Color.Transparent;
            this.lblvehicle.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblvehicle.ForeColor = System.Drawing.Color.Red;
            this.lblvehicle.Location = new System.Drawing.Point(49, 177);
            this.lblvehicle.Name = "lblvehicle";
            this.lblvehicle.Size = new System.Drawing.Size(93, 38);
            this.lblvehicle.TabIndex = 4;
            this.lblvehicle.Text = "label1";
            this.lblvehicle.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(138, 373);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 40);
            this.label2.TabIndex = 5;
            this.label2.Text = "label2";
            this.label2.Visible = false;
            // 
            // cmbVehicle
            // 
            this.cmbVehicle.FormattingEnabled = true;
            this.cmbVehicle.Location = new System.Drawing.Point(183, 223);
            this.cmbVehicle.Name = "cmbVehicle";
            this.cmbVehicle.Size = new System.Drawing.Size(298, 21);
            this.cmbVehicle.TabIndex = 6;
            this.cmbVehicle.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(408, 373);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 40);
            this.label3.TabIndex = 7;
            this.label3.Text = "label3";
            this.label3.Visible = false;
            // 
            // frmSell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GUI.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(701, 661);
            this.ControlBox = false;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbVehicle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblvehicle);
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
        private System.Windows.Forms.Label lblvehicle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbVehicle;
        private System.Windows.Forms.Label label3;
    }
}