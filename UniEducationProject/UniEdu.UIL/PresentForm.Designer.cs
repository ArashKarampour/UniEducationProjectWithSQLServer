namespace UniEdu.UIL
{
    partial class PresentForm
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
            this.IDTxtBox = new System.Windows.Forms.TextBox();
            this.IDLbl = new System.Windows.Forms.Label();
            this.ClassFinishTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ClassBeginTimePicker = new System.Windows.Forms.DateTimePicker();
            this.PresentFormLbl = new System.Windows.Forms.Label();
            this.FTimeLbl = new System.Windows.Forms.Label();
            this.BgTimeLbl = new System.Windows.Forms.Label();
            this.DeleteBut = new System.Windows.Forms.Button();
            this.AddBut = new System.Windows.Forms.Button();
            this.UpdateBut = new System.Windows.Forms.Button();
            this.SearchBut = new System.Windows.Forms.Button();
            this.SearchTxtBox = new System.Windows.Forms.TextBox();
            this.SearchIDLbl = new System.Windows.Forms.Label();
            this.LastPresentBut = new System.Windows.Forms.Button();
            this.PreviousPresentBut = new System.Windows.Forms.Button();
            this.NextPresentBut = new System.Windows.Forms.Button();
            this.LoadFirstPresentBut = new System.Windows.Forms.Button();
            this.DayTxtBox = new System.Windows.Forms.TextBox();
            this.SemesterTxtBox = new System.Windows.Forms.TextBox();
            this.YearTxtBox = new System.Windows.Forms.TextBox();
            this.ClassIDTxtBox = new System.Windows.Forms.TextBox();
            this.DayLbl = new System.Windows.Forms.Label();
            this.SemesterLbl = new System.Windows.Forms.Label();
            this.YearLbl = new System.Windows.Forms.Label();
            this.ClassIDLbl = new System.Windows.Forms.Label();
            this.CourseIDTxtBox = new System.Windows.Forms.TextBox();
            this.CourseIDLbl = new System.Windows.Forms.Label();
            this.InstIDTxtBox = new System.Windows.Forms.TextBox();
            this.InstIDLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // IDTxtBox
            // 
            this.IDTxtBox.Location = new System.Drawing.Point(143, 59);
            this.IDTxtBox.Name = "IDTxtBox";
            this.IDTxtBox.Size = new System.Drawing.Size(131, 22);
            this.IDTxtBox.TabIndex = 99;
            // 
            // IDLbl
            // 
            this.IDLbl.AutoSize = true;
            this.IDLbl.Location = new System.Drawing.Point(24, 62);
            this.IDLbl.Name = "IDLbl";
            this.IDLbl.Size = new System.Drawing.Size(21, 17);
            this.IDLbl.TabIndex = 98;
            this.IDLbl.Text = "ID";
            // 
            // ClassFinishTimePicker
            // 
            this.ClassFinishTimePicker.Location = new System.Drawing.Point(143, 360);
            this.ClassFinishTimePicker.Name = "ClassFinishTimePicker";
            this.ClassFinishTimePicker.Size = new System.Drawing.Size(200, 22);
            this.ClassFinishTimePicker.TabIndex = 97;
            // 
            // ClassBeginTimePicker
            // 
            this.ClassBeginTimePicker.Location = new System.Drawing.Point(143, 323);
            this.ClassBeginTimePicker.Name = "ClassBeginTimePicker";
            this.ClassBeginTimePicker.Size = new System.Drawing.Size(200, 22);
            this.ClassBeginTimePicker.TabIndex = 96;
            this.ClassBeginTimePicker.Value = new System.DateTime(2021, 7, 8, 0, 0, 0, 0);
            // 
            // PresentFormLbl
            // 
            this.PresentFormLbl.AutoSize = true;
            this.PresentFormLbl.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.PresentFormLbl.Location = new System.Drawing.Point(82, 19);
            this.PresentFormLbl.Name = "PresentFormLbl";
            this.PresentFormLbl.Size = new System.Drawing.Size(93, 17);
            this.PresentFormLbl.TabIndex = 95;
            this.PresentFormLbl.Text = "Present Form";
            // 
            // FTimeLbl
            // 
            this.FTimeLbl.AutoSize = true;
            this.FTimeLbl.Location = new System.Drawing.Point(24, 360);
            this.FTimeLbl.Name = "FTimeLbl";
            this.FTimeLbl.Size = new System.Drawing.Size(110, 17);
            this.FTimeLbl.TabIndex = 94;
            this.FTimeLbl.Text = "ClassFinishTime";
            // 
            // BgTimeLbl
            // 
            this.BgTimeLbl.AutoSize = true;
            this.BgTimeLbl.Location = new System.Drawing.Point(24, 323);
            this.BgTimeLbl.Name = "BgTimeLbl";
            this.BgTimeLbl.Size = new System.Drawing.Size(109, 17);
            this.BgTimeLbl.TabIndex = 93;
            this.BgTimeLbl.Text = "ClassBeginTime";
            // 
            // DeleteBut
            // 
            this.DeleteBut.Location = new System.Drawing.Point(616, 227);
            this.DeleteBut.Name = "DeleteBut";
            this.DeleteBut.Size = new System.Drawing.Size(82, 28);
            this.DeleteBut.TabIndex = 92;
            this.DeleteBut.Text = "Delete";
            this.DeleteBut.UseVisualStyleBackColor = true;
            this.DeleteBut.Click += new System.EventHandler(this.DeleteBut_Click);
            // 
            // AddBut
            // 
            this.AddBut.Location = new System.Drawing.Point(489, 227);
            this.AddBut.Name = "AddBut";
            this.AddBut.Size = new System.Drawing.Size(90, 28);
            this.AddBut.TabIndex = 91;
            this.AddBut.Text = "Add";
            this.AddBut.UseVisualStyleBackColor = true;
            this.AddBut.Click += new System.EventHandler(this.AddBut_Click);
            // 
            // UpdateBut
            // 
            this.UpdateBut.Location = new System.Drawing.Point(363, 227);
            this.UpdateBut.Name = "UpdateBut";
            this.UpdateBut.Size = new System.Drawing.Size(92, 28);
            this.UpdateBut.TabIndex = 90;
            this.UpdateBut.Text = "Update";
            this.UpdateBut.UseVisualStyleBackColor = true;
            this.UpdateBut.Click += new System.EventHandler(this.UpdateBut_Click);
            // 
            // SearchBut
            // 
            this.SearchBut.Location = new System.Drawing.Point(653, 168);
            this.SearchBut.Name = "SearchBut";
            this.SearchBut.Size = new System.Drawing.Size(75, 23);
            this.SearchBut.TabIndex = 89;
            this.SearchBut.Text = "Search";
            this.SearchBut.UseVisualStyleBackColor = true;
            this.SearchBut.Click += new System.EventHandler(this.SearchBut_Click);
            // 
            // SearchTxtBox
            // 
            this.SearchTxtBox.Location = new System.Drawing.Point(445, 166);
            this.SearchTxtBox.Name = "SearchTxtBox";
            this.SearchTxtBox.Size = new System.Drawing.Size(167, 22);
            this.SearchTxtBox.TabIndex = 88;
            // 
            // SearchIDLbl
            // 
            this.SearchIDLbl.AutoSize = true;
            this.SearchIDLbl.Location = new System.Drawing.Point(369, 166);
            this.SearchIDLbl.Name = "SearchIDLbl";
            this.SearchIDLbl.Size = new System.Drawing.Size(21, 17);
            this.SearchIDLbl.TabIndex = 87;
            this.SearchIDLbl.Text = "ID";
            // 
            // LastPresentBut
            // 
            this.LastPresentBut.Location = new System.Drawing.Point(675, 86);
            this.LastPresentBut.Name = "LastPresentBut";
            this.LastPresentBut.Size = new System.Drawing.Size(88, 44);
            this.LastPresentBut.TabIndex = 86;
            this.LastPresentBut.Text = "Last";
            this.LastPresentBut.UseVisualStyleBackColor = true;
            this.LastPresentBut.Click += new System.EventHandler(this.LastPresentBut_Click);
            // 
            // PreviousPresentBut
            // 
            this.PreviousPresentBut.Location = new System.Drawing.Point(466, 86);
            this.PreviousPresentBut.Name = "PreviousPresentBut";
            this.PreviousPresentBut.Size = new System.Drawing.Size(83, 44);
            this.PreviousPresentBut.TabIndex = 85;
            this.PreviousPresentBut.Text = "Previous";
            this.PreviousPresentBut.UseVisualStyleBackColor = true;
            this.PreviousPresentBut.Click += new System.EventHandler(this.PreviousPresentBut_Click);
            // 
            // NextPresentBut
            // 
            this.NextPresentBut.Location = new System.Drawing.Point(572, 86);
            this.NextPresentBut.Name = "NextPresentBut";
            this.NextPresentBut.Size = new System.Drawing.Size(82, 44);
            this.NextPresentBut.TabIndex = 84;
            this.NextPresentBut.Text = "Next";
            this.NextPresentBut.UseVisualStyleBackColor = true;
            this.NextPresentBut.Click += new System.EventHandler(this.NextPresentBut_Click);
            // 
            // LoadFirstPresentBut
            // 
            this.LoadFirstPresentBut.Location = new System.Drawing.Point(363, 86);
            this.LoadFirstPresentBut.Name = "LoadFirstPresentBut";
            this.LoadFirstPresentBut.Size = new System.Drawing.Size(83, 44);
            this.LoadFirstPresentBut.TabIndex = 83;
            this.LoadFirstPresentBut.Text = "Load First Present";
            this.LoadFirstPresentBut.UseVisualStyleBackColor = true;
            this.LoadFirstPresentBut.Click += new System.EventHandler(this.LoadFirstPresentBut_Click);
            // 
            // DayTxtBox
            // 
            this.DayTxtBox.Location = new System.Drawing.Point(143, 284);
            this.DayTxtBox.Name = "DayTxtBox";
            this.DayTxtBox.Size = new System.Drawing.Size(131, 22);
            this.DayTxtBox.TabIndex = 80;
            // 
            // SemesterTxtBox
            // 
            this.SemesterTxtBox.Location = new System.Drawing.Point(143, 247);
            this.SemesterTxtBox.Name = "SemesterTxtBox";
            this.SemesterTxtBox.Size = new System.Drawing.Size(131, 22);
            this.SemesterTxtBox.TabIndex = 79;
            // 
            // YearTxtBox
            // 
            this.YearTxtBox.Location = new System.Drawing.Point(143, 205);
            this.YearTxtBox.Name = "YearTxtBox";
            this.YearTxtBox.Size = new System.Drawing.Size(131, 22);
            this.YearTxtBox.TabIndex = 78;
            // 
            // ClassIDTxtBox
            // 
            this.ClassIDTxtBox.Location = new System.Drawing.Point(143, 93);
            this.ClassIDTxtBox.Name = "ClassIDTxtBox";
            this.ClassIDTxtBox.Size = new System.Drawing.Size(131, 22);
            this.ClassIDTxtBox.TabIndex = 75;
            // 
            // DayLbl
            // 
            this.DayLbl.AutoSize = true;
            this.DayLbl.Location = new System.Drawing.Point(24, 284);
            this.DayLbl.Name = "DayLbl";
            this.DayLbl.Size = new System.Drawing.Size(33, 17);
            this.DayLbl.TabIndex = 73;
            this.DayLbl.Text = "Day";
            // 
            // SemesterLbl
            // 
            this.SemesterLbl.AutoSize = true;
            this.SemesterLbl.Location = new System.Drawing.Point(24, 247);
            this.SemesterLbl.Name = "SemesterLbl";
            this.SemesterLbl.Size = new System.Drawing.Size(68, 17);
            this.SemesterLbl.TabIndex = 72;
            this.SemesterLbl.Text = "Semester";
            // 
            // YearLbl
            // 
            this.YearLbl.AutoSize = true;
            this.YearLbl.Location = new System.Drawing.Point(24, 208);
            this.YearLbl.Name = "YearLbl";
            this.YearLbl.Size = new System.Drawing.Size(38, 17);
            this.YearLbl.TabIndex = 71;
            this.YearLbl.Text = "Year";
            // 
            // ClassIDLbl
            // 
            this.ClassIDLbl.AutoSize = true;
            this.ClassIDLbl.Location = new System.Drawing.Point(24, 98);
            this.ClassIDLbl.Name = "ClassIDLbl";
            this.ClassIDLbl.Size = new System.Drawing.Size(59, 17);
            this.ClassIDLbl.TabIndex = 68;
            this.ClassIDLbl.Text = "Class ID";
            // 
            // CourseIDTxtBox
            // 
            this.CourseIDTxtBox.Location = new System.Drawing.Point(143, 130);
            this.CourseIDTxtBox.Name = "CourseIDTxtBox";
            this.CourseIDTxtBox.Size = new System.Drawing.Size(131, 22);
            this.CourseIDTxtBox.TabIndex = 66;
            // 
            // CourseIDLbl
            // 
            this.CourseIDLbl.AutoSize = true;
            this.CourseIDLbl.Location = new System.Drawing.Point(24, 135);
            this.CourseIDLbl.Name = "CourseIDLbl";
            this.CourseIDLbl.Size = new System.Drawing.Size(70, 17);
            this.CourseIDLbl.TabIndex = 65;
            this.CourseIDLbl.Text = "Course ID";
            // 
            // InstIDTxtBox
            // 
            this.InstIDTxtBox.Location = new System.Drawing.Point(143, 168);
            this.InstIDTxtBox.Name = "InstIDTxtBox";
            this.InstIDTxtBox.Size = new System.Drawing.Size(131, 22);
            this.InstIDTxtBox.TabIndex = 74;
            // 
            // InstIDLbl
            // 
            this.InstIDLbl.AutoSize = true;
            this.InstIDLbl.Location = new System.Drawing.Point(24, 173);
            this.InstIDLbl.Name = "InstIDLbl";
            this.InstIDLbl.Size = new System.Drawing.Size(84, 17);
            this.InstIDLbl.TabIndex = 67;
            this.InstIDLbl.Text = "Instructor ID";
            // 
            // PresentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 509);
            this.Controls.Add(this.IDTxtBox);
            this.Controls.Add(this.IDLbl);
            this.Controls.Add(this.ClassFinishTimePicker);
            this.Controls.Add(this.ClassBeginTimePicker);
            this.Controls.Add(this.PresentFormLbl);
            this.Controls.Add(this.FTimeLbl);
            this.Controls.Add(this.BgTimeLbl);
            this.Controls.Add(this.DeleteBut);
            this.Controls.Add(this.AddBut);
            this.Controls.Add(this.UpdateBut);
            this.Controls.Add(this.SearchBut);
            this.Controls.Add(this.SearchTxtBox);
            this.Controls.Add(this.SearchIDLbl);
            this.Controls.Add(this.LastPresentBut);
            this.Controls.Add(this.PreviousPresentBut);
            this.Controls.Add(this.NextPresentBut);
            this.Controls.Add(this.LoadFirstPresentBut);
            this.Controls.Add(this.DayTxtBox);
            this.Controls.Add(this.SemesterTxtBox);
            this.Controls.Add(this.YearTxtBox);
            this.Controls.Add(this.ClassIDTxtBox);
            this.Controls.Add(this.InstIDTxtBox);
            this.Controls.Add(this.DayLbl);
            this.Controls.Add(this.SemesterLbl);
            this.Controls.Add(this.YearLbl);
            this.Controls.Add(this.ClassIDLbl);
            this.Controls.Add(this.InstIDLbl);
            this.Controls.Add(this.CourseIDTxtBox);
            this.Controls.Add(this.CourseIDLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PresentForm";
            this.Text = "PresentForm";
            this.Load += new System.EventHandler(this.PresentForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox IDTxtBox;
        private System.Windows.Forms.Label IDLbl;
        private System.Windows.Forms.DateTimePicker ClassFinishTimePicker;
        private System.Windows.Forms.DateTimePicker ClassBeginTimePicker;
        private System.Windows.Forms.Label PresentFormLbl;
        private System.Windows.Forms.Label FTimeLbl;
        private System.Windows.Forms.Label BgTimeLbl;
        private System.Windows.Forms.Button DeleteBut;
        private System.Windows.Forms.Button AddBut;
        private System.Windows.Forms.Button UpdateBut;
        private System.Windows.Forms.Button SearchBut;
        private System.Windows.Forms.TextBox SearchTxtBox;
        private System.Windows.Forms.Label SearchIDLbl;
        private System.Windows.Forms.Button LastPresentBut;
        private System.Windows.Forms.Button PreviousPresentBut;
        private System.Windows.Forms.Button NextPresentBut;
        private System.Windows.Forms.Button LoadFirstPresentBut;
        private System.Windows.Forms.TextBox DayTxtBox;
        private System.Windows.Forms.TextBox SemesterTxtBox;
        private System.Windows.Forms.TextBox YearTxtBox;
        private System.Windows.Forms.TextBox ClassIDTxtBox;
        private System.Windows.Forms.Label DayLbl;
        private System.Windows.Forms.Label SemesterLbl;
        private System.Windows.Forms.Label YearLbl;
        private System.Windows.Forms.Label ClassIDLbl;
        private System.Windows.Forms.TextBox CourseIDTxtBox;
        private System.Windows.Forms.Label CourseIDLbl;
        private System.Windows.Forms.TextBox InstIDTxtBox;
        private System.Windows.Forms.Label InstIDLbl;
    }
}