using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace wk1Assignment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btnUpdate.Visible = false;
            btnUpdate.Enabled = false;
            btnDelete.Visible = false;
            btnDelete.Enabled = false;
        }

        //Has no data in it by default
        public Form1(Int32 intPerson_ID)
        {
            //btnSubmit.Visible = false;
            //btnSubmit.Enabled = false;

            InitializeComponent();
            Person_V2 temp = new Person_V2();
            OleDbDataReader dr = temp.FindOnePerson(intPerson_ID);

            while (dr.Read())
            {
                fName.Text = dr["FName"].ToString();
                mName.Text = dr["MName"].ToString();
                lName.Text = dr["LName"].ToString();
                str1.Text = dr["Str1"].ToString();
                str2.Text  = dr["Str2"].ToString();
                city.Text = dr["City"].ToString();
                state.Text = dr["State"].ToString();
                zip.Text = dr["Zip"].ToString();
                phone.Text = dr["Phone"].ToString();
                email.Text = dr["Email"].ToString();
                color.Text = dr["Color"].ToString();


                //store the ID in a new label
                lblPerson_ID.Text = dr["Person_ID"].ToString();

            }

        
        }
        public void FillLabel(Person temp)
        {
            //btnSubmit.Visible = false;
            //btnSubmit.Enabled = false;
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
            lblfeedback.Text += temp.Color;
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Person_V2 temp;
            temp = new Person_V2();
           // Person_V2 temp = new Person_V2();
            temp.FName = fName.Text;
            temp.MName = mName.Text;
            temp.LName = lName.Text;
            temp.Str1 = str1.Text;
            temp.Str2 = str2.Text;
            temp.City = city.Text;
            temp.State = state.Text;
            temp.Zip = zip.Text;
            temp.Phone = phone.Text;
            temp.Email = email.Text;
            temp.Color = color.Text;
            FillLabel(temp);

            if (temp.Feedback.Contains("ERROR: "))
            {
                lblfeedback.Text = temp.Feedback;
            }
            else
            {
               // FillLabel(temp);
                lblfeedback.Text = temp.AddContacts();
                DisplayInfo();
            }
        }
        
        private void DisplayInfo(Person temp)
        {
            lblfeedback.Text = temp.FName + "" + temp.MName + "" + temp.LName; 
        }

        private void DisplayInfo()
        {
         //   lblfeedback.Text = "Unknown Person...Lack of Data";
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //create a person so we can use the delete methode
            Person_V2 temp = new Person_V2();

            //convert the label text holding the ID to an integer
            Int32 intPerson_ID = Convert.ToInt32(lblPerson_ID.Text);

            //Use the Person ID and pass it to the delete function and get the number of records deleted
            Int32 intRecords = temp.DeleteOnePerson(intPerson_ID);

            //Display feedback to the user
            lblfeedback.Text = intRecords.ToString() + "Records Deleted";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
           
            //Declaration            
            Person_V2 temp = new Person_V2();

            //Fill in data from form
            temp.FName = fName.Text;
            temp.MName = mName.Text;
            temp.LName = lName.Text;
            temp.Str1 = str1.Text;
            temp.Str2 = str2.Text;
            temp.City = city.Text;
            temp.State = state.Text;
            temp.Zip = zip.Text;
            temp.Phone = phone.Text;
            temp.Email = email.Text;
            temp.Color = color.Text;
            temp.Person_ID = Convert.ToInt32(lblPerson_ID.Text);

            if (temp.Feedback.Contains("ERROR:"))
            {
                lblfeedback.Text = temp.Feedback;

            }
            else if (temp.FName.Length > 0 && temp.LName.Length > 0)
            {
                DisplayInfo(temp);

                Int32 intRocords = temp.UpdateAContact();
                lblfeedback.Text = intRocords.ToString() + " Records Updated.";
            }
            else
            {
                DisplayInfo();
            }


        }






    }
}
