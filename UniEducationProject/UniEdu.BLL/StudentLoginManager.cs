using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniEdu.DAL;
using UniEdu.Entities;

namespace UniEdu.BLL
{
    public class StudentLoginManager
    {
        public Student verifyStudent(string username, string password)
        {
            StudentLoginDao studentLoginDao = new StudentLoginDao();
            return studentLoginDao.verifyStudent(username, password);
        }
    }
}
