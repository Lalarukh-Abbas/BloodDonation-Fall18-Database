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
namespace BDMS
{
    public partial class DonatedBlood : Form
    {
        public DonatedBlood()
        {
            InitializeComponent();
            //comboBox1.Items.Add("O-");
            //comboBox1.Items.Add("O+");
            //comboBox1.Items.Add("A-");
            //comboBox1.Items.Add("A+");
            //comboBox1.Items.Add("B-");
            //comboBox1.Items.Add("B+");
            //comboBox1.Items.Add("AB-");
            //comboBox1.Items.Add("AB+");
        }
        public string conString = "Data Source=LAPTOP-6PRF2F3F;Initial Catalog=BBDatabase2;Integrated Security=True";
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void DonatedBlood_Load(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(conString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDA = new SqlDataAdapter("select * from DonatedBlood", sqlCon);
                DataTable dtbl = new DataTable();
                sqlDA.Fill(dtbl);
                dataGridView1.DataSource = dtbl;

            }
        }
    }
}
