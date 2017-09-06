using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace wk1Assignment
{
    class MyUtilities
    {
        public static SqlDataReader getMyStates()
        { 
        //create my db objects
        SqlConnection conn = new SqlConnection();
        SqlCommand comm = new SqlCommand();
        //Create my strings to with db objects
        string strConn = @GetConnected();
        string strSQL = "SELECT * FROM States ORDER BY States";
 
            //inistialize DB objects
        conn.ConnectionString = strConn;
        comm.Connection = conn;
        comm.CommandText = strSQL;
        conn.Open();
        return comm.ExecuteReader();
        }
        public static string GetConnected()
        {
            return "Server=sql.neit.edu;Database=SE255_MHolden;User Id=SE255_MHolden;Password=001021282;";
        }
    }
}
