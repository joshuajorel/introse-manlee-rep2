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
            //selID = UInt16.Parse(patientView.SelectedCells[0].Value.ToString());

            sel = UInt16.Parse(patientView.SelectedCells[0].Value.ToString());
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

    }
}
