using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniEdu.Entities;

namespace UniEdu.DAL
{
    public class InstructorDao
    {
        public Instructor LoadFirstInstructor()
        {
            //Connection to SQL
            //1)Connect to SQL
            string connectionString = "Data Source=ARASH-PC\\MYSQLSERVER;Initial Catalog=UniEducation;Integrated Security=true";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();

            //2) Create Command
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = "Select top 1 * from Instructor";


            //3) Execute Query and Read data
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            Instructor instructor = null;

            if (sqlDataReader.Read())
            {
                instructor = new Instructor();
                instructor.InstID = sqlDataReader.GetInt32(0);
                if (!sqlDataReader.IsDBNull(1))
                    instructor.InstFName = sqlDataReader.GetString(1);
                if (!sqlDataReader.IsDBNull(2))
                    instructor.InstLName = sqlDataReader.GetString(2);
                if (!sqlDataReader.IsDBNull(3))
                    instructor.InstPhone = sqlDataReader.GetString(3);
                if (!sqlDataReader.IsDBNull(4))
                    instructor.InstEmail = sqlDataReader.GetString(4);
                if (!sqlDataReader.IsDBNull(5))
                    instructor.Degree = sqlDataReader.GetString(5);
                if (!sqlDataReader.IsDBNull(6))
                    instructor.InstGender = sqlDataReader.GetString(6);
                if (!sqlDataReader.IsDBNull(7))
                    instructor.InstNumber = sqlDataReader.GetString(7);
                if (!sqlDataReader.IsDBNull(8))
                    instructor.InstNationalCode = sqlDataReader.GetString(8);


            }

            sqlConnection.Close();

            return instructor;
        }

        public Instructor LoadNextInstructor(int currentInstructorID)
        {
            //1)
            string connectionString = "Data Source=ARASH-PC\\MYSQLSERVER;Initial Catalog=UniEducation;Integrated Security=true";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();

            //2)
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            sqlCommand.CommandText = "Instructor_NextInstructor";

            SqlParameter IDParameter = sqlCommand.Parameters.Add("CurrentID", System.Data.SqlDbType.Int);
            IDParameter.Value = currentInstructorID;

            //3)
            Instructor instructor = null;

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            if (sqlDataReader.Read())
            {
                instructor = new Instructor();

                instructor.InstID = sqlDataReader.GetInt32(0);
                if (!sqlDataReader.IsDBNull(1))
                    instructor.InstFName = sqlDataReader.GetString(1);
                if (!sqlDataReader.IsDBNull(2))
                    instructor.InstLName = sqlDataReader.GetString(2);
                if (!sqlDataReader.IsDBNull(3))
                    instructor.InstPhone = sqlDataReader.GetString(3);
                if (!sqlDataReader.IsDBNull(4))
                    instructor.InstEmail = sqlDataReader.GetString(4);
                if (!sqlDataReader.IsDBNull(5))
                    instructor.Degree = sqlDataReader.GetString(5);
                if (!sqlDataReader.IsDBNull(6))
                    instructor.InstGender = sqlDataReader.GetString(6);
                if (!sqlDataReader.IsDBNull(7))
                    instructor.InstNumber = sqlDataReader.GetString(7);
                if (!sqlDataReader.IsDBNull(8))
                    instructor.InstNationalCode = sqlDataReader.GetString(8);

            }


            sqlConnection.Close();
            return instructor;
        }

        public Instructor LoadPreviousInstructor(int currentInstructorID)
        {
            //1)
            string connectionString = "Data Source=ARASH-PC\\MYSQLSERVER;Initial Catalog=UniEducation;Integrated Security=true";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();

            //2)
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            sqlCommand.CommandText = "Instructor_PreviousInstructor";

            SqlParameter IDParameter = sqlCommand.Parameters.Add("CurrentID", System.Data.SqlDbType.Int);
            IDParameter.Value = currentInstructorID;

            //3)
            Instructor instructor = null;

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            if (sqlDataReader.Read())
            {
                instructor = new Instructor();

                instructor.InstID = sqlDataReader.GetInt32(0);
                if (!sqlDataReader.IsDBNull(1))
                    instructor.InstFName = sqlDataReader.GetString(1);
                if (!sqlDataReader.IsDBNull(2))
                    instructor.InstLName = sqlDataReader.GetString(2);
                if (!sqlDataReader.IsDBNull(3))
                    instructor.InstPhone = sqlDataReader.GetString(3);
                if (!sqlDataReader.IsDBNull(4))
                    instructor.InstEmail = sqlDataReader.GetString(4);
                if (!sqlDataReader.IsDBNull(5))
                    instructor.Degree = sqlDataReader.GetString(5);
                if (!sqlDataReader.IsDBNull(6))
                    instructor.InstGender = sqlDataReader.GetString(6);
                if (!sqlDataReader.IsDBNull(7))
                    instructor.InstNumber = sqlDataReader.GetString(7);
                if (!sqlDataReader.IsDBNull(8))
                    instructor.InstNationalCode = sqlDataReader.GetString(8);

            }


            sqlConnection.Close();
            return instructor;
        }

