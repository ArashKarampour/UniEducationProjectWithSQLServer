using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniEdu.Entities;

namespace UniEdu.DAL
{
    public class EnrollDao
    {
        public Enroll LoadFirstEnroll()
        {
            //Connection to SQL
            //1)Connect to SQL
            string connectionString = "Data Source=ARASH-PC\\MYSQLSERVER;Initial Catalog=UniEducation;Integrated Security=true";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();

            //2) Create Command
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = "Select top 1 * from Enroll order by ID asc";


            //3) Execute Query and Read data
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            Enroll enroll = null;

            if (sqlDataReader.Read())
            {
                enroll = new Enroll();

                enroll.ID = sqlDataReader.GetInt32(0);
                enroll.StudentID = sqlDataReader.GetInt32(1);
                enroll.CourseID = sqlDataReader.GetInt32(2);

                if (!sqlDataReader.IsDBNull(3))
                    enroll.InstructorID = sqlDataReader.GetInt32(3);
                if (!sqlDataReader.IsDBNull(4))
                    enroll.ClassID = sqlDataReader.GetInt32(4);
                if (!sqlDataReader.IsDBNull(5))
                    enroll.Status = sqlDataReader.GetString(5);
                if (!sqlDataReader.IsDBNull(6))
                    enroll.Point = sqlDataReader.GetDouble(6);
                
                enroll.Year = sqlDataReader.GetString(7);
                enroll.Semester = sqlDataReader.GetString(8);
                enroll.Day = sqlDataReader.GetString(9);
                enroll.CourseBeginTime = sqlDataReader.GetTimeSpan(10);
                enroll.CourseFinishTime = sqlDataReader.GetTimeSpan(11);

            }

            sqlConnection.Close();

            return enroll;
        }

        public Enroll LoadNextEnroll(int currentID)
        {
            //1)
            string connectionString = "Data Source=ARASH-PC\\MYSQLSERVER;Initial Catalog=UniEducation;Integrated Security=true";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();

            //2)
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            sqlCommand.CommandText = "Enroll_NextEnroll";

            SqlParameter IDParameter = sqlCommand.Parameters.Add("CurrentID", System.Data.SqlDbType.Int);
            IDParameter.Value = currentID;

            //3)
            Enroll enroll = null;

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            if (sqlDataReader.Read())
            {
                enroll = new Enroll();

                enroll.ID = sqlDataReader.GetInt32(0);
                enroll.StudentID = sqlDataReader.GetInt32(1);
                enroll.CourseID = sqlDataReader.GetInt32(2);

                if (!sqlDataReader.IsDBNull(3))
                    enroll.InstructorID = sqlDataReader.GetInt32(3);
                if (!sqlDataReader.IsDBNull(4))
                    enroll.ClassID = sqlDataReader.GetInt32(4);
                if (!sqlDataReader.IsDBNull(5))
                    enroll.Status = sqlDataReader.GetString(5);
                if (!sqlDataReader.IsDBNull(6))
                    enroll.Point = sqlDataReader.GetDouble(6);

                enroll.Year = sqlDataReader.GetString(7);
                enroll.Semester = sqlDataReader.GetString(8);
                enroll.Day = sqlDataReader.GetString(9);
                enroll.CourseBeginTime = sqlDataReader.GetTimeSpan(10);
                enroll.CourseFinishTime = sqlDataReader.GetTimeSpan(11);

            }


            sqlConnection.Close();
            return enroll;
        }

        public Enroll LoadPreviousEnroll(int currentID)
        {
            //1)
            string connectionString = "Data Source=ARASH-PC\\MYSQLSERVER;Initial Catalog=UniEducation;Integrated Security=true";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();

            //2)
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            sqlCommand.CommandText = "Enroll_PreviousEnroll";

            SqlParameter IDParameter = sqlCommand.Parameters.Add("CurrentID", System.Data.SqlDbType.Int);
            IDParameter.Value = currentID;

            //3)
            Enroll enroll = null;

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            if (sqlDataReader.Read())
            {
                enroll = new Enroll();

                enroll.ID = sqlDataReader.GetInt32(0);
                enroll.StudentID = sqlDataReader.GetInt32(1);
                enroll.CourseID = sqlDataReader.GetInt32(2);

                if (!sqlDataReader.IsDBNull(3))
                    enroll.InstructorID = sqlDataReader.GetInt32(3);
                if (!sqlDataReader.IsDBNull(4))
                    enroll.ClassID = sqlDataReader.GetInt32(4);
                if (!sqlDataReader.IsDBNull(5))
                    enroll.Status = sqlDataReader.GetString(5);
                if (!sqlDataReader.IsDBNull(6))
                    enroll.Point = sqlDataReader.GetDouble(6);

                enroll.Year = sqlDataReader.GetString(7);
                enroll.Semester = sqlDataReader.GetString(8);
                enroll.Day = sqlDataReader.GetString(9);
                enroll.CourseBeginTime = sqlDataReader.GetTimeSpan(10);
                enroll.CourseFinishTime = sqlDataReader.GetTimeSpan(11);

            }


            sqlConnection.Close();
            return enroll;
        }

