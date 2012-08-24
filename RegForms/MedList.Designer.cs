namespace introseHHC.RegForms
{
    partial class MedList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cancelButton = new System.Windows.Forms.Button();
            this.medListView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.freqField = new System.Windows.Forms.TextBox();
            this.doseField = new System.Windows.Forms.TextBox();
            this.medField = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.selectMed = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.medListView)).BeginInit();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(469, 15);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 8;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // medListView
            // 
            this.medListView.AllowUserToAddRows = false;
            this.medListView.AllowUserToDeleteRows = false;
            this.medListView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.medListView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.medListView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.medListView.Location = new System.Drawing.Point(12, 15);
            this.medListView.Name = "medListView";
            this.medListView.ReadOnly = true;
            this.medListView.Size = new System.Drawing.Size(451, 172);
            this.medListView.TabIndex = 6;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Medicine";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Dose";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Frequency";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // freqField
            // 
            this.freqField.Location = new System.Drawing.Point(227, 215);
            this.freqField.Name = "freqField";
            this.freqField.Size = new System.Drawing.Size(118, 20);
            this.freqField.TabIndex = 13;
            // 
            // doseField
            // 
            this.doseField.Location = new System.Drawing.Point(148, 215);
            this.doseField.Name = "doseField";
            this.doseField.Size = new System.Drawing.Size(73, 20);
            this.doseField.TabIndex = 12;
            // 
            // medField
            // 
            this.medField.Location = new System.Drawing.Point(12, 216);
            this.medField.Name = "medField";
            this.medField.Size = new System.Drawing.Size(130, 20);
            this.medField.TabIndex = 11;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(361, 213);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 10;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Medicine";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(168, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Dose";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(255, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Frequency";
            // 
            // selectMed
            // 
            this.selectMed.Location = new System.Drawing.Point(12, 242);
            this.selectMed.Name = "selectMed";
            this.selectMed.Size = new System.Drawing.Size(46, 20);
            this.selectMed.TabIndex = 17;
            this.selectMed.Text = "Select";
            this.selectMed.UseVisualStyleBackColor = true;
            this.selectMed.Click += new System.EventHandler(this.selectMed_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(96, 242);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(46, 20);
            this.clearButton.TabIndex = 18;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // MedList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 265);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.selectMed);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.freqField);
            this.Controls.Add(this.doseField);
            this.Controls.Add(this.medField);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.medListView);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(564, 292);
            this.MinimumSize = new System.Drawing.Size(564, 292);
            this.Name = "MedList";
            this.Text = "Medication List";
            this.Load += new System.EventHandler(this.MedList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.medListView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.DataGridView medListView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.TextBox freqField;
        private System.Windows.Forms.TextBox doseField;
        private System.Windows.Forms.TextBox medField;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button selectMed;
        private System.Windows.Forms.Button clearButton;
    }
}