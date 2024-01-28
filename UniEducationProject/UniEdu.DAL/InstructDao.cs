using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniEdu.Entities;

namespace UniEdu.DAL
{
    public class InstructDao
    {
        public Instruct LoadFirstInstruct()
        {
            //Connection to SQL
            //1)Connect to SQL
            string connectionString = "Data Source=ARASH-PC\\MYSQLSERVER;Initial Catalog=UniEducation;Integrated Security=true";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();

            //2) Create Command
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = "Select top 1 * from Instruct order by ID asc";


            //3) Execute Query and Read data
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            Instruct instruct = null;

            if (sqlDataReader.Read())
            {
                instruct = new Instruct();

                instruct.ID = sqlDataReader.GetInt32(0);
                instruct.InstructorID = sqlDataReader.GetInt32(1);
                instruct.CourseID = sqlDataReader.GetInt32(2);
                instruct.Year = sqlDataReader.GetString(3);
                instruct.Semester = sqlDataReader.GetString(4);
                

            }

            sqlConnection.Close();

            return instruct;
        }

        public Instruct LoadNextInstruct(int CurrentID)
        {
            //Connection to SQL
            //1)Connect to SQL
            string connectionString = "Data Source=ARASH-PC\\MYSQLSERVER;Initial Catalog=UniEducation;Integrated Security=true";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();

            //2) Create Command
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            sqlCommand.CommandText = "Instruct_NextInstruct";

            SqlParameter IDParameter = sqlCommand.Parameters.Add("CurrentID", System.Data.SqlDbType.Int);
            IDParameter.Value = CurrentID;

            //3) Execute Query and Read data
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            Instruct instruct = null;

            if (sqlDataReader.Read())
            {
                instruct = new Instruct();

                instruct.ID = sqlDataReader.GetInt32(0);
                instruct.InstructorID = sqlDataReader.GetInt32(1);
                instruct.CourseID = sqlDataReader.GetInt32(2);
                instruct.Year = sqlDataReader.GetString(3);
                instruct.Semester = sqlDataReader.GetString(4);


            }

            sqlConnection.Close();

            return instruct;
        }

        public Instruct LoadPreviousInstruct(int currentID)
        {
            //Connection to SQL
            //1)Connect to SQL
            string connectionString = "Data Source=ARASH-PC\\MYSQLSERVER;Initial Catalog=UniEducation;Integrated Security=true";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();

            //2) Create Command
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            sqlCommand.CommandText = "Instruct_PreviousInstruct";

            SqlParameter IDParameter = sqlCommand.Parameters.Add("CurrentID", System.Data.SqlDbType.Int);
            IDParameter.Value = currentID;

            //3) Execute Query and Read data
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            Instruct instruct = null;

            if (sqlDataReader.Read())
            {
                instruct = new Instruct();

                instruct.ID = sqlDataReader.GetInt32(0);
                instruct.InstructorID = sqlDataReader.GetInt32(1);
                instruct.CourseID = sqlDataReader.GetInt32(2);
                instruct.Year = sqlDataReader.GetString(3);
                instruct.Semester = sqlDataReader.GetString(4);


            }

            sqlConnection.Close();

            return instruct;
        }

        public Instruct LoadLastInstruct()
        {
            //Connection to SQL
            //1)Connect to SQL
            string connectionString = "Data Source=ARASH-PC\\MYSQLSERVER;Initial Catalog=UniEducation;Integrated Security=true";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();

            //2) Create Command
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            sqlCommand.CommandText = "Instruct_LastInstruct";


            //3) Execute Query and Read data
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            Instruct instruct = null;

            if (sqlDataReader.Read())
            {
                instruct = new Instruct();

                instruct.ID = sqlDataReader.GetInt32(0);
                instruct.InstructorID = sqlDataReader.GetInt32(1);
                instruct.CourseID = sqlDataReader.GetInt32(2);
                instruct.Year = sqlDataReader.GetString(3);
                instruct.Semester = sqlDataReader.GetString(4);


            }

            sqlConnection.Close();

            return instruct;
        }

