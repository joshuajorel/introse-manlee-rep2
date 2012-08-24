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
        private bool connEstablished = false;
        private UInt16 patID;

        public MedList(UInt16 id, string c)
        {
            InitializeComponent();
            conn = new MySqlConnection(c);
            connString = c;
            patID = id;
        }

        private bool OpenConnection()
        {
            try
            {
                conn.Open();
                Console.WriteLine("SQL Connection Opened.");
                return true;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return false;
            }
        }

        private bool CloseConnection()
        {
            try
            {
                conn.Close();
                Console.WriteLine("SQL Connection Closed.");
                return true;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return false;
            }
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

        private void MedList_Load(object sender, EventArgs e)
        {
            if (OpenConnection())
            {   //load data into the table
                string query;


                connEstablished = true;
            }
            else
            {
                connEstablished = false;
            }

        }
    }
}
