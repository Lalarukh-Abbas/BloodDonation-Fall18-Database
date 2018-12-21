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
    public partial class ScreeningResult : Form
    {
        public ScreeningResult()
        {
            InitializeComponent();
        }
        public string conString = "Data Source=LAPTOP-6PRF2F3F;Initial Catalog=BBDatabase2;Integrated Security=True";
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void ScreeningResult_Load(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(conString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDA = new SqlDataAdapter("select * from [Unsuccessful Results]", sqlCon);
                DataTable dtbl = new DataTable();
                sqlDA.Fill(dtbl);
                dataGridView1.DataSource = dtbl;

                SqlDataAdapter sqlDA2 = new SqlDataAdapter("select * from [successful Results]", sqlCon);
                DataTable dtbl2 = new DataTable();
                sqlDA.Fill(dtbl2);
                dataGridView2.DataSource = dtbl2;

            }
            
        }
    }
}
