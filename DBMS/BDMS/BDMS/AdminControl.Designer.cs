namespace BDMS
{
    partial class AdminControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminControl));
            this.button2 = new System.Windows.Forms.Button();
            this.ScreeningRslt = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(264, 39);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(132, 47);
            this.button2.TabIndex = 1;
            this.button2.Text = "Donor Details";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ScreeningRslt
            // 
            this.ScreeningRslt.Location = new System.Drawing.Point(454, 39);
            this.ScreeningRslt.Name = "ScreeningRslt";
            this.ScreeningRslt.Size = new System.Drawing.Size(176, 47);
            this.ScreeningRslt.TabIndex = 2;
            this.ScreeningRslt.Text = "Screening Results";
            this.ScreeningRslt.UseVisualStyleBackColor = true;
            this.ScreeningRslt.Click += new System.EventHandler(this.ScreeningRslt_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(690, 39);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(154, 47);
            this.button3.TabIndex = 3;
            this.button3.Text = "Donated Blood";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // AdminControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1687, 771);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.ScreeningRslt);
            this.Controls.Add(this.button2);
            this.Name = "AdminControl";
            this.Text = "AdminControl";
            this.Load += new System.EventHandler(this.AdminControl_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button ScreeningRslt;
        private System.Windows.Forms.Button button3;
    }
}