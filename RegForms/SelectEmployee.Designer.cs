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
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.employeeView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.getEmployeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.getEmployeesDB1 = new introseHHC.getEmployeesDB();
            this.getEmployeesTableAdapter2 = new introseHHC.getEmployeesDBTableAdapters.getEmployeesTableAdapter();
            this.clearButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchIn = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.employeeView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getEmployeesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getEmployeesDB1)).BeginInit();
            this.SuspendLayout();
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(12, 223);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 1;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(307, 223);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 2;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // employeeView
            // 
            this.employeeView.AllowUserToAddRows = false;
            this.employeeView.AllowUserToDeleteRows = false;
            this.employeeView.AutoGenerateColumns = false;
            this.employeeView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeeView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.employeeView.DataSource = this.getEmployeesBindingSource;
            this.employeeView.Location = new System.Drawing.Point(11, 57);
            this.employeeView.MultiSelect = false;
            this.employeeView.Name = "employeeView";
            this.employeeView.ReadOnly = true;
            this.employeeView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.employeeView.Size = new System.Drawing.Size(370, 150);
            this.employeeView.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "First Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "First Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Surname";
            this.dataGridViewTextBoxColumn3.HeaderText = "Surname";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // getEmployeesBindingSource
            // 
            this.getEmployeesBindingSource.DataMember = "getEmployees";
            this.getEmployeesBindingSource.DataSource = this.getEmployeesDB1;
            // 
            // getEmployeesDB1
            // 
            this.getEmployeesDB1.DataSetName = "getEmployeesDB";
            this.getEmployeesDB1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // getEmployeesTableAdapter2
            // 
            this.getEmployeesTableAdapter2.ClearBeforeFill = true;
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(288, 13);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 15;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(207, 13);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 14;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchIn
            // 
            this.searchIn.Location = new System.Drawing.Point(54, 15);
            this.searchIn.Name = "searchIn";
            this.searchIn.Size = new System.Drawing.Size(147, 20);
            this.searchIn.TabIndex = 13;
            // 
            // SelectEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 258);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchIn);
            this.Controls.Add(this.employeeView);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Name = "SelectEmployee";
            this.Text = "SelectEmployee";
            this.Load += new System.EventHandler(this.SelectEmployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employeeView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getEmployeesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getEmployeesDB1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private getEmployeesDB getEmployeesDB;
        private getEmployeesDBTableAdapters.getEmployeesTableAdapter getEmployeesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        
        private System.Windows.Forms.DataGridView employeeView;
        private getEmployeesDB getEmployeesDB1;
        private System.Windows.Forms.BindingSource getEmployeesBindingSource;
        private getEmployeesDBTableAdapters.getEmployeesTableAdapter getEmployeesTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox searchIn;
    }
}