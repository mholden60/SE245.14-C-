using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace midTerm
{
    class ValidationLibrary
    {




        public static bool IsItFilledIn(string temp)
        {
            bool result = false;

            if (temp.Length > 0)
            {
                result = true;
            }

            return result;
        }



        //Receives a string and we can let user know if it is filled in
        public static bool IsItFilledIn(string temp, int minlen)
        {
            bool result = false;

            if (temp.Length >= minlen)
            {
                result = true;
            }

            return result;
        }

        public static bool Zipcode(string temp, int length)
        {
            bool result = false;
            if (temp.Length == length || temp.Length == 0)
            {
                result = true;
            }
            return result;
        }

        public static bool numbers(string temp, int Length)
        {
            bool result = false;
            if (temp.Length == Length || temp.Length == 0)
            {
                result = true;
            }
            return result;
        }



        //Receives a string and we can let user know if it has a semi-valid email format
        public static bool IsValidEmail(string temp)
        {
            //assume true, but look for bad stuff to make it false
            bool result = true;

            //Look for position of "@"
            int atLocation = temp.IndexOf("@");
            int NextatLocation = temp.IndexOf("@", atLocation + 1);
           

         

            //Look for position of last period "."
            int Location = temp.IndexOf(".");
            int periodLocation = temp.LastIndexOf(".");
          

            //check for minimum length
            if (temp.Length < 8)
            {
                result = false;
            }
            else if (atLocation < 2)    //if it is -1, not found and needs at least 2 chars in front
            {
                result = false;
            }
            else if (Location < 2)
            {
                result = false;
            }

            else if (periodLocation + 2 > (temp.Length))
            {
                result = false;
            }

            return result;
        }

    
      


        internal static bool Temp(string p)
        {
            throw new NotImplementedException();
        }



    }
}
