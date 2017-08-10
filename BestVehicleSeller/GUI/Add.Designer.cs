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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbMotor = new System.Windows.Forms.RadioButton();
            this.rbCar = new System.Windows.Forms.RadioButton();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.cmbtype2 = new System.Windows.Forms.ComboBox();
            this.lblText = new System.Windows.Forms.Label();
            this.lbltype = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
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
            this.btSave.Location = new System.Drawing.Point(12, 556);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(181, 93);
            this.btSave.TabIndex = 0;
            this.btSave.Text = "Save";
            this.btSave.UseVisualStyleBackColor = false;
            // 
            // btCancel
            // 
            this.btCancel.BackColor = System.Drawing.Color.Transparent;
            this.btCancel.BackgroundImage = global::GUI.Properties.Resources.Button;
            this.btCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btCancel.Font = new System.Drawing.Font("Comic Sans MS", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btCancel.Location = new System.Drawing.Point(491, 556);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(181, 93);
            this.btCancel.TabIndex = 1;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = false;
            this.btCancel.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.rbCar);
            this.groupBox1.Controls.Add(this.rbMotor);
            this.groupBox1.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.ForeColor = System.Drawing.Color.Red;
            this.groupBox1.Location = new System.Drawing.Point(90, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(465, 99);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "What vehicle do you want to add?";
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
            this.rbCar.CheckedChanged += new System.EventHandler(this.rbCar_CheckedChanged);
            this.rbCar.Click += new System.EventHandler(this.rbCar_Click);
            // 
            // cmbType
            // 
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Location = new System.Drawing.Point(90, 189);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(285, 21);
            this.cmbType.TabIndex = 3;
            this.cmbType.Visible = false;
            // 
            // cmbtype2
            // 
            this.cmbtype2.FormattingEnabled = true;
            this.cmbtype2.Location = new System.Drawing.Point(435, 189);
            this.cmbtype2.Name = "cmbtype2";
            this.cmbtype2.Size = new System.Drawing.Size(120, 21);
            this.cmbtype2.TabIndex = 4;
            this.cmbtype2.Visible = false;
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.BackColor = System.Drawing.Color.Transparent;
            this.lblText.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblText.ForeColor = System.Drawing.Color.Red;
            this.lblText.Location = new System.Drawing.Point(84, 142);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(71, 31);
            this.lblText.TabIndex = 5;
            this.lblText.Text = "Text";
            this.lblText.Visible = false;
            // 
            // lbltype
            // 
            this.lbltype.AutoSize = true;
            this.lbltype.BackColor = System.Drawing.Color.Transparent;
            this.lbltype.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbltype.ForeColor = System.Drawing.Color.Red;
            this.lbltype.Location = new System.Drawing.Point(429, 142);
            this.lbltype.Name = "lbltype";
            this.lbltype.Size = new System.Drawing.Size(71, 31);
            this.lbltype.TabIndex = 6;
            this.lbltype.Text = "Text";
            this.lbltype.Visible = false;
            // 
            // frmAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GUI.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(684, 661);
            this.ControlBox = false;
            this.Controls.Add(this.lbltype);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.cmbtype2);
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btSave);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Vehicle";
            this.Load += new System.EventHandler(this.frmAdd_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbCar;
        private System.Windows.Forms.RadioButton rbMotor;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.ComboBox cmbtype2;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.Label lbltype;
    }
}