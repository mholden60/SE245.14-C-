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
        public class Person
        {
            public string fName;
            public string mName;
            public string lName;
            public string str1;
            public string str2;
            public string city;
            public string state;
            public string zip;
            public string phone;
            public string email;
        };
        public Form1()
        {
            InitializeComponent();
        }

        public void FillLabel(Person temp)
        {
            //Add temperory label to First name
            temp.fName += " is a Poopy Pants";
            lblfeedback.Text = temp.fName + "\n";
            lblfeedback.Text += temp.mName + "\n";
            lblfeedback.Text += temp.lName + "\n";
            lblfeedback.Text += temp.str1 + "\n";
            lblfeedback.Text += temp.str2 + "\n";
            lblfeedback.Text += temp.city + "\n";
            lblfeedback.Text += temp.state + "\n";
            lblfeedback.Text += temp.zip + "\n";
            lblfeedback.Text += temp.phone + "\n";
            lblfeedback.Text += temp.email + "\n";
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Person newEmp = new Person();
            newEmp.fName = fName.Text;
            newEmp.mName = mName.Text;
            newEmp.lName = lName.Text;
            newEmp.str1 = str1.Text;
            newEmp.str2 = str2.Text;
            newEmp.city = city.Text;
            newEmp.state = state.Text;
            newEmp.zip = zip.Text;
            newEmp.phone = phone.Text;
            newEmp.email = email.Text;
            FillLabel(newEmp);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }





    }
}
