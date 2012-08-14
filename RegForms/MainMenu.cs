using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using introseHHC.Objects;


namespace introseHHC.RegForms
{
    public partial class MainMenu : Form
    {

        private string user, pass;
        private Login li;

        private string db_server;
        private string db;
        private string db_user;
        private string db_password;
        private string connString;


        public MainMenu(Login l)
        {
            InitializeComponent();

            db_server = "localhost";
            db_user = "root";
            db = "hhc-db";
            db_password = "root";

            connString = "SERVER=" + db_server + ";" + "DATABASE=" +
                                db + ";" + "UID=" + db_user + ";" +
                                "PASSWORD=" + db_password + ";";

            li = l;
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        //register facesheet
        private void button1_Click(object sender, EventArgs e)
        {
            RegisterPatientTab regPatTab = new RegisterPatientTab();
            regPatTab.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            li.Show();
            li.clearPass();
        }


        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void regEmpButton_Click(object sender, EventArgs e)
        {
            RegisterEmployee emp = new RegisterEmployee();

            emp.ShowDialog();
        }

        private void manageRecButton_Click(object sender, EventArgs e)
        {
            ManageRecord mn = new ManageRecord(connString);

            mn.ShowDialog();
        }

      
    }
}
