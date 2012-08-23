namespace introseHHC.RegForms
{
    partial class SocEnv
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
            this.socEnvView = new System.Windows.Forms.DataGridView();
            this.getSocialBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.getSocial = new introseHHC.getSocial();
            this.cancelButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.nameField = new System.Windows.Forms.TextBox();
            this.relField = new System.Windows.Forms.TextBox();
            this.freqField = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.getSocialTableAdapter = new introseHHC.getSocialTableAdapters.getSocialTableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.relationshipDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.frequencyOfVisitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.socEnvView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getSocialBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getSocial)).BeginInit();
            this.SuspendLayout();
            // 
            // socEnvView
            // 
            this.socEnvView.AllowUserToAddRows = false;
            this.socEnvView.AllowUserToDeleteRows = false;
            this.socEnvView.AutoGenerateColumns = false;
            this.socEnvView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.socEnvView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.relationshipDataGridViewTextBoxColumn,
            this.frequencyOfVisitDataGridViewTextBoxColumn});
            this.socEnvView.DataSource = this.getSocialBindingSource;
            this.socEnvView.Location = new System.Drawing.Point(12, 12);
            this.socEnvView.Name = "socEnvView";
            this.socEnvView.ReadOnly = true;
            this.socEnvView.Size = new System.Drawing.Size(451, 172);
            this.socEnvView.TabIndex = 0;
            // 
            // getSocialBindingSource
            // 
            this.getSocialBindingSource.DataMember = "getSocial";
            this.getSocialBindingSource.DataSource = this.getSocial;
            // 
            // getSocial
            // 
            this.getSocial.DataSetName = "getSocial";
            this.getSocial.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(469, 54);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 4;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click_1);
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(469, 25);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 3;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click_1);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(388, 211);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 5;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // nameField
            // 
            this.nameField.Location = new System.Drawing.Point(41, 213);
            this.nameField.Name = "nameField";
            this.nameField.Size = new System.Drawing.Size(100, 20);
            this.nameField.TabIndex = 6;
            // 
            // relField
            // 
            this.relField.Location = new System.Drawing.Point(147, 213);
            this.relField.Name = "relField";
            this.relField.Size = new System.Drawing.Size(100, 20);
            this.relField.TabIndex = 7;
            // 
            // freqField
            // 
            this.freqField.Location = new System.Drawing.Point(253, 213);
            this.freqField.Name = "freqField";
            this.freqField.Size = new System.Drawing.Size(100, 20);
            this.freqField.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(168, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Relationship";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(272, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Frequency";
            // 
            // getSocialTableAdapter
            // 
            this.getSocialTableAdapter.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // relationshipDataGridViewTextBoxColumn
            // 
            this.relationshipDataGridViewTextBoxColumn.DataPropertyName = "Relationship";
            this.relationshipDataGridViewTextBoxColumn.HeaderText = "Relationship";
            this.relationshipDataGridViewTextBoxColumn.Name = "relationshipDataGridViewTextBoxColumn";
            this.relationshipDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // frequencyOfVisitDataGridViewTextBoxColumn
            // 
            this.frequencyOfVisitDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.frequencyOfVisitDataGridViewTextBoxColumn.DataPropertyName = "Frequency of Visit";
            this.frequencyOfVisitDataGridViewTextBoxColumn.HeaderText = "Frequency of Visit";
            this.frequencyOfVisitDataGridViewTextBoxColumn.Name = "frequencyOfVisitDataGridViewTextBoxColumn";
            this.frequencyOfVisitDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // SocEnv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 265);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.freqField);
            this.Controls.Add(this.relField);
            this.Controls.Add(this.nameField);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.socEnvView);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(564, 292);
            this.MinimumSize = new System.Drawing.Size(564, 292);
            this.Name = "SocEnv";
            this.Text = "Society and Environment";
            this.Load += new System.EventHandler(this.SocEnv_Load);
            ((System.ComponentModel.ISupportInitialize)(this.socEnvView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getSocialBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getSocial)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView socEnvView;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox nameField;
        private System.Windows.Forms.TextBox relField;
        private System.Windows.Forms.TextBox freqField;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private getSocial getSocial;
        private System.Windows.Forms.BindingSource getSocialBindingSource;
        private getSocialTableAdapters.getSocialTableAdapter getSocialTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn relationshipDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn frequencyOfVisitDataGridViewTextBoxColumn;
    }
}