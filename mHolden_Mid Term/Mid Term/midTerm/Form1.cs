using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace midTerm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
            lblfeedback.Text += temp.DTime2;

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
    }
}
