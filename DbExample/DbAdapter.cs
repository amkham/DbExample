using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbExample
{
    class DbAdapter
    {
        private DbConnection dbConnection;
        public DbAdapter(DbConnection dbConnection)
        {

            this.dbConnection = dbConnection;
        }


        public List<People> SelectAll()
        {

            List<People> result = new List<People>();

            string query = "SELECT * FROM [dbo].[Table]";

            SqlCommand command = new(query, dbConnection.SqlConnection);

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {

                People p = new();
                p.Id = int.Parse(reader[0].ToString());
                p.Name = reader[1].ToString();
                p.Age = reader[2].ToString();
                p.Data = reader[3].ToString();

                result.Add(p);
            }


            return result;
        }
    }
}
