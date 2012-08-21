namespace introseHHC.RegForms
{
    partial class ImmRec
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.tetDate = new System.Windows.Forms.DateTimePicker();
            this.pneDate = new System.Windows.Forms.DateTimePicker();
            this.infDate = new System.Windows.Forms.DateTimePicker();
            this.othDate = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 117);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vaccine\r\n\r\nTetanus\r\n\r\nPneumonia\r\n\r\nInfluenza\r\n\r\nOthers";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Date";
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(15, 159);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 5;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(137, 159);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 6;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // tetDate
            // 
            this.tetDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.tetDate.Location = new System.Drawing.Point(78, 34);
            this.tetDate.Name = "tetDate";
            this.tetDate.Size = new System.Drawing.Size(122, 20);
            this.tetDate.TabIndex = 44;
            // 
            // pneDate
            // 
            this.pneDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.pneDate.Location = new System.Drawing.Point(78, 60);
            this.pneDate.Name = "pneDate";
            this.pneDate.Size = new System.Drawing.Size(122, 20);
            this.pneDate.TabIndex = 45;
            // 
            // infDate
            // 
            this.infDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.infDate.Location = new System.Drawing.Point(78, 86);
            this.infDate.Name = "infDate";
            this.infDate.Size = new System.Drawing.Size(122, 20);
            this.infDate.TabIndex = 46;
            // 
            // othDate
            // 
            this.othDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.othDate.Location = new System.Drawing.Point(78, 112);
            this.othDate.Name = "othDate";
            this.othDate.Size = new System.Drawing.Size(122, 20);
            this.othDate.TabIndex = 47;
            // 
            // ImmRec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(232, 197);
            this.Controls.Add(this.othDate);
            this.Controls.Add(this.infDate);
            this.Controls.Add(this.pneDate);
            this.Controls.Add(this.tetDate);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ImmRec";
            this.Text = "ImmRec";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.DateTimePicker tetDate;
        private System.Windows.Forms.DateTimePicker pneDate;
        private System.Windows.Forms.DateTimePicker infDate;
        private System.Windows.Forms.DateTimePicker othDate;

    }
}