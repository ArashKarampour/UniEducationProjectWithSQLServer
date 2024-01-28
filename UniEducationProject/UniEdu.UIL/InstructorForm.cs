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
    public partial class InstructorForm : Form
    {
        public InstructorForm()
        {
            InitializeComponent();
        }

        private void InstructorForm_Load(object sender, EventArgs e)
        {
            
            InstructorManager instructormanager = new InstructorManager();
            Instructor instructor = instructormanager.LoadFirstInstructor();
            if (instructor != null)
            {
                InstIDTxtBox.Text = instructor.InstID.ToString();
                InstFNameTxtBox.Text = instructor.InstFName;
                InstLNameTxtBox.Text = instructor.InstLName;
                InstPhoneTxtBox.Text = instructor.InstPhone;
                InstEmailTxtBox.Text = instructor.InstEmail;
                InstNumTxtBox.Text = instructor.InstNumber;
                InstNationalCodeTxtBox.Text = instructor.InstNationalCode;
                InstGenderTxtBox.Text = instructor.InstGender;
                DegreeTxtBox.Text = instructor.Degree;
            }
        }

        private void LoadFirstInstBut_Click(object sender, EventArgs e)
        {
            InstructorManager instructormanager = new InstructorManager();
            Instructor instructor = instructormanager.LoadFirstInstructor();
            if (instructor != null)
            {
                InstIDTxtBox.Text = instructor.InstID.ToString();
                InstFNameTxtBox.Text = instructor.InstFName;
                InstLNameTxtBox.Text = instructor.InstLName;
                InstPhoneTxtBox.Text = instructor.InstPhone;
                InstEmailTxtBox.Text = instructor.InstEmail;
                InstNumTxtBox.Text = instructor.InstNumber;
                InstNationalCodeTxtBox.Text = instructor.InstNationalCode;
                InstGenderTxtBox.Text = instructor.InstGender;
                DegreeTxtBox.Text = instructor.Degree;
            }
        }

        private void NextInstBut_Click(object sender, EventArgs e)
        {
            int CurrentInstID = 0;
            int.TryParse(InstIDTxtBox.Text, out CurrentInstID);

            if (CurrentInstID != 0)
            {
                InstructorManager instructormanager = new InstructorManager();
                Instructor instructor = instructormanager.LoadNextInstructor(CurrentInstID);

                if (instructor != null)
                {
                    InstIDTxtBox.Text = instructor.InstID.ToString();
                    InstFNameTxtBox.Text = instructor.InstFName;
                    InstLNameTxtBox.Text = instructor.InstLName;
                    InstPhoneTxtBox.Text = instructor.InstPhone;
                    InstEmailTxtBox.Text = instructor.InstEmail;
                    InstNumTxtBox.Text = instructor.InstNumber;
                    InstNationalCodeTxtBox.Text = instructor.InstNationalCode;
                    InstGenderTxtBox.Text = instructor.InstGender;
                    DegreeTxtBox.Text = instructor.Degree;
                }
            }
        }

        private void PreviousInstBut_Click(object sender, EventArgs e)
        {
            int CurrentInstID = 0;
            int.TryParse(InstIDTxtBox.Text, out CurrentInstID);

            if (CurrentInstID != 0)
            {
                InstructorManager instructormanager = new InstructorManager();
                Instructor instructor = instructormanager.LoadPreviousInstructor(CurrentInstID);

                if (instructor != null)
                {
                    InstIDTxtBox.Text = instructor.InstID.ToString();
                    InstFNameTxtBox.Text = instructor.InstFName;
                    InstLNameTxtBox.Text = instructor.InstLName;
                    InstPhoneTxtBox.Text = instructor.InstPhone;
                    InstEmailTxtBox.Text = instructor.InstEmail;
                    InstNumTxtBox.Text = instructor.InstNumber;
                    InstNationalCodeTxtBox.Text = instructor.InstNationalCode;
                    InstGenderTxtBox.Text = instructor.InstGender;
                    DegreeTxtBox.Text = instructor.Degree;
                }
            }
        }

        private void LastInstBut_Click(object sender, EventArgs e)
        {
            InstructorManager instructormanager = new InstructorManager();
            Instructor instructor = instructormanager.LoadLastInstructor();

            if (instructor != null)
            {
                InstIDTxtBox.Text = instructor.InstID.ToString();
                InstFNameTxtBox.Text = instructor.InstFName;
                InstLNameTxtBox.Text = instructor.InstLName;
                InstPhoneTxtBox.Text = instructor.InstPhone;
                InstEmailTxtBox.Text = instructor.InstEmail;
                InstNumTxtBox.Text = instructor.InstNumber;
                InstNationalCodeTxtBox.Text = instructor.InstNationalCode;
                InstGenderTxtBox.Text = instructor.InstGender;
                DegreeTxtBox.Text = instructor.Degree;
            }
        }

        private void InstSearchBut_Click(object sender, EventArgs e)
        {
            string find = InstSearchTxtBox.Text;

            InstructorManager instructormanager = new InstructorManager();
            Instructor instructor = instructormanager.SearchInstructor(find);

            if (instructor != null)
            {
                InstIDTxtBox.Text = instructor.InstID.ToString();
                InstFNameTxtBox.Text = instructor.InstFName;
                InstLNameTxtBox.Text = instructor.InstLName;
                InstPhoneTxtBox.Text = instructor.InstPhone;
                InstEmailTxtBox.Text = instructor.InstEmail;
                InstNumTxtBox.Text = instructor.InstNumber;
                InstNationalCodeTxtBox.Text = instructor.InstNationalCode;
                InstGenderTxtBox.Text = instructor.InstGender;
                DegreeTxtBox.Text = instructor.Degree;
            }

        }

        private void InstUpdateBut_Click(object sender, EventArgs e)
        {
            Instructor instructor = new Instructor();
            instructor.InstID = int.Parse(InstIDTxtBox.Text);
            instructor.InstFName = InstFNameTxtBox.Text;
            instructor.InstLName = InstLNameTxtBox.Text;
            instructor.InstPhone = InstPhoneTxtBox.Text;
            instructor.InstEmail = InstEmailTxtBox.Text;
            instructor.InstNumber = InstNumTxtBox.Text;
            instructor.InstGender = InstGenderTxtBox.Text;
            instructor.Degree = DegreeTxtBox.Text;
            instructor.InstNationalCode = InstNationalCodeTxtBox.Text;

            InstructorManager instructorManager = new InstructorManager();
            instructorManager.UpdateInstructor(instructor);
        }

        private void InstAddBut_Click(object sender, EventArgs e)
        {
            Instructor instructor = new Instructor();
            instructor.InstID = int.Parse(InstIDTxtBox.Text);
            instructor.InstFName = InstFNameTxtBox.Text;
            instructor.InstLName = InstLNameTxtBox.Text;
            instructor.InstPhone = InstPhoneTxtBox.Text;
            instructor.InstEmail = InstEmailTxtBox.Text;
            instructor.InstNumber = InstNumTxtBox.Text;
            instructor.InstGender = InstGenderTxtBox.Text;
            instructor.Degree = DegreeTxtBox.Text;
            instructor.InstNationalCode = InstNationalCodeTxtBox.Text;

            InstructorManager instructorManager = new InstructorManager();
            instructorManager.AddInstructor(instructor);
        }

        private void InstDeleteBut_Click(object sender, EventArgs e)
        {
            int CurrentInstID = 0;
            int.TryParse(InstIDTxtBox.Text, out CurrentInstID);

            if (CurrentInstID != 0)
            {
                InstructorManager instructormanager = new InstructorManager();
                instructormanager.DeleteInstructor(CurrentInstID);
            }
        }
    }
}
