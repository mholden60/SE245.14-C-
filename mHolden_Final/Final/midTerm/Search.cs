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
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }

        private void gvResults_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string Person_ID = gvResults.Rows[e.RowIndex].Cells[0].Value.ToString();
            int intPerson_ID = Convert.ToInt32(Person_ID);
            Form1 Editor = new Form1(intPerson_ID);
            Editor.ShowDialog();
        }


        private void txtlName_TextChanged(object sender, EventArgs e)
        {

        }

        private void Search_Load(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            //Call the search function in Person_v2
            Person_v2 temp = new Person_v2();
            DataSet ds = temp.SearchRecords(txtfName.Text, txtlName.Text, txtEmpID.Text, comment.Text, states.Text);

            //Get the results and display
            gvResults.DataSource = ds;
            gvResults.DataMember = "CopyOfPersons";
            //gvResults.
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void state_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

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
        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
