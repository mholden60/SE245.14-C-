using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace wk1Assignment
{
    public partial class ControlPanel : Form
    {
        public const string connstring = @"Server=sql.neit.edu;Database=SE255_MHolden;User Id=SE255_MHolden;Password=001021282;";
        public ControlPanel()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form1 temp = new Form1();   //Create form Instance in Memory(Doesnt show Form)
            temp.ShowDialog();                //show the form on screen
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Search temp = new Search();
            temp.Show();

        }

        

        private void ControlPanel_Load(object sender, EventArgs e)
        {

        }

        private void pnlLogin_Paint(object sender, PaintEventArgs e)
        {


        }

        private void txtUName_TextChanged(object sender, EventArgs e)
        {

        }

        private int EmployeeLogin(string strUName, string strPW)
        {
                                            //declare var to hold admin lvl
            int intAdminLevel = 0;

                                             //create a darareader to return filled
            SqlDataReader dr;

                                                 //create a command for our SQL Statement
            SqlCommand comm = new SqlCommand();

                                                   //write a select statement to perform search
            String strSQL = "SELECT MyLevel FROM Login WHERE (UName = @UName AND PW = @PW)";
                                                        //Set params
            comm.Parameters.AddWithValue("@UName", strUName);
            comm.Parameters.AddWithValue("@PW", strPW);

                                                          //Create DB Tools and configure
            //****************************************************************************************
            SqlConnection conn = new SqlConnection();

                                                            //Create the who, what, where of the DB
            string strConn = @connstring;
            conn.ConnectionString = strConn;

                                                            //fill in basic info to command object
            comm.Connection = conn;                              //Tells commander what connection to use
            comm.CommandText = strSQL;                               //Tells commander what tp say

                                                                        //GET DATA
            conn.Open();                                                     //open the connection
            dr = comm.ExecuteReader();                                          //fill in data reader

            while (dr.Read())
            {

                                                    //change the Admin lvl to whateve the employee's lvl is...elese it remains 0 
                intAdminLevel = Convert.ToInt16(dr["MyLevel"].ToString());
            }

            conn.Close();                                               //closes the connection

            //return the persons admin lvl
            return intAdminLevel;
        }





        private void btnLogin_Click(object sender, EventArgs e)
        {
            //clears  any previous feedback
            lblFeedback.Text = "";
            //if (!txtUName.Text.Contains("Mathew"))
            //{
            //    lblFeedback.Text = "INVALID USERNAME!";
            //}
            //else if (!txtPWord.Text.Contains("Password"))
            //{
            //    lblFeedback.Text = "INVALID PASSWORD!";
            //}
            //else
            //{
            //    lblFeedback.Text = "Welcome";
            //    pnlControl.Enabled = true;
            //    pnlControl.Visible = true;

            //    pnlLogin.Enabled = false;
            //    pnlLogin.Visible = false;
            //}

            //-if login is valid
            //-Disable/Inable  aswell as visible or not login
            //1 is highest admin and 10 is a basic user (5 and less is allowed access)

            int intLevel = EmployeeLogin(txtUName.Text, txtPWord.Text);
            if (intLevel <= 5 && intLevel != 0)
            {

                lblFeedback.Text = "Welcome";
                                                //
                pnlControl.Enabled = true;
                pnlControl.Visible = true;
                                               // make login unaviable
                pnlLogin.Enabled = false;
                pnlLogin.Visible = false;
             }
                                                //if invailid:
                                                //display invalid login message
                                                //makesure controls panel is disabled
            else if (intLevel > 10)
            {
                //make controls unavailable
                pnlControl.Enabled = false;
                pnlControl.Visible = false;
                //make login available
                pnlLogin.Enabled = true;
                pnlLogin.Visible = true;
                lblFeedback.Text = "Unauthorized Login";
            }
            else
            {
                //make controls unavailable
                pnlControl.Enabled = false;
                pnlControl.Visible = false;
                //make login available
                pnlLogin.Enabled = true;
                pnlLogin.Visible = true;
                lblFeedback.Text = "Invalid Login";
            }
        }
    }
}
