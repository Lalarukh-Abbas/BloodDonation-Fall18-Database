using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Attempt2
{
    public partial class Login : Form
    {
        public Login()
        {
            this.BackgroundImage = Properties.Resources.screen2;
            SqlConnection con = new SqlConnection();
            //con.ConnectionString = "Data Source=.; Initial Catalog=BloodBank_final; Integrated Security=true;";
            con.ConnectionString = "Data Source=.; Initial Catalog=BloodBank_final; User ID = sa; Pwd=Habib123##";

          // con.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "try1 (use sql command)";
            cmd.CommandType = CommandType.Text;

            InitializeComponent();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //show screen when either the user has successfully logged in or has not
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Designation.Visible = false;
            comboBoxDesignation.Visible = false;

            comboBoxDesignation.Items.Add("Receptionist");
            comboBoxDesignation.Items.Add("Hospital Assistant");
            comboBoxDesignation.Items.Add("Head Of Branch");
        }

        private void button3_Click(object sender, EventArgs e) //btnSignUp
        {

            UserType userT = new Attempt2.UserType();
            userT.Show();
        }

        private void btnMainPg_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main main = new Attempt2.Main();
            main.Show();
        }

 

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void radioButtonEmployee_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonEmployee.Checked)
            {
                Designation.Visible = true;
                comboBoxDesignation.Visible = true;
            }
            else
            {
                Designation.Visible = false;
                comboBoxDesignation.Visible = false;
            }

        }
    }
}
