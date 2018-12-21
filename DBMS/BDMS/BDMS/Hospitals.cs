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
    public partial class Hospitals : Form
    {
        public Hospitals()
        {
            InitializeComponent();
        }
        public string conString = "Data Source=LAPTOP-6PRF2F3F;Initial Catalog=BBDatabase2;Integrated Security=True";
        private void Hospitals_Load(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(conString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDA = new SqlDataAdapter("Exec Hospitals", sqlCon);
                DataTable dtbl = new DataTable();
                sqlDA.Fill(dtbl);
                dataGridView1.DataSource = dtbl;

            }
        }
    }
}
