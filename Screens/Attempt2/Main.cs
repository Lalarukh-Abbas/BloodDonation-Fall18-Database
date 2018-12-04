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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btnMainLogin_Click(object sender, EventArgs e)
        {
            Login login = new Attempt2.Login();
            login.Show();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            About abt = new Attempt2.About();
            abt.Show();
    }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            Help help = new Attempt2.Help();
            help.Show();
        }

        private void btnDonors_Click(object sender, EventArgs e)
        {
            Donors_List donorsList = new Attempt2.Donors_List();
            donorsList.Show();
        }

        private void btnMainContactUs_Click(object sender, EventArgs e)
        {
            Contact_Us contactUs = new Attempt2.Contact_Us();
            contactUs.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Admin admin = new Attempt2.Admin();
            admin.Show();
        }
    }
}
