using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniEdu.DAL;
using UniEdu.Entities;


namespace UniEdu.BLL
{
    public class AdminLoginManager
    {
        public int verifyAdmin(string username,string password)
        {
            AdminLoginDao adminLoginDao = new AdminLoginDao();
            return adminLoginDao.verifyAdmin(username, password);
        }
    }
}
