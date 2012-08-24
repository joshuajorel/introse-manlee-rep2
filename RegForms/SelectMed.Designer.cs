namespace introseHHC.RegForms
{
    partial class SelectMed
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
            this.searchField = new System.Windows.Forms.TextBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.medView = new System.Windows.Forms.DataGridView();
            this.medIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.getMedicationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.getMedicationsDB = new introseHHC.getMedicationsDB();
            this.getMedicationsTableAdapter = new introseHHC.getMedicationsDBTableAdapters.getMedicationsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.medView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getMedicationsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getMedicationsDB)).BeginInit();
            this.SuspendLayout();
            // 
            // searchField
            // 
            this.searchField.Location = new System.Drawing.Point(12, 12);
            this.searchField.Name = "searchField";
            this.searchField.Size = new System.Drawing.Size(159, 20);
            this.searchField.TabIndex = 0;
            this.searchField.TextChanged += new System.EventHandler(this.searchField_TextChanged);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(86, 293);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(177, 10);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 2;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            // 
            // medView
            // 
            this.medView.AllowUserToAddRows = false;
            this.medView.AllowUserToDeleteRows = false;
            this.medView.AutoGenerateColumns = false;
            this.medView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.medView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.medIDDataGridViewTextBoxColumn,
            this.medNameDataGridViewTextBoxColumn});
            this.medView.DataSource = this.getMedicationsBindingSource;
            this.medView.Location = new System.Drawing.Point(12, 38);
            this.medView.MultiSelect = false;
            this.medView.Name = "medView";
            this.medView.ReadOnly = true;
            this.medView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.medView.Size = new System.Drawing.Size(240, 249);
            this.medView.TabIndex = 3;
            this.medView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.medView_CellDoubleClick);
            // 
            // medIDDataGridViewTextBoxColumn
            // 
            this.medIDDataGridViewTextBoxColumn.DataPropertyName = "medID";
            this.medIDDataGridViewTextBoxColumn.HeaderText = "medID";
            this.medIDDataGridViewTextBoxColumn.Name = "medIDDataGridViewTextBoxColumn";
            this.medIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.medIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // medNameDataGridViewTextBoxColumn
            // 
            this.medNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.medNameDataGridViewTextBoxColumn.DataPropertyName = "medName";
            this.medNameDataGridViewTextBoxColumn.HeaderText = "Medication";
            this.medNameDataGridViewTextBoxColumn.Name = "medNameDataGridViewTextBoxColumn";
            this.medNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // getMedicationsBindingSource
            // 
            this.getMedicationsBindingSource.DataMember = "getMedications";
            this.getMedicationsBindingSource.DataSource = this.getMedicationsDB;
            // 
            // getMedicationsDB
            // 
            this.getMedicationsDB.DataSetName = "getMedicationsDB";
            this.getMedicationsDB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // getMedicationsTableAdapter
            // 
            this.getMedicationsTableAdapter.ClearBeforeFill = true;
            // 
            // SelectMed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 336);
            this.Controls.Add(this.medView);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.searchField);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(273, 363);
            this.MinimumSize = new System.Drawing.Size(273, 363);
            this.Name = "SelectMed";
            this.Text = "Select Medicaton";
            this.Load += new System.EventHandler(this.SelectMed_Load);
            this.VisibleChanged += new System.EventHandler(this.SelectMed_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.medView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getMedicationsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getMedicationsDB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox searchField;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.DataGridView medView;
        private getMedicationsDB getMedicationsDB;
        private System.Windows.Forms.BindingSource getMedicationsBindingSource;
        private getMedicationsDBTableAdapters.getMedicationsTableAdapter getMedicationsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn medIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn medNameDataGridViewTextBoxColumn;
    }
}