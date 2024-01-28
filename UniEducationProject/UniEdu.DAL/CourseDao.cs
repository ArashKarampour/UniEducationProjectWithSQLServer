using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniEdu.Entities;

namespace UniEdu.DAL
{
    public class CourseDao
    {
        public Course LoadFirstCourse()
        {
            //Connection to SQL
            //1)Connect to SQL
            string connectionString = "Data Source=ARASH-PC\\MYSQLSERVER;Initial Catalog=UniEducation;Integrated Security=true";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();

            //2) Create Command
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = "Select top 1 * from Course";


            //3) Execute Query and Read data
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            Course course = null;

            if (sqlDataReader.Read())
            {
                course = new Course();
                course.CouID = sqlDataReader.GetInt32(0);
                if (!sqlDataReader.IsDBNull(1))
                    course.CouTitle = sqlDataReader.GetString(1);
                if (!sqlDataReader.IsDBNull(2))
                    course.GroupNumber = sqlDataReader.GetString(2);
                if (!sqlDataReader.IsDBNull(3))
                    course.UnitNumber = sqlDataReader.GetInt32(3);
                if (!sqlDataReader.IsDBNull(4))
                    course.Requirement = sqlDataReader.GetString(4);

            }

            sqlConnection.Close();

            return course;
        }

        public Course LoadNextCourse(int currentCourseID)
        {
            //1)
            string connectionString = "Data Source=ARASH-PC\\MYSQLSERVER;Initial Catalog=UniEducation;Integrated Security=true";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();

            //2)
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            sqlCommand.CommandText = "Course_NextCourse";

            SqlParameter IDParameter = sqlCommand.Parameters.Add("CurrentID", System.Data.SqlDbType.Int);
            IDParameter.Value = currentCourseID;

            //3)
            Course course = null;

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            if (sqlDataReader.Read())
            {
                course = new Course();

                course.CouID = sqlDataReader.GetInt32(0);
                if (!sqlDataReader.IsDBNull(1))
                    course.CouTitle = sqlDataReader.GetString(1);
                if (!sqlDataReader.IsDBNull(2))
                    course.GroupNumber = sqlDataReader.GetString(2);
                if (!sqlDataReader.IsDBNull(3))
                    course.UnitNumber = sqlDataReader.GetInt32(3);
                if (!sqlDataReader.IsDBNull(4))
                    course.Requirement = sqlDataReader.GetString(4);
                
            }


            sqlConnection.Close();
            return course;
        }

        public Course LoadPreviousCourse(int currentCourseID)
        {
            //1)
            string connectionString = "Data Source=ARASH-PC\\MYSQLSERVER;Initial Catalog=UniEducation;Integrated Security=true";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();

            //2)
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            sqlCommand.CommandText = "Course_PreviousCourse";

            SqlParameter IDParameter = sqlCommand.Parameters.Add("CurrentID", System.Data.SqlDbType.Int);
            IDParameter.Value = currentCourseID;

            //3)
            Course course = null;

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            if (sqlDataReader.Read())
            {
                course = new Course();

                course.CouID = sqlDataReader.GetInt32(0);
                if (!sqlDataReader.IsDBNull(1))
                    course.CouTitle = sqlDataReader.GetString(1);
                if (!sqlDataReader.IsDBNull(2))
                    course.GroupNumber = sqlDataReader.GetString(2);
                if (!sqlDataReader.IsDBNull(3))
                    course.UnitNumber = sqlDataReader.GetInt32(3);
                if (!sqlDataReader.IsDBNull(4))
                    course.Requirement = sqlDataReader.GetString(4);

            }


            sqlConnection.Close();
            return course;
        }

        public Course LoadLastCourse()
        {
            //Connection to SQL
            //1)Connect to SQL
            string connectionString = "Data Source=ARASH-PC\\MYSQLSERVER;Initial Catalog=UniEducation;Integrated Security=true";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();

            //2) Create Command
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            sqlCommand.CommandText = "Course_LastCourse";


            //3) Execute Query and Read data
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            Course course = null;

            if (sqlDataReader.Read())
            {
                course = new Course();
                course.CouID = sqlDataReader.GetInt32(0);
                if (!sqlDataReader.IsDBNull(1))
                    course.CouTitle = sqlDataReader.GetString(1);
                if (!sqlDataReader.IsDBNull(2))
                    course.GroupNumber = sqlDataReader.GetString(2);
                if (!sqlDataReader.IsDBNull(3))
                    course.UnitNumber = sqlDataReader.GetInt32(3);
                if (!sqlDataReader.IsDBNull(4))
                    course.Requirement = sqlDataReader.GetString(4);

            }

            sqlConnection.Close();

            return course;
        }

