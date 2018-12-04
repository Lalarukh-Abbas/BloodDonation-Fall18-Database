namespace Attempt2
{
    partial class UserType
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
            this.btnDonor = new System.Windows.Forms.Button();
            this.btnHospital = new System.Windows.Forms.Button();
            this.lblUserType = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDonor
            // 
            this.btnDonor.Location = new System.Drawing.Point(225, 156);
            this.btnDonor.Name = "btnDonor";
            this.btnDonor.Size = new System.Drawing.Size(75, 23);
            this.btnDonor.TabIndex = 0;
            this.btnDonor.Text = "Donor";
            this.btnDonor.UseVisualStyleBackColor = true;
            this.btnDonor.Click += new System.EventHandler(this.btnDonor_Click);
            // 
            // btnHospital
            // 
            this.btnHospital.Location = new System.Drawing.Point(51, 156);
            this.btnHospital.Name = "btnHospital";
            this.btnHospital.Size = new System.Drawing.Size(75, 23);
            this.btnHospital.TabIndex = 2;
            this.btnHospital.Text = "Hospital";
            this.btnHospital.UseVisualStyleBackColor = true;
            this.btnHospital.Click += new System.EventHandler(this.btnHospital_Click);
            // 
            // lblUserType
            // 
            this.lblUserType.AutoSize = true;
            this.lblUserType.Location = new System.Drawing.Point(99, 88);
            this.lblUserType.Name = "lblUserType";
            this.lblUserType.Size = new System.Drawing.Size(149, 13);
            this.lblUserType.TabIndex = 3;
            this.lblUserType.Text = "Click the type of User you are.";
            this.lblUserType.Click += new System.EventHandler(this.label1_Click);
            // 
            // UserType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 283);
            this.Controls.Add(this.lblUserType);
            this.Controls.Add(this.btnHospital);
            this.Controls.Add(this.btnDonor);
            this.Name = "UserType";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserType";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDonor;
        private System.Windows.Forms.Button btnHospital;
        private System.Windows.Forms.Label lblUserType;
    }
}