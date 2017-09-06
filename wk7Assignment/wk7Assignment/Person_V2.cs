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
        public Int32 Person_ID = 0;
        public string Color;
        //private object Person_ID;
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
                comm.CommandText += " AND LName LIKE @LName";
                comm.Parameters.AddWithValue("@LName", "%" + lname + "%");
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
        //Method that will delete one person record specified by the ID
        //It will return an Interger meant for feedback on how many 
        // records were deleted
        public Int32 DeleteOnePerson(int intPerson_ID)
        {
            Int32 intRecords = 0;

            //Create and Initialize the DB Tools we need
            OleDbConnection conn = new OleDbConnection();
            OleDbCommand comm = new OleDbCommand();

            //My Connection String
            string strConn = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Data\Database31.accdb; Persist Security Info=False;";

            //My SQL command string to pull up one person's data
            string sqlString =
           "DELETE FROM Data WHERE Person_ID = @Person_ID;";

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
            string strSQL = "UPDATE Data SET FName = @FName, MName = @MName, LName = @LName, STR1 = @STR1, STR2 = @STR2, City = @City, State = @State, Zip = @Zip, Phone = @Phone, Email = @Email, Color = @Color WHERE Person_ID = @Person_ID;";

            // Create a connection to DB
            OleDbConnection conn = new OleDbConnection();
            //Create the who, what where of the DB
            string strConn = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Data\Database31.accdb; Persist Security Info=False;";
            conn.ConnectionString = strConn;

            // Bark out our command
            OleDbCommand comm = new OleDbCommand();
            comm.CommandText = strSQL;  //Commander knows what to say
            comm.Connection = conn;     //Where's the phone?  Here it is

            //Fill in the paramters (Has to be created in same sequence as they are used in SQL Statement)
            comm.Parameters.AddWithValue("@FName", FName);
            comm.Parameters.AddWithValue("@MName", MName);
            comm.Parameters.AddWithValue("@LName", LName);
            comm.Parameters.AddWithValue("@Str1", Str1);
            comm.Parameters.AddWithValue("@Str2", Str2);
            comm.Parameters.AddWithValue("@City", City);
            comm.Parameters.AddWithValue("@State",State);
            comm.Parameters.AddWithValue("@Zip", Zip);
            comm.Parameters.AddWithValue("@Phone", Phone);
            comm.Parameters.AddWithValue("@Email", Email);
            comm.Parameters.AddWithValue("@Color", Color);
          
            comm.Parameters.AddWithValue("@Person_ID", Person_ID);

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




    };
}