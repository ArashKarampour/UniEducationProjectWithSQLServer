namespace UniEdu.UIL
{
    partial class StudentLogin
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
            this.StCancelBut = new System.Windows.Forms.Button();
            this.StLoginBut = new System.Windows.Forms.Button();
            this.StPassTxt = new System.Windows.Forms.TextBox();
            this.StUserNameTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AdminLoginLbl = new System.Windows.Forms.Label();
            this.AdminPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // StCancelBut
            // 
            this.StCancelBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StCancelBut.Location = new System.Drawing.Point(461, 349);
            this.StCancelBut.Name = "StCancelBut";
            this.StCancelBut.Size = new System.Drawing.Size(83, 34);
            this.StCancelBut.TabIndex = 15;
            this.StCancelBut.Text = "Cancel";
            this.StCancelBut.UseVisualStyleBackColor = true;
            this.StCancelBut.Click += new System.EventHandler(this.StCancelBut_Click);
            // 
            // StLoginBut
            // 
            this.StLoginBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StLoginBut.Location = new System.Drawing.Point(601, 349);
            this.StLoginBut.Name = "StLoginBut";
            this.StLoginBut.Size = new System.Drawing.Size(86, 34);
            this.StLoginBut.TabIndex = 14;
            this.StLoginBut.Text = "Login";
            this.StLoginBut.UseVisualStyleBackColor = true;
            this.StLoginBut.Click += new System.EventHandler(this.StLoginBut_Click);
            // 
            // StPassTxt
            // 
            this.StPassTxt.Location = new System.Drawing.Point(475, 220);
            this.StPassTxt.Name = "StPassTxt";
            this.StPassTxt.PasswordChar = '*';
            this.StPassTxt.Size = new System.Drawing.Size(212, 22);
            this.StPassTxt.TabIndex = 13;
            // 
            // StUserNameTxt
            // 
            this.StUserNameTxt.Location = new System.Drawing.Point(475, 134);
            this.StUserNameTxt.Name = "StUserNameTxt";
            this.StUserNameTxt.Size = new System.Drawing.Size(212, 22);
            this.StUserNameTxt.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Ivory;
            this.label2.Location = new System.Drawing.Point(356, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Ivory;
            this.label1.Location = new System.Drawing.Point(356, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "User name:";
            // 
            // AdminLoginLbl
            // 
            this.AdminLoginLbl.BackColor = System.Drawing.Color.GreenYellow;
            this.AdminLoginLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminLoginLbl.Location = new System.Drawing.Point(4, 61);
            this.AdminLoginLbl.Name = "AdminLoginLbl";
            this.AdminLoginLbl.Size = new System.Drawing.Size(264, 41);
            this.AdminLoginLbl.TabIndex = 8;
            this.AdminLoginLbl.Text = "Student Login Page";
            // 
            // AdminPanel
            // 
            this.AdminPanel.BackgroundImage = global::UniEdu.UIL.Properties.Resources.studentLogin;
            this.AdminPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.AdminPanel.Location = new System.Drawing.Point(2, 98);
            this.AdminPanel.Name = "AdminPanel";
            this.AdminPanel.Size = new System.Drawing.Size(266, 265);
            this.AdminPanel.TabIndex = 9;
            // 
            // StudentLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.StCancelBut);
            this.Controls.Add(this.StLoginBut);
            this.Controls.Add(this.StPassTxt);
            this.Controls.Add(this.StUserNameTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AdminLoginLbl);
            this.Controls.Add(this.AdminPanel);
            this.Name = "StudentLogin";
            this.Text = "StudentLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StCancelBut;
        private System.Windows.Forms.Button StLoginBut;
        private System.Windows.Forms.TextBox StPassTxt;
        private System.Windows.Forms.TextBox StUserNameTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label AdminLoginLbl;
        private System.Windows.Forms.Panel AdminPanel;
    }
}