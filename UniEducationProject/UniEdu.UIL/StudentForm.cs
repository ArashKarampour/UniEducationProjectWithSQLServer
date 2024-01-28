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
    public partial class StudentForm : Form
    {
        public StudentForm()
        {
            InitializeComponent();
        }

        private void StudentForm_Load(object sender, EventArgs e)
        {
            StudentManager studentmanager = new StudentManager();
            Student student = studentmanager.LoadFirstStudent();
            if (student != null)
            {
                SIDTxtBox.Text = student.SID.ToString();
                SFNameTxtBox.Text = student.SFName;
                SLNameTxtBox.Text = student.SLName;
                SPhoneTxtBox.Text = student.SPhone;
                SEmailTxtBox.Text = student.SEmail;
                StNumTxtBox.Text = student.StNumber;
                SNationalCodeTxtBox.Text = student.SNationalCode;
                SGenderTxtBox.Text = student.SGender;
                SAverageTxtBox.Text = student.SAverage.ToString();
                SMajor.Text = student.SMajor;
            }

        }

        private void LoadFirstBut_Click(object sender, EventArgs e)
        {
            StudentManager studentmanager = new StudentManager();
            Student student = studentmanager.LoadFirstStudent();
            if (student != null)
            {
                SIDTxtBox.Text = student.SID.ToString();
                SFNameTxtBox.Text = student.SFName;
                SLNameTxtBox.Text = student.SLName;
                SPhoneTxtBox.Text = student.SPhone;
                SEmailTxtBox.Text = student.SEmail;
                StNumTxtBox.Text = student.StNumber;
                SNationalCodeTxtBox.Text = student.SNationalCode;
                SGenderTxtBox.Text = student.SGender;
                SAverageTxtBox.Text = student.SAverage.ToString();
                SMajor.Text = student.SMajor;
            }
        }

        private void NextStudentBut_Click(object sender, EventArgs e)
        {
            int CurrentStudentID = 0;
            int.TryParse(SIDTxtBox.Text, out CurrentStudentID);

            if(CurrentStudentID != 0)
            {
                StudentManager studentManager = new StudentManager();
                Student student = studentManager.LoadNextStudent(CurrentStudentID);
                if(student != null)
                {
                    SIDTxtBox.Text = student.SID.ToString();
                    SFNameTxtBox.Text = student.SFName;
                    SLNameTxtBox.Text = student.SLName;
                    SPhoneTxtBox.Text = student.SPhone;
                    SEmailTxtBox.Text = student.SEmail;
                    StNumTxtBox.Text = student.StNumber;
                    SNationalCodeTxtBox.Text = student.SNationalCode;
                    SGenderTxtBox.Text = student.SGender;
                    SAverageTxtBox.Text = student.SAverage.ToString();
                    SMajor.Text = student.SMajor;
                }
            }
        }

        private void PreviousBut_Click(object sender, EventArgs e)
        {
            int CurrentStudentID = 0;
            int.TryParse(SIDTxtBox.Text, out CurrentStudentID);

            if(CurrentStudentID != 0)
            {
                StudentManager studentManager = new StudentManager();
                Student student = studentManager.LoadPreviousStudent(CurrentStudentID);

                if(student != null)
                {
                    SIDTxtBox.Text = student.SID.ToString();
                    SFNameTxtBox.Text = student.SFName;
                    SLNameTxtBox.Text = student.SLName;
                    SPhoneTxtBox.Text = student.SPhone;
                    SEmailTxtBox.Text = student.SEmail;
                    StNumTxtBox.Text = student.StNumber;
                    SNationalCodeTxtBox.Text = student.SNationalCode;
                    SGenderTxtBox.Text = student.SGender;
                    SAverageTxtBox.Text = student.SAverage.ToString();
                    SMajor.Text = student.SMajor;
                }
            }
            
        }

        private void LastStudentBut_Click(object sender, EventArgs e)
        {
            StudentManager studentManager = new StudentManager();
            Student student = studentManager.LoadLastStudent();

            if (student != null)
            {
                SIDTxtBox.Text = student.SID.ToString();
                SFNameTxtBox.Text = student.SFName;
                SLNameTxtBox.Text = student.SLName;
                SPhoneTxtBox.Text = student.SPhone;
                SEmailTxtBox.Text = student.SEmail;
                StNumTxtBox.Text = student.StNumber;
                SNationalCodeTxtBox.Text = student.SNationalCode;
                SGenderTxtBox.Text = student.SGender;
                SAverageTxtBox.Text = student.SAverage.ToString();
                SMajor.Text = student.SMajor;
            }
        }

        private void SearchBut_Click(object sender, EventArgs e)
        {

            string find = SearchTxtBox.Text;
            
            StudentManager studentManager = new StudentManager();
            Student student = studentManager.SearchStudent(find);

            if (student != null)
            {
                SIDTxtBox.Text = student.SID.ToString();
                SFNameTxtBox.Text = student.SFName;
                SLNameTxtBox.Text = student.SLName;
                SPhoneTxtBox.Text = student.SPhone;
                SEmailTxtBox.Text = student.SEmail;
                StNumTxtBox.Text = student.StNumber;
                SNationalCodeTxtBox.Text = student.SNationalCode;
                SGenderTxtBox.Text = student.SGender;
                SAverageTxtBox.Text = student.SAverage.ToString();
                SMajor.Text = student.SMajor;
            }
            

        }

        private void UpdateBut_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            student.SID = int.Parse(SIDTxtBox.Text);
            student.SFName = SFNameTxtBox.Text;
            student.SLName = SLNameTxtBox.Text;
            student.SPhone = SPhoneTxtBox.Text;
            student.SEmail = SEmailTxtBox.Text;
            student.StNumber = StNumTxtBox.Text;
            student.SGender = SGenderTxtBox.Text;
            student.SAverage = Double.Parse(SAverageTxtBox.Text);
            student.SNationalCode = SNationalCodeTxtBox.Text;
            student.SMajor = SMajor.Text;

            StudentManager studentManager = new StudentManager();
            studentManager.UpdateStudent(student);
        }

        private void AddBut_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            student.SID = int.Parse(SIDTxtBox.Text);
            student.SFName = SFNameTxtBox.Text;
            student.SLName = SLNameTxtBox.Text;
            student.SPhone = SPhoneTxtBox.Text;
            student.SEmail = SEmailTxtBox.Text;
            student.StNumber = StNumTxtBox.Text;
            student.SGender = SGenderTxtBox.Text;
            student.SAverage = Double.Parse(SAverageTxtBox.Text);
            student.SNationalCode = SNationalCodeTxtBox.Text;
            student.SMajor = SMajor.Text;

            StudentManager studentManager = new StudentManager();
            studentManager.AddStudent(student);
        }

        private void DeleteBut_Click(object sender, EventArgs e)
        {
            int CurrentStudentID = 0;
            int.TryParse(SIDTxtBox.Text, out CurrentStudentID);

            if (CurrentStudentID != 0)
            {
                StudentManager studentManager = new StudentManager();
                studentManager.DeleteStudent(CurrentStudentID);

            }
        }
    }
}
