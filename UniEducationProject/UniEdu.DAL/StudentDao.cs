using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniEdu.Entities;

namespace UniEdu.DAL
{
    public class StudentDao
    {
        public Student LoadFirstStudent()
        {
            //Connection to SQL
            //1)Connect to SQL
            string connectionString = "Data Source=ARASH-PC\\MYSQLSERVER;Initial Catalog=UniEducation;Integrated Security=true";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();

            //2) Create Command
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = "Select top 1 * from Student";


            //3) Execute Query and Read data
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            Student student = null;

            if (sqlDataReader.Read())
            {
                student = new Student();
                student.SID = sqlDataReader.GetInt32(0);
                if (!sqlDataReader.IsDBNull(1))
                    student.SFName = sqlDataReader.GetString(1);
                if (!sqlDataReader.IsDBNull(2))
                    student.SLName = sqlDataReader.GetString(2);
                if (!sqlDataReader.IsDBNull(3))
                    student.SPhone = sqlDataReader.GetString(3);
                if (!sqlDataReader.IsDBNull(4))
                    student.SEmail = sqlDataReader.GetString(4);
                if (!sqlDataReader.IsDBNull(5))
                    student.StNumber = sqlDataReader.GetString(5);
                if (!sqlDataReader.IsDBNull(6))
                    student.SNationalCode = sqlDataReader.GetString(6);
                if (!sqlDataReader.IsDBNull(7))
                    student.SGender = sqlDataReader.GetString(7);
                if (!sqlDataReader.IsDBNull(8))
                    student.SAverage = sqlDataReader.GetDouble(8);
                if (!sqlDataReader.IsDBNull(9))
                    student.SMajor = sqlDataReader.GetString(9);

            }

            sqlConnection.Close();

            return student;
        }

        

        public Student LoadLastStudent()
        {
            //1)
            string connectionString = "Data Source=ARASH-PC\\MYSQLSERVER;Initial Catalog=UniEducation;Integrated Security=true";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();

            //2)
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            sqlCommand.CommandText = "Student_LastStudent";


            //3)
            Student student = null;

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            if (sqlDataReader.Read())
            {
                student = new Student();

                student.SID = sqlDataReader.GetInt32(0);
                if (!sqlDataReader.IsDBNull(1))
                    student.SFName = sqlDataReader.GetString(1);
                if (!sqlDataReader.IsDBNull(2))
                    student.SLName = sqlDataReader.GetString(2);
                if (!sqlDataReader.IsDBNull(3))
                    student.SPhone = sqlDataReader.GetString(3);
                if (!sqlDataReader.IsDBNull(4))
                    student.SEmail = sqlDataReader.GetString(4);
                if (!sqlDataReader.IsDBNull(5))
                    student.StNumber = sqlDataReader.GetString(5);
                if (!sqlDataReader.IsDBNull(6))
                    student.SNationalCode = sqlDataReader.GetString(6);
                if (!sqlDataReader.IsDBNull(7))
                    student.SGender = sqlDataReader.GetString(7);
                if (!sqlDataReader.IsDBNull(8))
                    student.SAverage = sqlDataReader.GetDouble(8);
                if (!sqlDataReader.IsDBNull(9))
                    student.SMajor = sqlDataReader.GetString(9);

            }


            sqlConnection.Close();
            return student;
        }

        public Student LoadPreviousStudent(int CurrentStudentID)
        {
            //1)
            string connectionString = "Data Source=ARASH-PC\\MYSQLSERVER;Initial Catalog=UniEducation;Integrated Security=true";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();

            //2)
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            sqlCommand.CommandText = "Student_PreviousStudent";

            SqlParameter IDParameter = sqlCommand.Parameters.Add("CurrentID", System.Data.SqlDbType.Int);
            IDParameter.Value = CurrentStudentID;

            //3)
            Student student = null;

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            if (sqlDataReader.Read())
            {
                student = new Student();

                student.SID = sqlDataReader.GetInt32(0);
                if (!sqlDataReader.IsDBNull(1))
                    student.SFName = sqlDataReader.GetString(1);
                if (!sqlDataReader.IsDBNull(2))
                    student.SLName = sqlDataReader.GetString(2);
                if (!sqlDataReader.IsDBNull(3))
                    student.SPhone = sqlDataReader.GetString(3);
                if (!sqlDataReader.IsDBNull(4))
                    student.SEmail = sqlDataReader.GetString(4);
                if (!sqlDataReader.IsDBNull(5))
                    student.StNumber = sqlDataReader.GetString(5);
                if (!sqlDataReader.IsDBNull(6))
                    student.SNationalCode = sqlDataReader.GetString(6);
                if (!sqlDataReader.IsDBNull(7))
                    student.SGender = sqlDataReader.GetString(7);
                if (!sqlDataReader.IsDBNull(8))
                    student.SAverage = sqlDataReader.GetDouble(8);
                if (!sqlDataReader.IsDBNull(9))
                    student.SMajor = sqlDataReader.GetString(9);

            }


            sqlConnection.Close();
            return student;
        }

