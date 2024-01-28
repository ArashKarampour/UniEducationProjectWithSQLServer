namespace UniEdu.UIL
{
    partial class StChangePassPanel
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
            this.NewPassTxt = new System.Windows.Forms.TextBox();
            this.ConfirmTxt = new System.Windows.Forms.TextBox();
            this.OkChangePassBut = new System.Windows.Forms.Button();
            this.CancelChangePassBut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "New Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Confirm Password:";
            // 
            // NewPassTxt
            // 
            this.NewPassTxt.Location = new System.Drawing.Point(159, 123);
            this.NewPassTxt.Name = "NewPassTxt";
            this.NewPassTxt.PasswordChar = '*';
            this.NewPassTxt.Size = new System.Drawing.Size(177, 22);
            this.NewPassTxt.TabIndex = 2;
            // 
            // ConfirmTxt
            // 
            this.ConfirmTxt.Location = new System.Drawing.Point(159, 183);
            this.ConfirmTxt.Name = "ConfirmTxt";
            this.ConfirmTxt.PasswordChar = '*';
            this.ConfirmTxt.Size = new System.Drawing.Size(177, 22);
            this.ConfirmTxt.TabIndex = 3;
            // 
            // OkChangePassBut
            // 
            this.OkChangePassBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OkChangePassBut.Location = new System.Drawing.Point(261, 275);
            this.OkChangePassBut.Name = "OkChangePassBut";
            this.OkChangePassBut.Size = new System.Drawing.Size(75, 23);
            this.OkChangePassBut.TabIndex = 4;
            this.OkChangePassBut.Text = "OK";
            this.OkChangePassBut.UseVisualStyleBackColor = true;
            this.OkChangePassBut.Click += new System.EventHandler(this.OkChangePassBut_Click);
            // 
            // CancelChangePassBut
            // 
            this.CancelChangePassBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelChangePassBut.Location = new System.Drawing.Point(147, 275);
            this.CancelChangePassBut.Name = "CancelChangePassBut";
            this.CancelChangePassBut.Size = new System.Drawing.Size(75, 23);
            this.CancelChangePassBut.TabIndex = 5;
            this.CancelChangePassBut.Text = "Cancel";
            this.CancelChangePassBut.UseVisualStyleBackColor = true;
            this.CancelChangePassBut.Click += new System.EventHandler(this.CancelChangePassBut_Click);
            // 
            // StChangePassPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(437, 391);
            this.Controls.Add(this.CancelChangePassBut);
            this.Controls.Add(this.OkChangePassBut);
            this.Controls.Add(this.ConfirmTxt);
            this.Controls.Add(this.NewPassTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "StChangePassPanel";
            this.Text = "StChangePassPanel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NewPassTxt;
        private System.Windows.Forms.TextBox ConfirmTxt;
        private System.Windows.Forms.Button OkChangePassBut;
        private System.Windows.Forms.Button CancelChangePassBut;
    }
}