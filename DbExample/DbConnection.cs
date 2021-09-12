using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbExample
{

   

    class DbConnection
    {
        private static string connectPath = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\betir\\source\\repos\\DbExample\\DbExample\\Database1.mdf;Integrated Security=True";

        private static DbConnection dbConnection;

        private  SqlConnection sqlConnection;

        private static object locker = new();

        public SqlConnection SqlConnection { get => sqlConnection; private set => sqlConnection = value; }

        private DbConnection()
        {
            SqlConnection = new SqlConnection(connectPath);

        }

        public static DbConnection GetInstance()
        {

            if (dbConnection == null)
            {
                lock (locker)
                {
                    if (dbConnection == null)
                    {
                       
                        
                        dbConnection =  new DbConnection();

                    }
                }
            }
          
                return dbConnection;
         
        }


        public void Open()
        {
            if (SqlConnection.State == ConnectionState.Closed)
            {
               
                SqlConnection.Open();
            }
           
        }


        public String Status()
        {

            return SqlConnection.State.ToString();
        }

        public void Close()
        {
            if (SqlConnection.State == ConnectionState.Open)
            {
                SqlConnection.Close();
            }
            
        }





    }
}