        public Student LoadNextStudent(int CurrentStudentID)
        {
            //1)
            string connectionString = "Data Source=ARASH-PC\\MYSQLSERVER;Initial Catalog=UniEducation;Integrated Security=true";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();

            //2)
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            sqlCommand.CommandText = "Student_NextStudent";

            SqlParameter IDParameter = sqlCommand.Parameters.Add("CurrentID",System.Data.SqlDbType.Int);
            IDParameter.Value = CurrentStudentID;

            //3)
            Student student = null;

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            if (sqlDataReader.Read())
            {
                student = new Student();
                
                student.SID = sqlDataReader.GetInt32(0);
                if (!sqlDataReader.IsDBNull(1))
                    student.SFName = sqlDataReader.GetString(1);
                if (!sqlDataReader.IsDBNull(2))
                    student.SLName = sqlDataReader.GetString(2);
                if (!sqlDataReader.IsDBNull(3))
                    student.SPhone = sqlDataReader.GetString(3);
                if (!sqlDataReader.IsDBNull(4))
                    student.SEmail = sqlDataReader.GetString(4);
                if (!sqlDataReader.IsDBNull(5))
                    student.StNumber = sqlDataReader.GetString(5);
                if (!sqlDataReader.IsDBNull(6))
                    student.SNationalCode = sqlDataReader.GetString(6);
                if (!sqlDataReader.IsDBNull(7))
                    student.SGender = sqlDataReader.GetString(7);
                if (!sqlDataReader.IsDBNull(8))
                    student.SAverage = sqlDataReader.GetDouble(8);
                if (!sqlDataReader.IsDBNull(9))
                    student.SMajor = sqlDataReader.GetString(9);

            }
            

            sqlConnection.Close();
            return student;
        }

        public Student SearchStudent(string find)
        {
            //1)
            string connectionString = "Data Source=ARASH-PC\\MYSQLSERVER;Initial Catalog=UniEducation;Integrated Security=true";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();

            //2)
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            sqlCommand.CommandText = "Student_SearchStudent";

            SqlParameter findParameter = sqlCommand.Parameters.Add("find", System.Data.SqlDbType.NChar);
            findParameter.Value = find;

            //3)
            Student student = null;

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            if (sqlDataReader.Read())
            {
                student = new Student();

                student.SID = sqlDataReader.GetInt32(0);
                if (!sqlDataReader.IsDBNull(1))
                    student.SFName = sqlDataReader.GetString(1);
                if (!sqlDataReader.IsDBNull(2))
                    student.SLName = sqlDataReader.GetString(2);
                if (!sqlDataReader.IsDBNull(3))
                    student.SPhone = sqlDataReader.GetString(3);
                if (!sqlDataReader.IsDBNull(4))
                    student.SEmail = sqlDataReader.GetString(4);
                if (!sqlDataReader.IsDBNull(5))
                    student.StNumber = sqlDataReader.GetString(5);
                if (!sqlDataReader.IsDBNull(6))
                    student.SNationalCode = sqlDataReader.GetString(6);
                if (!sqlDataReader.IsDBNull(7))
                    student.SGender = sqlDataReader.GetString(7);
                if (!sqlDataReader.IsDBNull(8))
                    student.SAverage = sqlDataReader.GetDouble(8);
                if (!sqlDataReader.IsDBNull(9))
                    student.SMajor = sqlDataReader.GetString(9);

            }


            sqlConnection.Close();
            return student;
        }

