namespace introseHHC.RegForms
{
    partial class SelectEmployee
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
            this.employeeView = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.getEmployeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.getEmployeesDB = new introseHHC.getEmployeesDB();
            this.okButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.getEmployeesTableAdapter = new introseHHC.getEmployeesDBTableAdapters.getEmployeesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.employeeView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getEmployeesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getEmployeesDB)).BeginInit();
            this.SuspendLayout();
            // 
            // employeeView
            // 
            this.employeeView.AllowUserToAddRows = false;
            this.employeeView.AllowUserToDeleteRows = false;
            this.employeeView.AutoGenerateColumns = false;
            this.employeeView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeeView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.surnameDataGridViewTextBoxColumn});
            this.employeeView.DataSource = this.getEmployeesBindingSource;
            this.employeeView.Location = new System.Drawing.Point(17, 12);
            this.employeeView.MultiSelect = false;
            this.employeeView.Name = "employeeView";
            this.employeeView.ReadOnly = true;
            this.employeeView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.employeeView.Size = new System.Drawing.Size(360, 150);
            this.employeeView.TabIndex = 0;
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
            // getEmployeesBindingSource
            // 
            this.getEmployeesBindingSource.DataMember = "getEmployees";
            this.getEmployeesBindingSource.DataSource = this.getEmployeesDB;
            // 
            // getEmployeesDB
            // 
            this.getEmployeesDB.DataSetName = "getEmployeesDB";
            this.getEmployeesDB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(22, 213);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 1;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(307, 213);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // getEmployeesTableAdapter
            // 
            this.getEmployeesTableAdapter.ClearBeforeFill = true;
            // 
            // SelectEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 258);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.employeeView);
            this.Name = "SelectEmployee";
            this.Text = "SelectEmployee";
            this.Load += new System.EventHandler(this.SelectEmployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employeeView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getEmployeesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getEmployeesDB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView employeeView;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button button2;
        private getEmployeesDB getEmployeesDB;
        private System.Windows.Forms.BindingSource getEmployeesBindingSource;
        private getEmployeesDBTableAdapters.getEmployeesTableAdapter getEmployeesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
    }
}