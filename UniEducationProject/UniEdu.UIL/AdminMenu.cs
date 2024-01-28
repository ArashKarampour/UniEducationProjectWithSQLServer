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
    public partial class AdminMenu : Form
    {       
        public AdminMenu()
        {
            InitializeComponent();          
        }

        private void StudentsBut_Click(object sender, EventArgs e)
        {
            StudentForm studentForm = new StudentForm();
            navigate(studentForm, ContentPanel);
        }

        private void InstructorBut_Click(object sender, EventArgs e)
        {
            InstructorForm instructorForm = new InstructorForm();
            navigate(instructorForm, ContentPanel);
        }

        private void CourseBut_Click(object sender, EventArgs e)
        {
            CourseForm courseForm = new CourseForm();
            navigate(courseForm, ContentPanel);
        }

        private void Enroll_Click(object sender, EventArgs e)
        {
            EnrollForm enrollForm = new EnrollForm();
            navigate(enrollForm, ContentPanel);
        }

        private void PresentBut_Click(object sender, EventArgs e)
        {
            PresentForm presentForm = new PresentForm();
            navigate(presentForm, ContentPanel);
        }

        private void InstructBut_Click(object sender, EventArgs e)
        {
            InstructForm instructForm = new InstructForm();
            navigate(instructForm, ContentPanel);
        }

        private void ClassRoomBut_Click(object sender, EventArgs e)
        {
            ClassForm classForm = new ClassForm();
            navigate(classForm, ContentPanel);
        }
        public void navigate(Form form,Panel panel)
        {
            form.TopLevel = false;
            form.Size = panel.Size;
            panel.Controls.Clear();
            panel.Controls.Add(form);
            form.Show();
        }
    }
}
