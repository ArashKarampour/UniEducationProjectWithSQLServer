using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniEdu.DAL;

namespace UniEdu.BLL
{
    public class StChangePassMgr
    {
        public void ChangePass(int sID, string newPass)
        {
            StChangePassDao scpdao = new StChangePassDao();
            scpdao.ChangePass(sID, newPass);            
        }
    }
}
