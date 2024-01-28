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
    public partial class InstructForm : Form
    {
        public InstructForm()
        {
            InitializeComponent();
        }
        private void InstructForm_Load(object sender, EventArgs e)
        {
            InstructManager instructManager = new InstructManager();
            Instruct instruct = instructManager.LoadFirstInstruct();
            if (instruct != null)
            {
                IDTxtBox.Text = instruct.ID.ToString();
                InstIDTxtBox.Text = instruct.InstructorID.ToString();
                CourseIDTxtBox.Text = instruct.CourseID.ToString();
                YearTxtBox.Text = instruct.Year;
                SemesterTxtBox.Text = instruct.Semester;
               
            }
        }

        private void LoadFirstInstructBut_Click(object sender, EventArgs e)
        {
            InstructManager instructManager = new InstructManager();
            Instruct instruct = instructManager.LoadFirstInstruct();
            if (instruct != null)
            {
                IDTxtBox.Text = instruct.ID.ToString();
                InstIDTxtBox.Text = instruct.InstructorID.ToString();
                CourseIDTxtBox.Text = instruct.CourseID.ToString();
                YearTxtBox.Text = instruct.Year;
                SemesterTxtBox.Text = instruct.Semester;

            }
        }

        private void NextInstructBut_Click(object sender, EventArgs e)
        {
            int CurrentID = 0;
            int.TryParse(IDTxtBox.Text, out CurrentID);

            if (CurrentID > 0)
            {
                InstructManager instructManager = new InstructManager();
                Instruct instruct = instructManager.LoadNextInstruct(CurrentID);

                if (instruct != null)
                {
                    IDTxtBox.Text = instruct.ID.ToString();
                    InstIDTxtBox.Text = instruct.InstructorID.ToString();
                    CourseIDTxtBox.Text = instruct.CourseID.ToString();
                    YearTxtBox.Text = instruct.Year;
                    SemesterTxtBox.Text = instruct.Semester;

                }
            }
        }

        private void PreviousInstructBut_Click(object sender, EventArgs e)
        {
            int CurrentID = 0;
            int.TryParse(IDTxtBox.Text, out CurrentID);

            if (CurrentID != 0)
            {
                InstructManager instructManager = new InstructManager();
                Instruct instruct = instructManager.LoadPreviousInstruct(CurrentID);

                if (instruct != null)
                {
                    IDTxtBox.Text = instruct.ID.ToString();
                    InstIDTxtBox.Text = instruct.InstructorID.ToString();
                    CourseIDTxtBox.Text = instruct.CourseID.ToString();
                    YearTxtBox.Text = instruct.Year;
                    SemesterTxtBox.Text = instruct.Semester;

                }
            }
        }

        private void LastInstructBut_Click(object sender, EventArgs e)
        {
            InstructManager instructManager = new InstructManager();
            Instruct instruct = instructManager.LoadLastInstruct();
            if (instruct != null)
            {
                IDTxtBox.Text = instruct.ID.ToString();
                InstIDTxtBox.Text = instruct.InstructorID.ToString();
                CourseIDTxtBox.Text = instruct.CourseID.ToString();
                YearTxtBox.Text = instruct.Year;
                SemesterTxtBox.Text = instruct.Semester;

            }
        }

        private void SearchBut_Click(object sender, EventArgs e)
        {
            int CurrentID = 0;
            int.TryParse(SearchTxtBox.Text, out CurrentID);

            if (CurrentID > 0)
            {
                InstructManager instructManager = new InstructManager();
                Instruct instruct = instructManager.SearchInstruct(CurrentID);

                if (instruct != null)
                {
                    IDTxtBox.Text = instruct.ID.ToString();
                    InstIDTxtBox.Text = instruct.InstructorID.ToString();
                    CourseIDTxtBox.Text = instruct.CourseID.ToString();
                    YearTxtBox.Text = instruct.Year;
                    SemesterTxtBox.Text = instruct.Semester;

                }
            }
        }

        private void UpdateBut_Click(object sender, EventArgs e)
        {
            Instruct instruct = new Instruct();
            
            instruct.ID = int.Parse(IDTxtBox.Text);
            instruct.InstructorID = int.Parse(InstIDTxtBox.Text);
            instruct.CourseID = int.Parse(CourseIDTxtBox.Text);
            instruct.Year = YearTxtBox.Text;
            instruct.Semester = SemesterTxtBox.Text;

            InstructManager instructManager = new InstructManager();
            instructManager.UpdateInstruct(instruct);
        }

        private void AddBut_Click(object sender, EventArgs e)
        {
            Instruct instruct = new Instruct();

            instruct.ID = int.Parse(IDTxtBox.Text);
            instruct.InstructorID = int.Parse(InstIDTxtBox.Text);
            instruct.CourseID = int.Parse(CourseIDTxtBox.Text);
            instruct.Year = YearTxtBox.Text;
            instruct.Semester = SemesterTxtBox.Text;

            InstructManager instructManager = new InstructManager();
            instructManager.AddInstruct(instruct);
        }

        private void DeleteBut_Click(object sender, EventArgs e)
        {
            int CurrentID = 0;
            int.TryParse(IDTxtBox.Text, out CurrentID);

            if (CurrentID > 0)
            {
                InstructManager instructManager = new InstructManager();
                instructManager.DeleteInstruct(CurrentID);

            }
        }

    }
}
