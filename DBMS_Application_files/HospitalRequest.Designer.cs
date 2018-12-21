namespace Attempt2
{
    partial class HospitalRequest
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
            this.btnOKRequest = new System.Windows.Forms.Button();
            this.btnCancelRequest = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxBloodGrpRequest = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxRequestQuantity = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePickerBloodRequest = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // btnOKRequest
            // 
            this.btnOKRequest.Location = new System.Drawing.Point(171, 174);
            this.btnOKRequest.Name = "btnOKRequest";
            this.btnOKRequest.Size = new System.Drawing.Size(75, 23);
            this.btnOKRequest.TabIndex = 3;
            this.btnOKRequest.Text = "OK";
            this.btnOKRequest.UseVisualStyleBackColor = true;
            // 
            // btnCancelRequest
            // 
            this.btnCancelRequest.Location = new System.Drawing.Point(252, 174);
            this.btnCancelRequest.Name = "btnCancelRequest";
            this.btnCancelRequest.Size = new System.Drawing.Size(75, 23);
            this.btnCancelRequest.TabIndex = 7;
            this.btnCancelRequest.Text = "Cancel";
            this.btnCancelRequest.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Blood Group";
            // 
            // textBoxBloodGrpRequest
            // 
            this.textBoxBloodGrpRequest.Location = new System.Drawing.Point(127, 43);
            this.textBoxBloodGrpRequest.Name = "textBoxBloodGrpRequest";
            this.textBoxBloodGrpRequest.Size = new System.Drawing.Size(200, 20);
            this.textBoxBloodGrpRequest.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Provide By";
            // 
            // textBoxRequestQuantity
            // 
            this.textBoxRequestQuantity.Location = new System.Drawing.Point(127, 78);
            this.textBoxRequestQuantity.Name = "textBoxRequestQuantity";
            this.textBoxRequestQuantity.Size = new System.Drawing.Size(200, 20);
            this.textBoxRequestQuantity.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Quantity";
            // 
            // dateTimePickerBloodRequest
            // 
            this.dateTimePickerBloodRequest.Location = new System.Drawing.Point(127, 122);
            this.dateTimePickerBloodRequest.Name = "dateTimePickerBloodRequest";
            this.dateTimePickerBloodRequest.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerBloodRequest.TabIndex = 16;
            // 
            // HospitalRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 240);
            this.Controls.Add(this.dateTimePickerBloodRequest);
            this.Controls.Add(this.textBoxRequestQuantity);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxBloodGrpRequest);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancelRequest);
            this.Controls.Add(this.btnOKRequest);
            this.Name = "HospitalRequest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HospitalRequest";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOKRequest;
        private System.Windows.Forms.Button btnCancelRequest;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxBloodGrpRequest;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxRequestQuantity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePickerBloodRequest;
    }
}