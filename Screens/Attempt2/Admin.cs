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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void btnScreeningAlert_Click(object sender, EventArgs e)
        {
            /*DataTable dataTable = new DataTable();
            DataColumn[] columns = { new DataColumn("ID"), new DataColumn("Value") };
            Object[] row1 = { "1", "Value1" };
            Object[] row2 = { "2", "Value2" };
            Object[] row3 = { "3", "Value3" };
            dataTable.Columns.AddRange(columns);
            dataTable.Rows.Add(row1);
            dataTable.Rows.Add(row2);
            dataTable.Rows.Add(row3);

            //Set the data source
            dataGridView.DataSource = dataTable;*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonViewAffiliatedHospitalList_Click(object sender, EventArgs e)
        {

        }

        private void buttonDonationStatus_Click(object sender, EventArgs e)
        {
            //DonationStatus
        }

        private void buttonViewRequest_Click(object sender, EventArgs e)
        {

        }
    }
}
