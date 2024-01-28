namespace UniEdu.UIL
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
            this.AdLoginBut = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.StLoginBut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AdLoginBut
            // 
            this.AdLoginBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdLoginBut.Location = new System.Drawing.Point(169, 295);
            this.AdLoginBut.Name = "AdLoginBut";
            this.AdLoginBut.Size = new System.Drawing.Size(152, 51);
            this.AdLoginBut.TabIndex = 0;
            this.AdLoginBut.Text = "Admin Login";
            this.AdLoginBut.UseVisualStyleBackColor = true;
            this.AdLoginBut.Click += new System.EventHandler(this.AdLoginBut_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkKhaki;
            this.label1.Location = new System.Drawing.Point(59, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Menu";
            // 
            // StLoginBut
            // 
            this.StLoginBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StLoginBut.Location = new System.Drawing.Point(352, 295);
            this.StLoginBut.Name = "StLoginBut";
            this.StLoginBut.Size = new System.Drawing.Size(158, 51);
            this.StLoginBut.TabIndex = 2;
            this.StLoginBut.Text = "Student Login";
            this.StLoginBut.UseVisualStyleBackColor = true;
            this.StLoginBut.Click += new System.EventHandler(this.StLoginBut_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.StLoginBut);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AdLoginBut);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AdLoginBut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button StLoginBut;
    }
}