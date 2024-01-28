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
    public partial class StChangePassPanel : Form
    {
        private int SID { get; set; }
        public StChangePassPanel(int sID)
        {
            InitializeComponent();
            SID = sID;
        }

        private void CancelChangePassBut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OkChangePassBut_Click(object sender, EventArgs e)
        {
            if((ConfirmTxt.Text == NewPassTxt.Text)&&((ConfirmTxt.Text != "")||(NewPassTxt.Text != "")))
            {
                StChangePassMgr scpmgr = new StChangePassMgr();
                scpmgr.ChangePass(SID, NewPassTxt.Text);
                MessageBox.Show("Your password has been changed successfully!", "Password Changed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Your password doesn't match with confirmation check it agin!", "Wrong input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                
        }
    }
}
