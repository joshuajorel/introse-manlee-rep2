using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace introseHHC.RegForms
{
    public partial class MedList : Form
    {
        public string allout;
        private string connString;
        private MySqlConnection conn;
        private MySqlCommand cmd;
        private MySqlDataReader read;

        public MedList(string c)
        {
            InitializeComponent();
            conn = new MySqlConnection(c);
        }

        private void PMedHist_Load(object sender, EventArgs e)
        {
            this.medListView.Rows.Add("Add Medication");
        }

   
        private void doneButton_Click(object sender, EventArgs e)
        {

        }



        private void addButton_Click(object sender, EventArgs e)
        {

        }

        private void okButton_Click(object sender, EventArgs e)
        {

        }
    }
}
