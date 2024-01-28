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
    public partial class StudentPanel : Form
    {
        private Student student { set; get; }
        public StudentPanel(Student studentParameter)
        {
            InitializeComponent();
            student = studentParameter;
        }

        private void StudentPanel_Load(object sender, EventArgs e)
        {
            StudentPanelLbl.Text = "Hello " + student.SFName.ToString() + " " + student.SLName.ToString()+" !";
            SemcomboBox.SelectedIndex = 0;
            StPanelMgr stPanelMgr = new StPanelMgr();
            DataTable dt = stPanelMgr.LoadYears();
            YearcomboBox.DataSource = dt;
            YearcomboBox.DisplayMember = "Year";
            YearcomboBox.ValueMember = "Year";
            //StudentPanelLbl.Text = SemcomboBox.SelectedItem.ToString();
        }

        private void StShowCourseBut_Click(object sender, EventArgs e)
        {
            StPanelMgr stPanelMgr = new StPanelMgr();
            DataTable dt = stPanelMgr.LoadCourses(student.SID, YearcomboBox.SelectedValue.ToString(), SemcomboBox.SelectedItem.ToString());
            CoursedataGridView.DataSource = dt;
            //this.CoursedataGridView[1, 0].Value.ToString();
            ////CoursedataGridView.CurrentCell.RowIndex.ToString()
            //CoursedataGridView.Rows.GetRowCount(DataGridViewElementStates.Selected).ToString();
            //MessageBox.Show(this.CoursedataGridView[1, CoursedataGridView.CurrentCell.RowIndex].Value.ToString());
        }

        private void ShowClassMateBut_Click(object sender, EventArgs e)
        {
            //this.CoursedataGridView[0, CoursedataGridView.CurrentCell.RowIndex].Value;
            StPanelMgr stPanelMgr = new StPanelMgr();
            if (CoursedataGridView.Rows.GetRowCount(DataGridViewElementStates.Selected) > 0)
            {
                DataTable dt = stPanelMgr.LoadClassMates(int.Parse(this.CoursedataGridView[0, CoursedataGridView.CurrentCell.RowIndex].Value.ToString()), YearcomboBox.SelectedValue.ToString(), SemcomboBox.SelectedItem.ToString());
                CoursedataGridView.DataSource = dt;
            }            
            
        }

        private void StChangePassBut_Click(object sender, EventArgs e)
        {
            StChangePassPanel scpp = new StChangePassPanel(student.SID);                       
            scpp.ShowDialog();            
        }
    }
}
