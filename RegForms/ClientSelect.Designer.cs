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
            this.clientView = new System.Windows.Forms.DataGridView();
            this._hhc_dbDataSet = new introseHHC._hhc_dbDataSet();
            this.getClientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.getClientsTableAdapter = new introseHHC._hhc_dbDataSetTableAdapters.getClientsTableAdapter();
            this.clientIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.clientView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._hhc_dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getClientsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // clientView
            // 
            this.clientView.AllowUserToAddRows = false;
            this.clientView.AllowUserToDeleteRows = false;
            this.clientView.AutoGenerateColumns = false;
            this.clientView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clientView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clientIDDataGridViewTextBoxColumn,
            this.fNameDataGridViewTextBoxColumn,
            this.sNameDataGridViewTextBoxColumn});
            this.clientView.DataSource = this.getClientsBindingSource;
            this.clientView.Location = new System.Drawing.Point(22, 12);
            this.clientView.MultiSelect = false;
            this.clientView.Name = "clientView";
            this.clientView.ReadOnly = true;
            this.clientView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.clientView.Size = new System.Drawing.Size(360, 150);
            this.clientView.TabIndex = 0;
            // 
            // _hhc_dbDataSet
            // 
            this._hhc_dbDataSet.DataSetName = "_hhc_dbDataSet";
            this._hhc_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // getClientsBindingSource
            // 
            this.getClientsBindingSource.DataMember = "getClients";
            this.getClientsBindingSource.DataSource = this._hhc_dbDataSet;
            // 
            // getClientsTableAdapter
            // 
            this.getClientsTableAdapter.ClearBeforeFill = true;
            // 
            // clientIDDataGridViewTextBoxColumn
            // 
            this.clientIDDataGridViewTextBoxColumn.DataPropertyName = "ClientID";
            this.clientIDDataGridViewTextBoxColumn.HeaderText = "ClientID";
            this.clientIDDataGridViewTextBoxColumn.Name = "clientIDDataGridViewTextBoxColumn";
            this.clientIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fNameDataGridViewTextBoxColumn
            // 
            this.fNameDataGridViewTextBoxColumn.DataPropertyName = "FName";
            this.fNameDataGridViewTextBoxColumn.HeaderText = "FName";
            this.fNameDataGridViewTextBoxColumn.Name = "fNameDataGridViewTextBoxColumn";
            this.fNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sNameDataGridViewTextBoxColumn
            // 
            this.sNameDataGridViewTextBoxColumn.DataPropertyName = "SName";
            this.sNameDataGridViewTextBoxColumn.HeaderText = "SName";
            this.sNameDataGridViewTextBoxColumn.Name = "sNameDataGridViewTextBoxColumn";
            this.sNameDataGridViewTextBoxColumn.ReadOnly = true;
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
            // 
            // ClientSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 258);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.clientView);
            this.Name = "ClientSelect";
            this.Text = "ClientSelect";
            this.Load += new System.EventHandler(this.ClientSelect_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clientView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._hhc_dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getClientsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView clientView;
        private _hhc_dbDataSet _hhc_dbDataSet;
        private System.Windows.Forms.BindingSource getClientsBindingSource;
        private _hhc_dbDataSetTableAdapters.getClientsTableAdapter getClientsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
    }
}