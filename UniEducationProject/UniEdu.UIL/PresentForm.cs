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
    public partial class PresentForm : Form
    {
        public PresentForm()
        {
            InitializeComponent();
        }

        private void PresentForm_Load(object sender, EventArgs e)
        {
            ClassBeginTimePicker.Format = DateTimePickerFormat.Time;
            //CourseBeginTimePicker.CustomFormat = "HH:mm:ss";
            ClassFinishTimePicker.Format = DateTimePickerFormat.Time;
            ClassBeginTimePicker.ShowUpDown = true;
            ClassFinishTimePicker.ShowUpDown = true;

            PresentManager presentManager = new PresentManager();
            Present present = presentManager.LoadFirstPresent();
            if (present != null)
            {
                IDTxtBox.Text = present.ID.ToString();
                ClassIDTxtBox.Text = present.ClassID.ToString();
                CourseIDTxtBox.Text = present.CourseID.ToString();
                InstIDTxtBox.Text = present.InstructorID.ToString();
                YearTxtBox.Text = present.Year;
                SemesterTxtBox.Text = present.Semester;
                DayTxtBox.Text = present.Day;
                ClassBeginTimePicker.Text = present.ClassBeginTime.ToString();
                ClassFinishTimePicker.Text = present.ClassFinishTime.ToString();
            }
        }
        private void LoadFirstPresentBut_Click(object sender, EventArgs e)
        {

            PresentManager presentManager = new PresentManager();
            Present present = presentManager.LoadFirstPresent();
            if (present != null)
            {
                IDTxtBox.Text = present.ID.ToString();
                ClassIDTxtBox.Text = present.ClassID.ToString();
                CourseIDTxtBox.Text = present.CourseID.ToString();
                InstIDTxtBox.Text = present.InstructorID.ToString();
                YearTxtBox.Text = present.Year;
                SemesterTxtBox.Text = present.Semester;
                DayTxtBox.Text = present.Day;
                ClassBeginTimePicker.Text = present.ClassBeginTime.ToString();
                ClassFinishTimePicker.Text = present.ClassFinishTime.ToString();
            }
        }

        private void NextPresentBut_Click(object sender, EventArgs e)
        {
            int CurrentID = 0;
            int.TryParse(IDTxtBox.Text, out CurrentID);

            if (CurrentID != 0)
            {
                PresentManager presentManager = new PresentManager();
                Present present = presentManager.LoadNextPresent(CurrentID);

                if (present != null)
                {
                    IDTxtBox.Text = present.ID.ToString();
                    ClassIDTxtBox.Text = present.ClassID.ToString();
                    CourseIDTxtBox.Text = present.CourseID.ToString();
                    InstIDTxtBox.Text = present.InstructorID.ToString();
                    YearTxtBox.Text = present.Year;
                    SemesterTxtBox.Text = present.Semester;
                    DayTxtBox.Text = present.Day;
                    ClassBeginTimePicker.Text = present.ClassBeginTime.ToString();
                    ClassFinishTimePicker.Text = present.ClassFinishTime.ToString();
                }
            }
        }

        private void PreviousPresentBut_Click(object sender, EventArgs e)
        {
            int CurrentID = 0;
            int.TryParse(IDTxtBox.Text, out CurrentID);

            if (CurrentID != 0)
            {
                PresentManager presentManager = new PresentManager();
                Present present = presentManager.LoadPreviousPresent(CurrentID);

                if (present != null)
                {
                    IDTxtBox.Text = present.ID.ToString();
                    ClassIDTxtBox.Text = present.ClassID.ToString();
                    CourseIDTxtBox.Text = present.CourseID.ToString();
                    InstIDTxtBox.Text = present.InstructorID.ToString();
                    YearTxtBox.Text = present.Year;
                    SemesterTxtBox.Text = present.Semester;
                    DayTxtBox.Text = present.Day;
                    ClassBeginTimePicker.Text = present.ClassBeginTime.ToString();
                    ClassFinishTimePicker.Text = present.ClassFinishTime.ToString();
                }
            }
        }

        private void LastPresentBut_Click(object sender, EventArgs e)
        {
            PresentManager presentManager = new PresentManager();
            Present present = presentManager.LoadLastPresent();
            if (present != null)
            {
                IDTxtBox.Text = present.ID.ToString();
                ClassIDTxtBox.Text = present.ClassID.ToString();
                CourseIDTxtBox.Text = present.CourseID.ToString();
                InstIDTxtBox.Text = present.InstructorID.ToString();
                YearTxtBox.Text = present.Year;
                SemesterTxtBox.Text = present.Semester;
                DayTxtBox.Text = present.Day;
                ClassBeginTimePicker.Text = present.ClassBeginTime.ToString();
                ClassFinishTimePicker.Text = present.ClassFinishTime.ToString();
            }
        }

        private void SearchBut_Click(object sender, EventArgs e)
        {
            int CurrentID = 0;
            int.TryParse(SearchTxtBox.Text, out CurrentID);

            if (CurrentID > 0)
            {
                PresentManager presentManager = new PresentManager();
                Present present = presentManager.SearchPresent(CurrentID);

                if (present != null)
                {
                    IDTxtBox.Text = present.ID.ToString();
                    ClassIDTxtBox.Text = present.ClassID.ToString();
                    CourseIDTxtBox.Text = present.CourseID.ToString();
                    InstIDTxtBox.Text = present.InstructorID.ToString();
                    YearTxtBox.Text = present.Year;
                    SemesterTxtBox.Text = present.Semester;
                    DayTxtBox.Text = present.Day;
                    ClassBeginTimePicker.Text = present.ClassBeginTime.ToString();
                    ClassFinishTimePicker.Text = present.ClassFinishTime.ToString();
                }
            }
        }

        private void UpdateBut_Click(object sender, EventArgs e)
        {
            Present present = new Present();
            ClassBeginTimePicker.Format = DateTimePickerFormat.Custom;
            ClassBeginTimePicker.CustomFormat = "HH:mm:ss";
            ClassFinishTimePicker.Format = DateTimePickerFormat.Custom;
            ClassFinishTimePicker.CustomFormat = "HH:mm:ss";

            present.ID = int.Parse(IDTxtBox.Text);
            present.ClassID = int.Parse(ClassIDTxtBox.Text);
            present.CourseID = int.Parse(CourseIDTxtBox.Text);
            present.InstructorID = int.Parse(InstIDTxtBox.Text);
            present.Year = YearTxtBox.Text;
            present.Semester = SemesterTxtBox.Text;
            present.Day = DayTxtBox.Text;
            present.ClassBeginTime = TimeSpan.Parse(ClassBeginTimePicker.Text);
            present.ClassFinishTime = TimeSpan.Parse(ClassFinishTimePicker.Text);

            ClassBeginTimePicker.Format = DateTimePickerFormat.Time;
            ClassFinishTimePicker.Format = DateTimePickerFormat.Time;

            PresentManager presentManager = new PresentManager();
            presentManager.UpdatePresent(present);
        }

        private void AddBut_Click(object sender, EventArgs e)
        {
            Present present = new Present();
            ClassBeginTimePicker.Format = DateTimePickerFormat.Custom;
            ClassBeginTimePicker.CustomFormat = "HH:mm:ss";
            ClassFinishTimePicker.Format = DateTimePickerFormat.Custom;
            ClassFinishTimePicker.CustomFormat = "HH:mm:ss";

            present.ClassID = int.Parse(ClassIDTxtBox.Text);
            present.CourseID = int.Parse(CourseIDTxtBox.Text);
            present.InstructorID = int.Parse(InstIDTxtBox.Text);
            present.Year = YearTxtBox.Text;
            present.Semester = SemesterTxtBox.Text;
            present.Day = DayTxtBox.Text;
            present.ClassBeginTime = TimeSpan.Parse(ClassBeginTimePicker.Text);
            present.ClassFinishTime = TimeSpan.Parse(ClassFinishTimePicker.Text);

            ClassBeginTimePicker.Format = DateTimePickerFormat.Time;
            ClassFinishTimePicker.Format = DateTimePickerFormat.Time;

            PresentManager presentManager = new PresentManager();
            presentManager.AddPresent(present);
        }

        private void DeleteBut_Click(object sender, EventArgs e)
        {
            int CurrentID = 0;
            int.TryParse(IDTxtBox.Text, out CurrentID);

            if (CurrentID > 0)
            {
                PresentManager presentManager = new PresentManager();
                presentManager.DeletePresent(CurrentID);

            }
        }
    }
}
