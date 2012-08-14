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
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.patientView = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.middleNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.getPatientDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.getPatientDetailsDB = new introseHHC.getPatientDetailsDB();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.middleNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.getClientDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.getClientDetailsDB = new introseHHC.getClientDetailsDB();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button5 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.employeeView = new System.Windows.Forms.DataGridView();
            this.button6 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.getPatientDetailsTableAdapter = new introseHHC.getPatientDetailsDBTableAdapters.getPatientDetailsTableAdapter();
            this.getClientDetailsTableAdapter = new introseHHC.getClientDetailsDBTableAdapters.getClientDetailsTableAdapter();
            this.getEmployeeDetailsDB = new introseHHC.getEmployeeDetailsDB();
            this.getEmployeeDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.getEmployeeDetailsTableAdapter = new introseHHC.getEmployeeDetailsDBTableAdapters.getEmployeeDetailsTableAdapter();
            this.iDDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.middleNameDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getPatientDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getPatientDetailsDB)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getClientDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getClientDetailsDB)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getEmployeeDetailsDB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getEmployeeDetailsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(100, 497);
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
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.patientView);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(556, 460);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Patient";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(388, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(375, 20);
            this.textBox1.TabIndex = 1;
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
            this.middleNameDataGridViewTextBoxColumn,
            this.surnameDataGridViewTextBoxColumn});
            this.patientView.DataSource = this.getPatientDetailsBindingSource;
            this.patientView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.patientView.Location = new System.Drawing.Point(3, 66);
            this.patientView.MultiSelect = false;
            this.patientView.Name = "patientView";
            this.patientView.ReadOnly = true;
            this.patientView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.patientView.Size = new System.Drawing.Size(550, 391);
            this.patientView.TabIndex = 0;
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
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.textBox2);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(556, 460);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Client";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(387, 17);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Search";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(6, 17);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(375, 20);
            this.textBox2.TabIndex = 2;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn1,
            this.firstNameDataGridViewTextBoxColumn1,
            this.middleNameDataGridViewTextBoxColumn1,
            this.surnameDataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.getClientDetailsBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(3, 62);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(544, 392);
            this.dataGridView2.TabIndex = 1;
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
            this.tabPage3.Controls.Add(this.button5);
            this.tabPage3.Controls.Add(this.textBox3);
            this.tabPage3.Controls.Add(this.employeeView);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(556, 460);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Employee";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(387, 16);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 3;
            this.button5.Text = "Search";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(6, 18);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(375, 20);
            this.textBox3.TabIndex = 2;
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
            this.employeeView.Location = new System.Drawing.Point(3, 55);
            this.employeeView.MultiSelect = false;
            this.employeeView.Name = "employeeView";
            this.employeeView.ReadOnly = true;
            this.employeeView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.employeeView.Size = new System.Drawing.Size(544, 402);
            this.employeeView.TabIndex = 1;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(12, 88);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 5;
            this.button6.Text = "Exit";
            this.button6.UseVisualStyleBackColor = true;
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
            // getEmployeeDetailsDB
            // 
            this.getEmployeeDetailsDB.DataSetName = "getEmployeeDetailsDB";
            this.getEmployeeDetailsDB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // getEmployeeDetailsBindingSource
            // 
            this.getEmployeeDetailsBindingSource.DataMember = "getEmployeeDetails";
            this.getEmployeeDetailsBindingSource.DataSource = this.getEmployeeDetailsDB;
            // 
            // getEmployeeDetailsTableAdapter
            // 
            this.getEmployeeDetailsTableAdapter.ClearBeforeFill = true;
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
            // ManageRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 497);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button6);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getClientDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getClientDetailsDB)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getEmployeeDetailsDB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getEmployeeDetailsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView patientView;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.DataGridView employeeView;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button2;
        private getPatientDetailsDB getPatientDetailsDB;
        private System.Windows.Forms.BindingSource getPatientDetailsBindingSource;
        private getPatientDetailsDBTableAdapters.getPatientDetailsTableAdapter getPatientDetailsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn middleNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
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

    }
}