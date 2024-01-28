using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniEdu.Entities;

namespace UniEdu.DAL
{
    public class PresentDao
    {
        public Present LoadFirstPresent()
        {
            //Connection to SQL
            //1)Connect to SQL
            string connectionString = "Data Source=ARASH-PC\\MYSQLSERVER;Initial Catalog=UniEducation;Integrated Security=true";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();

            //2) Create Command
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = "Select top 1 * from Present order by ID asc";


            //3) Execute Query and Read data
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            Present present = null;

            if (sqlDataReader.Read())
            {
                present = new Present();

                present.ID = sqlDataReader.GetInt32(0);
                present.ClassID = sqlDataReader.GetInt32(1);
                present.CourseID = sqlDataReader.GetInt32(2);
                if (!sqlDataReader.IsDBNull(3))
                    present.InstructorID = sqlDataReader.GetInt32(3);

                present.Year = sqlDataReader.GetString(4);
                present.Semester = sqlDataReader.GetString(5);
                present.Day = sqlDataReader.GetString(6);
                present.ClassBeginTime = sqlDataReader.GetTimeSpan(7);
                present.ClassFinishTime = sqlDataReader.GetTimeSpan(8);

            }

            sqlConnection.Close();

            return present;
        }

        public Present LoadNextPresent(int currentID)
        {
            //Connection to SQL
            //1)Connect to SQL
            string connectionString = "Data Source=ARASH-PC\\MYSQLSERVER;Initial Catalog=UniEducation;Integrated Security=true";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();

            //2) Create Command
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            sqlCommand.CommandText = "Present_NextPresent";

            SqlParameter IDParameter = sqlCommand.Parameters.Add("CurrentID", System.Data.SqlDbType.Int);
            IDParameter.Value = currentID;

            //3) Execute Query and Read data
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            Present present = null;

            if (sqlDataReader.Read())
            {
                present = new Present();

                present.ID = sqlDataReader.GetInt32(0);
                present.ClassID = sqlDataReader.GetInt32(1);
                present.CourseID = sqlDataReader.GetInt32(2);
                if (!sqlDataReader.IsDBNull(3))
                    present.InstructorID = sqlDataReader.GetInt32(3);

                present.Year = sqlDataReader.GetString(4);
                present.Semester = sqlDataReader.GetString(5);
                present.Day = sqlDataReader.GetString(6);
                present.ClassBeginTime = sqlDataReader.GetTimeSpan(7);
                present.ClassFinishTime = sqlDataReader.GetTimeSpan(8);

            }

            sqlConnection.Close();

            return present;
        }

        public Present LoadPreviousPresent(int currentID)
        {
            //Connection to SQL
            //1)Connect to SQL
            string connectionString = "Data Source=ARASH-PC\\MYSQLSERVER;Initial Catalog=UniEducation;Integrated Security=true";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();

            //2) Create Command
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            sqlCommand.CommandText = "Present_PreviousPresent";

            SqlParameter IDParameter = sqlCommand.Parameters.Add("CurrentID", System.Data.SqlDbType.Int);
            IDParameter.Value = currentID;

            //3) Execute Query and Read data
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            Present present = null;

            if (sqlDataReader.Read())
            {
                present = new Present();

                present.ID = sqlDataReader.GetInt32(0);
                present.ClassID = sqlDataReader.GetInt32(1);
                present.CourseID = sqlDataReader.GetInt32(2);
                if (!sqlDataReader.IsDBNull(3))
                    present.InstructorID = sqlDataReader.GetInt32(3);

                present.Year = sqlDataReader.GetString(4);
                present.Semester = sqlDataReader.GetString(5);
                present.Day = sqlDataReader.GetString(6);
                present.ClassBeginTime = sqlDataReader.GetTimeSpan(7);
                present.ClassFinishTime = sqlDataReader.GetTimeSpan(8);

            }

            sqlConnection.Close();

            return present;
        }

        public Present LoadLastPresent()
        {
            //Connection to SQL
            //1)Connect to SQL
            string connectionString = "Data Source=ARASH-PC\\MYSQLSERVER;Initial Catalog=UniEducation;Integrated Security=true";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();

            //2) Create Command
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            sqlCommand.CommandText = "Present_LastPresent";


            //3) Execute Query and Read data
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            Present present = null;

            if (sqlDataReader.Read())
            {
                present = new Present();

                present.ID = sqlDataReader.GetInt32(0);
                present.ClassID = sqlDataReader.GetInt32(1);
                present.CourseID = sqlDataReader.GetInt32(2);
                if (!sqlDataReader.IsDBNull(3))
                    present.InstructorID = sqlDataReader.GetInt32(3);

                present.Year = sqlDataReader.GetString(4);
                present.Semester = sqlDataReader.GetString(5);
                present.Day = sqlDataReader.GetString(6);
                present.ClassBeginTime = sqlDataReader.GetTimeSpan(7);
                present.ClassFinishTime = sqlDataReader.GetTimeSpan(8);

            }

            sqlConnection.Close();

            return present;
        }

