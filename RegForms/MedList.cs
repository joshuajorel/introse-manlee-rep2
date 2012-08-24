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
        private UInt16 medID;
        private bool selectStatus;

        public MedList(UInt16 id, string c)
        {
            InitializeComponent();
            conn = new MySqlConnection(c);
            connString = c;
            patID = id;
            selectStatus = false;
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

        private void addButton_Click(object sender, EventArgs e)
        {
            bool m, d, f;
            m = string.IsNullOrEmpty(medField.Text) || string.IsNullOrWhiteSpace(medField.Text);
            d = string.IsNullOrEmpty(doseField.Text) || string.IsNullOrWhiteSpace(doseField.Text);
            f = string.IsNullOrEmpty(freqField.Text) || string.IsNullOrWhiteSpace(freqField.Text);

            if (!m && !d && !f)
            {
                if (OpenConnection())
                {
                    string query;
                    query = "INSERT INTO MEDICATION_MAP(MEDID,PATID,DOSAGE,FREQUENCY)" 
                            +"VALUES (@mid,@pid,@dsg,@freq);";
                    cmd = new MySqlCommand(query,conn);
                    cmd.Parameters.Clear();
                    cmd.Prepare();
                    cmd.Parameters.AddWithValue("@mid",medID);
                    cmd.Parameters.AddWithValue("@pid",patID);
                    cmd.Parameters.AddWithValue("@dsg",doseField.Text);
                    cmd.Parameters.AddWithValue("@freq",freqField.Text);

                    cmd.ExecuteNonQuery();

                    if (!selectStatus)
                    {
                        query = "INSERT INTO MEDICATION_LIST(MEDNAME) VALUES(@mdname)";
                        cmd.Parameters.AddWithValue("@mdname",medField.Text);
                        cmd.CommandText = query;
                        cmd.ExecuteNonQuery();
                    
                    }
                    //reset fields
                    medField.Text = "";
                    medField.Enabled = true;
                    medID = 0;
                    doseField.Text = "";
                    freqField.Text = "";
                    selectStatus = false;

                    
                    CloseConnection();
                }
                else
                {
                }
                medListView.Rows.Clear();
                fillTable();
            }
            else
            {
                MessageBox.Show("Kindly fill-up all fields.","Message");
            }
        }

        private void MedList_Load(object sender, EventArgs e)
        {
            fillTable();
        }

        private void fillTable()
        {
            if (OpenConnection())
            {   //load data into the table
                string query;
                query = "SELECT * FROM"
        + "(SELECT PATID ,MEDNAME,DOSAGE,FREQUENCY FROM MEDICATION_LIST AS ML "
        + "RIGHT JOIN MEDICATION_MAP AS MP ON ML.MEDID = MP.MEDID) AS MED "
        + "WHERE PATID = @pid";
                cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@pid", patID);
                read = cmd.ExecuteReader();

                int x;
                while (read.Read())
                {
                    x = medListView.Rows.Add();
                    medListView.Rows[x].Cells[0].Value = read.GetString("MEDNAME");
                    medListView.Rows[x].Cells[1].Value = read.GetString("DOSAGE");
                    medListView.Rows[x].Cells[2].Value = read.GetString("FREQUENCY");

                }
                read.Close();

                CloseConnection();
                connEstablished = true;
            }
            else
            {
                connEstablished = false;
            }
        }

        private void selectMed_Click(object sender, EventArgs e)
        {
            introseHHC.RegForms.SelectMed sm = new introseHHC.RegForms.SelectMed();
            sm.ShowDialog();
            if (sm.Status)
            {
                medField.Text = sm.MedName;
                medID = sm.MedID;
                selectStatus = true;
                medField.Enabled = false;
            }
            sm.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {

                medField.Enabled = true;
                medField.Text = "";
                medID = 0;
          
        }
    }
}
