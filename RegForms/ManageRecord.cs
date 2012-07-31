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
    public partial class ManageRecord : Form
    {
        public ManageRecord()
        {
            InitializeComponent();
        }

        private void ManageRecord_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'getEmployeeDetailsDB.getEmployeeDetails' table. You can move, or remove it, as needed.
            
            // TODO: This line of code loads data into the 'getClientDetailsDB.getClientDetails' table. You can move, or remove it, as needed.
            this.getClientDetailsTableAdapter.Fill(this.getClientDetailsDB.getClientDetails);
            // TODO: This line of code loads data into the 'getPatientDetailsDB.getPatientDetails' table. You can move, or remove it, as needed.
            this.getPatientDetailsTableAdapter.Fill(this.getPatientDetailsDB.getPatientDetails);
           

        }


    }
}
