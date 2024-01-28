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
    public partial class ClassForm : Form
    {
        public ClassForm()
        {
            InitializeComponent();
        }

        private void ClassForm_Load(object sender, EventArgs e)
        {
            ClassManager classManager = new ClassManager();
            ClassRoom classRoom = classManager.LoadFirstClass();

            if(classRoom != null)
            {
                IDTxtBox.Text = classRoom.ID.ToString();
                RoomNumberTxtBox.Text = classRoom.RoomNumber;
                DepartmentTxtBox.Text = classRoom.Department;

            }
        }

        private void LoadFirstClassBut_Click(object sender, EventArgs e)
        {
            ClassManager classManager = new ClassManager();
            ClassRoom classRoom = classManager.LoadFirstClass();

            if (classRoom != null)
            {
                IDTxtBox.Text = classRoom.ID.ToString();
                RoomNumberTxtBox.Text = classRoom.RoomNumber;
                DepartmentTxtBox.Text = classRoom.Department;

            }
        }

        private void NextClassBut_Click(object sender, EventArgs e)
        {
            int CurrentID = 0;
            int.TryParse(IDTxtBox.Text, out CurrentID);

            if(CurrentID > 0)
            {
                ClassManager classManager = new ClassManager();
                ClassRoom classRoom = classManager.LoadNextClass(CurrentID);

                if (classRoom != null)
                {
                    IDTxtBox.Text = classRoom.ID.ToString();
                    RoomNumberTxtBox.Text = classRoom.RoomNumber;
                    DepartmentTxtBox.Text = classRoom.Department;

                }
            }
        }

        private void PreviousClassBut_Click(object sender, EventArgs e)
        {
            int CurrentID = 0;
            int.TryParse(IDTxtBox.Text, out CurrentID);

            if (CurrentID > 0)
            {
                ClassManager classManager = new ClassManager();
                ClassRoom classRoom = classManager.LoadPreviousClass(CurrentID);

                if (classRoom != null)
                {
                    IDTxtBox.Text = classRoom.ID.ToString();
                    RoomNumberTxtBox.Text = classRoom.RoomNumber;
                    DepartmentTxtBox.Text = classRoom.Department;

                }
            }
        }

        private void LastClassBut_Click(object sender, EventArgs e)
        {
            ClassManager classManager = new ClassManager();
            ClassRoom classRoom = classManager.LoadLastClass();

            if (classRoom != null)
            {
                IDTxtBox.Text = classRoom.ID.ToString();
                RoomNumberTxtBox.Text = classRoom.RoomNumber;
                DepartmentTxtBox.Text = classRoom.Department;
            }
        }

        private void SearchBut_Click(object sender, EventArgs e)
        {
            int CurrentID = 0;
            int.TryParse(SearchTxtBox.Text, out CurrentID);

            if (CurrentID > 0)
            {
                ClassManager classManager = new ClassManager();
                ClassRoom classRoom = classManager.SearchClass(CurrentID);

                if (classRoom != null)
                {
                    IDTxtBox.Text = classRoom.ID.ToString();
                    RoomNumberTxtBox.Text = classRoom.RoomNumber;
                    DepartmentTxtBox.Text = classRoom.Department;

                }
            }
        }

        private void UpdateBut_Click(object sender, EventArgs e)
        {
            ClassRoom classRoom = new ClassRoom();

            classRoom.ID = int.Parse(IDTxtBox.Text);
            classRoom.RoomNumber = RoomNumberTxtBox.Text;
            classRoom.Department = DepartmentTxtBox.Text;

            ClassManager classManager = new ClassManager();
            classManager.UpdateClass(classRoom);
        }

        private void AddBut_Click(object sender, EventArgs e)
        {
            ClassRoom classRoom = new ClassRoom();

            classRoom.ID = int.Parse(IDTxtBox.Text);
            classRoom.RoomNumber = RoomNumberTxtBox.Text;
            classRoom.Department = DepartmentTxtBox.Text;

            ClassManager classManager = new ClassManager();
            classManager.AddClass(classRoom);
        }

        private void DeleteBut_Click(object sender, EventArgs e)
        {
            int CurrentID = 0;
            int.TryParse(IDTxtBox.Text, out CurrentID);

            if (CurrentID > 0)
            {
                ClassManager classManager = new ClassManager();
                classManager.DeleteClass(CurrentID);

            }
        }
    }
}
