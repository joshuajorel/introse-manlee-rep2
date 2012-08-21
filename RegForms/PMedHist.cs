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
        private string server;
        private string user;
        private string password;
        private string database;
        private string query;
        private MedicalHistory mhis;

        private string diag;
        private string place;
        private DateTime date;
        private UInt16 medID;

        public PMedHist(UInt16 id, string c)
        {
            InitializeComponent();
            server = "localhost";
            user = "root";
            database = "hhc-db";
            password = "root";

            conn = new MySqlConnection(c);
            medID = id;
            mhis = new MedicalHistory();
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
            string query = "INSERT INTO PMED_HIS(CGAID, DIAGNOSIS, PLACECON, INCDATE) VALUES" +
                "(@id ,@diag, @pla, @inc)";

            cmd = new MySqlCommand(query, conn);
            cmd.Prepare();

            cmd.Parameters.AddWithValue("@id", medID);
            cmd.Parameters.AddWithValue("@diag", mh.getDiag());
            cmd.Parameters.AddWithValue("@pla", mh.getPla());
            cmd.Parameters.AddWithValue("@inc", mh.getDate());

            try
            {
                cmd.ExecuteNonQuery();
                textBox1.Text = string.Empty;
                textBox2.Text = string.Empty;
                Console.WriteLine("Past Medical History Has Been Added.");

            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
            conn.Close();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            diag = textBox1.Text;
            place = textBox2.Text;
            date = DatePick.Value;

            mhis.setMH(diag, place, date);
            addmed(mhis);
        }
    }
}
