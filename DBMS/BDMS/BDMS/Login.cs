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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void lgnBtn_Click(object sender, EventArgs e)
        {
            if(UserNAmetextBox.Text == "sa" && PwdtextBox.Text == "pwd123")
            {
                this.Hide();
                AdminControl admn = new BDMS.AdminControl();

                admn.Show();
            }
            //else
            //{
                
            //}
        }
    }
}
