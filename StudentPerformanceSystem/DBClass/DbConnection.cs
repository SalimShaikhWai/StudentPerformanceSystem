using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentPerformanceSystem.DBClass
{
    public static class DbConnection
    {
        static string connectionString = @"Data Source=WAIANGDESK21\MSSQLSERVER01;Initial Catalog=StudentMGTSystem;Integrated Security=True";
        static SqlConnection conn;
        static SqlCommand cmd;

        public static SqlConnection GetConnection()
        {
            conn = new SqlConnection(connectionString);
            return conn;
        }
        public static SqlCommand GetCommand(string text)
        {
            if (conn.State != ConnectionState.Open)
                conn.Open();
            cmd = new SqlCommand(text, conn);
            return cmd;
        }

        public static SqlCommand GetStoreProcedure(string text)
        {
            if (conn.State != ConnectionState.Open)
                conn.Open();

            cmd = new SqlCommand(text, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            return cmd;
        }

        public static void AddInputParameter(string parameterName, dynamic value)
        {
            cmd.Parameters.Add(new SqlParameter("@" + parameterName, value));
        }
        public static SqlDataReader ExcecuteReader()
        {
            return cmd.ExecuteReader();
        }
       public static string ExcecuteNonQuery()
        {
            try
            {
                cmd.ExecuteNonQuery();
                return "Record Added Successfully";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public static void ExecuteScaler()
        {
            cmd.ExecuteScalar();
        }
    }
}
