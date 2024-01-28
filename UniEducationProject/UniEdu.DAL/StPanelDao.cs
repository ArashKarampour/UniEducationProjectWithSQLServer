using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace UniEdu.DAL

{
    public class StPanelDao
    {
        public DataTable LoadYears()
        {
            
            string connectionString = "Data Source=ARASH-PC\\MYSQLSERVER;Initial Catalog=UniEducation;Integrated Security=true";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            SqlDataAdapter sda = new SqlDataAdapter(@"select Distinct [Year] from Enroll order by [Year] Desc", sqlConnection);

            DataTable dt = new DataTable();
            sda.Fill(dt);

            return dt;
        }

        public DataTable LoadCourses(int sID, string year, string semester)
        {
            DataTable dt = new DataTable();
            string connectionString = "Data Source=ARASH-PC\\MYSQLSERVER;Initial Catalog=UniEducation;Integrated Security=true";
            using (SqlConnection sqlCon = new System.Data.SqlClient.SqlConnection(connectionString))
            {
                using (SqlDataAdapter sda = new SqlDataAdapter("StudentPanel_ShowCourses", sqlCon))
                {
                    sda.SelectCommand.CommandType = CommandType.StoredProcedure;
                    SqlParameter IDParameter = sda.SelectCommand.Parameters.Add("sID", System.Data.SqlDbType.Int);
                    IDParameter.Value = sID;
                    SqlParameter YearParameter = sda.SelectCommand.Parameters.Add("Year", System.Data.SqlDbType.NVarChar);
                    YearParameter.Value = year;
                    SqlParameter SemesterParameter = sda.SelectCommand.Parameters.Add("Semester", System.Data.SqlDbType.NVarChar);
                    SemesterParameter.Value = semester;
                    sda.Fill(dt);
                }
            }
            return dt;
        }

        public DataTable LoadClassMates(int courseID, string year, string semester)
        {
            DataTable dt = new DataTable();
            string connectionString = "Data Source=ARASH-PC\\MYSQLSERVER;Initial Catalog=UniEducation;Integrated Security=true";
            using (SqlConnection sqlCon = new System.Data.SqlClient.SqlConnection(connectionString))
            {
                using (SqlDataAdapter sda = new SqlDataAdapter("Student_ShowClassMates", sqlCon))
                {
                    sda.SelectCommand.CommandType = CommandType.StoredProcedure;
                    SqlParameter IDParameter = sda.SelectCommand.Parameters.Add("CourseID", System.Data.SqlDbType.Int);
                    IDParameter.Value = courseID;
                    SqlParameter YearParameter = sda.SelectCommand.Parameters.Add("Year", System.Data.SqlDbType.NVarChar);
                    YearParameter.Value = year;
                    SqlParameter SemesterParameter = sda.SelectCommand.Parameters.Add("Semester", System.Data.SqlDbType.NVarChar);
                    SemesterParameter.Value = semester;
                    sda.Fill(dt);
                }
            }
            return dt;
        }
    }
}
