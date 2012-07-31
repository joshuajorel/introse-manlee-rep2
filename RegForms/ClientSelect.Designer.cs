namespace introseHHC.RegForms
{
    partial class ClientSelect
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
            this.clientView = new System.Windows.Forms.DataGridView();
            this.getClientsDB = new introseHHC.getClientsDB();
            this.getClientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.getClientsTableAdapter = new introseHHC.getClientsDBTableAdapters.getClientsTableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.clientView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getClientsDB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getClientsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(22, 195);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 1;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(306, 194);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 2;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // clientView
            // 
            this.clientView.AllowUserToAddRows = false;
            this.clientView.AllowUserToDeleteRows = false;
            this.clientView.AutoGenerateColumns = false;
            this.clientView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clientView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.surnameDataGridViewTextBoxColumn});
            this.clientView.DataSource = this.getClientsBindingSource;
            this.clientView.Location = new System.Drawing.Point(12, 12);
            this.clientView.MultiSelect = false;
            this.clientView.Name = "clientView";
            this.clientView.ReadOnly = true;
            this.clientView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.clientView.Size = new System.Drawing.Size(370, 150);
            this.clientView.TabIndex = 3;
            // 
            // getClientsDB
            // 
            this.getClientsDB.DataSetName = "getClientsDB";
            this.getClientsDB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // getClientsBindingSource
            // 
            this.getClientsBindingSource.DataMember = "getClients";
            this.getClientsBindingSource.DataSource = this.getClientsDB;
            // 
            // getClientsTableAdapter
            // 
            this.getClientsTableAdapter.ClearBeforeFill = true;
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
            // ClientSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 258);
            this.Controls.Add(this.clientView);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Name = "ClientSelect";
            this.Text = "ClientSelect";
            this.Load += new System.EventHandler(this.ClientSelect_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clientView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getClientsDB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getClientsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion



        private System.Windows.Forms.DataGridViewTextBoxColumn clientIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
      
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridView clientView;
        private getClientsDB getClientsDB;
        private System.Windows.Forms.BindingSource getClientsBindingSource;
        private getClientsDBTableAdapters.getClientsTableAdapter getClientsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
    }
}