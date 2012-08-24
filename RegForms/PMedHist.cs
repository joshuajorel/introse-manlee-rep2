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
        private UInt16 patID;

        public PMedHist(UInt16 id, string c)
        {
            InitializeComponent();


            conn = new MySqlConnection(c);
            patID = id;
            mhis = new MedicalHistory();
            connString = c;
        }

        private void PMedHist_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'getPMed._getPMed' table. You can move, or remove it, as needed.
            this.getPMedTableAdapter.Fill(this.getPMed._getPMed);
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void addmed(MedicalHistory mh)
        {
            conn.Open();
            string query = "INSERT INTO PMED_HIS(PATID, DIAGNOSIS, PLACECON, INCDATE) VALUES" +
                "(@id ,@diag, @pla, @inc)";

            cmd = new MySqlCommand(query, conn);
            cmd.Prepare();

            cmd.Parameters.AddWithValue("@id", patID);
            cmd.Parameters.AddWithValue("@diag", mh.getDiag());
            cmd.Parameters.AddWithValue("@pla", mh.getPla());
            cmd.Parameters.AddWithValue("@inc", mh.getDate());

            try
            {
                cmd.ExecuteNonQuery();
                diagField.Text = string.Empty;
                placeField.Text = string.Empty;
                Console.WriteLine("Past Medical History Has Been Added.");

            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
            conn.Close();
        }


        private void addButton_Click_1(object sender, EventArgs e)
        {
            diag = diagField.Text;
            place = placeField.Text;
            date = DatePick.Value;

            mhis.setMH(diag, place, date);
            addmed(mhis);
            this.getPMedTableAdapter.Fill(this.getPMed._getPMed);
        }
    }
}
