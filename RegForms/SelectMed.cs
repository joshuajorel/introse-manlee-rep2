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
    public partial class SelectMed : Form
    {
        private bool status;

        public bool Status
        {
            get { return status; }
            set { status = value; }
        }
        private string medName;

        public string MedName
        {
            get { return medName; }
            set { medName = value; }
        }
        private UInt16 medID;

        public UInt16 MedID
        {
            get { return medID; }
            set { medID = value; }
        }

        public SelectMed()
        {
            InitializeComponent();
            status = false;
        }

        private void SelectMed_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'getMedicationsDB.getMedications' table. You can move, or remove it, as needed.
            this.getMedicationsTableAdapter.Fill(this.getMedicationsDB.getMedications);

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            status = false;
        }

        private void searchField_TextChanged(object sender, EventArgs e)
        {
            this.getMedicationsBindingSource.Filter = string.Format("medName LIKE '*{0}*'", searchField.Text);
        }

        private void medView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //UInt16.Parse(employeeView.SelectedCells[0].Value.ToString())
            medID = UInt16.Parse(medView.SelectedCells[0].Value.ToString());
            medName = medView.SelectedCells[1].Value.ToString();

            Console.WriteLine(medName+" "+medID.ToString());
            status = true;
            this.Hide();
        }

        private void SelectMed_VisibleChanged(object sender, EventArgs e)
        {
            Console.WriteLine("Status:"+this.Visible.ToString());
            if (!this.Visible)
            {
                

            }
        }
    }
}
