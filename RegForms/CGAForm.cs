using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace introseHHC.RegForms
{
    public partial class CGAForm : Form
    {
        public CGAForm()
        {
            InitializeComponent();
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
            Social soc = new Social();
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
    }
}
