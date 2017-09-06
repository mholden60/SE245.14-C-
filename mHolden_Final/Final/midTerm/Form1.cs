using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace midTerm
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
            FillStates();
        }
        private void FillStates()
        {
            //get list of states in DataReader
            SqlDataReader dr = MyUtilities.getMyStates();
            //lopp thru each states
            while (dr.Read())
            {
                //for each states add it to the combo box
                states.Items.Add(dr["States"].ToString());
            }
            states.Items.Insert(0, "Please Choose One...");
            states.SelectedIndex = 0;
            dr.Close();

        }
        public Form1(Int32 intPerson_ID)
        {
            InitializeComponent();
            Person_v2 temp = new Person_v2();
            SqlDataReader dr = temp.FindOnePerson(intPerson_ID);

            while (dr.Read())
            {
                fName.Text = dr["FName"].ToString();
                lName.Text = dr["LName"].ToString();
                empID.Text = dr["EmpId"].ToString();
                dTime1.Text = dr["DTime1"].ToString();
                dTime2.Text = dr["DTime2"].ToString();
                comment.Text = dr["Comment"].ToString();
                states.Text = dr["States"].ToString();
                lblPerson_ID.Text = dr["Person_ID"].ToString();
            }

        }




        private void dTime1_ValueChanged(object sender, EventArgs e)
        {
            string DTime1 = Convert.ToString(dTime1);
            dTime1.Format = DateTimePickerFormat.Custom;
   //         dTime1.CustomFormat = "MM dd yyyy hh:mm";
           
        }

        private void dTime2_ValueChanged(object sender, EventArgs e)
        {
            string DTime2 = Convert.ToString(dTime2);
            dTime2.Format = DateTimePickerFormat.Custom;
          // dTime2.CustomFormat = "MM dd yyyy hh:mm";
        }
            

        public void FillLabel(Person temp)
        {
            lblfeedback.Text = temp.FName + "\n";
            lblfeedback.Text += temp.LName + "\n";
            lblfeedback.Text += temp.EmpId + "\n";
            lblfeedback.Text += temp.DTime1 + "\n";
            lblfeedback.Text += temp.DTime2 + "\n";
            lblfeedback.Text += temp.Comment + "\n";
            lblfeedback.Text += temp.States;


           

        }


        private void submit_Click(object sender, EventArgs e)
        { 
            Person_v2 newEmp = new Person_v2();
           // DateTime dt1 = dTime1.Value;
           // DateTime dt2 = dTime2.Value;
            newEmp.FName = fName.Text;
            newEmp.LName = lName.Text;
            newEmp.EmpId = empID.Text;
            newEmp.DTime1 = dTime1.Text;
            newEmp.DTime2 = dTime2.Text;
            newEmp.States = states.Text;
            newEmp.Comment = comment.Text;
            FillLabel(newEmp);
            
           if (newEmp.Feedback.Contains("Error: "))
            {
                lblfeedback.Text = newEmp.Feedback;
            }
            else if ((dTime1.Value) > (dTime2.Value))
            {
                lblfeedback.Text = "ERROR: Unvalid vacation request";
            }
            
            else
            {
                 FillLabel(newEmp);
                lblfeedback.Text = newEmp.AddContact();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            if (dTime1.Value > dTime2.Value)
            {
                lblfeedback.Text = "Please enter valid request";
            }
            
                
        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }


        private void empID_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //create a person so we can use the delete methode
            Person_v2 temp = new Person_v2();

            //convert the label text holding the ID to an integer
            Int32 intPerson_ID = Convert.ToInt32(lblPerson_ID.Text);

            //Use the Person ID and pass it to the delete function and get the number of records deleted
            Int32 intRecords = temp.DeleteOnePerson(intPerson_ID);

            //Display feedback to the user
            lblfeedback.Text = intRecords.ToString() + "Records Deleted";
        }

        private void DisplayInfo(Person temp)
        {
            lblfeedback.Text = temp.FName + "" + temp.LName;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //Declaration
            Person_v2 temp = new Person_v2();

            temp.FName = fName.Text;
            temp.LName = lName.Text;
            temp.EmpId = empID.Text;
            temp.DTime1 = dTime1.Text;
            temp.DTime2 = dTime2.Text;
            temp.Comment = comment.Text;
            temp.States = states.Text;
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
                DisplayInfo(temp);
            }
        }

        private void state_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comment_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
