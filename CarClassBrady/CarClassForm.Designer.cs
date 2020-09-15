namespace CarClassBrady
{
    partial class CarClassForm
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
            this.btnAccelerate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblCurrentSpeed = new System.Windows.Forms.Label();
            this.lblSpeed = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblMake = new System.Windows.Forms.Label();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.txtMake = new System.Windows.Forms.TextBox();
            this.btnBrake = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAccelerate
            // 
            this.btnAccelerate.Location = new System.Drawing.Point(26, 205);
            this.btnAccelerate.Name = "btnAccelerate";
            this.btnAccelerate.Size = new System.Drawing.Size(97, 52);
            this.btnAccelerate.TabIndex = 0;
            this.btnAccelerate.Text = "&Accelerate";
            this.btnAccelerate.UseVisualStyleBackColor = true;
            this.btnAccelerate.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(258, 204);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(97, 52);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.Button2_Click);
            // 
            // lblCurrentSpeed
            // 
            this.lblCurrentSpeed.AutoSize = true;
            this.lblCurrentSpeed.Location = new System.Drawing.Point(135, 150);
            this.lblCurrentSpeed.Name = "lblCurrentSpeed";
            this.lblCurrentSpeed.Size = new System.Drawing.Size(104, 17);
            this.lblCurrentSpeed.TabIndex = 2;
            this.lblCurrentSpeed.Text = "Current Speed:";
            // 
            // lblSpeed
            // 
            this.lblSpeed.AutoSize = true;
            this.lblSpeed.Location = new System.Drawing.Point(252, 150);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(16, 17);
            this.lblSpeed.TabIndex = 3;
            this.lblSpeed.Text = "0";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(96, 37);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(42, 17);
            this.lblYear.TabIndex = 4;
            this.lblYear.Text = "Year:";
            // 
            // lblMake
            // 
            this.lblMake.AutoSize = true;
            this.lblMake.Location = new System.Drawing.Point(96, 96);
            this.lblMake.Name = "lblMake";
            this.lblMake.Size = new System.Drawing.Size(46, 17);
            this.lblMake.TabIndex = 5;
            this.lblMake.Text = "Make:";
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(192, 34);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(100, 22);
            this.txtYear.TabIndex = 7;
            // 
            // txtMake
            // 
            this.txtMake.Location = new System.Drawing.Point(192, 91);
            this.txtMake.Name = "txtMake";
            this.txtMake.Size = new System.Drawing.Size(100, 22);
            this.txtMake.TabIndex = 8;
            // 
            // btnBrake
            // 
            this.btnBrake.Location = new System.Drawing.Point(142, 205);
            this.btnBrake.Name = "btnBrake";
            this.btnBrake.Size = new System.Drawing.Size(97, 51);
            this.btnBrake.TabIndex = 9;
            this.btnBrake.Text = "&Brake";
            this.btnBrake.UseVisualStyleBackColor = true;
            this.btnBrake.Click += new System.EventHandler(this.BtnBrake_Click);
            // 
            // CarClassForm
            // 
            this.AcceptButton = this.btnAccelerate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(408, 286);
            this.Controls.Add(this.btnBrake);
            this.Controls.Add(this.txtMake);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.lblMake);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.lblSpeed);
            this.Controls.Add(this.lblCurrentSpeed);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAccelerate);
            this.Name = "CarClassForm";
            this.Text = "Car Class";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAccelerate;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblCurrentSpeed;
        private System.Windows.Forms.Label lblSpeed;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblMake;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.TextBox txtMake;
        private System.Windows.Forms.Button btnBrake;
    }
}

