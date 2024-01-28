using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniEdu.DAL;
using UniEdu.Entities;

namespace UniEdu.BLL
{
    public class StudentManager
    {
        public Student LoadFirstStudent()
        {
            StudentDao studentdao = new StudentDao();
            return studentdao.LoadFirstStudent();
        }

        public Student LoadNextStudent(int CurrentStudentID)
        {
            StudentDao studentDao = new StudentDao();
            return studentDao.LoadNextStudent(CurrentStudentID);
        }

        public Student LoadPreviousStudent(int CurrentStudentID)
        {
            StudentDao studentDao = new StudentDao();
            return studentDao.LoadPreviousStudent(CurrentStudentID);
        }

        public Student LoadLastStudent()
        {
            StudentDao studentDao = new StudentDao();
            return studentDao.LoadLastStudent();
        }

        public Student SearchStudent(string find)
        {
            StudentDao studentDao = new StudentDao();
            return studentDao.SearchStudent(find);
        }

        public void UpdateStudent(Student student)
        {
            StudentDao studentDao = new StudentDao();
            studentDao.UpdateStudent(student);
        }

        public void AddStudent(Student student)
        {
            StudentDao studentDao = new StudentDao();
            studentDao.AddStudent(student);
        }

        public void DeleteStudent(int currentStudentID)
        {
            StudentDao studentDao = new StudentDao();
            studentDao.DeleteStudent(currentStudentID);
        }
    }
}
