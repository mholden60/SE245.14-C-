using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data;

namespace midTerm
{
    class Person_v2 : Person
    {
        public Person_v2()
            : base()
        {

        }

        public string AddContact()
        {
            string strFeedback = "";

            //Creating Command String for SQL   
            string strSQL = "INSERT INTO Data (FName, LName, EmpId, DTime1, DTime2) VALUES (@FName, @LName, @EmpId, @DTime1, @DTime2)";
            OleDbConnection conn = new OleDbConnection();
            string strConn = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Data\data1.accdb;
Persist Security Info=False;";
            conn.ConnectionString = strConn;

            OleDbCommand comm = new OleDbCommand();
            comm.CommandText = strSQL;
            comm.Connection = conn;

            comm.Parameters.AddWithValue("@fName", FName);
            comm.Parameters.AddWithValue("@lName", LName);
            comm.Parameters.AddWithValue("@empID", EmpId);
            comm.Parameters.AddWithValue("@dTime1", DTime1);
            comm.Parameters.AddWithValue("@dTime2", DTime2);
            try
            {
                conn.Open();

                strFeedback = comm.ExecuteNonQuery().ToString() + " Record Added";
                conn.Close();
            }
            catch (Exception err)
            {
                strFeedback = "Error: " + err.Message;
            }
            return strFeedback;




        }
    }


}