        public Instructor LoadLastInstructor()
        {
            //1)
            string connectionString = "Data Source=ARASH-PC\\MYSQLSERVER;Initial Catalog=UniEducation;Integrated Security=true";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();

            //2)
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            sqlCommand.CommandText = "Instructor_LastInstructor";


            //3)
            Instructor instructor = null;

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            if (sqlDataReader.Read())
            {
                instructor = new Instructor();

                instructor.InstID = sqlDataReader.GetInt32(0);
                if (!sqlDataReader.IsDBNull(1))
                    instructor.InstFName = sqlDataReader.GetString(1);
                if (!sqlDataReader.IsDBNull(2))
                    instructor.InstLName = sqlDataReader.GetString(2);
                if (!sqlDataReader.IsDBNull(3))
                    instructor.InstPhone = sqlDataReader.GetString(3);
                if (!sqlDataReader.IsDBNull(4))
                    instructor.InstEmail = sqlDataReader.GetString(4);
                if (!sqlDataReader.IsDBNull(5))
                    instructor.Degree = sqlDataReader.GetString(5);
                if (!sqlDataReader.IsDBNull(6))
                    instructor.InstGender = sqlDataReader.GetString(6);
                if (!sqlDataReader.IsDBNull(7))
                    instructor.InstNumber = sqlDataReader.GetString(7);
                if (!sqlDataReader.IsDBNull(8))
                    instructor.InstNationalCode = sqlDataReader.GetString(8);

            }


            sqlConnection.Close();
            return instructor;
        }

        public Instructor SearchInstructor(string find)
        {
            //1)
            string connectionString = "Data Source=ARASH-PC\\MYSQLSERVER;Initial Catalog=UniEducation;Integrated Security=true";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();

            //2)
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            sqlCommand.CommandText = "Instructor_SearchInstructor";

            SqlParameter findParameter = sqlCommand.Parameters.Add("find", System.Data.SqlDbType.NChar);
            findParameter.Value = find;

            //3)
            Instructor instructor = null;

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            if (sqlDataReader.Read())
            {
                instructor = new Instructor();

                instructor.InstID = sqlDataReader.GetInt32(0);
                if (!sqlDataReader.IsDBNull(1))
                    instructor.InstFName = sqlDataReader.GetString(1);
                if (!sqlDataReader.IsDBNull(2))
                    instructor.InstLName = sqlDataReader.GetString(2);
                if (!sqlDataReader.IsDBNull(3))
                    instructor.InstPhone = sqlDataReader.GetString(3);
                if (!sqlDataReader.IsDBNull(4))
                    instructor.InstEmail = sqlDataReader.GetString(4);
                if (!sqlDataReader.IsDBNull(5))
                    instructor.Degree = sqlDataReader.GetString(5);
                if (!sqlDataReader.IsDBNull(6))
                    instructor.InstGender = sqlDataReader.GetString(6);
                if (!sqlDataReader.IsDBNull(7))
                    instructor.InstNumber = sqlDataReader.GetString(7);
                if (!sqlDataReader.IsDBNull(8))
                    instructor.InstNationalCode = sqlDataReader.GetString(8);

            }


            sqlConnection.Close();
            return instructor;
        }

