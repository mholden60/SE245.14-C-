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

        public DataSet SearchRecords(string fname, string lname, string str1, string city, string state, string phone, string zip, string email, string color)
        {
           //Create an empty data container
            DataSet ds = new DataSet();

            //MAKE Connection/command objects to the db AND SET properties
            OleDbConnection conn = new OleDbConnection();
            string strConn = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Data\Database31.accdb; Persist Security Info=False;";
            conn.ConnectionString = strConn;
     
            OleDbCommand comm = new OleDbCommand();
            comm.Connection = conn;
            comm.CommandText = "SELECT * FROM Data WHERE 0=0";
            //comm.Parameters.AddWithValue("@FName", "%" + fname + "%");

            if (fname.Length > 0)
            {
                comm.CommandText += " AND FName LIKE @FName";
                comm.Parameters.AddWithValue("@FName", "%" + fname + "%");
            }

            if (lname.Length > 0)
            {
                comm.CommandText += " AND LName = @LName";
                comm.Parameters.AddWithValue("@LName", lname);
            }
            if (str1.Length > 0)
            {
                comm.CommandText += " AND Str1 Like @Str1";
                comm.Parameters.AddWithValue("@Str1", "%" + str1 + "%");
            }
            if (city.Length > 0)
            {
                comm.CommandText += " AND City Like @City";
                comm.Parameters.AddWithValue("@City", "%" + city + "%");
            }
            if (state.Length > 0)
            {
                comm.CommandText += " AND State Like @State";
                comm.Parameters.AddWithValue("@State", "%" + State + "%");
            }
            if (zip.Length > 0)
            {
                comm.CommandText += " AND Zip = @Zip";
                comm.Parameters.AddWithValue("@Zip", str1);
            }
            if (email.Length > 0)
            {
                comm.CommandText += " AND Email Like @Email";
                comm.Parameters.AddWithValue("@Email", "%" + email + "%");
            }
            if (phone.Length > 0)
            {
                comm.CommandText += " AND Phone Like @Phone";
                comm.Parameters.AddWithValue("@Phone", "%" + phone + "%");
            }
            if (color.Length > 0)
            {
                comm.CommandText += " AND Color Like @Color";
                comm.Parameters.AddWithValue("@Color", "%" + color + "%");
            }
            OleDbDataAdapter da = new OleDbDataAdapter();
            da.SelectCommand = comm;
            conn.Open(); //open the connection
            //Perform search and fill ds
            da.Fill(ds, "CopyOfPersons");

            conn.Close(); //close the connection

            //Return the results
            return ds;
        }


        public OleDbDataReader FindOnePerson(int intPerson_ID)
        {
            //Create and Innitialize the DB tools we need
            OleDbConnection conn = new OleDbConnection();
            OleDbCommand comm = new OleDbCommand();

            //My Connection String
            string strConn = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Data\Database31.accdb; Persist Security Info=False;";
            string sqlString = "SELECT Person_ID, LName, FName, MName, STR1, STR2, City, State, Zip, Phone, Email, Color FROM Data WHERE Person_ID = @Person_ID;";

            //Tell the  connection object WHO WHAT WHERE HOW
            conn.ConnectionString = strConn;

            //give the command object info it needs
            comm.Connection = conn;
            comm.CommandText = sqlString;
            comm.Parameters.AddWithValue("@Person_ID", intPerson_ID);

            //Open the DB Connection and yell our SQL COMMAND
            conn.Open();

            return comm.ExecuteReader(); //Return the dataset to be used by others (THE CALLING FORM)
 
        }


    };
}