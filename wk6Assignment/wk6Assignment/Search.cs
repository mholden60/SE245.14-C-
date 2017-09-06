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
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }

        //private void btnSearch_Click(object sender, EventArgs e)
        //{
        //    //Call the search function in Person_v2
        //    Person_V2 temp = new Person_V2();
        //    DataSet ds = temp.SearchRecords(txtfName.Text, txtlName.Text, txtStr1.Text, txtCity.Text, state.Text, txtZip.Text, txtEmail.Text);

        //    //Get the results and display
        //    gvResults.DataSource = ds;
        //    gvResults.DataMember = ds.Tables["Persons"].ToString();
        //    //gvResults.
        //}

        private void gvResults_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string strPerson_ID = gvResults.Rows[e.RowIndex].Cells[0].Value.ToString();
            MessageBox.Show(strPerson_ID);
            int intPerson_ID = Convert.ToInt32(strPerson_ID);

            Form1 Editor = new Form1(intPerson_ID);
            Editor.ShowDialog();
        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            //Call the search function in Person_v2
            Person_V2 temp = new Person_V2();
            DataSet ds = temp.SearchRecords(txtfName.Text, txtlName.Text, txtStr1.Text, txtCity.Text, state.Text, txtZip.Text, txtPhone.Text, txtEmail.Text, txtColor.Text);

            //Get the results and display
            gvResults.DataSource = ds;
            gvResults.DataMember = "CopyOfPersons";
            //gvResults.
        }
    }
}
