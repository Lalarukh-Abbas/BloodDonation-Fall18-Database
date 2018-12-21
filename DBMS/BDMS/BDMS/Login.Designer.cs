namespace BDMS
{
    partial class Login
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
            this.UserNAmetextBox = new System.Windows.Forms.TextBox();
            this.PwdtextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lgnBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UserNAmetextBox
            // 
            this.UserNAmetextBox.Location = new System.Drawing.Point(350, 90);
            this.UserNAmetextBox.Name = "UserNAmetextBox";
            this.UserNAmetextBox.Size = new System.Drawing.Size(354, 26);
            this.UserNAmetextBox.TabIndex = 0;
            // 
            // PwdtextBox
            // 
            this.PwdtextBox.Location = new System.Drawing.Point(350, 212);
            this.PwdtextBox.Name = "PwdtextBox";
            this.PwdtextBox.PasswordChar = '*';
            this.PwdtextBox.Size = new System.Drawing.Size(354, 26);
            this.PwdtextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(141, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "UserName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(141, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // lgnBtn
            // 
            this.lgnBtn.Location = new System.Drawing.Point(566, 336);
            this.lgnBtn.Name = "lgnBtn";
            this.lgnBtn.Size = new System.Drawing.Size(111, 33);
            this.lgnBtn.TabIndex = 4;
            this.lgnBtn.Text = "Login";
            this.lgnBtn.UseVisualStyleBackColor = true;
            this.lgnBtn.Click += new System.EventHandler(this.lgnBtn_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lgnBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PwdtextBox);
            this.Controls.Add(this.UserNAmetextBox);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UserNAmetextBox;
        private System.Windows.Forms.TextBox PwdtextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button lgnBtn;
    }
}