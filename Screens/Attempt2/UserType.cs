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
    public partial class UserType : Form
    {
        public UserType()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnDonor_Click(object sender, EventArgs e)
        {
            this.Hide();
            Sign_Up_For_Donor signUp4Donor = new Attempt2.Sign_Up_For_Donor();
            signUp4Donor.Show();
        }

        private void btnHospital_Click(object sender, EventArgs e)
        {
            this.Hide();
            Sign_Up_For_Hospital signUp4Hospital = new Attempt2.Sign_Up_For_Hospital();
            signUp4Hospital.Show();
        }
    }
}
