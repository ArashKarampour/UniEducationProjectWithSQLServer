using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniEdu.Entities
{
    public class Enroll
    {
        public int ID { set; get; }
        public int StudentID { set; get; }
        public int CourseID { set; get; }
        public int InstructorID { set; get; }
        public int ClassID { set; get; }
        public string Status { set; get; }
        public double Point { set; get; }
        public string Year { set; get; }
        public string Semester { set; get; }
        public string Day { set; get; }
        public TimeSpan CourseBeginTime { set; get; }
        public TimeSpan CourseFinishTime { set; get; }
    }
}
