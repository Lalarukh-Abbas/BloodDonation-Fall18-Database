using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BDMS
{
    public partial class AdminControl : Form
    {
        public AdminControl()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void AdminControl_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            DonorDetails admn = new BDMS.DonorDetails();

            admn.Show();
        }

        private void ScreeningRslt_Click(object sender, EventArgs e)
        {
            this.Hide();
            ScreeningResult admn = new BDMS.ScreeningResult();

            admn.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            DonatedBlood admn = new BDMS.DonatedBlood();

            admn.Show();
        }
    }
}