        public void UpdateStudent(Student student)
        {
            //1)
            string connectionString = "Data Source=ARASH-PC\\MYSQLSERVER;Initial Catalog=UniEducation;Integrated Security=true";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();

            //2)
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            sqlCommand.CommandText = "Student_UpdateStudent";

            SqlParameter IDParameter = sqlCommand.Parameters.Add("ID", System.Data.SqlDbType.Int);
            IDParameter.Value = student.SID;
            SqlParameter FNameParameter = sqlCommand.Parameters.Add("FName", System.Data.SqlDbType.NVarChar);
            FNameParameter.Value = student.SFName;
            SqlParameter LNameParameter = sqlCommand.Parameters.Add("LName", System.Data.SqlDbType.NVarChar);
            LNameParameter.Value = student.SLName;
            SqlParameter PhoneParameter = sqlCommand.Parameters.Add("PhoneNumber", System.Data.SqlDbType.NChar);
            PhoneParameter.Value = student.SPhone;
            SqlParameter EmailParameter = sqlCommand.Parameters.Add("Email", System.Data.SqlDbType.NVarChar);
            EmailParameter.Value = student.SEmail;
            SqlParameter StNumParameter = sqlCommand.Parameters.Add("StNumber", System.Data.SqlDbType.NChar);
            StNumParameter.Value = student.StNumber;
            SqlParameter NCodeParameter = sqlCommand.Parameters.Add("NCode", System.Data.SqlDbType.NChar);
            NCodeParameter.Value = student.SNationalCode;
            SqlParameter GenderParameter = sqlCommand.Parameters.Add("Gender", System.Data.SqlDbType.NVarChar);
            GenderParameter.Value = student.SGender;
            SqlParameter AverageParameter = sqlCommand.Parameters.Add("Average", System.Data.SqlDbType.Float);
            AverageParameter.Value = student.SAverage;
            SqlParameter MajorParameter = sqlCommand.Parameters.Add("Major", System.Data.SqlDbType.NVarChar);
            MajorParameter.Value = student.SMajor;


            //3)
            sqlCommand.ExecuteNonQuery();


            sqlConnection.Close();
            
        }

        public void AddStudent(Student student)
        {
            //1)
            string connectionString = "Data Source=ARASH-PC\\MYSQLSERVER;Initial Catalog=UniEducation;Integrated Security=true";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();

            //2)
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            sqlCommand.CommandText = "Student_AddStudent";

            SqlParameter IDParameter = sqlCommand.Parameters.Add("ID", System.Data.SqlDbType.Int);
            IDParameter.Value = student.SID;
            SqlParameter FNameParameter = sqlCommand.Parameters.Add("FName", System.Data.SqlDbType.NVarChar);
            FNameParameter.Value = student.SFName;
            SqlParameter LNameParameter = sqlCommand.Parameters.Add("LName", System.Data.SqlDbType.NVarChar);
            LNameParameter.Value = student.SLName;
            SqlParameter PhoneParameter = sqlCommand.Parameters.Add("PhoneNumber", System.Data.SqlDbType.NChar);
            PhoneParameter.Value = student.SPhone;
            SqlParameter EmailParameter = sqlCommand.Parameters.Add("Email", System.Data.SqlDbType.NVarChar);
            EmailParameter.Value = student.SEmail;
            SqlParameter StNumParameter = sqlCommand.Parameters.Add("StNumber", System.Data.SqlDbType.NChar);
            StNumParameter.Value = student.StNumber;
            SqlParameter NCodeParameter = sqlCommand.Parameters.Add("NCode", System.Data.SqlDbType.NChar);
            NCodeParameter.Value = student.SNationalCode;
            SqlParameter GenderParameter = sqlCommand.Parameters.Add("Gender", System.Data.SqlDbType.NVarChar);
            GenderParameter.Value = student.SGender;
            SqlParameter AverageParameter = sqlCommand.Parameters.Add("Average", System.Data.SqlDbType.Float);
            AverageParameter.Value = student.SAverage;
            SqlParameter MajorParameter = sqlCommand.Parameters.Add("Major", System.Data.SqlDbType.NVarChar);
            MajorParameter.Value = student.SMajor;


            //3)
            sqlCommand.ExecuteNonQuery();


            sqlConnection.Close();
        }

        public void DeleteStudent(int currentStudentID)
        {
            //1)
            string connectionString = "Data Source=ARASH-PC\\MYSQLSERVER;Initial Catalog=UniEducation;Integrated Security=true";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();

            //2)
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            sqlCommand.CommandText = "Student_DeleteStudent";

            SqlParameter IDParameter = sqlCommand.Parameters.Add("ID", System.Data.SqlDbType.Int);
            IDParameter.Value = currentStudentID;

            //3)
            sqlCommand.ExecuteNonQuery();


            sqlConnection.Close();
        }
    }
}
