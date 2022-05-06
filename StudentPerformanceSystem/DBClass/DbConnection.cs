using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentPerformanceSystem.DBClass
{
    public class DbConnection
    {
        string connectionString= @"Data Source=WAIANGDESK21\MSSQLSERVER01;Initial Catalog=StudentMGTSystem;Integrated Security=True";
        SqlConnection conn;
        SqlCommand cmd;

        public SqlConnection  getConnection()
        {
           conn= new SqlConnection(connectionString);
           return conn;
            
        }

        public SqlCommand getCommand(string text)
        {   conn.Open();
            cmd=new SqlCommand(text,conn);
            return cmd;
        }

        public SqlDataReader ExcecuteReader()
        {
           return cmd.ExecuteReader();
        }

        public void ExcecuteNonQuery()
        {
             cmd.ExecuteNonQuery();
        }

        public void ExecuteScaler()
        {
            cmd.ExecuteScalar();
        }
    }
}
