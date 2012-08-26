using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using introseHHC.Objects;

namespace introseHHC.RegForms
{
    public partial class PMedHist : Form
    {
        private MySqlConnection conn;
        private MySqlCommand cmd;
        private MySqlDataReader read;
        private string query;
        private string connString;
        private MedicalHistory mhis;

        private string diag;
        private string place;
        private DateTime date;
        private UInt16 pmedID;

        public PMedHist(UInt16 id, string c)
        {
            InitializeComponent();


            conn = new MySqlConnection(c);
            pmedID = id;
            mhis = new MedicalHistory();
            connString = c;
            fillTable();
        }

        public UInt16 PMedID
        {
            get { return pmedID; }
            set { pmedID = value; }
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

        private void addmed(MedicalHistory mh)
        {
            if (OpenConnection())
            {
                string query = "INSERT INTO PMED_HIS(PATID, DIAGNOSIS, PLACECON, INCDATE) VALUES" +
                    "(@id ,@diag, @pla, @inc)";

                cmd = new MySqlCommand(query, conn);
                cmd.Prepare();

                cmd.Parameters.AddWithValue("@id", pmedID);
                cmd.Parameters.AddWithValue("@diag", mh.getDiag());
                cmd.Parameters.AddWithValue("@pla", mh.getPla());
                cmd.Parameters.AddWithValue("@inc", mh.getDate());

                try
                {
                    cmd.ExecuteNonQuery();
                    diagField.Text = string.Empty;
                    placeField.Text = string.Empty;
                    Console.WriteLine("Medical History Has Been Added.");

                }
                catch (Exception err)
                {
                    Console.WriteLine(err.Message);
                }
            }
            CloseConnection();
            pmedView.Rows.Clear();
            fillTable();
        }

        private void fillTable()
        {

            if (OpenConnection())
            {
                string query;
                query = "SELECT * FROM PMED_HIS WHERE PATID = @patID;";
                cmd = new MySqlCommand(query, conn);
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@patID", pmedID);
                read = cmd.ExecuteReader();

                int x;
                while (read.Read())
                {
                    x = pmedView.Rows.Add();
                    pmedView.Rows[x].Cells[0].Value = read.GetString("DIAGNOSIS");
                    pmedView.Rows[x].Cells[1].Value = read.GetString("PLACECON");
                    pmedView.Rows[x].Cells[2].Value = read.GetString("INCDATE");
                }
                read.Close();
                CloseConnection();
            }
        }

        private void addButton_Click_1(object sender, EventArgs e)
        {
            diag = diagField.Text;
            place = placeField.Text;
            date = DatePick.Value;

            mhis.setMH(diag, place, date);
            addmed(mhis);
        }

        private void okButton_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void cancelButton_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
