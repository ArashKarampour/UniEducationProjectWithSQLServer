using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using UniEdu.Entities;

namespace UniEdu.DAL
{
    public class StudentLoginDao
    {
        public Student verifyStudent(string username, string password)
        {
            //Connection to SQL
            //1)Connect to SQL
            string connectionString = "Data Source=ARASH-PC\\MYSQLSERVER;Initial Catalog=UniEducation;Integrated Security=true";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();

            //2) Create Command
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            sqlCommand.CommandText = "Student_VerifyLogin";

            SqlParameter UserName = sqlCommand.Parameters.Add("username", System.Data.SqlDbType.VarChar);
            UserName.Value = username;
            SqlParameter Password = sqlCommand.Parameters.Add("password", System.Data.SqlDbType.VarChar);
            Password.Value = password;

            //3) Execute Query and Read data
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            Student student = null;

            if (sqlDataReader.Read())
            {
                student = new Student();
                student.SID = sqlDataReader.GetInt32(0);
                student.SFName = sqlDataReader.GetString(1);
                student.SLName = sqlDataReader.GetString(2);
            }

            sqlConnection.Close();

            return student;
            
        }
    }
}