        public Present SearchPresent(int currentID)
        {
            //Connection to SQL
            //1)Connect to SQL
            string connectionString = "Data Source=ARASH-PC\\MYSQLSERVER;Initial Catalog=UniEducation;Integrated Security=true";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();

            //2) Create Command
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            sqlCommand.CommandText = "Present_SearchPresent";

            SqlParameter IDParameter = sqlCommand.Parameters.Add("ID", System.Data.SqlDbType.Int);
            IDParameter.Value = currentID;
            //3) Execute Query and Read data
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            Present present = null;

            if (sqlDataReader.Read())
            {
                present = new Present();

                present.ID = sqlDataReader.GetInt32(0);
                present.ClassID = sqlDataReader.GetInt32(1);
                present.CourseID = sqlDataReader.GetInt32(2);
                if (!sqlDataReader.IsDBNull(3))
                    present.InstructorID = sqlDataReader.GetInt32(3);

                present.Year = sqlDataReader.GetString(4);
                present.Semester = sqlDataReader.GetString(5);
                present.Day = sqlDataReader.GetString(6);
                present.ClassBeginTime = sqlDataReader.GetTimeSpan(7);
                present.ClassFinishTime = sqlDataReader.GetTimeSpan(8);

            }

            sqlConnection.Close();

            return present;
        }

        public void UpdatePresent(Present present)
        {
            //Connection to SQL
            //1)Connect to SQL
            string connectionString = "Data Source=ARASH-PC\\MYSQLSERVER;Initial Catalog=UniEducation;Integrated Security=true";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();

            //2) Create Command
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            sqlCommand.CommandText = "Present_UpdatePresent";

            SqlParameter IDParameter = sqlCommand.Parameters.Add("ID", System.Data.SqlDbType.Int);
            IDParameter.Value = present.ID;
            SqlParameter CIDParameter = sqlCommand.Parameters.Add("ClassID", System.Data.SqlDbType.Int);
            CIDParameter.Value = present.ClassID;
            SqlParameter CouIDParameter = sqlCommand.Parameters.Add("CourseID", System.Data.SqlDbType.Int);
            CouIDParameter.Value = present.CourseID;
            SqlParameter InstIDParameter = sqlCommand.Parameters.Add("InstID", System.Data.SqlDbType.Int);
            InstIDParameter.Value = present.InstructorID;
            SqlParameter YearParameter = sqlCommand.Parameters.Add("Year", System.Data.SqlDbType.NVarChar);
            YearParameter.Value = present.Year;
            SqlParameter SemesterParameter = sqlCommand.Parameters.Add("Semester", System.Data.SqlDbType.NVarChar);
            SemesterParameter.Value = present.Semester;
            SqlParameter DayParameter = sqlCommand.Parameters.Add("Day", System.Data.SqlDbType.NVarChar);
            DayParameter.Value = present.Day;
            SqlParameter CBeginTimeParameter = sqlCommand.Parameters.Add("ClassBeginTime", System.Data.SqlDbType.Time);
            CBeginTimeParameter.Value = present.ClassBeginTime;
            SqlParameter CFinishTimeParameter = sqlCommand.Parameters.Add("ClassFinishTime", System.Data.SqlDbType.Time);
            CFinishTimeParameter.Value = present.ClassFinishTime;


            //3)
            sqlCommand.ExecuteNonQuery();


            sqlConnection.Close();
        }

        public void AddPresent(Present present)
        {
            //Connection to SQL
            //1)Connect to SQL
            string connectionString = "Data Source=ARASH-PC\\MYSQLSERVER;Initial Catalog=UniEducation;Integrated Security=true";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();

            //2) Create Command
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            sqlCommand.CommandText = "Present_AddPresent";

            SqlParameter IDParameter = sqlCommand.Parameters.Add("ID", System.Data.SqlDbType.Int);
            IDParameter.Value = present.ID;
            SqlParameter CIDParameter = sqlCommand.Parameters.Add("ClassID", System.Data.SqlDbType.Int);
            CIDParameter.Value = present.ClassID;
            SqlParameter CouIDParameter = sqlCommand.Parameters.Add("CourseID", System.Data.SqlDbType.Int);
            CouIDParameter.Value = present.CourseID;
            SqlParameter InstIDParameter = sqlCommand.Parameters.Add("InstID", System.Data.SqlDbType.Int);
            InstIDParameter.Value = present.InstructorID;
            SqlParameter YearParameter = sqlCommand.Parameters.Add("Year", System.Data.SqlDbType.NVarChar);
            YearParameter.Value = present.Year;
            SqlParameter SemesterParameter = sqlCommand.Parameters.Add("Semester", System.Data.SqlDbType.NVarChar);
            SemesterParameter.Value = present.Semester;
            SqlParameter DayParameter = sqlCommand.Parameters.Add("Day", System.Data.SqlDbType.NVarChar);
            DayParameter.Value = present.Day;
            SqlParameter CBeginTimeParameter = sqlCommand.Parameters.Add("ClassBeginTime", System.Data.SqlDbType.Time);
            CBeginTimeParameter.Value = present.ClassBeginTime;
            SqlParameter CFinishTimeParameter = sqlCommand.Parameters.Add("ClassFinishTime", System.Data.SqlDbType.Time);
            CFinishTimeParameter.Value = present.ClassFinishTime;


            //3)
            sqlCommand.ExecuteNonQuery();


            sqlConnection.Close();
        }

        public void DeletePresent(int currentID)
        {
            //1)
            string connectionString = "Data Source=ARASH-PC\\MYSQLSERVER;Initial Catalog=UniEducation;Integrated Security=true";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();

            //2)
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            sqlCommand.CommandText = "Present_DeletePresent";

            SqlParameter IDParameter = sqlCommand.Parameters.Add("ID", System.Data.SqlDbType.Int);
            IDParameter.Value = currentID;

            //3)
            sqlCommand.ExecuteNonQuery();


            sqlConnection.Close();
        }
    }
}
