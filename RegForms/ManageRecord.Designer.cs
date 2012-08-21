namespace introseHHC.RegForms
{
    partial class ManageRecord
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pClearButton = new System.Windows.Forms.Button();
            this.patSearch = new System.Windows.Forms.Button();
            this.patSearchIn = new System.Windows.Forms.TextBox();
            this.patientView = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.middleNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.getPatientDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.getPatientDetailsDB = new introseHHC.getPatientDetailsDB();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.clientClearButton = new System.Windows.Forms.Button();
            this.clientSearch = new System.Windows.Forms.Button();
            this.clientSearchIn = new System.Windows.Forms.TextBox();
            this.clientView = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.middleNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.getClientDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.getClientDetailsDB = new introseHHC.getClientDetailsDB();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.empClearButton = new System.Windows.Forms.Button();
            this.empSearch = new System.Windows.Forms.Button();
            this.empSearchIn = new System.Windows.Forms.TextBox();
            this.employeeView = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.middleNameDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.getEmployeeDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.getEmployeeDetailsDB = new introseHHC.getEmployeeDetailsDB();
            this.exitButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.getPatientDetailsTableAdapter = new introseHHC.getPatientDetailsDBTableAdapters.getPatientDetailsTableAdapter();
            this.getClientDetailsTableAdapter = new introseHHC.getClientDetailsDBTableAdapters.getClientDetailsTableAdapter();
            this.getEmployeeDetailsTableAdapter = new introseHHC.getEmployeeDetailsDBTableAdapters.getEmployeeDetailsTableAdapter();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getPatientDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getPatientDetailsDB)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getClientDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getClientDetailsDB)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getEmployeeDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getEmployeeDetailsDB)).BeginInit();
            this.SuspendLayout();
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(100, 496);
            this.splitter1.TabIndex = 2;
            this.splitter1.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(106, 11);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(564, 486);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.pClearButton);
            this.tabPage1.Controls.Add(this.patSearch);
            this.tabPage1.Controls.Add(this.patSearchIn);
            this.tabPage1.Controls.Add(this.patientView);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(556, 460);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Patient";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // pClearButton
            // 
            this.pClearButton.Location = new System.Drawing.Point(469, 11);
            this.pClearButton.Name = "pClearButton";
            this.pClearButton.Size = new System.Drawing.Size(75, 23);
            this.pClearButton.TabIndex = 3;
            this.pClearButton.Text = "Clear";
            this.pClearButton.UseVisualStyleBackColor = true;
            this.pClearButton.Click += new System.EventHandler(this.pClearButton_Click);
            // 
            // patSearch
            // 
            this.patSearch.Location = new System.Drawing.Point(388, 11);
            this.patSearch.Name = "patSearch";
            this.patSearch.Size = new System.Drawing.Size(75, 23);
            this.patSearch.TabIndex = 2;
            this.patSearch.Text = "Search";
            this.patSearch.UseVisualStyleBackColor = true;
            this.patSearch.Click += new System.EventHandler(this.patSearch_Click);
            // 
            // patSearchIn
            // 
            this.patSearchIn.Location = new System.Drawing.Point(16, 13);
            this.patSearchIn.Name = "patSearchIn";
            this.patSearchIn.Size = new System.Drawing.Size(365, 20);
            this.patSearchIn.TabIndex = 1;
            this.patSearchIn.TextChanged += new System.EventHandler(this.patSearchIn_TextChanged);
            // 
            // patientView
            // 
            this.patientView.AllowUserToAddRows = false;
            this.patientView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.patientView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.patientView.AutoGenerateColumns = false;
            this.patientView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.patientView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.middleNameDataGridViewTextBoxColumn,
            this.surnameDataGridViewTextBoxColumn});
            this.patientView.DataSource = this.getPatientDetailsBindingSource;
            this.patientView.Location = new System.Drawing.Point(15, 66);
            this.patientView.MultiSelect = false;
            this.patientView.Name = "patientView";
            this.patientView.ReadOnly = true;
            this.patientView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.patientView.Size = new System.Drawing.Size(524, 391);
            this.patientView.TabIndex = 0;
            this.patientView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.patientView_CellDoubleClick);
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
            // middleNameDataGridViewTextBoxColumn
            // 
            this.middleNameDataGridViewTextBoxColumn.DataPropertyName = "Middle Name";
            this.middleNameDataGridViewTextBoxColumn.HeaderText = "Middle Name";
            this.middleNameDataGridViewTextBoxColumn.Name = "middleNameDataGridViewTextBoxColumn";
            this.middleNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // surnameDataGridViewTextBoxColumn
            // 
            this.surnameDataGridViewTextBoxColumn.DataPropertyName = "Surname";
            this.surnameDataGridViewTextBoxColumn.HeaderText = "Surname";
            this.surnameDataGridViewTextBoxColumn.Name = "surnameDataGridViewTextBoxColumn";
            this.surnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // getPatientDetailsBindingSource
            // 
            this.getPatientDetailsBindingSource.DataMember = "getPatientDetails";
            this.getPatientDetailsBindingSource.DataSource = this.getPatientDetailsDB;
            // 
            // getPatientDetailsDB
            // 
            this.getPatientDetailsDB.DataSetName = "getPatientDetailsDB";
            this.getPatientDetailsDB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.clientClearButton);
            this.tabPage2.Controls.Add(this.clientSearch);
            this.tabPage2.Controls.Add(this.clientSearchIn);
            this.tabPage2.Controls.Add(this.clientView);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(556, 460);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Client";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // clientClearButton
            // 
            this.clientClearButton.Location = new System.Drawing.Point(468, 11);
            this.clientClearButton.Name = "clientClearButton";
            this.clientClearButton.Size = new System.Drawing.Size(75, 23);
            this.clientClearButton.TabIndex = 4;
            this.clientClearButton.Text = "Clear";
            this.clientClearButton.UseVisualStyleBackColor = true;
            this.clientClearButton.Click += new System.EventHandler(this.clientClearButton_Click);
            // 
            // clientSearch
            // 
            this.clientSearch.Location = new System.Drawing.Point(387, 11);
            this.clientSearch.Name = "clientSearch";
            this.clientSearch.Size = new System.Drawing.Size(75, 23);
            this.clientSearch.TabIndex = 3;
            this.clientSearch.Text = "Search";
            this.clientSearch.UseVisualStyleBackColor = true;
            this.clientSearch.Click += new System.EventHandler(this.clientSearch_Click);
            // 
            // clientSearchIn
            // 
            this.clientSearchIn.Location = new System.Drawing.Point(16, 13);
            this.clientSearchIn.Name = "clientSearchIn";
            this.clientSearchIn.Size = new System.Drawing.Size(365, 20);
            this.clientSearchIn.TabIndex = 2;
            this.clientSearchIn.TextChanged += new System.EventHandler(this.clientSearchIn_TextChanged);
            // 
            // clientView
            // 
            this.clientView.AllowUserToAddRows = false;
            this.clientView.AllowUserToDeleteRows = false;
            this.clientView.AutoGenerateColumns = false;
            this.clientView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clientView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn1,
            this.firstNameDataGridViewTextBoxColumn1,
            this.middleNameDataGridViewTextBoxColumn1,
            this.surnameDataGridViewTextBoxColumn1});
            this.clientView.DataSource = this.getClientDetailsBindingSource;
            this.clientView.Location = new System.Drawing.Point(15, 66);
            this.clientView.Name = "clientView";
            this.clientView.ReadOnly = true;
            this.clientView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.clientView.Size = new System.Drawing.Size(524, 391);
            this.clientView.TabIndex = 1;
            this.clientView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.clientView_CellDoubleClick);
            // 
            // iDDataGridViewTextBoxColumn1
            // 
            this.iDDataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn1.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn1.Name = "iDDataGridViewTextBoxColumn1";
            this.iDDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // firstNameDataGridViewTextBoxColumn1
            // 
            this.firstNameDataGridViewTextBoxColumn1.DataPropertyName = "First Name";
            this.firstNameDataGridViewTextBoxColumn1.HeaderText = "First Name";
            this.firstNameDataGridViewTextBoxColumn1.Name = "firstNameDataGridViewTextBoxColumn1";
            this.firstNameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // middleNameDataGridViewTextBoxColumn1
            // 
            this.middleNameDataGridViewTextBoxColumn1.DataPropertyName = "Middle Name";
            this.middleNameDataGridViewTextBoxColumn1.HeaderText = "Middle Name";
            this.middleNameDataGridViewTextBoxColumn1.Name = "middleNameDataGridViewTextBoxColumn1";
            this.middleNameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // surnameDataGridViewTextBoxColumn1
            // 
            this.surnameDataGridViewTextBoxColumn1.DataPropertyName = "Surname";
            this.surnameDataGridViewTextBoxColumn1.HeaderText = "Surname";
            this.surnameDataGridViewTextBoxColumn1.Name = "surnameDataGridViewTextBoxColumn1";
            this.surnameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // getClientDetailsBindingSource
            // 
            this.getClientDetailsBindingSource.DataMember = "getClientDetails";
            this.getClientDetailsBindingSource.DataSource = this.getClientDetailsDB;
            // 
            // getClientDetailsDB
            // 
            this.getClientDetailsDB.DataSetName = "getClientDetailsDB";
            this.getClientDetailsDB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.empClearButton);
            this.tabPage3.Controls.Add(this.empSearch);
            this.tabPage3.Controls.Add(this.empSearchIn);
            this.tabPage3.Controls.Add(this.employeeView);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(556, 460);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Employee";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // empClearButton
            // 
            this.empClearButton.Location = new System.Drawing.Point(468, 11);
            this.empClearButton.Name = "empClearButton";
            this.empClearButton.Size = new System.Drawing.Size(75, 23);
            this.empClearButton.TabIndex = 4;
            this.empClearButton.Text = "Clear";
            this.empClearButton.UseVisualStyleBackColor = true;
            this.empClearButton.Click += new System.EventHandler(this.empClearButton_Click);
            // 
            // empSearch
            // 
            this.empSearch.Location = new System.Drawing.Point(387, 11);
            this.empSearch.Name = "empSearch";
            this.empSearch.Size = new System.Drawing.Size(75, 23);
            this.empSearch.TabIndex = 3;
            this.empSearch.Text = "Search";
            this.empSearch.UseVisualStyleBackColor = true;
            this.empSearch.Click += new System.EventHandler(this.empSearch_Click);
            // 
            // empSearchIn
            // 
            this.empSearchIn.Location = new System.Drawing.Point(16, 13);
            this.empSearchIn.Name = "empSearchIn";
            this.empSearchIn.Size = new System.Drawing.Size(365, 20);
            this.empSearchIn.TabIndex = 2;
            this.empSearchIn.TextChanged += new System.EventHandler(this.empSearchIn_TextChanged);
            // 
            // employeeView
            // 
            this.employeeView.AllowUserToAddRows = false;
            this.employeeView.AllowUserToDeleteRows = false;
            this.employeeView.AutoGenerateColumns = false;
            this.employeeView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeeView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn2,
            this.firstNameDataGridViewTextBoxColumn2,
            this.middleNameDataGridViewTextBoxColumn2,
            this.surnameDataGridViewTextBoxColumn2});
            this.employeeView.DataSource = this.getEmployeeDetailsBindingSource;
            this.employeeView.Location = new System.Drawing.Point(15, 66);
            this.employeeView.MultiSelect = false;
            this.employeeView.Name = "employeeView";
            this.employeeView.ReadOnly = true;
            this.employeeView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.employeeView.Size = new System.Drawing.Size(524, 391);
            this.employeeView.TabIndex = 1;
            this.employeeView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.employeeView_CellDoubleClick);
            // 
            // iDDataGridViewTextBoxColumn2
            // 
            this.iDDataGridViewTextBoxColumn2.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn2.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn2.Name = "iDDataGridViewTextBoxColumn2";
            this.iDDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // firstNameDataGridViewTextBoxColumn2
            // 
            this.firstNameDataGridViewTextBoxColumn2.DataPropertyName = "First Name";
            this.firstNameDataGridViewTextBoxColumn2.HeaderText = "First Name";
            this.firstNameDataGridViewTextBoxColumn2.Name = "firstNameDataGridViewTextBoxColumn2";
            this.firstNameDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // middleNameDataGridViewTextBoxColumn2
            // 
            this.middleNameDataGridViewTextBoxColumn2.DataPropertyName = "Middle Name";
            this.middleNameDataGridViewTextBoxColumn2.HeaderText = "Middle Name";
            this.middleNameDataGridViewTextBoxColumn2.Name = "middleNameDataGridViewTextBoxColumn2";
            this.middleNameDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // surnameDataGridViewTextBoxColumn2
            // 
            this.surnameDataGridViewTextBoxColumn2.DataPropertyName = "Surname";
            this.surnameDataGridViewTextBoxColumn2.HeaderText = "Surname";
            this.surnameDataGridViewTextBoxColumn2.Name = "surnameDataGridViewTextBoxColumn2";
            this.surnameDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // getEmployeeDetailsBindingSource
            // 
            this.getEmployeeDetailsBindingSource.DataMember = "getEmployeeDetails";
            this.getEmployeeDetailsBindingSource.DataSource = this.getEmployeeDetailsDB;
            // 
            // getEmployeeDetailsDB
            // 
            this.getEmployeeDetailsDB.DataSetName = "getEmployeeDetailsDB";
            this.getEmployeeDetailsDB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(12, 88);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(13, 49);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Open";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // getPatientDetailsTableAdapter
            // 
            this.getPatientDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // getClientDetailsTableAdapter
            // 
            this.getClientDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // getEmployeeDetailsTableAdapter
            // 
            this.getEmployeeDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // ManageRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 496);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.splitter1);
            this.Name = "ManageRecord";
            this.Text = "Manage Records";
            this.Load += new System.EventHandler(this.ManageRecord_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getPatientDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getPatientDetailsDB)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getClientDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getClientDetailsDB)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getEmployeeDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getEmployeeDetailsDB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button patSearch;
        private System.Windows.Forms.TextBox patSearchIn;
        private System.Windows.Forms.DataGridView patientView;
        private System.Windows.Forms.Button clientSearch;
        private System.Windows.Forms.TextBox clientSearchIn;
        private System.Windows.Forms.DataGridView clientView;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button empSearch;
        private System.Windows.Forms.TextBox empSearchIn;
        private System.Windows.Forms.DataGridView employeeView;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button button2;
        private getPatientDetailsDB getPatientDetailsDB;
        private System.Windows.Forms.BindingSource getPatientDetailsBindingSource;
        private getPatientDetailsDBTableAdapters.getPatientDetailsTableAdapter getPatientDetailsTableAdapter;
        private getClientDetailsDB getClientDetailsDB;
        private System.Windows.Forms.BindingSource getClientDetailsBindingSource;
        private getClientDetailsDBTableAdapters.getClientDetailsTableAdapter getClientDetailsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn middleNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn1;
        private getEmployeeDetailsDB getEmployeeDetailsDB;
        private System.Windows.Forms.BindingSource getEmployeeDetailsBindingSource;
        private getEmployeeDetailsDBTableAdapters.getEmployeeDetailsTableAdapter getEmployeeDetailsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn middleNameDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn2;
        private System.Windows.Forms.Button pClearButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn middleNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button clientClearButton;
        private System.Windows.Forms.Button empClearButton;

    }
}