        public Enroll LoadLastEnroll()
        {
            //Connection to SQL
            //1)Connect to SQL
            string connectionString = "Data Source=ARASH-PC\\MYSQLSERVER;Initial Catalog=UniEducation;Integrated Security=true";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();

            //2) Create Command
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            sqlCommand.CommandText = "Enroll_LastEnroll";


            //3) Execute Query and Read data
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            Enroll enroll = null;

            if (sqlDataReader.Read())
            {
                enroll = new Enroll();

                enroll.ID = sqlDataReader.GetInt32(0);
                enroll.StudentID = sqlDataReader.GetInt32(1);
                enroll.CourseID = sqlDataReader.GetInt32(2);

                if (!sqlDataReader.IsDBNull(3))
                    enroll.InstructorID = sqlDataReader.GetInt32(3);
                if (!sqlDataReader.IsDBNull(4))
                    enroll.ClassID = sqlDataReader.GetInt32(4);
                if (!sqlDataReader.IsDBNull(5))
                    enroll.Status = sqlDataReader.GetString(5);
                if (!sqlDataReader.IsDBNull(6))
                    enroll.Point = sqlDataReader.GetDouble(6);

                enroll.Year = sqlDataReader.GetString(7);
                enroll.Semester = sqlDataReader.GetString(8);
                enroll.Day = sqlDataReader.GetString(9);
                enroll.CourseBeginTime = sqlDataReader.GetTimeSpan(10);
                enroll.CourseFinishTime = sqlDataReader.GetTimeSpan(11);

            }

            sqlConnection.Close();

            return enroll;
        }

        public Enroll SearchEnroll(int ID)
        {
            //1)
            string connectionString = "Data Source=ARASH-PC\\MYSQLSERVER;Initial Catalog=UniEducation;Integrated Security=true";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();

            //2)
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            sqlCommand.CommandText = "Enroll_SearchEnroll";

            SqlParameter IDParameter = sqlCommand.Parameters.Add("ID", System.Data.SqlDbType.Int);
            IDParameter.Value = ID;

            //3)
            Enroll enroll = null;

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            if (sqlDataReader.Read())
            {
                enroll = new Enroll();

                enroll.ID = sqlDataReader.GetInt32(0);
                enroll.StudentID = sqlDataReader.GetInt32(1);
                enroll.CourseID = sqlDataReader.GetInt32(2);

                if (!sqlDataReader.IsDBNull(3))
                    enroll.InstructorID = sqlDataReader.GetInt32(3);
                if (!sqlDataReader.IsDBNull(4))
                    enroll.ClassID = sqlDataReader.GetInt32(4);
                if (!sqlDataReader.IsDBNull(5))
                    enroll.Status = sqlDataReader.GetString(5);
                if (!sqlDataReader.IsDBNull(6))
                    enroll.Point = sqlDataReader.GetDouble(6);

                enroll.Year = sqlDataReader.GetString(7);
                enroll.Semester = sqlDataReader.GetString(8);
                enroll.Day = sqlDataReader.GetString(9);
                enroll.CourseBeginTime = sqlDataReader.GetTimeSpan(10);
                enroll.CourseFinishTime = sqlDataReader.GetTimeSpan(11);

            }


            sqlConnection.Close();
            return enroll;
        }

