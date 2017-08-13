namespace GUI
{
    partial class frmTunning
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTunning));
            this.btSave = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.rbCar = new System.Windows.Forms.RadioButton();
            this.rbMotor = new System.Windows.Forms.RadioButton();
            this.gpQuestion = new System.Windows.Forms.GroupBox();
            this.gpQuestion.SuspendLayout();
            this.SuspendLayout();
            // 
            // btSave
            // 
            this.btSave.BackColor = System.Drawing.Color.Transparent;
            this.btSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btSave.BackgroundImage")));
            this.btSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btSave.Font = new System.Drawing.Font("Comic Sans MS", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btSave.Location = new System.Drawing.Point(29, 544);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(155, 94);
            this.btSave.TabIndex = 0;
            this.btSave.Text = "Save";
            this.btSave.UseVisualStyleBackColor = false;
            // 
            // btCancel
            // 
            this.btCancel.BackColor = System.Drawing.Color.Transparent;
            this.btCancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btCancel.BackgroundImage")));
            this.btCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btCancel.Font = new System.Drawing.Font("Comic Sans MS", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btCancel.Location = new System.Drawing.Point(503, 544);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(155, 94);
            this.btCancel.TabIndex = 1;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = false;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::GUI.Properties.Resources.Button;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(243, 488);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(210, 134);
            this.button1.TabIndex = 2;
            this.button1.Text = "Apply \r\nTunning";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            // 
            // gpQuestion
            // 
            this.gpQuestion.BackColor = System.Drawing.Color.Transparent;
            this.gpQuestion.Controls.Add(this.rbCar);
            this.gpQuestion.Controls.Add(this.rbMotor);
            this.gpQuestion.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gpQuestion.ForeColor = System.Drawing.Color.Red;
            this.gpQuestion.Location = new System.Drawing.Point(112, 25);
            this.gpQuestion.Name = "gpQuestion";
            this.gpQuestion.Size = new System.Drawing.Size(465, 99);
            this.gpQuestion.TabIndex = 4;
            this.gpQuestion.TabStop = false;
            this.gpQuestion.Text = "What vehicle do you want to upgrade?";
            this.gpQuestion.Enter += new System.EventHandler(this.gpQuestion_Enter);
            // 
            // frmTunning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GUI.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(684, 661);
            this.ControlBox = false;
            this.Controls.Add(this.gpQuestion);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btSave);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTunning";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tunning";
            this.gpQuestion.ResumeLayout(false);
            this.gpQuestion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton rbCar;
        private System.Windows.Forms.RadioButton rbMotor;
        private System.Windows.Forms.GroupBox gpQuestion;
    }
}