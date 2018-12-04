using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Attempt2
{
    public partial class Sign_Up_For_Donor : Form
    {
        public Sign_Up_For_Donor()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*Sign_Up_Confirmation confirmation = new Attempt2.Sign_Up_Confirmation();
            confirmation.Show();*/
            if (textBoxConfirmPwdD.Text != textBoxPwdD.Text)
            {
                //MessageBox.Show("Passwords do not match!");
                MessageBox.Show("Passwords do not match!",
                            "Warning!",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning // for Warning  
                                                   //MessageBoxIcon.Error // for Error 
                                                   //MessageBoxIcon.Information  // for Information
                                                   //MessageBoxIcon.Question // for Question
                          );
            }

            if (textBoxContact.Text.Length != 7 || textBoxEmergencyContact.Text.Length !=7)
            {
                MessageBox.Show("Please enter a 7 digit phone number!",
                              "Warning!",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Warning // for Warning 
                              );
            }
            if (textBoxCNIC1.Text.Length != 5)
            {
                MessageBox.Show("Wrong Length Of The First Part Of CNIC!",
                          "Warning!",
                          MessageBoxButtons.OK,
                          MessageBoxIcon.Warning);
            }
            
            if (textBoxCNIC2.Text.Length != 7)
            {
                MessageBox.Show("Wrong Length Of The Second Part Of CNIC!",
                          "Warning!",
                          MessageBoxButtons.OK,
                          MessageBoxIcon.Warning);
            }
            if (textBoxCNIC3.Text.Length != 1)
            {
                MessageBox.Show("Wrong Length Of The Third Part Of CNIC!",
                          "Warning!",
                          MessageBoxButtons.OK,
                          MessageBoxIcon.Warning);
            }
            else
            {

                MessageBox.Show("Do You Wish To Proceed?",
                            "Confirm",
                            MessageBoxButtons.YesNo,
                           MessageBoxIcon.Question
                                                   // // for Question
                                                   );
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBoxContact_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBoxContact.Text, "[^0-9]"))
            {
                MessageBox.Show("Please Enter Numbers Only!",
                        "Warning!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                textBoxContact.Text = textBoxContact.Text.Remove(textBoxContact.Text.Length - 1);
            }
        }

        private void textBoxEmergencyContact_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBoxEmergencyContact.Text, "[^0-9]"))
            {
                MessageBox.Show("Please Enter Numbers Only!",
                        "Warning!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                textBoxEmergencyContact.Text = textBoxEmergencyContact.Text.Remove(textBoxEmergencyContact.Text.Length - 1);
            }
        }

        private void textBoxWeight_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBoxWeight.Text, "[^0-9]"))
            {
                MessageBox.Show("Please Enter Numbers Only!",
                        "Warning!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                textBoxWeight.Text = textBoxWeight.Text.Remove(textBoxWeight.Text.Length - 1);
            }
        }

        private void Sign_Up_For_Donor_Load(object sender, EventArgs e)
        {
            

            comboBoxProvince.Items.Add("Punjab");
            comboBoxProvince.Items.Add("Sindh");
            comboBoxProvince.Items.Add("Balochistan");
            comboBoxProvince.Items.Add("Gilgit Baltistan");
            comboBoxProvince.Items.Add("Khyber Pakhtunkhwa");

      
            comboBoxBloodType.Items.Add("O-");
            comboBoxBloodType.Items.Add("O+");
            comboBoxBloodType.Items.Add("A-");
            comboBoxBloodType.Items.Add("A+");
            comboBoxBloodType.Items.Add("B-");
            comboBoxBloodType.Items.Add("B+");
            comboBoxBloodType.Items.Add("AB-");
            comboBoxBloodType.Items.Add("AB+");


        }

        private void textBoxBloodType_TextChanged(object sender, EventArgs e)
        {
           
        }
    

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBoxCNIC3.Text, "[^0-9]"))
            {
                MessageBox.Show("Please Enter Numbers Only!",
                        "Warning!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                textBoxCNIC3.Text = textBoxCNIC3.Text.Remove(textBoxCNIC3.Text.Length - 1);
            }
            
        }

        private void textBoxCNIC1_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBoxCNIC1.Text, "[^0-9]"))
            {
                MessageBox.Show("Please Enter Numbers Only!",
                        "Warning!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                textBoxCNIC1.Text = textBoxCNIC1.Text.Remove(textBoxCNIC1.Text.Length - 1);
            }
        }

        private void textBoxCNIC2_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBoxCNIC2.Text, "[^0-9]"))
            {
                MessageBox.Show("Please Enter Numbers Only!",
                        "Warning!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                textBoxCNIC2.Text = textBoxCNIC2.Text.Remove(textBoxCNIC2.Text.Length - 1);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBoxPwdD.PasswordChar = '*';
        }

        private void textBoxConfirmPwdD_TextChanged(object sender, EventArgs e)
        {
            textBoxConfirmPwdD.PasswordChar = '*';
        }

        private void comboBoxProvince_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePickerDOB_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxBloodType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
