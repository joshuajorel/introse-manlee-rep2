namespace introseHHC.RegForms
{
    partial class PMedHist
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
            this.addButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diagnosisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.placeOfConfinementDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inclusiveDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.getPMedBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.getPMed = new introseHHC.getPMed();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.placeField = new System.Windows.Forms.TextBox();
            this.diagField = new System.Windows.Forms.TextBox();
            this.getPMedTableAdapter = new introseHHC.getPMedTableAdapters.getPMedTableAdapter();
            this.DatePick = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getPMedBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getPMed)).BeginInit();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(388, 214);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 9;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(469, 80);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 8;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(469, 51);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 7;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.diagnosisDataGridViewTextBoxColumn,
            this.placeOfConfinementDataGridViewTextBoxColumn,
            this.inclusiveDateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.getPMedBindingSource;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dataGridView1.Location = new System.Drawing.Point(12, 15);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(451, 172);
            this.dataGridView1.TabIndex = 6;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Visible = false;
            // 
            // diagnosisDataGridViewTextBoxColumn
            // 
            this.diagnosisDataGridViewTextBoxColumn.DataPropertyName = "Diagnosis";
            this.diagnosisDataGridViewTextBoxColumn.HeaderText = "Diagnosis";
            this.diagnosisDataGridViewTextBoxColumn.Name = "diagnosisDataGridViewTextBoxColumn";
            this.diagnosisDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // placeOfConfinementDataGridViewTextBoxColumn
            // 
            this.placeOfConfinementDataGridViewTextBoxColumn.DataPropertyName = "Place Of Confinement";
            this.placeOfConfinementDataGridViewTextBoxColumn.HeaderText = "Place Of Confinement";
            this.placeOfConfinementDataGridViewTextBoxColumn.Name = "placeOfConfinementDataGridViewTextBoxColumn";
            this.placeOfConfinementDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // inclusiveDateDataGridViewTextBoxColumn
            // 
            this.inclusiveDateDataGridViewTextBoxColumn.DataPropertyName = "Inclusive Date";
            this.inclusiveDateDataGridViewTextBoxColumn.HeaderText = "Inclusive Date";
            this.inclusiveDateDataGridViewTextBoxColumn.Name = "inclusiveDateDataGridViewTextBoxColumn";
            this.inclusiveDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // getPMedBindingSource
            // 
            this.getPMedBindingSource.DataMember = "getPMed";
            this.getPMedBindingSource.DataSource = this.getPMed;
            // 
            // getPMed
            // 
            this.getPMed.DataSetName = "getPMed";
            this.getPMed.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(274, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(165, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Place";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Diagnosis";
            // 
            // placeField
            // 
            this.placeField.Location = new System.Drawing.Point(133, 216);
            this.placeField.Name = "placeField";
            this.placeField.Size = new System.Drawing.Size(100, 20);
            this.placeField.TabIndex = 13;
            // 
            // diagField
            // 
            this.diagField.Location = new System.Drawing.Point(27, 216);
            this.diagField.Name = "diagField";
            this.diagField.Size = new System.Drawing.Size(100, 20);
            this.diagField.TabIndex = 12;
            // 
            // getPMedTableAdapter
            // 
            this.getPMedTableAdapter.ClearBeforeFill = true;
            // 
            // DatePick
            // 
            this.DatePick.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DatePick.Location = new System.Drawing.Point(239, 216);
            this.DatePick.Name = "DatePick";
            this.DatePick.Size = new System.Drawing.Size(122, 20);
            this.DatePick.TabIndex = 44;
            // 
            // PMedHist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 263);
            this.Controls.Add(this.DatePick);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.placeField);
            this.Controls.Add(this.diagField);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(564, 290);
            this.MinimumSize = new System.Drawing.Size(564, 290);
            this.Name = "PMedHist";
            this.Text = "Past Medical History";
            this.Load += new System.EventHandler(this.PMedHist_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getPMedBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getPMed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox placeField;
        private System.Windows.Forms.TextBox diagField;
        private getPMed getPMed;
        private System.Windows.Forms.BindingSource getPMedBindingSource;
        private getPMedTableAdapters.getPMedTableAdapter getPMedTableAdapter;
        private System.Windows.Forms.DateTimePicker DatePick;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diagnosisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn placeOfConfinementDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inclusiveDateDataGridViewTextBoxColumn;
    }
}