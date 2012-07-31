using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace introseHHC.ErrorDiags
{
    public partial class ErrorBox : Form
    {
        private StringBuilder errMsg;
        public ErrorBox(System.Text.StringBuilder sb)
        {
            InitializeComponent();
            errMsg = sb;

            errorTextBox.Text = sb.ToString();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
