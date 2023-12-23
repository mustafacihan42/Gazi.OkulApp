using System;
using System.Data.SqlClient;

namespace DAL
{
    public class Helper
    {
        SqlConnection cn;
        SqlCommand cmd;
        string cstr=ConfigurationManager.

        public int ExecuteNonQuery()
        {
            using (cn=new SqlConnection(""))
            {

            }
        }
       
    }
}
