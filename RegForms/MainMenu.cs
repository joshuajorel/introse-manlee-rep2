using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using introseHHC.Objects;


namespace introseHHC.RegForms
{
    public partial class MainMenu : Form
    {
        

        public MainMenu()
        {
            InitializeComponent();
            
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        //register facesheet
        private void button1_Click(object sender, EventArgs e)
        {
            RegisterPatientTab regPatTab = new RegisterPatientTab();
            regPatTab.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void regEmpButton_Click(object sender, EventArgs e)
        {
            RegisterEmployee emp = new RegisterEmployee();

            emp.ShowDialog();
        }
    }
}