        public void UpdateInstructor(Instructor instructor)
        {
            //1)
            string connectionString = "Data Source=ARASH-PC\\MYSQLSERVER;Initial Catalog=UniEducation;Integrated Security=true";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();

            //2)
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            sqlCommand.CommandText = "Instructor_UpdateInstructor";

            SqlParameter IDParameter = sqlCommand.Parameters.Add("ID", System.Data.SqlDbType.Int);
            IDParameter.Value = instructor.InstID;
            SqlParameter FNameParameter = sqlCommand.Parameters.Add("FName", System.Data.SqlDbType.NVarChar);
            FNameParameter.Value = instructor.InstFName;
            SqlParameter LNameParameter = sqlCommand.Parameters.Add("LName", System.Data.SqlDbType.NVarChar);
            LNameParameter.Value = instructor.InstLName;
            SqlParameter PhoneParameter = sqlCommand.Parameters.Add("PhoneNumber", System.Data.SqlDbType.NChar);
            PhoneParameter.Value = instructor.InstPhone;
            SqlParameter EmailParameter = sqlCommand.Parameters.Add("Email", System.Data.SqlDbType.NVarChar);
            EmailParameter.Value = instructor.InstEmail;
            SqlParameter DegreeParameter = sqlCommand.Parameters.Add("Degree", System.Data.SqlDbType.NVarChar);
            DegreeParameter.Value = instructor.Degree;
            SqlParameter GenderParameter = sqlCommand.Parameters.Add("Gender", System.Data.SqlDbType.NVarChar);
            GenderParameter.Value = instructor.InstGender;
            SqlParameter InstNumParameter = sqlCommand.Parameters.Add("InstNumber", System.Data.SqlDbType.NChar);
            InstNumParameter.Value = instructor.InstNumber;
            SqlParameter NCodeParameter = sqlCommand.Parameters.Add("NCode", System.Data.SqlDbType.NChar);
            NCodeParameter.Value = instructor.InstNationalCode;


            //3)
            sqlCommand.ExecuteNonQuery();


            sqlConnection.Close();

        }

        public void AddInstructor(Instructor instructor)
        {
            //1)
            string connectionString = "Data Source=ARASH-PC\\MYSQLSERVER;Initial Catalog=UniEducation;Integrated Security=true";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();

            //2)
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            sqlCommand.CommandText = "Instructor_AddInstructor";

            SqlParameter IDParameter = sqlCommand.Parameters.Add("ID", System.Data.SqlDbType.Int);
            IDParameter.Value = instructor.InstID;
            SqlParameter FNameParameter = sqlCommand.Parameters.Add("FName", System.Data.SqlDbType.NVarChar);
            FNameParameter.Value = instructor.InstFName;
            SqlParameter LNameParameter = sqlCommand.Parameters.Add("LName", System.Data.SqlDbType.NVarChar);
            LNameParameter.Value = instructor.InstLName;
            SqlParameter PhoneParameter = sqlCommand.Parameters.Add("PhoneNumber", System.Data.SqlDbType.NChar);
            PhoneParameter.Value = instructor.InstPhone;
            SqlParameter EmailParameter = sqlCommand.Parameters.Add("Email", System.Data.SqlDbType.NVarChar);
            EmailParameter.Value = instructor.InstEmail;
            SqlParameter DegreeParameter = sqlCommand.Parameters.Add("Degree", System.Data.SqlDbType.NVarChar);
            DegreeParameter.Value = instructor.Degree;
            SqlParameter GenderParameter = sqlCommand.Parameters.Add("Gender", System.Data.SqlDbType.NVarChar);
            GenderParameter.Value = instructor.InstGender;
            SqlParameter InstNumParameter = sqlCommand.Parameters.Add("InstNumber", System.Data.SqlDbType.NChar);
            InstNumParameter.Value = instructor.InstNumber;
            SqlParameter NCodeParameter = sqlCommand.Parameters.Add("NCode", System.Data.SqlDbType.NChar);
            NCodeParameter.Value = instructor.InstNationalCode;


            //3)
            sqlCommand.ExecuteNonQuery();


            sqlConnection.Close();
        }

        public void DeleteInstructor(int currentInstructorID)
        {
            //1)
            string connectionString = "Data Source=ARASH-PC\\MYSQLSERVER;Initial Catalog=UniEducation;Integrated Security=true";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();

            //2)
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            sqlCommand.CommandText = "Instructor_DeleteInstructor";

            SqlParameter IDParameter = sqlCommand.Parameters.Add("ID", System.Data.SqlDbType.Int);
            IDParameter.Value = currentInstructorID;

            //3)
            sqlCommand.ExecuteNonQuery();


            sqlConnection.Close();
        }
    }
}
