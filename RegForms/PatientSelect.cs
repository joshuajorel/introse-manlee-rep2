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
    public partial class PatientSelect : Form
    {
        private UInt16 sel;
        private string fname;

        public string Fname
        {
            get { return fname; }
            set { fname = value; }
        }
        private string mname;
        private string sname;

        public string Sname
        {
            get { return sname; }
            set { sname = value; }
        }

        public UInt16 Sel
        {
            get { return sel; }
            set { sel = value; }
        }
       
        public PatientSelect()
        {
            InitializeComponent();
            sel = 0;
        }

        

        private void okButton_Click(object sender, EventArgs e)
        {
            this.Hide();

            sel = UInt16.Parse(patientView.SelectedCells[0].Value.ToString());
            fname = patientView.SelectedCells[1].Value.ToString();
            sname = patientView.SelectedCells[2].Value.ToString();
        }

        

        private void PatientSelect_Load(object sender, EventArgs e)
        {
            this.getPatientsTableAdapter.Fill(this.getPatientsDB.getPatients);
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            sel = 0;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            getPatientsBindingSource.Filter =  string.Format("Surname LIKE '{0}'", searchIn.Text);
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            getPatientsBindingSource.Filter = "";
            searchIn.Text = "";
        }

    }
}
