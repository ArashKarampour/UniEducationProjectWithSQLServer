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
    public partial class EnrollForm : Form
    {
       
        public EnrollForm()
        {
            InitializeComponent();
        }

        private void EnrollForm_Load(object sender, EventArgs e)
        {
            CourseBeginTimePicker.Format = DateTimePickerFormat.Time;
            //CourseBeginTimePicker.CustomFormat = "HH:mm:ss";
            CourseFinishTimePicker.Format = DateTimePickerFormat.Time;
            CourseBeginTimePicker.ShowUpDown = true;
            CourseFinishTimePicker.ShowUpDown = true;

            EnrollManager enrollManager = new EnrollManager();
            Enroll enroll = enrollManager.LoadFirstEnroll();
            if (enroll != null)
            {
                IDTxtBox.Text = enroll.ID.ToString();
                SIDTxtBox.Text = enroll.StudentID.ToString();
                CourseIDTxtBox.Text = enroll.CourseID.ToString();
                InstIDTxtBox.Text = enroll.InstructorID.ToString();
                ClassIDTxtBox.Text = enroll.ClassID.ToString();
                StatusTxtBox.Text = enroll.Status;
                PointTxtBox.Text = enroll.Point.ToString();
                YearTxtBox.Text = enroll.Year;
                SemesterTxtBox.Text = enroll.Semester;
                DayTxtBox.Text = enroll.Day;
                CourseBeginTimePicker.Text = enroll.CourseBeginTime.ToString();
                CourseFinishTimePicker.Text = enroll.CourseFinishTime.ToString();
            }
        }

        private void LoadFirstEnrollBut_Click(object sender, EventArgs e)
        {
            EnrollManager enrollManager = new EnrollManager();
            Enroll enroll = enrollManager.LoadFirstEnroll();
            if (enroll != null)
            {
                IDTxtBox.Text = enroll.ID.ToString();
                SIDTxtBox.Text = enroll.StudentID.ToString();
                CourseIDTxtBox.Text = enroll.CourseID.ToString();
                InstIDTxtBox.Text = enroll.InstructorID.ToString();
                ClassIDTxtBox.Text = enroll.ClassID.ToString();
                StatusTxtBox.Text = enroll.Status;
                PointTxtBox.Text = enroll.Point.ToString();
                YearTxtBox.Text = enroll.Year;
                SemesterTxtBox.Text = enroll.Semester;
                DayTxtBox.Text = enroll.Day;
                CourseBeginTimePicker.Text = enroll.CourseBeginTime.ToString();
                CourseFinishTimePicker.Text = enroll.CourseFinishTime.ToString();
            }
        }

        private void NextEnrollBut_Click(object sender, EventArgs e)
        {
            
            int CurrentID = 0;
            int.TryParse(IDTxtBox.Text, out CurrentID);

            if (CurrentID != 0)
            {
                EnrollManager enrollManager = new EnrollManager();
                Enroll enroll = enrollManager.LoadNextEnroll(CurrentID);

                if (enroll != null)
                {
                    IDTxtBox.Text = enroll.ID.ToString();
                    SIDTxtBox.Text = enroll.StudentID.ToString();
                    CourseIDTxtBox.Text = enroll.CourseID.ToString();
                    InstIDTxtBox.Text = enroll.InstructorID.ToString();
                    ClassIDTxtBox.Text = enroll.ClassID.ToString();
                    StatusTxtBox.Text = enroll.Status;
                    PointTxtBox.Text = enroll.Point.ToString();
                    YearTxtBox.Text = enroll.Year;
                    SemesterTxtBox.Text = enroll.Semester;
                    DayTxtBox.Text = enroll.Day;
                    CourseBeginTimePicker.Text = enroll.CourseBeginTime.ToString();
                    CourseFinishTimePicker.Text = enroll.CourseFinishTime.ToString();
                }
            }
        }

        private void PreviousEnrollBut_Click(object sender, EventArgs e)
        {
            int CurrentID = 0;
            int.TryParse(IDTxtBox.Text, out CurrentID);

            if (CurrentID != 0)
            {
                EnrollManager enrollManager = new EnrollManager();
                Enroll enroll = enrollManager.LoadPreviousEnroll(CurrentID);

                if (enroll != null)
                {
                    IDTxtBox.Text = enroll.ID.ToString();
                    SIDTxtBox.Text = enroll.StudentID.ToString();
                    CourseIDTxtBox.Text = enroll.CourseID.ToString();
                    InstIDTxtBox.Text = enroll.InstructorID.ToString();
                    ClassIDTxtBox.Text = enroll.ClassID.ToString();
                    StatusTxtBox.Text = enroll.Status;
                    PointTxtBox.Text = enroll.Point.ToString();
                    YearTxtBox.Text = enroll.Year;
                    SemesterTxtBox.Text = enroll.Semester;
                    DayTxtBox.Text = enroll.Day;
                    CourseBeginTimePicker.Text = enroll.CourseBeginTime.ToString();
                    CourseFinishTimePicker.Text = enroll.CourseFinishTime.ToString();
                }
            }
            
        }

        private void LastEnrollBut_Click(object sender, EventArgs e)
        {
            EnrollManager enrollManager = new EnrollManager();
            Enroll enroll = enrollManager.LoadLastEnroll();
            if (enroll != null)
            {
                IDTxtBox.Text = enroll.ID.ToString();
                SIDTxtBox.Text = enroll.StudentID.ToString();
                CourseIDTxtBox.Text = enroll.CourseID.ToString();
                InstIDTxtBox.Text = enroll.InstructorID.ToString();
                ClassIDTxtBox.Text = enroll.ClassID.ToString();
                StatusTxtBox.Text = enroll.Status;
                PointTxtBox.Text = enroll.Point.ToString();
                YearTxtBox.Text = enroll.Year;
                SemesterTxtBox.Text = enroll.Semester;
                DayTxtBox.Text = enroll.Day;
                CourseBeginTimePicker.Text = enroll.CourseBeginTime.ToString();
                CourseFinishTimePicker.Text = enroll.CourseFinishTime.ToString();
            }
        }

        private void SearchBut_Click(object sender, EventArgs e)
        {
            int CurrentID = 0;
            int.TryParse(SearchTxtBox.Text, out CurrentID);
            if (CurrentID != 0)
            {
                EnrollManager enrollManager = new EnrollManager();
                Enroll enroll = enrollManager.SearchEnroll(CurrentID);

                if (enroll != null)
                {
                    IDTxtBox.Text = enroll.ID.ToString();
                    SIDTxtBox.Text = enroll.StudentID.ToString();
                    CourseIDTxtBox.Text = enroll.CourseID.ToString();
                    InstIDTxtBox.Text = enroll.InstructorID.ToString();
                    ClassIDTxtBox.Text = enroll.ClassID.ToString();
                    StatusTxtBox.Text = enroll.Status;
                    PointTxtBox.Text = enroll.Point.ToString();
                    YearTxtBox.Text = enroll.Year;
                    SemesterTxtBox.Text = enroll.Semester;
                    DayTxtBox.Text = enroll.Day;
                    CourseBeginTimePicker.Text = enroll.CourseBeginTime.ToString();
                    CourseFinishTimePicker.Text = enroll.CourseFinishTime.ToString();
                }
            }
        }

        private void UpdateBut_Click(object sender, EventArgs e)
        {
            Enroll enroll = new Enroll();
            CourseBeginTimePicker.Format = DateTimePickerFormat.Custom;
            CourseBeginTimePicker.CustomFormat = "HH:mm:ss";
            CourseFinishTimePicker.Format = DateTimePickerFormat.Custom;
            CourseFinishTimePicker.CustomFormat = "HH:mm:ss";

            enroll.ID = int.Parse(IDTxtBox.Text);
            enroll.StudentID = int.Parse(SIDTxtBox.Text);
            enroll.CourseID = int.Parse(CourseIDTxtBox.Text);
            enroll.InstructorID = int.Parse(InstIDTxtBox.Text);
            enroll.ClassID = int.Parse(ClassIDTxtBox.Text);
            enroll.Status = StatusTxtBox.Text;
            enroll.Point = Double.Parse(PointTxtBox.Text);
            enroll.Year = YearTxtBox.Text;
            enroll.Semester = SemesterTxtBox.Text;
            enroll.Day = DayTxtBox.Text;
            enroll.CourseBeginTime = TimeSpan.Parse(CourseBeginTimePicker.Text);
            enroll.CourseFinishTime = TimeSpan.Parse(CourseFinishTimePicker.Text);

            CourseBeginTimePicker.Format = DateTimePickerFormat.Time;
            CourseFinishTimePicker.Format = DateTimePickerFormat.Time;

            EnrollManager enrollManager = new EnrollManager();
            enrollManager.UpdateEnroll(enroll);
        }

        private void AddBut_Click(object sender, EventArgs e)
        {
            Enroll enroll = new Enroll();

            CourseBeginTimePicker.Format = DateTimePickerFormat.Custom;
            CourseBeginTimePicker.CustomFormat = "HH:mm:ss";
            CourseFinishTimePicker.Format = DateTimePickerFormat.Custom;
            CourseFinishTimePicker.CustomFormat = "HH:mm:ss";

            enroll.StudentID = int.Parse(SIDTxtBox.Text);
            enroll.CourseID = int.Parse(CourseIDTxtBox.Text);
            enroll.InstructorID = int.Parse(InstIDTxtBox.Text);
            enroll.ClassID = int.Parse(ClassIDTxtBox.Text);
            enroll.Status = StatusTxtBox.Text;
            enroll.Point = Double.Parse(PointTxtBox.Text);
            enroll.Year = YearTxtBox.Text;
            enroll.Semester = SemesterTxtBox.Text;
            enroll.Day = DayTxtBox.Text;
            enroll.CourseBeginTime = TimeSpan.Parse(CourseBeginTimePicker.Text);
            enroll.CourseFinishTime = TimeSpan.Parse(CourseFinishTimePicker.Text);

            CourseBeginTimePicker.Format = DateTimePickerFormat.Time;
            CourseFinishTimePicker.Format = DateTimePickerFormat.Time;

            EnrollManager enrollManager = new EnrollManager();
            enrollManager.AddEnroll(enroll);
        }

        private void DeleteBut_Click(object sender, EventArgs e)
        {
            int CurrentID = 0;
            int.TryParse(IDTxtBox.Text, out CurrentID);

            if (CurrentID > 0)
            {
                EnrollManager enrollManager = new EnrollManager();
                enrollManager.DeleteEnroll(CurrentID);

            }
            
        }
    }
}
