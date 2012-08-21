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
    public partial class CGAForm : Form
    {
        private MySqlConnection conn;
        private MySqlCommand cmd;
        private MySqlDataReader read;
        private string connString;
        private PersonalHistory phis;
        private FamilyHistory fhis;
        private GDScales gds;
        private MentalExam me;
        private Nutrition nut;
        private CGiverAssess ca;
        private CGA cga;
        private UInt16 selID;
        private UInt16 phyID;
        private int msScore;

        private Boolean[] gdAns = new Boolean[]{true, false, false, false, true, false, true, false, false, false, true, true, true, false, false};
        private Boolean[] meAns = new Boolean[30];

        private void countBool()
        {
            for (int a = 0; a < meAns.Length; a++)
            {
                meAns[a] = false;
            }
        }
        

        public CGAForm(String c)
        {
            InitializeComponent();
            cga = new CGA();
            phis = new PersonalHistory();
            fhis = new FamilyHistory(false, false, false, false);
            gds = new GDScales(gdAns);
            ca = new CGiverAssess();

            countBool();
            me = new MentalExam(meAns);

            nut = new Nutrition();

            conn = new MySqlConnection();
            connString = c;

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

        private void CGAForm_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tabPage5_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label58_Click(object sender, EventArgs e)
        {

        }

        private void groupBox22_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton50_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton67_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            ImmRec IR = new ImmRec();
            IR.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SocEnv soc = new SocEnv(selID ,connString);
            soc.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PMedHist PMH = new PMedHist();
            PMH.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MedList ML = new MedList();
            ML.ShowDialog();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            FuncStat FS = new FuncStat();
            FS.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void selPatient_Click(object sender, EventArgs e)
        {
            PatientSelect psel = new PatientSelect();

            psel.ShowDialog();

            selID = psel.Sel;
           
            psel.Close();

            if (selID != 0)
            {
                cga.PID = selID;
                textBox1.Text = psel.Fname + " " + psel.Sname;
                panel1.Enabled = true;
                panel2.Enabled = true;
                panel3.Enabled = true;
                panel4.Enabled = true;
            }
        }

        private void selPhysician_Click(object sender, EventArgs e)
        {
            SelectEmployee sel = new SelectEmployee();
            sel.ShowDialog();
            phyID = sel.Sel;
            sel.Close();

            if (phyID != 0)
            {
                cga.PHYID = phyID;
                apTB.Text = sel.Fname + " " + sel.Sname;
            }
        }

        private void diaYesRB_CheckedChanged(object sender, EventArgs e)
        {
            fhis.setBD(true);
        }

        private void canYesRB_CheckedChanged(object sender, EventArgs e)
        {
            fhis.setCnr(true);
        }

        private void tubYesRB_CheckedChanged(object sender, EventArgs e)
        {
            fhis.setTub(true);
        }

        private void bdYesRB_CheckedChanged(object sender, EventArgs e)
        {
            fhis.setBD(true);
        }

        private void diaNoRB_CheckedChanged(object sender, EventArgs e)
        {
            fhis.setDbs(false);
        }

        private void canNoRB_CheckedChanged(object sender, EventArgs e)
        {
            fhis.setCnr(false);
        }

        private void tubNoRB_CheckedChanged(object sender, EventArgs e)
        {
            fhis.setTub(false);
        }

        private void bdNoRB_CheckedChanged(object sender, EventArgs e)
        {
            fhis.setBD(false);
        }

        private void nextBtn1_Click(object sender, EventArgs e)
        {
            cga.setIns(hiTB.Text);          
            cga.setPpc(ppcTB.Text);

            phis.setAllergy(allergyTB.Text);
            phis.setSmoke(smokingTB.Text);
            phis.setDrink(drinkingTB.Text);
            phis.setHobby(hobbyTB.Text);

            cga.setPH(phis);
            cga.setFH(fhis);
            tabControl1.SelectedIndex++;
        }

/////////////////////// NEXT TAB - Geriartric Depression Scale////////////////////////////////////////////////

//can still be optimized for later

        private void gdScore1_CheckedChanged_1(object sender, EventArgs e)
        {
            gds.setScale(0, true);
        }

        private void gdScore2_CheckedChanged_1(object sender, EventArgs e)
        {
            gds.setScale(1, true);
        }

        private void gdScore3_CheckedChanged_1(object sender, EventArgs e)
        {
            gds.setScale(2, true);
        }

        private void gdScore4_CheckedChanged_1(object sender, EventArgs e)
        {
            gds.setScale(3, true);
        }

        private void gdScore5_CheckedChanged_1(object sender, EventArgs e)
        {
            gds.setScale(4, true);
        }

        private void gdScore6_CheckedChanged_1(object sender, EventArgs e)
        {
            gds.setScale(5, true);
        }

        private void gdScore7_CheckedChanged_1(object sender, EventArgs e)
        {
            gds.setScale(6, true);
        }

        private void gdScore8_CheckedChanged_1(object sender, EventArgs e)
        {
            gds.setScale(7, true);
        }

        private void gdScore9_CheckedChanged_1(object sender, EventArgs e)
        {
            gds.setScale(8, true);
        }

        private void gdScore10_CheckedChanged_1(object sender, EventArgs e)
        {
            gds.setScale(9, true);
        }

        private void gdScore11_CheckedChanged_1(object sender, EventArgs e)
        {
            gds.setScale(10, true);
        }

        private void gdScore12_CheckedChanged_1(object sender, EventArgs e)
        {
            gds.setScale(11, true);
        }

        private void gdScore13_CheckedChanged_1(object sender, EventArgs e)
        {
            gds.setScale(12, true);
        }

        private void gdScore14_CheckedChanged_1(object sender, EventArgs e)
        {
            gds.setScale(13, true);
        }

        private void gdScore15_CheckedChanged_1(object sender, EventArgs e)
        {
            gds.setScale(14, true);
        }

        private void gdNo1_CheckedChanged_1(object sender, EventArgs e)
        {
            gds.setScale(0, false);
        }

        private void gdNo2_CheckedChanged_1(object sender, EventArgs e)
        {
            gds.setScale(1, false);
        }

        private void gdNo3_CheckedChanged_1(object sender, EventArgs e)
        {
            gds.setScale(2, false);
        }

        private void gdNo4_CheckedChanged_1(object sender, EventArgs e)
        {
            gds.setScale(3, false);
        }

        private void gdNo5_CheckedChanged_1(object sender, EventArgs e)
        {
            gds.setScale(4, false);
        }

        private void gdNo6_CheckedChanged_1(object sender, EventArgs e)
        {
            gds.setScale(5, false);
        }

        private void gdNo7_CheckedChanged_1(object sender, EventArgs e)
        {
            gds.setScale(6, false);
        }

        private void gdNo8_CheckedChanged_1(object sender, EventArgs e)
        {
            gds.setScale(7, false);
        }

        private void gdNo9_CheckedChanged_1(object sender, EventArgs e)
        {
            gds.setScale(8, false);
        }

        private void gdNo10_CheckedChanged_1(object sender, EventArgs e)
        {
            gds.setScale(9, false);
        }

        private void gdNo11_CheckedChanged_1(object sender, EventArgs e)
        {
            gds.setScale(10, false);
        }

        private void gdNo12_CheckedChanged_1(object sender, EventArgs e)
        {
            gds.setScale(11, false);
        }

        private void gdNo13_CheckedChanged_1(object sender, EventArgs e)
        {
            gds.setScale(12, false);
        }

        private void gdNo14_CheckedChanged_1(object sender, EventArgs e)
        {
            gds.setScale(13, false);
        }

        private void gdNo15_CheckedChanged_1(object sender, EventArgs e)
        {
            gds.setScale(14, false);
        }

        private void gdCompute_Click_1(object sender, EventArgs e)
        {
            gdTotalTB.Text = gds.computeScore().ToString() + " - " + gds.assess();
        }

        private void nextBtn2_Click_1(object sender, EventArgs e)
        {
            cga.setGD(gds);
            tabControl1.SelectedIndex++;
        }

/////////////////// NEXT TAB - MENTAL STATUS ///////////////////////////////////////////

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                me.setAns(0, true);
            else
                me.setAns(0, false);
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
                me.setAns(1, true);
            else
                me.setAns(1, false);
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
                me.setAns(2, true);
            else
                me.setAns(2, false);
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
                me.setAns(3, true);
            else
                me.setAns(3, false);
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked)
                me.setAns(4, true);
            else
                me.setAns(4, false);
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked)
                me.setAns(5, true);
            else
                me.setAns(5, false);
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox7.Checked)
                me.setAns(6, true);
            else
                me.setAns(6, false);
        }
        
        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox8.Checked)
                me.setAns(7, true);
            else
                me.setAns(7, false);
        }
        
        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox9.Checked)
                me.setAns(8, true);
            else
                me.setAns(8, false);
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox10.Checked)
                me.setAns(9, true);
            else
                me.setAns(9, false);
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox11.Checked)
                me.setAns(10, true);
            else
                me.setAns(10, false);
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox12.Checked)
                me.setAns(11, true);
            else
                me.setAns(11, false);
        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox13.Checked)
                me.setAns(12, true);
            else
                me.setAns(12, false);
        }

        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox14.Checked)
                me.setAns(13, true);
            else
                me.setAns(13, false);
        }

        private void checkBox15_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox15.Checked)
                me.setAns(14, true);
            else
                me.setAns(14, false);
        }

        private void checkBox16_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox16.Checked)
                me.setAns(15, true);
            else
                me.setAns(15, false);
        }

        private void checkBox17_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox17.Checked)
                me.setAns(16, true);
            else
                me.setAns(16, false);
        }

        private void checkBox18_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox18.Checked)
                me.setAns(17, true);
            else
                me.setAns(17, false);
        }

        private void checkBox19_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox19.Checked)
                me.setAns(18, true);
            else
                me.setAns(18, false);
        }

        private void checkBox20_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox20.Checked)
                me.setAns(19, true);
            else
                me.setAns(19, false);
        }

        private void checkBox21_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox21.Checked)
                me.setAns(20, true);
            else
                me.setAns(20, false);
        }

        private void checkBox22_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox22.Checked)
                me.setAns(21, true);
            else
                me.setAns(21, false);
        }

        private void checkBox23_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox23.Checked)
                me.setAns(22, true);
            else
                me.setAns(22, false);
        }

        private void checkBox24_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox24.Checked)
                me.setAns(23, true);
            else
                me.setAns(23, false);
        }

        private void checkBox25_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox25.Checked)
                me.setAns(24, true);
            else
                me.setAns(24, false);
        }

        private void checkBox26_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox26.Checked)
                me.setAns(25, true);
            else
                me.setAns(25, false);
        }

        private void checkBox27_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox27.Checked)
                me.setAns(26, true);
            else
                me.setAns(26, false);
        }

        private void checkBox28_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox28.Checked)
                me.setAns(27, true);
            else
                me.setAns(27, false);
        }

        private void checkBox29_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox29.Checked)
                me.setAns(28, true);
            else
                me.setAns(28, false);
        }

        private void msComputeBtn_Click(object sender, EventArgs e)
        {
            msTB.Text = me.getScore().ToString();
        }

        private void nextBtn3_Click(object sender, EventArgs e)
        {
            cga.setME(me);
            tabControl1.SelectedIndex++;
        }

        