        public Instruct SearchInstruct(int ID)
        {
            //Connection to SQL
            //1)Connect to SQL
            string connectionString = "Data Source=ARASH-PC\\MYSQLSERVER;Initial Catalog=UniEducation;Integrated Security=true";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();

            //2) Create Command
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            sqlCommand.CommandText = "Instruct_SearchInstruct";

            SqlParameter IDParameter = sqlCommand.Parameters.Add("ID", System.Data.SqlDbType.Int);
            IDParameter.Value = ID;

            //3) Execute Query and Read data
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            Instruct instruct = null;

            if (sqlDataReader.Read())
            {
                instruct = new Instruct();

                instruct.ID = sqlDataReader.GetInt32(0);
                instruct.InstructorID = sqlDataReader.GetInt32(1);
                instruct.CourseID = sqlDataReader.GetInt32(2);
                instruct.Year = sqlDataReader.GetString(3);
                instruct.Semester = sqlDataReader.GetString(4);


            }

            sqlConnection.Close();

            return instruct;
        }

        public void UpdateInstruct(Instruct instruct)
        {
            //Connection to SQL
            //1)Connect to SQL
            string connectionString = "Data Source=ARASH-PC\\MYSQLSERVER;Initial Catalog=UniEducation;Integrated Security=true";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();

            //2) Create Command
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            sqlCommand.CommandText = "Instruct_UpdateInstruct";

            SqlParameter IDParameter = sqlCommand.Parameters.Add("ID", System.Data.SqlDbType.Int);
            IDParameter.Value = instruct.ID;
            SqlParameter InstIDParameter = sqlCommand.Parameters.Add("InstID", System.Data.SqlDbType.Int);
            InstIDParameter.Value = instruct.InstructorID;
            SqlParameter CouIDParameter = sqlCommand.Parameters.Add("CourseID", System.Data.SqlDbType.Int);
            CouIDParameter.Value = instruct.CourseID;
            SqlParameter YearParameter = sqlCommand.Parameters.Add("Year", System.Data.SqlDbType.NVarChar);
            YearParameter.Value = instruct.Year;
            SqlParameter SemesterParameter = sqlCommand.Parameters.Add("Semester", System.Data.SqlDbType.NVarChar);
            SemesterParameter.Value = instruct.Semester;
           
            //3)
            sqlCommand.ExecuteNonQuery();


            sqlConnection.Close();
        }

        public void AddInstruct(Instruct instruct)
        {
            //Connection to SQL
            //1)Connect to SQL
            string connectionString = "Data Source=ARASH-PC\\MYSQLSERVER;Initial Catalog=UniEducation;Integrated Security=true";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();

            //2) Create Command
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            sqlCommand.CommandText = "Instruct_AddInstruct";

            SqlParameter IDParameter = sqlCommand.Parameters.Add("ID", System.Data.SqlDbType.Int);
            IDParameter.Value = instruct.ID;
            SqlParameter InstIDParameter = sqlCommand.Parameters.Add("InstID", System.Data.SqlDbType.Int);
            InstIDParameter.Value = instruct.InstructorID;
            SqlParameter CouIDParameter = sqlCommand.Parameters.Add("CourseID", System.Data.SqlDbType.Int);
            CouIDParameter.Value = instruct.CourseID;
            SqlParameter YearParameter = sqlCommand.Parameters.Add("Year", System.Data.SqlDbType.NVarChar);
            YearParameter.Value = instruct.Year;
            SqlParameter SemesterParameter = sqlCommand.Parameters.Add("Semester", System.Data.SqlDbType.NVarChar);
            SemesterParameter.Value = instruct.Semester;

            //3)
            sqlCommand.ExecuteNonQuery();


            sqlConnection.Close();
        }

        public void DeleteInstruct(int currentID)
        {
            //1)
            string connectionString = "Data Source=ARASH-PC\\MYSQLSERVER;Initial Catalog=UniEducation;Integrated Security=true";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();

            //2)
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            sqlCommand.CommandText = "Instruct_DeleteInstruct";

            SqlParameter IDParameter = sqlCommand.Parameters.Add("ID", System.Data.SqlDbType.Int);
            IDParameter.Value = currentID;

            //3)
            sqlCommand.ExecuteNonQuery();


            sqlConnection.Close();
        }
    }
}
