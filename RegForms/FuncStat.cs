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
    public partial class FuncStat : Form
    {
        private Boolean[] ans = new Boolean[] { true, true, true, true, true, true, true, true, true, true, true, true };
        private FunctionalStatus func;

        private MySqlConnection conn;
        private MySqlCommand cmd;
        private MySqlDataReader read;
        private string user;
        private string password;
        private string server;
        private string database;
        private string query;

        private UInt16 fncID;

        public FuncStat(UInt16 id, string c)
        {
            InitializeComponent();
            FunctionalStatus func = new FunctionalStatus(ans);

            server = "localhost";
            user = "root";
            database = "hhc-db";
            password = "root";

            conn = new MySqlConnection(c);
            fncID = id;
            func = new FunctionalStatus();
        }

        private void FuncStat_Load(object sender, EventArgs e)
        {
            /*   if (func.getStat(0) == false)
               {   radioButton2.Checked=true;
               }
               if (func.getStat(1) == false)
               {
                   radioButton3.Checked = true;
               }
               if (func.getStat(2) == false)
               {
                   radioButton5.Checked = true;
               }
               if (func.getStat(3) == false)
               {
                   radioButton7.Checked = true;
               }
               if (func.getStat(4) == false)
               {
                   radioButton9.Checked = true;
               }
               if (func.getStat(5) == false)
               {
                   radioButton11.Checked = true;
               }
               if (func.getStat(6) == false)
               {
                   radioButton13.Checked = true;
               }
               if (func.getStat(7) == false)
               {
                   radioButton15.Checked = true;
               }
               if (func.getStat(8) == false)
               {
                   radioButton17.Checked = true;
               }
               if (func.getStat(9) == false)
               {
                   radioButton19.Checked = true;
               }
               if (func.getStat(10) == false)
               {
                   radioButton21.Checked = true;
               }
               if (func.getStat(11) == false)
               {
                   radioButton23.Checked = true;
              
               if (func.getStat(0) == true)
               {   radioButton1.Checked=true;
               }
               if (func.getStat(1) == true)
               {
                   radioButton4.Checked = true;
               }
               if (func.getStat(2) == true)
               {
                   radioButton6.Checked = true;
               }
               if (func.getStat(3) == true)
               {
                   radioButton8.Checked = true;
               }
               if (func.getStat(4) == true)
               {
                   radioButton10.Checked = true;
               }s
               if (func.getStat(5) == true)
               {
                   radioButton12.Checked = true;
               }
               if (func.getStat(6) == true)
               {
                   radioButton14.Checked = true;
               }
               if (func.getStat(7) == true)
               {
                   radioButton16.Checked = true;
               }
               if (func.getStat(8) == true)
               {
                   radioButton18.Checked = true;
               }
               if (func.getStat(9) == true)
               {
                   radioButton20.Checked = true;
               }
               if (func.getStat(10) == true)
               {
                   radioButton22.Checked = true;
               }
               if (func.getStat(11) == true)
               {
                   radioButton24.Checked = true;
               }*/
        }

        private void addfunc(FunctionalStatus fs)
        {
            conn.Open();
            string query = "INSERT INTO FUNCSTAT(CGAID, ANSWER, NUMBER) VALUES" +
                "(@id, @ans, @num)";
            cmd.CommandText = query;

            for (int ccnt = 0; ccnt < 12; ccnt++)
            {
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", fncID);
                cmd.Parameters.AddWithValue("@ans", fs.getStat(ccnt));
                cmd.Parameters.AddWithValue("@num", ccnt + 1);
                cmd.Prepare();
                cmd.ExecuteNonQuery();
            }
            conn.Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            func.setStat(0, true);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            func.setStat(0, false);
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            func.setStat(1, true);
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            func.setStat(1, false);
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            func.setStat(2, true);
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            func.setStat(2, false);
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            func.setStat(3, true);
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            func.setStat(3, false);
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            func.setStat(4, true);
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            func.setStat(4, false);
        }

        private void radioButton12_CheckedChanged(object sender, EventArgs e)
        {
            func.setStat(5, true);
        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {
            func.setStat(5, false);
        }

        private void radioButton14_CheckedChanged(object sender, EventArgs e)
        {
            func.setStat(6, true);
        }

        private void radioButton13_CheckedChanged(object sender, EventArgs e)
        {
            func.setStat(6, false);
        }

        private void radioButton16_CheckedChanged(object sender, EventArgs e)
        {
            func.setStat(7, true);
        }

        private void radioButton15_CheckedChanged(object sender, EventArgs e)
        {
            func.setStat(7, false);
        }

        private void radioButton18_CheckedChanged(object sender, EventArgs e)
        {
            func.setStat(8, true);
        }

        private void radioButton17_CheckedChanged(object sender, EventArgs e)
        {
            func.setStat(8, false);
        }

        private void radioButton20_CheckedChanged(object sender, EventArgs e)
        {
            func.setStat(9, true);
        }

        private void radioButton19_CheckedChanged(object sender, EventArgs e)
        {
            func.setStat(9, false);
        }

        private void radioButton22_CheckedChanged(object sender, EventArgs e)
        {
            func.setStat(10, true);
        }

        private void radioButton21_CheckedChanged(object sender, EventArgs e)
        {
            func.setStat(10, false);
        }

        private void radioButton24_CheckedChanged(object sender, EventArgs e)
        {
            func.setStat(11, true);
        }

        private void radioButton23_CheckedChanged(object sender, EventArgs e)
        {
            func.setStat(11, false);
        }

        private void okButton_Click(object sender, EventArgs e)
        {

        }

    }
}
