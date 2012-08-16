namespace introseHHC.RegForms
{
    partial class MainMenu
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
            this.exitBtn = new System.Windows.Forms.Button();
            this.manageRecButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.regEmpButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(12, 209);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(238, 43);
            this.exitBtn.TabIndex = 13;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // manageRecButton
            // 
            this.manageRecButton.Location = new System.Drawing.Point(12, 160);
            this.manageRecButton.Name = "manageRecButton";
            this.manageRecButton.Size = new System.Drawing.Size(238, 43);
            this.manageRecButton.TabIndex = 12;
            this.manageRecButton.Text = "Manage Records";
            this.manageRecButton.UseVisualStyleBackColor = true;
            this.manageRecButton.Click += new System.EventHandler(this.manageRecButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(238, 43);
            this.button1.TabIndex = 11;
            this.button1.Text = "Register Facesheet";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // regEmpButton
            // 
            this.regEmpButton.Location = new System.Drawing.Point(12, 62);
            this.regEmpButton.Name = "regEmpButton";
            this.regEmpButton.Size = new System.Drawing.Size(238, 43);
            this.regEmpButton.TabIndex = 15;
            this.regEmpButton.Text = "Register Employee";
            this.regEmpButton.UseVisualStyleBackColor = true;
            this.regEmpButton.Click += new System.EventHandler(this.regEmpButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 111);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(238, 43);
            this.button2.TabIndex = 16;
            this.button2.Text = "Register CGA";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 263);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.regEmpButton);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.manageRecButton);
            this.Controls.Add(this.button1);
            this.Name = "MainMenu";
            this.Text = "Home Health Care";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainMenu_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button manageRecButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button regEmpButton;
        private System.Windows.Forms.Button button2;

    }
}