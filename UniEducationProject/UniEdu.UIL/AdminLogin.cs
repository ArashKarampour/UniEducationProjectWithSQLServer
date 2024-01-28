using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UniEdu.BLL;

namespace UniEdu.UIL
{
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void CancelBut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AdLoginBut_Click(object sender, EventArgs e)
        {
            AdminLoginManager adminLoginManager = new AdminLoginManager();
            int count = adminLoginManager.verifyAdmin(AdUserNameTxt.Text, AdPassTxt.Text);

            if(count != 0)
            {
                AdminMenu adminMenu = new AdminMenu();
                this.Hide();
                adminMenu.ShowDialog();
                this.Close();

            }
            else
            {
                MessageBox.Show("Your user name or password is incorrect", "Wrong input",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
