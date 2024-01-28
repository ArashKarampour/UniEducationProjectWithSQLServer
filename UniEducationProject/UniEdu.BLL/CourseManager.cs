using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniEdu.DAL;
using UniEdu.Entities;

namespace UniEdu.BLL
{
    public class CourseManager
    {
        public Course LoadFirstCourse()
        {
            CourseDao courseDao = new CourseDao();
            return courseDao.LoadFirstCourse();
        }

        public Course LoadNextCourse(int currentCourseID)
        {
            CourseDao courseDao = new CourseDao();
            return courseDao.LoadNextCourse(currentCourseID);
        }

        public Course LoadPreviousCourse(int currentCourseID)
        {
            CourseDao courseDao = new CourseDao();
            return courseDao.LoadPreviousCourse(currentCourseID);
        }

        public Course LoadLastCourse()
        {
            CourseDao courseDao = new CourseDao();
            return courseDao.LoadLastCourse();
        }

        public Course SearchCourse(string Title, string GroupNum)
        {
            CourseDao courseDao = new CourseDao();
            return courseDao.SearchCourse(Title,GroupNum);
        }

        public void UpdateCourse(Course course)
        {
            CourseDao courseDao = new CourseDao();
            courseDao.UpdateCourse(course);
        }

        public void AddCourse(Course course)
        {
            CourseDao courseDao = new CourseDao();
            courseDao.AddCourse(course);
        }

        public void DeleteCourse(int currentCourseID)
        {
            CourseDao courseDao = new CourseDao();
            courseDao.DeleteCourse(currentCourseID);
        }
    }
}
