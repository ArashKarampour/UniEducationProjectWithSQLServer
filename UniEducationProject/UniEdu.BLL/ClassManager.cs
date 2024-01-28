using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniEdu.DAL;
using UniEdu.Entities;

namespace UniEdu.BLL
{
    public class ClassManager
    {
        public ClassRoom LoadFirstClass()
        {
            ClassDao classDao = new ClassDao();
            return classDao.LoadFirstClass();
        }

        public ClassRoom LoadNextClass(int currentID)
        {
            ClassDao classDao = new ClassDao();
            return classDao.LoadNextClass(currentID);
        }

        public ClassRoom LoadPreviousClass(int currentID)
        {
            ClassDao classDao = new ClassDao();
            return classDao.LoadPreviousClass(currentID);
        }

        public ClassRoom LoadLastClass()
        {
            ClassDao classDao = new ClassDao();
            return classDao.LoadLastClass();
        }

        public ClassRoom SearchClass(int currentID)
        {
            ClassDao classDao = new ClassDao();
            return classDao.SearchClass(currentID);
        }

        public void UpdateClass(ClassRoom classRoom)
        {
            ClassDao classDao = new ClassDao();
            classDao.UpdateClass(classRoom);
        }
        public void AddClass(ClassRoom classRoom)
        {
            ClassDao classDao = new ClassDao();
            classDao.AddClass(classRoom);
        }

        public void DeleteClass(int currentID)
        {
            ClassDao classDao = new ClassDao();
            classDao.DeleteClass(currentID);
        }

    }
}