        public Course SearchCourse(string Title, string GroupNum)
        {
            //1)
            string connectionString = "Data Source=ARASH-PC\\MYSQLSERVER;Initial Catalog=UniEducation;Integrated Security=true";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();

            //2)
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            sqlCommand.CommandText = "Course_SearchCourse";

            SqlParameter findParameter = sqlCommand.Parameters.Add("Title", System.Data.SqlDbType.NVarChar);
            findParameter.Value = Title;
            SqlParameter GroupNumParameter = sqlCommand.Parameters.Add("GroupNum", System.Data.SqlDbType.NChar);
            GroupNumParameter.Value = GroupNum;

            //3)
            Course course = null;

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            if (sqlDataReader.Read())
            {
                course = new Course();

                course.CouID = sqlDataReader.GetInt32(0);
                if (!sqlDataReader.IsDBNull(1))
                    course.CouTitle = sqlDataReader.GetString(1);
                if (!sqlDataReader.IsDBNull(2))
                    course.GroupNumber = sqlDataReader.GetString(2);
                if (!sqlDataReader.IsDBNull(3))
                    course.UnitNumber = sqlDataReader.GetInt32(3);
                if (!sqlDataReader.IsDBNull(4))
                    course.Requirement = sqlDataReader.GetString(4);

            }


            sqlConnection.Close();
            return course;
        }

        public void UpdateCourse(Course course)
        {
            //1)
            string connectionString = "Data Source=ARASH-PC\\MYSQLSERVER;Initial Catalog=UniEducation;Integrated Security=true";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();

            //2)
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            sqlCommand.CommandText = "Course_UpdateCourse";

            SqlParameter IDParameter = sqlCommand.Parameters.Add("ID", System.Data.SqlDbType.Int);
            IDParameter.Value = course.CouID;
            SqlParameter TitleParameter = sqlCommand.Parameters.Add("Title", System.Data.SqlDbType.NVarChar);
            TitleParameter.Value = course.CouTitle;
            SqlParameter GrupNumParameter = sqlCommand.Parameters.Add("GroupNum", System.Data.SqlDbType.NVarChar);
            GrupNumParameter.Value = course.GroupNumber;
            SqlParameter UnitNumParameter = sqlCommand.Parameters.Add("UnitNum", System.Data.SqlDbType.NChar);
            UnitNumParameter.Value = course.UnitNumber;
            SqlParameter ReqParameter = sqlCommand.Parameters.Add("Requirement", System.Data.SqlDbType.NVarChar);
            ReqParameter.Value = course.Requirement;
            


            //3)
            sqlCommand.ExecuteNonQuery();


            sqlConnection.Close();
        }

        public void AddCourse(Course course)
        {
            //1)
            string connectionString = "Data Source=ARASH-PC\\MYSQLSERVER;Initial Catalog=UniEducation;Integrated Security=true";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();

            //2)
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            sqlCommand.CommandText = "Course_AddCourse";

            SqlParameter IDParameter = sqlCommand.Parameters.Add("ID", System.Data.SqlDbType.Int);
            IDParameter.Value = course.CouID;
            SqlParameter TitleParameter = sqlCommand.Parameters.Add("Title", System.Data.SqlDbType.NVarChar);
            TitleParameter.Value = course.CouTitle;
            SqlParameter GrupNumParameter = sqlCommand.Parameters.Add("GroupNum", System.Data.SqlDbType.NVarChar);
            GrupNumParameter.Value = course.GroupNumber;
            SqlParameter UnitNumParameter = sqlCommand.Parameters.Add("UnitNum", System.Data.SqlDbType.NChar);
            UnitNumParameter.Value = course.UnitNumber;
            SqlParameter ReqParameter = sqlCommand.Parameters.Add("Requirement", System.Data.SqlDbType.NVarChar);
            ReqParameter.Value = course.Requirement;



            //3)
            sqlCommand.ExecuteNonQuery();


            sqlConnection.Close();
        }

        public void DeleteCourse(int currentCourseID)
        {
            //1)
            string connectionString = "Data Source=ARASH-PC\\MYSQLSERVER;Initial Catalog=UniEducation;Integrated Security=true";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();

            //2)
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            sqlCommand.CommandText = "Course_DeleteCourse";

            SqlParameter IDParameter = sqlCommand.Parameters.Add("ID", System.Data.SqlDbType.Int);
            IDParameter.Value = currentCourseID;

            //3)
            sqlCommand.ExecuteNonQuery();


            sqlConnection.Close();
        }
    }
}
