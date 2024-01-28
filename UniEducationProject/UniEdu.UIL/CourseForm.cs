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
    public partial class CourseForm : Form
    {
        public CourseForm()
        {
            InitializeComponent();
        }

        private void CourseForm_Load(object sender, EventArgs e)
        {
            CourseManager coursemanager = new CourseManager();
            Course course = coursemanager.LoadFirstCourse();
            if (course != null)
            {
                CouIDTxtBox.Text = course.CouID.ToString();
                CouTitleTxtBox.Text = course.CouTitle;
                GroupNumTxtBox.Text = course.GroupNumber;
                UnitNumTxtBox.Text = course.UnitNumber.ToString();
                CouRequirementTxtBox.Text = course.Requirement;
            }
        }

        private void LoadFirstCouBut_Click(object sender, EventArgs e)
        {
            CourseManager coursemanager = new CourseManager();
            Course course = coursemanager.LoadFirstCourse();
            if (course != null)
            {
                CouIDTxtBox.Text = course.CouID.ToString();
                CouTitleTxtBox.Text = course.CouTitle;
                GroupNumTxtBox.Text = course.GroupNumber;
                UnitNumTxtBox.Text = course.UnitNumber.ToString();
                CouRequirementTxtBox.Text = course.Requirement;
            }
        }


        private void NextCouBut_Click(object sender, EventArgs e)
        {
            int CurrentCourseID = 0;
            int.TryParse(CouIDTxtBox.Text, out CurrentCourseID);

            if (CurrentCourseID != 0)
            {
                CourseManager courseManager = new CourseManager();
                Course course = courseManager.LoadNextCourse(CurrentCourseID);
                if (course != null)
                {
                    CouIDTxtBox.Text = course.CouID.ToString();
                    CouTitleTxtBox.Text = course.CouTitle;
                    GroupNumTxtBox.Text = course.GroupNumber;
                    UnitNumTxtBox.Text = course.UnitNumber.ToString();
                    CouRequirementTxtBox.Text = course.Requirement;
                }
            }
        }
        private void PreviousCouBut_Click(object sender, EventArgs e)
        {
            int CurrentCourseID = 0;
            int.TryParse(CouIDTxtBox.Text, out CurrentCourseID);

            if (CurrentCourseID != 0)
            {
                CourseManager courseManager = new CourseManager();
                Course course = courseManager.LoadPreviousCourse(CurrentCourseID);
                if (course != null)
                {
                    CouIDTxtBox.Text = course.CouID.ToString();
                    CouTitleTxtBox.Text = course.CouTitle;
                    GroupNumTxtBox.Text = course.GroupNumber;
                    UnitNumTxtBox.Text = course.UnitNumber.ToString();
                    CouRequirementTxtBox.Text = course.Requirement;
                }
            }
        }

        private void LastCouBut_Click(object sender, EventArgs e)
        {
            CourseManager courseManager = new CourseManager();
            Course course = courseManager.LoadLastCourse();
            if (course != null)
            {
                CouIDTxtBox.Text = course.CouID.ToString();
                CouTitleTxtBox.Text = course.CouTitle;
                GroupNumTxtBox.Text = course.GroupNumber;
                UnitNumTxtBox.Text = course.UnitNumber.ToString();
                CouRequirementTxtBox.Text = course.Requirement;
            }
        }

        private void CouSearchBut_Click(object sender, EventArgs e)
        {
            string Title = CouTitleSearchTxtBox.Text;
            string GroupNum = CouGNSearchTxtBox.Text;
            CourseManager courseManager = new CourseManager();
            Course course = courseManager.SearchCourse(Title,GroupNum);
            if (course != null)
            {
                CouIDTxtBox.Text = course.CouID.ToString();
                CouTitleTxtBox.Text = course.CouTitle;
                GroupNumTxtBox.Text = course.GroupNumber;
                UnitNumTxtBox.Text = course.UnitNumber.ToString();
                CouRequirementTxtBox.Text = course.Requirement;
            }

        }

        private void CouUpdateBut_Click(object sender, EventArgs e)
        {
            Course course = new Course();
            course.CouID = int.Parse(CouIDTxtBox.Text);
            course.CouTitle = CouTitleTxtBox.Text;
            course.GroupNumber = GroupNumTxtBox.Text;
            course.UnitNumber = int.Parse(UnitNumTxtBox.Text);
            course.Requirement = CouRequirementTxtBox.Text;

            CourseManager courseManager = new CourseManager();
            courseManager.UpdateCourse(course);
        }

        private void CouAddBut_Click(object sender, EventArgs e)
        {
            Course course = new Course();
            course.CouID = int.Parse(CouIDTxtBox.Text);
            course.CouTitle = CouTitleTxtBox.Text;
            course.GroupNumber = GroupNumTxtBox.Text;
            course.UnitNumber = int.Parse(UnitNumTxtBox.Text);
            course.Requirement = CouRequirementTxtBox.Text;

            CourseManager courseManager = new CourseManager();
            courseManager.AddCourse(course);
        }

        private void CouDeleteBut_Click(object sender, EventArgs e)
        {
            int CurrentCourseID = 0;
            int.TryParse(CouIDTxtBox.Text, out CurrentCourseID);

            if (CurrentCourseID != 0)
            {
                CourseManager courseManager = new CourseManager();
                courseManager.DeleteCourse(CurrentCourseID);
            }

        }
       
    }
}
