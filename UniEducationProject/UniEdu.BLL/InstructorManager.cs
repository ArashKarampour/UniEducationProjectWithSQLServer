using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniEdu.DAL;
using UniEdu.Entities;

namespace UniEdu.BLL
{
    public class InstructorManager
    {
        public Instructor LoadFirstInstructor()
        {
            InstructorDao instructordao = new InstructorDao();
            return instructordao.LoadFirstInstructor();
        }

        public Instructor LoadNextInstructor(int CurrentInstructorID)
        {
            InstructorDao instructordao = new InstructorDao();
            return instructordao.LoadNextInstructor(CurrentInstructorID);
        }

        public Instructor LoadPreviousInstructor(int CurrentInstructorID)
        {
            InstructorDao instructordao = new InstructorDao();
            return instructordao.LoadPreviousInstructor(CurrentInstructorID);
        }

        public Instructor LoadLastInstructor()
        {
            InstructorDao instructordao = new InstructorDao();
            return instructordao.LoadLastInstructor();
        }

        public Instructor SearchInstructor(string find)
        {
            InstructorDao instructordao = new InstructorDao();
            return instructordao.SearchInstructor(find);
        }

        public void UpdateInstructor(Instructor instructor)
        {
            InstructorDao instructordao = new InstructorDao();
            instructordao.UpdateInstructor(instructor);
        }

        public void AddInstructor(Instructor instructor)
        {
            InstructorDao instructordao = new InstructorDao();
            instructordao.AddInstructor(instructor);
        }

        public void DeleteInstructor(int currentInstructorID)
        {
            InstructorDao instructordao = new InstructorDao();
            instructordao.DeleteInstructor(currentInstructorID);
        }
    }
}
