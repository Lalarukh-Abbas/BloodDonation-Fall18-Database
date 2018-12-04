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
/// <summary>
/// ////////////////////////////////////////LALALALALA
/// </summary>
namespace Attempt2
{
    public partial class Donors_List : Form
    {
        public Donors_List()
        {
            SqlConnection con = new SqlConnection();
            //con.ConnectionString = "Data Source=.; Initial Catalog=Northwind; Integrated Security=true;";
            con.ConnectionString = "Data Source=.; Initial Catalog=BloodBank_final; User ID = sa; Pwd=Habib123##;";

            con.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            
            cmd.CommandText = "Select DonorName from Donation where ";
            //cmd.CommandType = CommandType.Text;
            //SqlDataReader rd = cmd.ExecuteReader();

            /*while (rd.Read())
            {
                cboCustomerCode.Items.Add(rd["CustomerID"]);
            }
            rd.Close();*/
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Donors_List_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=.; Initial Catalog=BloodBank_final; User ID = sa; Pwd=Habib123##;";
            con.Open();
            //string userid = textBox1.Text;
            //string password = textBox2.Text;
            //*****************SUBJECTED TO CHANGE*********************//
            /*SqlCommand cmd = new SqlCommand("select ,password from login where userid='" + textBox1.Text + "'and password='" + text            Box2.Text + "'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Login sucess Welcome to Homepage http://krishnasinghprogramming.nlogspot.com");
                System.Diagnostics.Process.Start("http://krishnasinghprogramming.blogspot.com");
            }
            else
            {
                MessageBox.Show("Invalid Login please check username and password");
            }
            con.Close();*/
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
