using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//********************************************
//using System.Data1.OleDb;//Library for Access
//********************************************
using System.Data;
using System.Data.SqlClient;

namespace midTerm
{
    class Person_v2 : Person
    {
        public const string connstring = @"Server=sql.neit.edu;Database=SE255_MHolden;User Id=SE255_MHolden;Password=001021282;";
        public Int32 Person_ID = 0;
        public string States;
        public string comment;
        public Person_v2()
            : base()
        {

        }

        public SqlDataReader FindOnePerson(int intPerson_ID)
        {
            //Create and Innitialize the DB tools we need
            SqlConnection conn = new SqlConnection();
            SqlCommand comm = new SqlCommand();

            //My Connection String
            string strConn = @connstring;
            string sqlString = "SELECT Person_ID, FName, LName, EmpId, DTime1, DTime2, Comment, States FROM Data1 WHERE Person_ID = @Person_ID;";

            //tell the connection object WHO WHAT WHERE HOW
            conn.ConnectionString = strConn;
            //give the command object info it needs
            comm.Connection = conn;
            comm.CommandText = sqlString;
            comm.Parameters.AddWithValue("@Person_ID", intPerson_ID);

            //Open the DB Connection and yell our SQL COMMAND
            conn.Open();

            return comm.ExecuteReader(); //Return the dataset to be used by others (THE CALLING FORM)
        }




        public string AddContact()
        {
            string strFeedback = "";

            //Creating Command String for SQL   
            string strSQL = "INSERT INTO Data1 (FName, LName, EmpId, DTime1, DTime2, Comment, States) VALUES (@FName, @LName, @EmpId, @DTime1, @DTime2, @Comment, @States )";
            SqlConnection conn = new SqlConnection();
            string strConn = @connstring;
            conn.ConnectionString = strConn;

            SqlCommand comm = new SqlCommand();
            comm.CommandText = strSQL;
            comm.Connection = conn;

            comm.Parameters.AddWithValue("@fName", FName);
            comm.Parameters.AddWithValue("@lName", LName);
            comm.Parameters.AddWithValue("@empID", EmpId);
            comm.Parameters.AddWithValue("@dTime1", DTime1);
            comm.Parameters.AddWithValue("@dTime2", DTime2);
            comm.Parameters.AddWithValue("@comment", Comment);
            comm.Parameters.AddWithValue("@Person_ID", Person_ID);
            comm.Parameters.AddWithValue("@states", States);
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
        public DataSet SearchRecords(string fname, string lname, string empID, string comment, string states)
        {
            //Create an empty data container
            DataSet ds = new DataSet();
            //Make Connection/Command objects to the db and SET properties
            SqlConnection conn = new SqlConnection();
            string strConn = @connstring;
            conn.ConnectionString = strConn;

            SqlCommand comm = new SqlCommand();
            comm.Connection = conn;
            comm.CommandText = "SELECT * FROM Data1 WHERE 0=0";

            if (fname.Length > 0)
            {
                comm.CommandText += " AND FName LIKE @FName";
                comm.Parameters.AddWithValue("@FName", "%" + fname + "%");
            }
            if (states.Length > 0)
            {
                comm.CommandText += " AND States = @States";
                comm.Parameters.AddWithValue("@States", states);
            }
            if (lname.Length > 0)
            {
                comm.CommandText += " AND LName LIKE @LName";
                comm.Parameters.AddWithValue("@LName", "%" + lname + "%");
            }

            if (empID.Length > 0)
            {
                comm.CommandText += "AND EmpId = @EmpId";
                comm.Parameters.AddWithValue("@EmpId", empID);
            }

            if (comment.Length > 0)
            {
                comm.CommandText += " AND Comment LIKE @Comment";
                comm.Parameters.AddWithValue("@Comment", "%" + comment + "%");
            }


            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = comm;
            conn.Open(); //open the connection
            //Perform search and fill ds
            da.Fill(ds, "CopyOfPersons");

            conn.Close(); //close the connection

            //Return the results
            return ds;

        }

        public Int32 DeleteOnePerson(int intPerson_ID)
        {
            Int32 intRecords = 0;

            //Create and Initialize the DB Tools we need
            SqlConnection conn = new SqlConnection();
            SqlCommand comm = new SqlCommand();

            //My Connection String
            string strConn = @connstring;

            //My SQL command string to pull up one person's data
            string sqlString =
           "DELETE FROM Data1 WHERE Person_ID = @Person_ID;";

            //Tell the connection object the who, what, where, how
            conn.ConnectionString = strConn;

            //Give the command object info it needs
            comm.Connection = conn;
            comm.CommandText = sqlString;
            comm.Parameters.AddWithValue("@Person_ID", intPerson_ID);

            //Open the DataBase Connection and Yell our SQL Command
            conn.Open();

            //Run the deletion and store the number of records effected
            intRecords = comm.ExecuteNonQuery();

            //close the connection
            conn.Close();

            return intRecords;   //Return # of records deleted

        }

        public Int32 UpdateAContact()
        {
            Int32 intRecords = 0;

            //Create SQL command string
            string strSQL = "UPDATE Data1 SET FName = @FName, LName = @LName, EmpId = @EmpId, Comment = @Comment, States = @States  WHERE Person_ID = @Person_ID;";

            // Create a connection to DB
            SqlConnection conn = new SqlConnection();
            //Create the who, what where of the DB
            string strConn = @connstring;
            conn.ConnectionString = strConn;

            // Bark out our command
            SqlCommand comm = new SqlCommand();
            comm.CommandText = strSQL;  //Commander knows what to say
            comm.Connection = conn;     //Where's the phone?  Here it is

            //Fill in the paramters (Has to be created in same sequence as they are used in SQL Statement)
            comm.Parameters.AddWithValue("@Person_ID", Person_ID);
            comm.Parameters.AddWithValue("@FName", FName);
            comm.Parameters.AddWithValue("@LName", LName);
            comm.Parameters.AddWithValue("@EmpId", EmpId);
            comm.Parameters.AddWithValue("@Comment", Comment);
            comm.Parameters.AddWithValue("@States", States);
            try
            {
                //Open the connection
                conn.Open();

                //Run the Update and store the number of records effected
                intRecords = comm.ExecuteNonQuery();
            }
            catch (Exception err)
            {
            }
            finally
            {
                //close the connection
                conn.Close();
            }

            return intRecords;

        }
        public static string GetConnected()
        {
            return "Server=sql.neit.edu;Database=SE255_MHolden;User Id=SE255_MHolden;Password=001021282;";
        }


    };
}
