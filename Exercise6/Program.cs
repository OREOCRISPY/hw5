using System;
using System.Data.SqlClient;

namespace Exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            String MyConnectString = "mystring";
            SqlConnection conn = new SqlConnection(MyConnectString);
            SqlCommand cmd = new SqlCommand("sp_Myproc", conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            using(conn)
            {
                conn.Open();
                cmd.ExecuteNonQuery();
            }


        }
    }
}
