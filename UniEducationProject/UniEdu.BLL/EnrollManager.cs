using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniEdu.DAL;
using UniEdu.Entities;

namespace UniEdu.BLL
{
    public class EnrollManager
    {
        public Enroll LoadFirstEnroll()
        {
            EnrollDao enrolldao = new EnrollDao();
            return enrolldao.LoadFirstEnroll();
        }

        public Enroll LoadNextEnroll(int currentID)
        {
            EnrollDao enrolldao = new EnrollDao();
            return enrolldao.LoadNextEnroll(currentID);
        }

        public Enroll LoadPreviousEnroll(int currentID)
        {
            EnrollDao enrolldao = new EnrollDao();
            return enrolldao.LoadPreviousEnroll(currentID);
        }

        public Enroll LoadLastEnroll()
        {
            EnrollDao enrolldao = new EnrollDao();
            return enrolldao.LoadLastEnroll();
        }

        public Enroll SearchEnroll(int find)
        {
            EnrollDao enrolldao = new EnrollDao();
            return enrolldao.SearchEnroll(find);
        }

        public void UpdateEnroll(Enroll enroll)
        {
            EnrollDao enrolldao = new EnrollDao();
            enrolldao.UpdateEnroll(enroll);
        }

        public void AddEnroll(Enroll enroll)
        {
            EnrollDao enrolldao = new EnrollDao();
            enrolldao.AddEnroll(enroll);
        }

        public void DeleteEnroll(int currentID)
        {
            EnrollDao enrolldao = new EnrollDao();
            enrolldao.DeleteEnroll(currentID);
        }
    }
}
