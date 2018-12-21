namespace BDMS
{
    partial class Donations
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
            this.dataGridViewDons = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDons)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewDons
            // 
            this.dataGridViewDons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDons.Location = new System.Drawing.Point(158, 98);
            this.dataGridViewDons.Name = "dataGridViewDons";
            this.dataGridViewDons.RowTemplate.Height = 28;
            this.dataGridViewDons.Size = new System.Drawing.Size(524, 281);
            this.dataGridViewDons.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(345, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 39);
            this.button1.TabIndex = 1;
            this.button1.Text = "Show Donations";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Donations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridViewDons);
            this.Name = "Donations";
            this.Text = "Donations";
            this.Load += new System.EventHandler(this.Donations_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDons)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewDons;
        private System.Windows.Forms.Button button1;
    }
}