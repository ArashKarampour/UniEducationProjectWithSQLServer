using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using UniEdu.Entities;

namespace UniEdu.DAL
{
    public class AdminLoginDao
    {
        public int verifyAdmin(string username, string password)
        {
            //Connection to SQL
            //1)Connect to SQL
            string connectionString = "Data Source=ARASH-PC\\MYSQLSERVER;Initial Catalog=UniEducation;Integrated Security=true";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();

            //2) Create Command
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            sqlCommand.CommandText = "AdminLogin_Verify";

            SqlParameter UserName = sqlCommand.Parameters.Add("UserName", System.Data.SqlDbType.VarChar);
            UserName.Value = username;
            SqlParameter Password = sqlCommand.Parameters.Add("Password", System.Data.SqlDbType.VarChar);
            Password.Value = password; 

            //3) Execute Query and Read data
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            int count = 0;

            if (sqlDataReader.Read())
            {                          
                 count = sqlDataReader.GetInt32(0);               
            }

            sqlConnection.Close();

            return count;
            
        }
    }
}
