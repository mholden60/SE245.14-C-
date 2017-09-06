using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data;



namespace wk1Assignment
{
    class Person_V2 : Person
    {
        public string Color;
        //Constructor
        public Person_V2()
            : base()
        {

        }


        public string AddContacts()
        {
            string strFeedback = "";

            //Creating Command String for SQL   
            string strSQL = "INSERT INTO Data (FName, MName, LName, Str1, Str2, City, State, Zip, Phone, Email, Color) VALUES (@FName, @MName, @LName, @Str1, @Str2, @City, @State, @Zip, @Phone, @Email, @Color)";
            OleDbConnection conn = new OleDbConnection();
            string strConn = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Data\Database31.accdb;
Persist Security Info=False;";
            conn.ConnectionString = strConn;

            OleDbCommand comm = new OleDbCommand();
            comm.CommandText = strSQL;
            comm.Connection = conn;

            comm.Parameters.AddWithValue("@fName", FName);
            comm.Parameters.AddWithValue("@mName", MName);
            comm.Parameters.AddWithValue("@lName", LName);
            comm.Parameters.AddWithValue("@str1", Str1);
            comm.Parameters.AddWithValue("@str2", Str2);
            comm.Parameters.AddWithValue("@city", City);
            comm.Parameters.AddWithValue("@state", State);
            comm.Parameters.AddWithValue("@zip", Zip);
            comm.Parameters.AddWithValue("@phone", Phone);
            comm.Parameters.AddWithValue("@email", Email);
            comm.Parameters.AddWithValue("@color", Color);
            try
            {
                conn.Open();

                strFeedback = comm.ExecuteNonQuery().ToString() + " Records Added";
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