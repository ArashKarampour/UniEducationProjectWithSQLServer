using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniEdu.Entities;

namespace UniEdu.DAL
{
    public class ClassDao
    {
        public ClassRoom LoadFirstClass()
        {
            //Connection to SQL
            //1)Connect to SQL
            string connectionString = "Data Source=ARASH-PC\\MYSQLSERVER;Initial Catalog=UniEducation;Integrated Security=true";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();

            //2) Create Command
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = "Select top 1 * from Class order by ID asc";


            //3) Execute Query and Read data
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            ClassRoom classRoom = null;

            if (sqlDataReader.Read())
            {
                classRoom = new ClassRoom();

                classRoom.ID = sqlDataReader.GetInt32(0);
                classRoom.RoomNumber = sqlDataReader.GetString(1);
                classRoom.Department = sqlDataReader.GetString(2);


            }

            sqlConnection.Close();

            return classRoom;
        }

        public ClassRoom LoadNextClass(int currentID)
        {
            //Connection to SQL
            //1)Connect to SQL
            string connectionString = "Data Source=ARASH-PC\\MYSQLSERVER;Initial Catalog=UniEducation;Integrated Security=true";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();

            //2) Create Command
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            sqlCommand.CommandText = "Class_NextClass";

            SqlParameter IDParameter = sqlCommand.Parameters.Add("CurrentID", System.Data.SqlDbType.Int);
            IDParameter.Value = currentID;

            //3) Execute Query and Read data
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            ClassRoom classRoom = null;

            if (sqlDataReader.Read())
            {
                classRoom = new ClassRoom();

                classRoom.ID = sqlDataReader.GetInt32(0);
                classRoom.RoomNumber = sqlDataReader.GetString(1);
                classRoom.Department = sqlDataReader.GetString(2);


            }

            sqlConnection.Close();

            return classRoom;
        }

        public ClassRoom LoadPreviousClass(int currentID)
        {
            //Connection to SQL
            //1)Connect to SQL
            string connectionString = "Data Source=ARASH-PC\\MYSQLSERVER;Initial Catalog=UniEducation;Integrated Security=true";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();

            //2) Create Command
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            sqlCommand.CommandText = "Class_PreviousClass";

            SqlParameter IDParameter = sqlCommand.Parameters.Add("CurrentID", System.Data.SqlDbType.Int);
            IDParameter.Value = currentID;

            //3) Execute Query and Read data
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            ClassRoom classRoom = null;

            if (sqlDataReader.Read())
            {
                classRoom = new ClassRoom();

                classRoom.ID = sqlDataReader.GetInt32(0);
                classRoom.RoomNumber = sqlDataReader.GetString(1);
                classRoom.Department = sqlDataReader.GetString(2);


            }

            sqlConnection.Close();

            return classRoom;
        }

        public ClassRoom LoadLastClass()
        {
            //Connection to SQL
            //1)Connect to SQL
            string connectionString = "Data Source=ARASH-PC\\MYSQLSERVER;Initial Catalog=UniEducation;Integrated Security=true";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();

            //2) Create Command
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            sqlCommand.CommandText = "Class_LastClass";


            //3) Execute Query and Read data
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            ClassRoom classRoom = null;

            if (sqlDataReader.Read())
            {
                classRoom = new ClassRoom();

                classRoom.ID = sqlDataReader.GetInt32(0);
                classRoom.RoomNumber = sqlDataReader.GetString(1);
                classRoom.Department = sqlDataReader.GetString(2);


            }

            sqlConnection.Close();

            return classRoom;
        }

        public ClassRoom SearchClass(int ID)
        {
            //Connection to SQL
            //1)Connect to SQL
            string connectionString = "Data Source=ARASH-PC\\MYSQLSERVER;Initial Catalog=UniEducation;Integrated Security=true";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();

            //2) Create Command
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            sqlCommand.CommandText = "Class_SearchClass";

            SqlParameter IDParameter = sqlCommand.Parameters.Add("ID", System.Data.SqlDbType.Int);
            IDParameter.Value = ID;

            //3) Execute Query and Read data
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            ClassRoom classRoom = null;

            if (sqlDataReader.Read())
            {
                classRoom = new ClassRoom();

                classRoom.ID = sqlDataReader.GetInt32(0);
                classRoom.RoomNumber = sqlDataReader.GetString(1);
                classRoom.Department = sqlDataReader.GetString(2);


            }

            sqlConnection.Close();

            return classRoom;
        }

        public void UpdateClass(ClassRoom classRoom)
        {
            //Connection to SQL
            //1)Connect to SQL
            string connectionString = "Data Source=ARASH-PC\\MYSQLSERVER;Initial Catalog=UniEducation;Integrated Security=true";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();

            //2) Create Command
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            sqlCommand.CommandText = "Class_UpdateClass";

            SqlParameter IDParameter = sqlCommand.Parameters.Add("ID", System.Data.SqlDbType.Int);
            IDParameter.Value = classRoom.ID;
            SqlParameter InstIDParameter = sqlCommand.Parameters.Add("RoomNum", System.Data.SqlDbType.NVarChar);
            InstIDParameter.Value = classRoom.RoomNumber;
            SqlParameter CouIDParameter = sqlCommand.Parameters.Add("Department", System.Data.SqlDbType.NVarChar);
            CouIDParameter.Value = classRoom.Department;
            
            //3)
            sqlCommand.ExecuteNonQuery();


            sqlConnection.Close();
        }

        public void AddClass(ClassRoom classRoom)
        {
            //Connection to SQL
            //1)Connect to SQL
            string connectionString = "Data Source=ARASH-PC\\MYSQLSERVER;Initial Catalog=UniEducation;Integrated Security=true";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();

            //2) Create Command
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            sqlCommand.CommandText = "Class_AddClass";

            SqlParameter IDParameter = sqlCommand.Parameters.Add("ID", System.Data.SqlDbType.Int);
            IDParameter.Value = classRoom.ID;
            SqlParameter InstIDParameter = sqlCommand.Parameters.Add("RoomNum", System.Data.SqlDbType.NVarChar);
            InstIDParameter.Value = classRoom.RoomNumber;
            SqlParameter CouIDParameter = sqlCommand.Parameters.Add("Department", System.Data.SqlDbType.NVarChar);
            CouIDParameter.Value = classRoom.Department;

            //3)
            sqlCommand.ExecuteNonQuery();


            sqlConnection.Close();
        }

        public void DeleteClass(int ID)
        {
            //1)
            string connectionString = "Data Source=ARASH-PC\\MYSQLSERVER;Initial Catalog=UniEducation;Integrated Security=true";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();

            //2)
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            sqlCommand.CommandText = "Class_DeleteClass";

            SqlParameter IDParameter = sqlCommand.Parameters.Add("ID", System.Data.SqlDbType.Int);
            IDParameter.Value = ID;

            //3)
            sqlCommand.ExecuteNonQuery();

            sqlConnection.Close();
        }
    }
}
