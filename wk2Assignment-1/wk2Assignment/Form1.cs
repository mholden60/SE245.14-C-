using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace wk1Assignment
{
    public partial class Form1 : Form
    {
        //Changed from "struct" to "class"
        //public class Person
        //{
        //    //public string FName;
        //    //public string mName;
        //    //public string lName;
        //    //public string str1;
        //    //public string str2;
        //    //public string city;
        //    //public string state;
        //    //public string zip;
        //    //public string phone;
        //    //public string email;

        //    public string fName
        //    {
        //        get { return FName; }
        //        set {
        //            if (!value.Contains(" is a Poopy Pants"))
        //            {
        //                FName = value;
        //            }
        //            else
        //            {
        //                FName = "Invalid";
        //            }
        //            }
        //    }
        //};
        public Form1()
        {
            InitializeComponent();
        }

        public void FillLabel(Person temp)
        {
            //Add temperory label to First name
            //temp.FName += " is a Poopy Pants";
            lblfeedback.Text = temp.FName + "\n";
            lblfeedback.Text += temp.MName + "\n";
            lblfeedback.Text += temp.LName + "\n";
            lblfeedback.Text += temp.Str1 + "\n";
            lblfeedback.Text += temp.Str2 + "\n";
            lblfeedback.Text += temp.City + "\n";
            lblfeedback.Text += temp.State + "\n";
            lblfeedback.Text += temp.Zip + "\n";
            lblfeedback.Text += temp.Phone + "\n";
            lblfeedback.Text += temp.Email + "\n";
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Person newEmp = new Person();
            newEmp.FName = fName.Text;
            newEmp.MName = mName.Text;
            newEmp.LName = lName.Text;
            newEmp.Str1 = str1.Text;
            newEmp.Str2 = str2.Text;
            newEmp.City = city.Text;
            newEmp.State = state.Text;
            newEmp.Zip = zip.Text;
            newEmp.Phone = phone.Text;
            newEmp.Email = email.Text;
            FillLabel(newEmp);

            if (newEmp.Feedback.Contains("ERROR: "))
            {
                lblfeedback.Text = newEmp.Feedback;
            }
            else
            {
                FillLabel(newEmp);
            }
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }





    }
}
