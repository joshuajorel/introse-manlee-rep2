using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using introseHHC.Objects;
using MySql.Data.MySqlClient;

namespace introseHHC.RegForms
{
    public partial class MedListView : Form
    {
        private MySqlConnection conn;
        private MySqlDataReader read;
        private MySqlCommand cmd;
        private string nme;
        private string dose;
        private string freq;
        private string query;
        private SocialEnvironment se;
        private UInt16 ID;
        private int ct;

        public MedListView(UInt16 id, string c)
        {
            InitializeComponent();
            ID = id;
            conn = new MySqlConnection(c);
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

        private void MedListView_Load(object sender, EventArgs e)
        {
            if (OpenConnection())
            {   //load data into the table
                string query;
                query = "SELECT * FROM"
                + "(SELECT PATID ,MEDNAME,DOSAGE,FREQUENCY FROM MEDICATION_LIST AS ML "
                + "RIGHT JOIN MEDICATION_MAP AS MP ON ML.MEDID = MP.MEDID) AS MED "
                + "WHERE PATID = @pid";
                cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@pid", ID);
                read = cmd.ExecuteReader();

                int x;
                while (read.Read())
                {
                    x = mlView.Rows.Add();
                    mlView.Rows[x].Cells[0].Value = read.GetString("MEDNAME");
                    mlView.Rows[x].Cells[1].Value = read.GetString("DOSAGE");
                    mlView.Rows[x].Cells[2].Value = read.GetString("FREQUENCY");

                }
                read.Close();
                CloseConnection();
            }
        }
    }
}
