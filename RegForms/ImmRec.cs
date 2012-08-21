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
    public partial class ImmRec : Form
    {
        private MySqlConnection conn;
        private MySqlCommand cmd;
        private MySqlDataReader read;
        private string user;
        private string password;
        private string database;
        private string server;
        private string query;
        private Immunization imm;

        private UInt16 immID;
        private DateTime tet;
        private DateTime pne;
        private DateTime inf;
        private DateTime oth;
       
        public ImmRec(UInt16 id, string c)
        {
            InitializeComponent();
            server = "localhost";
            user = "root";
            database = "hhc-db";
            password = "root";

            conn = new MySqlConnection(c);
            immID = id;
            imm = new Immunization();
        }
        private void setimmrec(Immunization rec)
        {
            conn.Open();
            string query = "INSERT INTO IMM_REC(TETDATE, PNEDATE, INFDATE, OTHDATE)" +
                "VALUES (@tet, @pne, @inf, @oth)";

            cmd = new MySqlCommand(query, conn);
            cmd.Prepare();

            //cmd.Parameters.AddWithValue("@tet", rec.getTet);
            //cmd.Parameters.AddWithValue("@pne", rec.getPne);
            //cmd.Parameters.AddWithValue("@inf", rec.getInf);
            //cmd.Parameters.AddWithValue("@oth", rec.getOth);

            cmd.ExecuteNonQuery();

            try
            {
                cmd.ExecuteNonQuery();
                Console.WriteLine("Immunization Record Has Been Added.");
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
            conn.Close();

        }

        private void okButton_Click(object sender, EventArgs e)
        {
            tet = tetDate.Value;
            pne = pneDate.Value;
            inf = infDate.Value;
            oth = othDate.Value;

            imm.setTet(tet);
            imm.setPne(pne);
            imm.setInf(inf);
            imm.setOth(oth);

            setimmrec(imm);

            this.Hide();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void ImmRec_Load(object sender, EventArgs e)
        {

        }
    }
}
