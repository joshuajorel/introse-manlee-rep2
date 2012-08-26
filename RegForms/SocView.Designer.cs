namespace introseHHC.RegForms
{
    partial class SocView
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
            this.CloseButton = new System.Windows.Forms.Button();
            this.socEnvView = new System.Windows.Forms.DataGridView();
            this.nameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.relCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.freqCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.socEnvView)).BeginInit();
            this.SuspendLayout();
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(378, 22);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(75, 23);
            this.CloseButton.TabIndex = 13;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // socEnvView
            // 
            this.socEnvView.AllowUserToAddRows = false;
            this.socEnvView.AllowUserToDeleteRows = false;
            this.socEnvView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.socEnvView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameCol,
            this.relCol,
            this.freqCol});
            this.socEnvView.Location = new System.Drawing.Point(12, 22);
            this.socEnvView.Name = "socEnvView";
            this.socEnvView.ReadOnly = true;
            this.socEnvView.Size = new System.Drawing.Size(355, 172);
            this.socEnvView.TabIndex = 12;
            // 
            // nameCol
            // 
            this.nameCol.HeaderText = "Name";
            this.nameCol.Name = "nameCol";
            this.nameCol.ReadOnly = true;
            // 
            // relCol
            // 
            this.relCol.HeaderText = "Relationship";
            this.relCol.Name = "relCol";
            this.relCol.ReadOnly = true;
            // 
            // freqCol
            // 
            this.freqCol.HeaderText = "Frequency";
            this.freqCol.Name = "freqCol";
            this.freqCol.ReadOnly = true;
            // 
            // SocView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 223);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.socEnvView);
            this.Name = "SocView";
            this.Text = "SocView";
            this.Load += new System.EventHandler(this.SocView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.socEnvView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.DataGridView socEnvView;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn relCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn freqCol;
    }
}