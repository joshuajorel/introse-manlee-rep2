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
    public partial class EditAddress : Form
    {
        private UInt16 num;

        public UInt16 Num
        {
            get { return num; }
            set { num = value; }
        }
        private string addline;

        public string Addline
        {
            get { return addline; }
            set { addline = value; }
        }
        private string city;

        public string City
        {
            get { return city; }
            set { city = value; }
        }
        private string regionVar;

        public string RegionVar
        {
            get { return regionVar; }
            set { regionVar = value; }
        }

        private bool status;

        public bool Status
        {
            get { return status; }
            set { status = value; }
        }

        public EditAddress()
        {
            InitializeComponent();
        }

        public EditAddress(UInt16 n, string a, string c, string r)
        {
            InitializeComponent();
            numField.Text = n.ToString();
            addLineField.Text = a;
            cityField.Text = c;
            regionField.Text = r;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            bool n, a, c, r;

            try
            {
                num  = UInt16.Parse(numField.Text);
                n = true;
            }
            catch (Exception err)
            {
                n = false;
            }
            a = introseHHC.Objects.Checker.check3(addLineField.Text);
            c = introseHHC.Objects.Checker.check(cityField.Text);
            r = introseHHC.Objects.Checker.check(regionField.Text);

            if (n && a && c && r)
            {
                this.Hide();
                status = true;
                addline = addLineField.Text;
                city = cityField.Text;
                regionVar = regionField.Text;
                
            }
            else
            {
                Console.WriteLine("Error.");
            }
            
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            status = false;
        }
    }
}
