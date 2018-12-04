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
    public partial class Sign_Up_For_Hospital : Form
    {
        public Sign_Up_For_Hospital()
        {
            InitializeComponent();
        }

        private void textBoxPwdH_TextChanged(object sender, EventArgs e)
        {
            textBoxPwdH.PasswordChar = '*';
        }


        private void txtBoxHospitalName_TextChanged_1(object sender, EventArgs e)
        {
            txtBoxHospitalNameUsername.Text = txtBoxHospitalName.Text; //As the user inputs the name of the hospital the user name is gerated accordingly
        }

        private void txtBoxHospitalNameUsername_TextChanged(object sender, EventArgs e)
        {
            txtBoxHospitalNameUsername.ReadOnly = true;
        }

        private void buttonConfirmSignUpHospital_Click(object sender, EventArgs e)
        {
            
            /***********PASSWORD MATCHING CHECKED***********/
            if (textBoxConfirmPwdH.Text != textBoxPwdH.Text)
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

            if(textBoxPhone.Text.Length != 7 || textBoxContactPersonPhone.Text.Length != 7)
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

        private void textBoxConformPwdH_TextChanged(object sender, EventArgs e)
        {
            textBoxConfirmPwdH.PasswordChar = '*';
         
        }

        //

        //********HOSPITAL PHONE*****//
        private void textBoxPhone_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBoxPhone.Text, "[^0-9]"))
            {
                MessageBox.Show("Please Enter Numbers Only!",
                        "Warning!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                textBoxPhone.Text = textBoxPhone.Text.Remove(textBoxPhone.Text.Length - 1);
            }
        }
        //********HOSPITAL CONTACT PERSON PHONE*****//
        private void textBoxContactPersonPhone_TextChanged(object sender, EventArgs e)
        {
            //textBoxContactPersonPhone.Text.Length == 7;
            if (System.Text.RegularExpressions.Regex.IsMatch(textBoxContactPersonPhone.Text, "[^0-9]"))
            {
                MessageBox.Show("Please Enter Numbers Only!",
                        "Warning!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                textBoxContactPersonPhone.Text = textBoxContactPersonPhone.Text.Remove(textBoxContactPersonPhone.Text.Length - 1);
            }
        }

        private void Sign_Up_For_Hospital_Load(object sender, EventArgs e)
        {
            comboBoxProvince.Items.Add("Sindh");
            comboBoxProvince.Items.Add("Punjab");
            comboBoxProvince.Items.Add("Balochistan");
            comboBoxProvince.Items.Add("Gilgit Baltistan");
            comboBoxProvince.Items.Add("Khyber Pakhtunkhwa");

        }
        public void addItems(AutoCompleteStringCollection col)
        {
            
        }
        
           
        private void textBoxCNIC3_TextChanged(object sender, EventArgs e)
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

        private void textBoxCity_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxProvince_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxProvince_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        /*
* Autocomplete TextBox working with Database values C#
The following C# program connect to database and add Dataset values to AutoCompleteStringCollection and perform as an Autocomplete TextBox
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
namespace WindowsFormsApplication1
{
public partial class Form1 : Form
{
public Form1()
{
InitializeComponent();
}
private void Form1_Load(object sender, EventArgs e)
{
textBox1.AutoCompleteMode = AutoCompleteMode.Suggest;
textBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;
AutoCompleteStringCollection DataCollection = new AutoCompleteStringCollection();
getData(DataCollection);
textBox1.AutoCompleteCustomSource = DataCollection;
}
private void getData(AutoCompleteStringCollection dataCollection)
{
string connetionString = null;
SqlConnection connection ;
SqlCommand command ;
SqlDataAdapter adapter = new SqlDataAdapter();
DataSet ds = new DataSet();
connetionString = "Data Source=.;Initial Catalog=pubs;User ID=sa;password=zen412";
string sql = "SELECT DISTINCT [fname] FROM [employee]";
connection = new SqlConnection(connetionString);
try
{
connection.Open();
command = new SqlCommand(sql, connection);
adapter.SelectCommand = command;
adapter.Fill(ds);
adapter.Dispose();
command.Dispose();
connection.Close();
foreach (DataRow row in ds.Tables[0].Rows)
{
dataCollection.Add(row[0].ToString());
}
}
catch (Exception ex)
{
MessageBox.Show("Can not open connection ! ");
}
}
}
}*/

    }
}
