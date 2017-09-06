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
    public partial class ControlPanel : Form
    {
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
    }
}
