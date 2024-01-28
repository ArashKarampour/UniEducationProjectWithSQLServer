using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniEdu.DAL;

namespace UniEdu.BLL
{
    public class StPanelMgr
    {
        public DataTable LoadYears()
        {
            StPanelDao stPanelYearLoadDao = new StPanelDao();
            return stPanelYearLoadDao.LoadYears();
        }

        public DataTable LoadCourses(int sID, string year, string semester)
        {
            StPanelDao stPanelDao = new StPanelDao();
            return stPanelDao.LoadCourses(sID,year,semester);
        }

        public DataTable LoadClassMates(int CourseID, string year, string semester)
        {
            StPanelDao stPanelDao = new StPanelDao();
            return stPanelDao.LoadClassMates(CourseID,year, semester);
        }
    }
}