///////////////////////// NEXT TAB - NUTRITIONAL ASSESSMENT //////////////////////////////////////


        private void na1Btn1_CheckedChanged(object sender, EventArgs e)
        {
            nut.setNut(0, 0);
        }

        private void na1Btn2_CheckedChanged(object sender, EventArgs e)
        {
            nut.setNut(0, 1);

        }

        private void na1Btn3_CheckedChanged(object sender, EventArgs e)
        {
            nut.setNut(0, 3);
        }

        private void na2Btn1_CheckedChanged(object sender, EventArgs e)
        {
            nut.setNut(1, 0);
        }

        private void na2Btn2_CheckedChanged(object sender, EventArgs e)
        {
            nut.setNut(1, 0.5f);
        }

        private void na2Btn3_CheckedChanged(object sender, EventArgs e)
        {
            nut.setNut(1, 1);
        }

        private void na3Btn1_CheckedChanged(object sender, EventArgs e)
        {
            nut.setNut(2, 0);
        }

        private void na3Btn2_CheckedChanged(object sender, EventArgs e)
        {
            nut.setNut(2, 1);
        }

        private void na4Btn1_CheckedChanged(object sender, EventArgs e)
        {
            nut.setNut(3, 0);
        }

        private void na4Btn2_CheckedChanged(object sender, EventArgs e)
        {
            nut.setNut(3, 1);
        }

        private void na4Btn3_CheckedChanged(object sender, EventArgs e)
        {
            nut.setNut(3, 2);
        }

        private void na4Btn4_CheckedChanged(object sender, EventArgs e)
        {
            nut.setNut(3, 3);
        }

        private void na5Btn1_CheckedChanged(object sender, EventArgs e)
        {
            nut.setNut(4, 1);
        }

        private void na5Btn2_CheckedChanged(object sender, EventArgs e)
        {
            nut.setNut(4, 0);
        }

        private void na6Btn1_CheckedChanged(object sender, EventArgs e)
        {
            nut.setNut(5, 0);
        }

        private void na6Btn2_CheckedChanged(object sender, EventArgs e)
        {
            nut.setNut(5, 1);
        }

        private void na7Btn1_CheckedChanged(object sender, EventArgs e)
        {
            nut.setNut(6, 1);
        }

        private void na7Btn2_CheckedChanged(object sender, EventArgs e)
        {
            nut.setNut(6, 2);
        }

        private void na8Btn1_CheckedChanged(object sender, EventArgs e)
        {
            nut.setNut(7, 0);
        }

        private void na8Btn2_CheckedChanged(object sender, EventArgs e)
        {
            nut.setNut(7, 1);
        }

        private void na8Btn3_CheckedChanged(object sender, EventArgs e)
        {
            nut.setNut(7, 2);
        }

        private void na9Btn1_CheckedChanged(object sender, EventArgs e)
        {
            nut.setNut(8, 0);
        }

        private void na9Btn2_CheckedChanged(object sender, EventArgs e)
        {
            nut.setNut(8, 2);
        }

        private void na10Btn1_CheckedChanged(object sender, EventArgs e)
        {
            nut.setNut(9, 0);
        }

        private void na10Btn2_CheckedChanged(object sender, EventArgs e)
        {
            nut.setNut(9, 1);
        }

        private void na10Btn3_CheckedChanged(object sender, EventArgs e)
        {
            nut.setNut(9, 2);
        }

        private void na11Btn1_CheckedChanged(object sender, EventArgs e)
        {
            nut.setNut(10, 0);
        }

        private void na11Btn2_CheckedChanged(object sender, EventArgs e)
        {
            nut.setNut(10, 1);
        }

        private void na12Btn1_CheckedChanged(object sender, EventArgs e)
        {
            nut.setNut(11, 0);
        }

        private void na12Btn2_CheckedChanged(object sender, EventArgs e)
        {
            nut.setNut(11, 1);
        }

        private void na12Btn3_CheckedChanged(object sender, EventArgs e)
        {
            nut.setNut(11, 2);
        }

        private void na13Btn1_CheckedChanged(object sender, EventArgs e)
        {
            if (na13Btn1.Checked)
            nut.proAdd();
        }

        private void na13Btn2_CheckedChanged(object sender, EventArgs e)
        {
            if (na13Btn2.Checked)
            nut.proSub();
        }

        private void na14Btn1_CheckedChanged(object sender, EventArgs e)
        {
            if (na14Btn1.Checked)
            nut.proAdd();
        }

        private void na14Btn2_CheckedChanged(object sender, EventArgs e)
        {
            if (na14Btn2.Checked)
            nut.proSub();
        }

        private void na15Btn1_CheckedChanged(object sender, EventArgs e)
        {
            if (na15Btn1.Checked)
            nut.proAdd();
        }

        private void na15Btn2_CheckedChanged(object sender, EventArgs e)
        {
            if (na15Btn2.Checked)
            nut.proSub();
        }

        private void na16Btn1_CheckedChanged(object sender, EventArgs e)
        {
            nut.setNut(13, 1);
        }

        private void na16Btn2_CheckedChanged(object sender, EventArgs e)
        {
            nut.setNut(13, 0);
        }

        private void na17Btn1_CheckedChanged(object sender, EventArgs e)
        {
            nut.setNut(14, 0);
        }

        private void na17Btn2_CheckedChanged(object sender, EventArgs e)
        {
            nut.setNut(14, 1);
        }

        private void na17Btn3_CheckedChanged(object sender, EventArgs e)
        {
            nut.setNut(14, 2);
        }

        private void na18Btn1_CheckedChanged(object sender, EventArgs e)
        {
            nut.setNut(15, 0);
        }

        private void na18Btn2_CheckedChanged(object sender, EventArgs e)
        {
            nut.setNut(15, 0.5f);
        }

        private void na18Btn3_CheckedChanged(object sender, EventArgs e)
        {
            nut.setNut(15, 1);
        }

        private void na19Btn1_CheckedChanged(object sender, EventArgs e)
        {
            nut.setNut(16, 0);
        }

        private void na19Btn2_CheckedChanged(object sender, EventArgs e)
        {
            nut.setNut(16, 1);
        }

        private void na19Btn3_CheckedChanged(object sender, EventArgs e)
        {
            nut.setNut(16, 2);
        }

        private void nutComputeBtn_Click(object sender, EventArgs e)
        {
            nutTB.Text = nut.getScore().ToString() + " - " + nut.assess();
        }

        private void nextBtn4_Click(object sender, EventArgs e)
        {
            cga.setNu(nut);
            tabControl1.SelectedIndex++;
        }

