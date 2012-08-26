﻿using System;
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
        private FunctionalStatus func;

        private MySqlConnection conn;
        private MySqlCommand cmd;
        private MySqlDataReader read;
        private string query;

        private UInt16 fncID;
        private bool ans = new bool();
        private int num;

        public FuncStat(UInt16 id, string c)
        {
            InitializeComponent();
            num = 0;
            FunctionalStatus func = new FunctionalStatus(ans, num);

            conn = new MySqlConnection(c);
            fncID = id;
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

        private void FuncStat_Load(object sender, EventArgs e)
        {
            if (func.getStat(num) != null)
            {
                for (num = 0; num < 12; num++)
                {
                    func.getStat(num);
                }

                if (func.getStat(0) == true)
                {
                    radioButton1.Checked = true;
                }
                else if (func.getStat(0) == false)
                {
                    radioButton2.Checked = true;
                }
                if (func.getStat(1) == true)
                {
                    radioButton4.Checked = true;
                }
                else if (func.getStat(1) == false)
                {
                    radioButton3.Checked = true;
                }
                if (func.getStat(2) == true)
                {
                    radioButton6.Checked = true;
                }
                else if (func.getStat(2) == false)
                {
                    radioButton5.Checked = true;
                }
                if (func.getStat(3) == true)
                {
                    radioButton8.Checked = true;
                }
                else if (func.getStat(3) == false)
                {
                    radioButton7.Checked = true;
                }
                if (func.getStat(4) == true)
                {
                    radioButton10.Checked = true;
                }
                else if (func.getStat(4) == false)
                {
                    radioButton9.Checked = true;
                }
                if (func.getStat(5) == true)
                {
                    radioButton12.Checked = true;
                }
                else if (func.getStat(5) == false)
                {
                    radioButton11.Checked = true;
                }
                if (func.getStat(6) == true)
                {
                    radioButton14.Checked = true;
                }
                else if (func.getStat(6) == false)
                {
                    radioButton13.Checked = true;
                }
                if (func.getStat(7) == true)
                {
                    radioButton16.Checked = true;
                }
                else if (func.getStat(7) == false)
                {
                    radioButton15.Checked = true;
                }
                if (func.getStat(8) == true)
                {
                    radioButton18.Checked = true;
                }
                else if (func.getStat(8) == false)
                {
                    radioButton17.Checked = true;
                }
                if (func.getStat(9) == true)
                {
                    radioButton20.Checked = true;
                }
                else if (func.getStat(9) == false)
                {
                    radioButton19.Checked = true;
                }
                if (func.getStat(10) == true)
                {
                    radioButton22.Checked = true;
                }
                else if (func.getStat(10) == false)
                {
                    radioButton21.Checked = true;
                }
                if (func.getStat(11) == true)
                {
                    radioButton24.Checked = true;
                }
                else if (func.getStat(11) == false)
                {
                    radioButton23.Checked = true;
                }
            }
            else
            {
                radioButton1.Checked = true;
                radioButton4.Checked = true;
                radioButton6.Checked = true;
                radioButton8.Checked = true;
                radioButton10.Checked = true;
                radioButton12.Checked = true;
                radioButton14.Checked = true;
                radioButton16.Checked = true;
                radioButton18.Checked = true;
                radioButton20.Checked = true;
                radioButton22.Checked = true;
                radioButton24.Checked = true;
            }
        }

        private void addfunc(FunctionalStatus fs)
        {
            if (OpenConnection())
            {
                string query = "INSERT INTO FUNCSTAT(CGAID, ANSWER, NUMBER) VALUES" +
                    "(@id, @ans, @num)";
                cmd.CommandText = query;
                cmd.Parameters.Clear();

                for(num = 0; num < 12; num++)
                {
                    try
                    {
                        cmd.Parameters.AddWithValue("@id", fncID);
                        cmd.Parameters.AddWithValue("@ans", fs.getStat(num));
                        cmd.Parameters.AddWithValue("@num", num);
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception err)
                    {
                        Console.WriteLine(err.Message);
                    }
                }
            }
            CloseConnection();
            Console.WriteLine("Functional Status Recorded.");
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            func.setStat(true, 0);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            func.setStat(false, 0);
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            func.setStat(true, 1);
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            func.setStat(false, 1);
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            func.setStat(true, 2);
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            func.setStat(false, 2);
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            func.setStat(true, 3);
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            func.setStat(false, 3);
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            func.setStat(true, 4);
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            func.setStat(false, 4);
        }

        private void radioButton12_CheckedChanged(object sender, EventArgs e)
        {
            func.setStat(true, 5);
        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {
            func.setStat(false, 5);
        }

        private void radioButton14_CheckedChanged(object sender, EventArgs e)
        {
            func.setStat(true, 6);
        }

        private void radioButton13_CheckedChanged(object sender, EventArgs e)
        {
            func.setStat(false, 6);
        }

        private void radioButton16_CheckedChanged(object sender, EventArgs e)
        {
            func.setStat(true, 7);
        }

        private void radioButton15_CheckedChanged(object sender, EventArgs e)
        {
            func.setStat(false, 7);
        }

        private void radioButton18_CheckedChanged(object sender, EventArgs e)
        {
            func.setStat(true, 8);
        }

        private void radioButton17_CheckedChanged(object sender, EventArgs e)
        {
            func.setStat(false, 8);
        }

        private void radioButton20_CheckedChanged(object sender, EventArgs e)
        {
            func.setStat(true, 9);
        }

        private void radioButton19_CheckedChanged(object sender, EventArgs e)
        {
            func.setStat(false, 9);
        }

        private void radioButton22_CheckedChanged(object sender, EventArgs e)
        {
            func.setStat(true, 10);
        }

        private void radioButton21_CheckedChanged(object sender, EventArgs e)
        {
            func.setStat(false, 10);
        }

        private void radioButton24_CheckedChanged(object sender, EventArgs e)
        {
            func.setStat(true, 11);
        }

        private void radioButton23_CheckedChanged(object sender, EventArgs e)
        {
            func.setStat(false, 11);
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            addfunc(func);
            this.Hide();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

    }
}
