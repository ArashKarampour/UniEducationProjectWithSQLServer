using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace UniEdu.DAL
{
    public class StChangePassDao
    {
        public void ChangePass(int sID, string newPass)
        {
            //Connection to SQL
            //1)Connect to SQL
            string connectionString = "Data Source=ARASH-PC\\MYSQLSERVER;Initial Catalog=UniEducation;Integrated Security=true";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();

            //2) Create Command
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            sqlCommand.CommandText = "Student_ChangePass";

            SqlParameter sIDParameter = sqlCommand.Parameters.Add("SID", System.Data.SqlDbType.Int);
            sIDParameter.Value = sID;
            SqlParameter NewPassParameter = sqlCommand.Parameters.Add("NewPass", System.Data.SqlDbType.VarChar);
            NewPassParameter.Value = newPass;
            

            //3)
            sqlCommand.ExecuteNonQuery();


            sqlConnection.Close();
        }
    }
}
