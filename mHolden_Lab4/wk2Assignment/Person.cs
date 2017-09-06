using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;

namespace wk1Assignment
{
    public class Person
    {
        private string feedback;
        private string fName;
        private string mName;
        private string lName;
        private string str1;
        private string str2;
        private string city;
        private string state;
        private string zip;
        private string phone;
        private string email;

        public string Feedback
        {
            get { return feedback; }
        }

        public Person()
        {
            //Start by giving the feedback an empty string
            feedback = "";
        }


        public string FName
        {
            get { return fName; }
            set
            {
                if (ValidationLibrary.IsItFilledIn(value, 1) == false)
                    feedback += "ERROR: Invalid First Name...must be at least one character.\n";
                else
                    fName = value;


            }
        }
        public string MName
        {
            get { return mName; }
            set
            {
                if (value.ToUpper().Contains("POOPY"))
                {
                    mName = "invalid";
                }
                else
                {
                    mName = value;
                }
            }
        }
        public string LName
        {
            get { return lName; }
            set
            {
                if (ValidationLibrary.IsItFilledIn(value, 1) == false)
                    feedback += "ERROR: Invalid Last Name...must be at least one character.\n";
                else
                    lName = value;
            }
        }
        public string Str1
        {
            get { return str1; }
            set
            {
                if (ValidationLibrary.IsItFilledIn(value, 1) == false)
                    feedback += "ERROR: Fill in Address.\n";
                else
                  str1 = value;
            }
        }
        public string Str2
        {
            get { return str2; }
            set { str2 = value; }
        }
        public string City
        {
            get { return city; }
            set
            {
                if (ValidationLibrary.IsItFilledIn(value, 1) == false)
                    feedback += "ERROR: Fill in City.\n";
                else
                    city = value;
            }
        }
        public string State
        {
            get { return state; }
            set {
                if (ValidationLibrary.chooseState(value) == false)
                    feedback += "ERROR: Please Choose a State.\n";
                else
                state = value; }
        }
        public string Zip
        {
            get { return zip; }
            set
            {
                if (ValidationLibrary.Zipcode(value, 1) == false)
                {
                    feedback += "ERROR: Not valid Zip Code\n";
                }
                else { zip = value; }
            }
        }
        public string Phone
        {
            get { return phone; }
            set {
                if (ValidationLibrary.phone(value, 1) == false)
                {
                    feedback += "ERROR: Please enter valid Phone number";
                }
                else
                phone = value; } 
            
        }
        public string Email
        {
            get { return email; }
            set
            {
                if (ValidationLibrary.IsValidEmail(value) == false)
                {
                    feedback += "ERROR: Email not in proper format\n";
                }
                else
                { email = value; }
            }

            //        public string AddRecord()
            //        {
            //            string results = "Connected";

            //            OleDbConnection conn = new OleDbConnection();
            //            conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=contacts.accdb;
            //Persist Security Info=False;";

            //    try
            //    {
            //        conn.Open();
            //        conn.Close();
            //    }        
            //    catch
            //    {

            //    }


            //    return results;
            //    }
            //}
        }
    }
}
