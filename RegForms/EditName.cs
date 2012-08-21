using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using introseHHC.Objects;

namespace introseHHC.Objects
{
    public partial class EditName : Form
    {
        private bool status;

        public bool Status
        {
            get { return status; }
            set { status = value; }
        }
        private string firstName;

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        private string middleName;

        public string MiddleName
        {
            get { return middleName; }
            set { middleName = value; }
        }
        private string lastName;

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        private string designation;

        public string Designation
        {
            get { return designation; }
            set { designation = value; }
        }

        public EditName()
        {
            InitializeComponent();
            status = false;
            firstName = "";
            middleName = "";
            lastName = "";
            designation = "";
        }

        public EditName(string d, string f, string m, string l)
        {
            InitializeComponent();
            status = false;
            fNameField.Text  = firstName = f;
            mNameField.Text  = middleName = m;
            snameField.Text  = lastName = l;
            desigBox.Text = designation = d;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            bool f, m, l, d;
            //d = desigBox.SelectedIndex != 0;
            d = desigBox.Items.Contains(desigBox.Text);
            f = Checker.check(fNameField.Text);
            m = Checker.check(mNameField.Text);
            l = Checker.check(snameField.Text);

            if (f && m && l &&d)
            {
                this.Hide();
                status = true;
                Console.WriteLine("Name is good.");
                firstName = fNameField.Text;
                middleName = mNameField.Text;
                lastName = snameField.Text;
                designation = desigBox.Text;
            }
            else
            {   
                Console.WriteLine("Name not good.");
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            status = false;
            this.Hide();
           
        }
    }
}
