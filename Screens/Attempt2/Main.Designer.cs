namespace Attempt2
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnDonors = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnMainContactUs = new System.Windows.Forms.Button();
            this.btnMainLogin = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnHelp
            // 
            this.btnHelp.Location = new System.Drawing.Point(550, 34);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(75, 23);
            this.btnHelp.TabIndex = 13;
            this.btnHelp.Text = "Help";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // btnDonors
            // 
            this.btnDonors.Location = new System.Drawing.Point(783, 34);
            this.btnDonors.Name = "btnDonors";
            this.btnDonors.Size = new System.Drawing.Size(75, 23);
            this.btnDonors.TabIndex = 12;
            this.btnDonors.Text = "Donors List";
            this.btnDonors.UseVisualStyleBackColor = true;
            this.btnDonors.Click += new System.EventHandler(this.btnDonors_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.Location = new System.Drawing.Point(448, 34);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(75, 23);
            this.btnAbout.TabIndex = 11;
            this.btnAbout.Text = "About";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // btnMainContactUs
            // 
            this.btnMainContactUs.Location = new System.Drawing.Point(884, 34);
            this.btnMainContactUs.Name = "btnMainContactUs";
            this.btnMainContactUs.Size = new System.Drawing.Size(75, 23);
            this.btnMainContactUs.TabIndex = 15;
            this.btnMainContactUs.Text = "Contact Us";
            this.btnMainContactUs.UseVisualStyleBackColor = true;
            this.btnMainContactUs.Click += new System.EventHandler(this.btnMainContactUs_Click);
            // 
            // btnMainLogin
            // 
            this.btnMainLogin.Location = new System.Drawing.Point(667, 34);
            this.btnMainLogin.Name = "btnMainLogin";
            this.btnMainLogin.Size = new System.Drawing.Size(75, 23);
            this.btnMainLogin.TabIndex = 18;
            this.btnMainLogin.Text = "Login";
            this.btnMainLogin.UseVisualStyleBackColor = true;
            this.btnMainLogin.Click += new System.EventHandler(this.btnMainLogin_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(978, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "Admin";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1593, 714);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnMainLogin);
            this.Controls.Add(this.btnMainContactUs);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnDonors);
            this.Controls.Add(this.btnAbout);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btnDonors;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Button btnMainContactUs;
        private System.Windows.Forms.Button btnMainLogin;
        private System.Windows.Forms.Button button1;
    }
}