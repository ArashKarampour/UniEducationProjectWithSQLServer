using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniEdu.Entities
{
    public class Course
    {
        public int CouID { get; set; }
        public string CouTitle { get; set; }
        public string GroupNumber { get; set; }
        public int UnitNumber { get; set; }
        public string Requirement { get; set; }
    }
}
