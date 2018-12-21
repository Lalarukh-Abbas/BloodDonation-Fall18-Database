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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Donations_Click(object sender, EventArgs e)
        {
            this.Hide();
            Donations dtn = new BDMS.Donations();

            dtn.Show();
        }

        private void Hospitalbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Hospitals hptl = new BDMS.Hospitals();

            hptl.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Requests rqsts = new BDMS.Requests();

            rqsts.Show();
        }

        private void lgnBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login lgn = new BDMS.Login();

            lgn.Show();
        }
    }
}
