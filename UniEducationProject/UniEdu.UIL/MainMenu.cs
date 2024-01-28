using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniEdu.UIL
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void AdLoginBut_Click(object sender, EventArgs e)
        {
            AdminLogin adminLogin = new AdminLogin();            
            adminLogin.ShowDialog();
        }

        private void StLoginBut_Click(object sender, EventArgs e)
        {
            StudentLogin studentLogin = new StudentLogin();
            studentLogin.ShowDialog();
        }
    }
}