        public void UpdateEnroll(Enroll enroll)
        {
            //1)
            string connectionString = "Data Source=ARASH-PC\\MYSQLSERVER;Initial Catalog=UniEducation;Integrated Security=true";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();

            //2)
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            sqlCommand.CommandText = "Enroll_UpdateEnroll";

            SqlParameter IDParameter = sqlCommand.Parameters.Add("ID", System.Data.SqlDbType.Int);
            IDParameter.Value = enroll.ID;
            SqlParameter SIDParameter = sqlCommand.Parameters.Add("SID", System.Data.SqlDbType.Int);
            SIDParameter.Value = enroll.StudentID;
            SqlParameter CouIDParameter = sqlCommand.Parameters.Add("CourseID", System.Data.SqlDbType.Int);
            CouIDParameter.Value = enroll.CourseID;
            SqlParameter InstIDParameter = sqlCommand.Parameters.Add("InstID", System.Data.SqlDbType.Int);
            InstIDParameter.Value = enroll.InstructorID;
            SqlParameter CIDParameter = sqlCommand.Parameters.Add("ClassID", System.Data.SqlDbType.Int);
            CIDParameter.Value = enroll.ClassID;
            SqlParameter StatusParameter = sqlCommand.Parameters.Add("Status", System.Data.SqlDbType.NVarChar);
            StatusParameter.Value = enroll.Status;
            SqlParameter PointParameter = sqlCommand.Parameters.Add("Point", System.Data.SqlDbType.Float);
            PointParameter.Value = enroll.Point;
            SqlParameter YearParameter = sqlCommand.Parameters.Add("Year", System.Data.SqlDbType.NVarChar);
            YearParameter.Value = enroll.Year;
            SqlParameter SemesterParameter = sqlCommand.Parameters.Add("Semester", System.Data.SqlDbType.NVarChar);
            SemesterParameter.Value = enroll.Semester;
            SqlParameter DayParameter = sqlCommand.Parameters.Add("Day", System.Data.SqlDbType.NVarChar);
            DayParameter.Value = enroll.Day;
            SqlParameter CBeginTimeParameter = sqlCommand.Parameters.Add("CourseBeginTime", System.Data.SqlDbType.Time);
            CBeginTimeParameter.Value = enroll.CourseBeginTime;
            SqlParameter CFinishTimeParameter = sqlCommand.Parameters.Add("CourseFinishTime", System.Data.SqlDbType.Time);
            CFinishTimeParameter.Value = enroll.CourseFinishTime;


            //3)
            sqlCommand.ExecuteNonQuery();


            sqlConnection.Close();
        }

        public void AddEnroll(Enroll enroll)
        {
            //1)
            string connectionString = "Data Source=ARASH-PC\\MYSQLSERVER;Initial Catalog=UniEducation;Integrated Security=true";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();

            //2)
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            sqlCommand.CommandText = "Enroll_AddEnroll";

            SqlParameter SIDParameter = sqlCommand.Parameters.Add("SID", System.Data.SqlDbType.Int);
            SIDParameter.Value = enroll.StudentID;
            SqlParameter CouIDParameter = sqlCommand.Parameters.Add("CourseID", System.Data.SqlDbType.Int);
            CouIDParameter.Value = enroll.CourseID;
            SqlParameter InstIDParameter = sqlCommand.Parameters.Add("InstID", System.Data.SqlDbType.Int);
            InstIDParameter.Value = enroll.InstructorID;
            SqlParameter CIDParameter = sqlCommand.Parameters.Add("ClassID", System.Data.SqlDbType.Int);
            CIDParameter.Value = enroll.ClassID;
            SqlParameter StatusParameter = sqlCommand.Parameters.Add("Status", System.Data.SqlDbType.NVarChar);
            StatusParameter.Value = enroll.Status;
            SqlParameter PointParameter = sqlCommand.Parameters.Add("Point", System.Data.SqlDbType.Float);
            PointParameter.Value = enroll.Point;
            SqlParameter YearParameter = sqlCommand.Parameters.Add("Year", System.Data.SqlDbType.NVarChar);
            YearParameter.Value = enroll.Year;
            SqlParameter SemesterParameter = sqlCommand.Parameters.Add("Semester", System.Data.SqlDbType.NVarChar);
            SemesterParameter.Value = enroll.Semester;
            SqlParameter DayParameter = sqlCommand.Parameters.Add("Day", System.Data.SqlDbType.NVarChar);
            DayParameter.Value = enroll.Day;
            SqlParameter CBeginTimeParameter = sqlCommand.Parameters.Add("CourseBeginTime", System.Data.SqlDbType.Time);
            CBeginTimeParameter.Value = enroll.CourseBeginTime;
            SqlParameter CFinishTimeParameter = sqlCommand.Parameters.Add("CourseFinishTime", System.Data.SqlDbType.Time);
            CFinishTimeParameter.Value = enroll.CourseFinishTime;


            //3)
            sqlCommand.ExecuteNonQuery();


            sqlConnection.Close();
        }

        public void DeleteEnroll(int currentID)
        {
            //1)
            string connectionString = "Data Source=ARASH-PC\\MYSQLSERVER;Initial Catalog=UniEducation;Integrated Security=true";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();

            //2)
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            sqlCommand.CommandText = "Enroll_DeleteEnroll";

            SqlParameter IDParameter = sqlCommand.Parameters.Add("ID", System.Data.SqlDbType.Int);
            IDParameter.Value = currentID;

            //3)
            sqlCommand.ExecuteNonQuery();


            sqlConnection.Close();
        }
    }
}