//////////////// NEXT TAB - CAREGIVER ASSESSMENT SORRY LAST NA TOH ////////////////


        private void caNoRB1_CheckedChanged(object sender, EventArgs e)
        {
            if (caNoRB1.Checked)
            {
                ca.setAns(0, false);
            }
            
        }

        private void caNoRB2_CheckedChanged(object sender, EventArgs e)
        {
            if (caNoRB2.Checked)
            {
                ca.setAns(1, false);
            }
            
        }

        private void caNoRB3_CheckedChanged(object sender, EventArgs e)
        {
            if (caNoRB3.Checked)
            {
                ca.setAns(2, false);
            }
            
        }

        private void caNoRB4_CheckedChanged(object sender, EventArgs e)
        {
            if (caNoRB4.Checked)
            {
                ca.setAns(3, false);
            }
            
        }

     
        private void cg_CheckedChanged(object sender, EventArgs e)
        {
            ca.setAns(0, true);
        }

        private void radioButton14_CheckedChanged(object sender, EventArgs e)
        {
            ca.setAns(1, true);
        }

        private void radioButton12_CheckedChanged(object sender, EventArgs e)
        {
            ca.setAns(2, true);
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            ca.setAns(3, true);
            Console.WriteLine(ca.getAns(3));
        }

        private void cgaSubmitBtn_Click(object sender, EventArgs e)
        {

            cga.setCAss(ca);
        }

        
    }
}
