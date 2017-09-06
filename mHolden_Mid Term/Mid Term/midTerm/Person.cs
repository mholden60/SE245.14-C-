using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;

namespace midTerm
{
    public class Person
    {
        private string feedback;
        private string fName;
        private string lName;
        private string empID;
        private string dTime1;
        private string dTime2;
        public string dt1;

        public string Feedback
        {
            get { return feedback; }
        }

        public Person()
        {
            feedback = "";
        }
        public string FName
        {
            get { return fName; }
            set
            {
                if (ValidationLibrary.IsItFilledIn(value, 1) == false)
                    feedback += "Error: Please fill in FIRST NAME \n";
                else
                    fName = value;
            }
        }
        public string LName
        {
            get { return lName; }
            set
            {
                if (ValidationLibrary.IsItFilledIn(value, 1) == false)
                    feedback += "Error: Please fill in LAST NAME \n";
                else
                    lName = value;
            }
        }

        public string DTime1
        {
            get { return dTime1; }
            set { dTime1 = value; }
        }
        public string DTime2
        {
            get { return dTime2; }
            set { dTime2 = value; }
        }

        public string EmpId
        {
            get { return empID; }
            set
            {
                if (ValidationLibrary.IsItFilledIn(value, 1) == false)
                    feedback += "Error: Please fill in EMPLOYEE ID";
                else
                    empID = value;
            }
        }


    }
}
