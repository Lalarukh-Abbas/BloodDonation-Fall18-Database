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
    public partial class Requests : Form
    {
        public Requests()
        {
            InitializeComponent();
        }
        public string conString = "Data Source=LAPTOP-6PRF2F3F;Initial Catalog=BBDatabase2;Integrated Security=True";
        private void Requests_Load(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(conString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDA = new SqlDataAdapter("Exec RequestDelivery", sqlCon);
                DataTable dtbl = new DataTable();
                sqlDA.Fill(dtbl);
                dataGridView1.DataSource = dtbl;

            }

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void freqBtn_Click(object sender, EventArgs e)
        {
            //if dateTimePicker1.Value
        }
    }
}
