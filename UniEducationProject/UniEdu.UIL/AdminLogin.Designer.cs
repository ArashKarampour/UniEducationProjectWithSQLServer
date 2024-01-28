namespace UniEdu.UIL
{
    partial class AdminLogin
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
            this.AdminLoginLbl = new System.Windows.Forms.Label();
            this.AdminPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AdUserNameTxt = new System.Windows.Forms.TextBox();
            this.AdPassTxt = new System.Windows.Forms.TextBox();
            this.AdLoginBut = new System.Windows.Forms.Button();
            this.CancelBut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AdminLoginLbl
            // 
            this.AdminLoginLbl.BackColor = System.Drawing.Color.GreenYellow;
            this.AdminLoginLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminLoginLbl.Location = new System.Drawing.Point(1, 45);
            this.AdminLoginLbl.Name = "AdminLoginLbl";
            this.AdminLoginLbl.Size = new System.Drawing.Size(264, 41);
            this.AdminLoginLbl.TabIndex = 0;
            this.AdminLoginLbl.Text = "Admin Login Page";
            // 
            // AdminPanel
            // 
            this.AdminPanel.BackgroundImage = global::UniEdu.UIL.Properties.Resources.index;
            this.AdminPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.AdminPanel.Location = new System.Drawing.Point(-1, 82);
            this.AdminPanel.Name = "AdminPanel";
            this.AdminPanel.Size = new System.Drawing.Size(266, 265);
            this.AdminPanel.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Ivory;
            this.label1.Location = new System.Drawing.Point(325, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "User name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Ivory;
            this.label2.Location = new System.Drawing.Point(325, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password:";
            // 
            // AdUserNameTxt
            // 
            this.AdUserNameTxt.Location = new System.Drawing.Point(444, 143);
            this.AdUserNameTxt.Name = "AdUserNameTxt";
            this.AdUserNameTxt.Size = new System.Drawing.Size(212, 22);
            this.AdUserNameTxt.TabIndex = 4;
            // 
            // AdPassTxt
            // 
            this.AdPassTxt.Location = new System.Drawing.Point(444, 229);
            this.AdPassTxt.Name = "AdPassTxt";
            this.AdPassTxt.PasswordChar = '*';
            this.AdPassTxt.Size = new System.Drawing.Size(212, 22);
            this.AdPassTxt.TabIndex = 5;
            // 
            // AdLoginBut
            // 
            this.AdLoginBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdLoginBut.Location = new System.Drawing.Point(570, 339);
            this.AdLoginBut.Name = "AdLoginBut";
            this.AdLoginBut.Size = new System.Drawing.Size(86, 34);
            this.AdLoginBut.TabIndex = 6;
            this.AdLoginBut.Text = "Login";
            this.AdLoginBut.UseVisualStyleBackColor = true;
            this.AdLoginBut.Click += new System.EventHandler(this.AdLoginBut_Click);
            // 
            // CancelBut
            // 
            this.CancelBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelBut.Location = new System.Drawing.Point(430, 339);
            this.CancelBut.Name = "CancelBut";
            this.CancelBut.Size = new System.Drawing.Size(83, 34);
            this.CancelBut.TabIndex = 7;
            this.CancelBut.Text = "Cancel";
            this.CancelBut.UseVisualStyleBackColor = true;
            this.CancelBut.Click += new System.EventHandler(this.CancelBut_Click);
            // 
            // AdminLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CancelBut);
            this.Controls.Add(this.AdLoginBut);
            this.Controls.Add(this.AdPassTxt);
            this.Controls.Add(this.AdUserNameTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AdminLoginLbl);
            this.Controls.Add(this.AdminPanel);
            this.Name = "AdminLogin";
            this.Text = "AdminLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AdminLoginLbl;
        private System.Windows.Forms.Panel AdminPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox AdUserNameTxt;
        private System.Windows.Forms.TextBox AdPassTxt;
        private System.Windows.Forms.Button AdLoginBut;
        private System.Windows.Forms.Button CancelBut;
    }
}