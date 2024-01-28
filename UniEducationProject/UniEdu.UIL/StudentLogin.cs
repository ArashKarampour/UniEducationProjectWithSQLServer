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
using UniEdu.Entities;

namespace UniEdu.UIL
{
    public partial class StudentLogin : Form
    {
        public StudentLogin()
        {
            InitializeComponent();
        }

        private void StCancelBut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void StLoginBut_Click(object sender, EventArgs e)
        {
            StudentLoginManager studentLoginManager = new StudentLoginManager();
            Student student = studentLoginManager.verifyStudent(StUserNameTxt.Text, StPassTxt.Text);

            if(student != null)
            {
                StudentPanel studentPanel = new StudentPanel(student);
                this.Hide();
                studentPanel.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Your user name or password is incorrect", "Wrong input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
