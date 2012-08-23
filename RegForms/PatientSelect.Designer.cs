namespace introseHHC.RegForms
{
    partial class PatientSelect
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
            this.components = new System.ComponentModel.Container();
            this.cancelButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.patientView = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.getPatientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.getPatientsDB = new introseHHC.getPatientsDB();
            this.getPatientsTableAdapter = new introseHHC.getPatientsDBTableAdapters.getPatientsTableAdapter();
            this.searchIn = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.patientView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getPatientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getPatientsDB)).BeginInit();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(306, 223);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(12, 223);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 4;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // patientView
            // 
            this.patientView.AllowUserToAddRows = false;
            this.patientView.AllowUserToDeleteRows = false;
            this.patientView.AutoGenerateColumns = false;
            this.patientView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.patientView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.surnameDataGridViewTextBoxColumn});
            this.patientView.DataSource = this.getPatientsBindingSource;
            this.patientView.Location = new System.Drawing.Point(11, 57);
            this.patientView.MultiSelect = false;
            this.patientView.Name = "patientView";
            this.patientView.ReadOnly = true;
            this.patientView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.patientView.Size = new System.Drawing.Size(370, 150);
            this.patientView.TabIndex = 6;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "First Name";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "First Name";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // surnameDataGridViewTextBoxColumn
            // 
            this.surnameDataGridViewTextBoxColumn.DataPropertyName = "Surname";
            this.surnameDataGridViewTextBoxColumn.HeaderText = "Surname";
            this.surnameDataGridViewTextBoxColumn.Name = "surnameDataGridViewTextBoxColumn";
            this.surnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // getPatientsBindingSource
            // 
            this.getPatientsBindingSource.DataMember = "getPatients";
            this.getPatientsBindingSource.DataSource = this.getPatientsDB;
            // 
            // getPatientsDB
            // 
            this.getPatientsDB.DataSetName = "getPatientsDB";
            this.getPatientsDB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // getPatientsTableAdapter
            // 
            this.getPatientsTableAdapter.ClearBeforeFill = true;
            // 
            // searchIn
            // 
            this.searchIn.Location = new System.Drawing.Point(54, 15);
            this.searchIn.Name = "searchIn";
            this.searchIn.Size = new System.Drawing.Size(147, 20);
            this.searchIn.TabIndex = 7;
            this.searchIn.TextChanged += new System.EventHandler(this.searchIn_TextChanged);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(207, 13);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 8;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(288, 13);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 9;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // PatientSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 258);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchIn);
            this.Controls.Add(this.patientView);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(402, 285);
            this.MinimumSize = new System.Drawing.Size(402, 285);
            this.Name = "PatientSelect";
            this.Text = "PatientSelect";
            this.Load += new System.EventHandler(this.PatientSelect_Load);
            ((System.ComponentModel.ISupportInitialize)(this.patientView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getPatientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getPatientsDB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.DataGridView patientView;
        private getPatientsDB getPatientsDB;
        private System.Windows.Forms.BindingSource getPatientsBindingSource;
        private getPatientsDBTableAdapters.getPatientsTableAdapter getPatientsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox searchIn;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button clearButton;
    }
}