namespace UniEdu.UIL
{
    partial class InstructorForm
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
            this.InstDeleteBut = new System.Windows.Forms.Button();
            this.InstAddBut = new System.Windows.Forms.Button();
            this.InstUpdateBut = new System.Windows.Forms.Button();
            this.InstSearchBut = new System.Windows.Forms.Button();
            this.InstSearchTxtBox = new System.Windows.Forms.TextBox();
            this.InstSearchLbl = new System.Windows.Forms.Label();
            this.LastInstBut = new System.Windows.Forms.Button();
            this.PreviousInstBut = new System.Windows.Forms.Button();
            this.NextInstBut = new System.Windows.Forms.Button();
            this.LoadFirstInstBut = new System.Windows.Forms.Button();
            this.InstIDTxtBox = new System.Windows.Forms.TextBox();
            this.InsIDLbl = new System.Windows.Forms.Label();
            this.InstGenderTxtBox = new System.Windows.Forms.TextBox();
            this.InstNationalCodeTxtBox = new System.Windows.Forms.TextBox();
            this.InstNumTxtBox = new System.Windows.Forms.TextBox();
            this.InstEmailTxtBox = new System.Windows.Forms.TextBox();
            this.InstPhoneTxtBox = new System.Windows.Forms.TextBox();
            this.InstLNameTxtBox = new System.Windows.Forms.TextBox();
            this.InsGenderLbl = new System.Windows.Forms.Label();
            this.InsNationalCodeLbl = new System.Windows.Forms.Label();
            this.InstNumLbl = new System.Windows.Forms.Label();
            this.InsEmailLbl = new System.Windows.Forms.Label();
            this.InsPhoneLbl = new System.Windows.Forms.Label();
            this.InsLastNameLbl = new System.Windows.Forms.Label();
            this.InstFNameTxtBox = new System.Windows.Forms.TextBox();
            this.InsFNameLbl = new System.Windows.Forms.Label();
            this.DegreeLbl = new System.Windows.Forms.Label();
            this.DegreeTxtBox = new System.Windows.Forms.TextBox();
            this.InstructorLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // InstDeleteBut
            // 
            this.InstDeleteBut.Location = new System.Drawing.Point(606, 190);
            this.InstDeleteBut.Name = "InstDeleteBut";
            this.InstDeleteBut.Size = new System.Drawing.Size(96, 28);
            this.InstDeleteBut.TabIndex = 55;
            this.InstDeleteBut.Text = "Delete";
            this.InstDeleteBut.UseVisualStyleBackColor = true;
            this.InstDeleteBut.Click += new System.EventHandler(this.InstDeleteBut_Click);
            // 
            // InstAddBut
            // 
            this.InstAddBut.Location = new System.Drawing.Point(479, 190);
            this.InstAddBut.Name = "InstAddBut";
            this.InstAddBut.Size = new System.Drawing.Size(90, 28);
            this.InstAddBut.TabIndex = 54;
            this.InstAddBut.Text = "Add";
            this.InstAddBut.UseVisualStyleBackColor = true;
            this.InstAddBut.Click += new System.EventHandler(this.InstAddBut_Click);
            // 
            // InstUpdateBut
            // 
            this.InstUpdateBut.Location = new System.Drawing.Point(353, 190);
            this.InstUpdateBut.Name = "InstUpdateBut";
            this.InstUpdateBut.Size = new System.Drawing.Size(92, 28);
            this.InstUpdateBut.TabIndex = 53;
            this.InstUpdateBut.Text = "Update";
            this.InstUpdateBut.UseVisualStyleBackColor = true;
            this.InstUpdateBut.Click += new System.EventHandler(this.InstUpdateBut_Click);
            // 
            // InstSearchBut
            // 
            this.InstSearchBut.Location = new System.Drawing.Point(654, 129);
            this.InstSearchBut.Name = "InstSearchBut";
            this.InstSearchBut.Size = new System.Drawing.Size(75, 23);
            this.InstSearchBut.TabIndex = 52;
            this.InstSearchBut.Text = "Search";
            this.InstSearchBut.UseVisualStyleBackColor = true;
            this.InstSearchBut.Click += new System.EventHandler(this.InstSearchBut_Click);
            // 
            // InstSearchTxtBox
            // 
            this.InstSearchTxtBox.Location = new System.Drawing.Point(462, 129);
            this.InstSearchTxtBox.Name = "InstSearchTxtBox";
            this.InstSearchTxtBox.Size = new System.Drawing.Size(167, 22);
            this.InstSearchTxtBox.TabIndex = 51;
            // 
            // InstSearchLbl
            // 
            this.InstSearchLbl.AutoSize = true;
            this.InstSearchLbl.Location = new System.Drawing.Point(359, 129);
            this.InstSearchLbl.Name = "InstSearchLbl";
            this.InstSearchLbl.Size = new System.Drawing.Size(97, 17);
            this.InstSearchLbl.TabIndex = 50;
            this.InstSearchLbl.Text = "National Code";
            // 
            // LastInstBut
            // 
            this.LastInstBut.Location = new System.Drawing.Point(665, 49);
            this.LastInstBut.Name = "LastInstBut";
            this.LastInstBut.Size = new System.Drawing.Size(88, 44);
            this.LastInstBut.TabIndex = 49;
            this.LastInstBut.Text = "Last";
            this.LastInstBut.UseVisualStyleBackColor = true;
            this.LastInstBut.Click += new System.EventHandler(this.LastInstBut_Click);
            // 
            // PreviousInstBut
            // 
            this.PreviousInstBut.Location = new System.Drawing.Point(456, 49);
            this.PreviousInstBut.Name = "PreviousInstBut";
            this.PreviousInstBut.Size = new System.Drawing.Size(83, 44);
            this.PreviousInstBut.TabIndex = 48;
            this.PreviousInstBut.Text = "Previous";
            this.PreviousInstBut.UseVisualStyleBackColor = true;
            this.PreviousInstBut.Click += new System.EventHandler(this.PreviousInstBut_Click);
            // 
            // NextInstBut
            // 
            this.NextInstBut.Location = new System.Drawing.Point(562, 49);
            this.NextInstBut.Name = "NextInstBut";
            this.NextInstBut.Size = new System.Drawing.Size(82, 44);
            this.NextInstBut.TabIndex = 47;
            this.NextInstBut.Text = "Next";
            this.NextInstBut.UseVisualStyleBackColor = true;
            this.NextInstBut.Click += new System.EventHandler(this.NextInstBut_Click);
            // 
            // LoadFirstInstBut
            // 
            this.LoadFirstInstBut.Location = new System.Drawing.Point(353, 49);
            this.LoadFirstInstBut.Name = "LoadFirstInstBut";
            this.LoadFirstInstBut.Size = new System.Drawing.Size(83, 44);
            this.LoadFirstInstBut.TabIndex = 46;
            this.LoadFirstInstBut.Text = "Load First Intructor";
            this.LoadFirstInstBut.UseVisualStyleBackColor = true;
            this.LoadFirstInstBut.Click += new System.EventHandler(this.LoadFirstInstBut_Click);
            // 
            // InstIDTxtBox
            // 
            this.InstIDTxtBox.Location = new System.Drawing.Point(133, 60);
            this.InstIDTxtBox.Name = "InstIDTxtBox";
            this.InstIDTxtBox.Size = new System.Drawing.Size(131, 22);
            this.InstIDTxtBox.TabIndex = 45;
            // 
            // InsIDLbl
            // 
            this.InsIDLbl.AutoSize = true;
            this.InsIDLbl.Location = new System.Drawing.Point(14, 60);
            this.InsIDLbl.Name = "InsIDLbl";
            this.InsIDLbl.Size = new System.Drawing.Size(21, 17);
            this.InsIDLbl.TabIndex = 44;
            this.InsIDLbl.Text = "ID";
            // 
            // InstGenderTxtBox
            // 
            this.InstGenderTxtBox.Location = new System.Drawing.Point(133, 311);
            this.InstGenderTxtBox.Name = "InstGenderTxtBox";
            this.InstGenderTxtBox.Size = new System.Drawing.Size(131, 22);
            this.InstGenderTxtBox.TabIndex = 42;
            // 
            // InstNationalCodeTxtBox
            // 
            this.InstNationalCodeTxtBox.Location = new System.Drawing.Point(133, 274);
            this.InstNationalCodeTxtBox.Name = "InstNationalCodeTxtBox";
            this.InstNationalCodeTxtBox.Size = new System.Drawing.Size(131, 22);
            this.InstNationalCodeTxtBox.TabIndex = 41;
            // 
            // InstNumTxtBox
            // 
            this.InstNumTxtBox.Location = new System.Drawing.Point(133, 239);
            this.InstNumTxtBox.Name = "InstNumTxtBox";
            this.InstNumTxtBox.Size = new System.Drawing.Size(131, 22);
            this.InstNumTxtBox.TabIndex = 40;
            // 
            // InstEmailTxtBox
            // 
            this.InstEmailTxtBox.Location = new System.Drawing.Point(133, 207);
            this.InstEmailTxtBox.Name = "InstEmailTxtBox";
            this.InstEmailTxtBox.Size = new System.Drawing.Size(131, 22);
            this.InstEmailTxtBox.TabIndex = 39;
            // 
            // InstPhoneTxtBox
            // 
            this.InstPhoneTxtBox.Location = new System.Drawing.Point(133, 174);
            this.InstPhoneTxtBox.Name = "InstPhoneTxtBox";
            this.InstPhoneTxtBox.Size = new System.Drawing.Size(131, 22);
            this.InstPhoneTxtBox.TabIndex = 38;
            // 
            // InstLNameTxtBox
            // 
            this.InstLNameTxtBox.Location = new System.Drawing.Point(133, 140);
            this.InstLNameTxtBox.Name = "InstLNameTxtBox";
            this.InstLNameTxtBox.Size = new System.Drawing.Size(131, 22);
            this.InstLNameTxtBox.TabIndex = 37;
            // 
            // InsGenderLbl
            // 
            this.InsGenderLbl.AutoSize = true;
            this.InsGenderLbl.Location = new System.Drawing.Point(14, 316);
            this.InsGenderLbl.Name = "InsGenderLbl";
            this.InsGenderLbl.Size = new System.Drawing.Size(56, 17);
            this.InsGenderLbl.TabIndex = 35;
            this.InsGenderLbl.Text = "Gender";
            // 
            // InsNationalCodeLbl
            // 
            this.InsNationalCodeLbl.AutoSize = true;
            this.InsNationalCodeLbl.Location = new System.Drawing.Point(14, 274);
            this.InsNationalCodeLbl.Name = "InsNationalCodeLbl";
            this.InsNationalCodeLbl.Size = new System.Drawing.Size(97, 17);
            this.InsNationalCodeLbl.TabIndex = 34;
            this.InsNationalCodeLbl.Text = "National Code";
            // 
            // InstNumLbl
            // 
            this.InstNumLbl.AutoSize = true;
            this.InstNumLbl.Location = new System.Drawing.Point(14, 239);
            this.InstNumLbl.Name = "InstNumLbl";
            this.InstNumLbl.Size = new System.Drawing.Size(114, 17);
            this.InstNumLbl.TabIndex = 33;
            this.InstNumLbl.Text = "Intructor Number";
            // 
            // InsEmailLbl
            // 
            this.InsEmailLbl.AutoSize = true;
            this.InsEmailLbl.Location = new System.Drawing.Point(14, 207);
            this.InsEmailLbl.Name = "InsEmailLbl";
            this.InsEmailLbl.Size = new System.Drawing.Size(42, 17);
            this.InsEmailLbl.TabIndex = 32;
            this.InsEmailLbl.Text = "Email";
            // 
            // InsPhoneLbl
            // 
            this.InsPhoneLbl.AutoSize = true;
            this.InsPhoneLbl.Location = new System.Drawing.Point(14, 179);
            this.InsPhoneLbl.Name = "InsPhoneLbl";
            this.InsPhoneLbl.Size = new System.Drawing.Size(49, 17);
            this.InsPhoneLbl.TabIndex = 31;
            this.InsPhoneLbl.Text = "Phone";
            // 
            // InsLastNameLbl
            // 
            this.InsLastNameLbl.AutoSize = true;
            this.InsLastNameLbl.Location = new System.Drawing.Point(14, 140);
            this.InsLastNameLbl.Name = "InsLastNameLbl";
            this.InsLastNameLbl.Size = new System.Drawing.Size(76, 17);
            this.InsLastNameLbl.TabIndex = 30;
            this.InsLastNameLbl.Text = "Last Name";
            // 
            // InstFNameTxtBox
            // 
            this.InstFNameTxtBox.Location = new System.Drawing.Point(133, 99);
            this.InstFNameTxtBox.Name = "InstFNameTxtBox";
            this.InstFNameTxtBox.Size = new System.Drawing.Size(131, 22);
            this.InstFNameTxtBox.TabIndex = 29;
            // 
            // InsFNameLbl
            // 
            this.InsFNameLbl.AutoSize = true;
            this.InsFNameLbl.Location = new System.Drawing.Point(14, 99);
            this.InsFNameLbl.Name = "InsFNameLbl";
            this.InsFNameLbl.Size = new System.Drawing.Size(76, 17);
            this.InsFNameLbl.TabIndex = 28;
            this.InsFNameLbl.Text = "First Name";
            // 
            // DegreeLbl
            // 
            this.DegreeLbl.AutoSize = true;
            this.DegreeLbl.Location = new System.Drawing.Point(14, 355);
            this.DegreeLbl.Name = "DegreeLbl";
            this.DegreeLbl.Size = new System.Drawing.Size(55, 17);
            this.DegreeLbl.TabIndex = 56;
            this.DegreeLbl.Text = "Degree";
            // 
            // DegreeTxtBox
            // 
            this.DegreeTxtBox.Location = new System.Drawing.Point(133, 355);
            this.DegreeTxtBox.Name = "DegreeTxtBox";
            this.DegreeTxtBox.Size = new System.Drawing.Size(131, 22);
            this.DegreeTxtBox.TabIndex = 57;
            // 
            // InstructorLbl
            // 
            this.InstructorLbl.AutoSize = true;
            this.InstructorLbl.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.InstructorLbl.Location = new System.Drawing.Point(57, 19);
            this.InstructorLbl.Name = "InstructorLbl";
            this.InstructorLbl.Size = new System.Drawing.Size(103, 17);
            this.InstructorLbl.TabIndex = 58;
            this.InstructorLbl.Text = "Instructor Form";
            // 
            // InstructorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.InstructorLbl);
            this.Controls.Add(this.DegreeTxtBox);
            this.Controls.Add(this.DegreeLbl);
            this.Controls.Add(this.InstDeleteBut);
            this.Controls.Add(this.InstAddBut);
            this.Controls.Add(this.InstUpdateBut);
            this.Controls.Add(this.InstSearchBut);
            this.Controls.Add(this.InstSearchTxtBox);
            this.Controls.Add(this.InstSearchLbl);
            this.Controls.Add(this.LastInstBut);
            this.Controls.Add(this.PreviousInstBut);
            this.Controls.Add(this.NextInstBut);
            this.Controls.Add(this.LoadFirstInstBut);
            this.Controls.Add(this.InstIDTxtBox);
            this.Controls.Add(this.InsIDLbl);
            this.Controls.Add(this.InstGenderTxtBox);
            this.Controls.Add(this.InstNationalCodeTxtBox);
            this.Controls.Add(this.InstNumTxtBox);
            this.Controls.Add(this.InstEmailTxtBox);
            this.Controls.Add(this.InstPhoneTxtBox);
            this.Controls.Add(this.InstLNameTxtBox);
            this.Controls.Add(this.InsGenderLbl);
            this.Controls.Add(this.InsNationalCodeLbl);
            this.Controls.Add(this.InstNumLbl);
            this.Controls.Add(this.InsEmailLbl);
            this.Controls.Add(this.InsPhoneLbl);
            this.Controls.Add(this.InsLastNameLbl);
            this.Controls.Add(this.InstFNameTxtBox);
            this.Controls.Add(this.InsFNameLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InstructorForm";
            this.Text = "InstructorForm";
            this.Load += new System.EventHandler(this.InstructorForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button InstDeleteBut;
        private System.Windows.Forms.Button InstAddBut;
        private System.Windows.Forms.Button InstUpdateBut;
        private System.Windows.Forms.Button InstSearchBut;
        private System.Windows.Forms.TextBox InstSearchTxtBox;
        private System.Windows.Forms.Label InstSearchLbl;
        private System.Windows.Forms.Button LastInstBut;
        private System.Windows.Forms.Button PreviousInstBut;
        private System.Windows.Forms.Button NextInstBut;
        private System.Windows.Forms.Button LoadFirstInstBut;
        private System.Windows.Forms.TextBox InstIDTxtBox;
        private System.Windows.Forms.Label InsIDLbl;
        private System.Windows.Forms.TextBox InstGenderTxtBox;
        private System.Windows.Forms.TextBox InstNationalCodeTxtBox;
        private System.Windows.Forms.TextBox InstNumTxtBox;
        private System.Windows.Forms.TextBox InstEmailTxtBox;
        private System.Windows.Forms.TextBox InstPhoneTxtBox;
        private System.Windows.Forms.TextBox InstLNameTxtBox;
        private System.Windows.Forms.Label InsGenderLbl;
        private System.Windows.Forms.Label InsNationalCodeLbl;
        private System.Windows.Forms.Label InstNumLbl;
        private System.Windows.Forms.Label InsEmailLbl;
        private System.Windows.Forms.Label InsPhoneLbl;
        private System.Windows.Forms.Label InsLastNameLbl;
        private System.Windows.Forms.TextBox InstFNameTxtBox;
        private System.Windows.Forms.Label InsFNameLbl;
        private System.Windows.Forms.Label DegreeLbl;
        private System.Windows.Forms.TextBox DegreeTxtBox;
        private System.Windows.Forms.Label InstructorLbl;
    }
}