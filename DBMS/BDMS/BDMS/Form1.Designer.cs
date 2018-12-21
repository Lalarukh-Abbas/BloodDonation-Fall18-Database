namespace BDMS
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Donationsbtn = new System.Windows.Forms.Button();
            this.Hospitalbtn = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.lgnBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Donationsbtn
            // 
            this.Donationsbtn.Location = new System.Drawing.Point(62, 12);
            this.Donationsbtn.Name = "Donationsbtn";
            this.Donationsbtn.Size = new System.Drawing.Size(94, 50);
            this.Donationsbtn.TabIndex = 0;
            this.Donationsbtn.Text = "Donations";
            this.Donationsbtn.UseVisualStyleBackColor = true;
            this.Donationsbtn.Click += new System.EventHandler(this.Donations_Click);
            // 
            // Hospitalbtn
            // 
            this.Hospitalbtn.Location = new System.Drawing.Point(178, 12);
            this.Hospitalbtn.Name = "Hospitalbtn";
            this.Hospitalbtn.Size = new System.Drawing.Size(98, 50);
            this.Hospitalbtn.TabIndex = 1;
            this.Hospitalbtn.Text = "Hospital";
            this.Hospitalbtn.UseVisualStyleBackColor = true;
            this.Hospitalbtn.Click += new System.EventHandler(this.Hospitalbtn_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(294, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(110, 50);
            this.button3.TabIndex = 2;
            this.button3.Text = "Requests";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // lgnBtn
            // 
            this.lgnBtn.Location = new System.Drawing.Point(428, 12);
            this.lgnBtn.Name = "lgnBtn";
            this.lgnBtn.Size = new System.Drawing.Size(110, 50);
            this.lgnBtn.TabIndex = 3;
            this.lgnBtn.Text = "Login";
            this.lgnBtn.UseVisualStyleBackColor = true;
            this.lgnBtn.Click += new System.EventHandler(this.lgnBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1387, 450);
            this.Controls.Add(this.lgnBtn);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Hospitalbtn);
            this.Controls.Add(this.Donationsbtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Donationsbtn;
        private System.Windows.Forms.Button Hospitalbtn;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button lgnBtn;
    }
}

