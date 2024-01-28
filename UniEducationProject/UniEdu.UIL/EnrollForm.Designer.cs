namespace UniEdu.UIL
{
    partial class EnrollForm
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
            this.DeleteBut = new System.Windows.Forms.Button();
            this.AddBut = new System.Windows.Forms.Button();
            this.UpdateBut = new System.Windows.Forms.Button();
            this.SearchBut = new System.Windows.Forms.Button();
            this.SearchTxtBox = new System.Windows.Forms.TextBox();
            this.SearchIDLbl = new System.Windows.Forms.Label();
            this.LastEnrollBut = new System.Windows.Forms.Button();
            this.PreviousEnrollBut = new System.Windows.Forms.Button();
            this.NextEnrollBut = new System.Windows.Forms.Button();
            this.LoadFirstEnrollBut = new System.Windows.Forms.Button();
            this.SIDTxtBox = new System.Windows.Forms.TextBox();
            this.StudentIDLbl = new System.Windows.Forms.Label();
            this.DayTxtBox = new System.Windows.Forms.TextBox();
            this.SemesterTxtBox = new System.Windows.Forms.TextBox();
            this.YearTxtBox = new System.Windows.Forms.TextBox();
            this.PointTxtBox = new System.Windows.Forms.TextBox();
            this.StatusTxtBox = new System.Windows.Forms.TextBox();
            this.ClassIDTxtBox = new System.Windows.Forms.TextBox();
            this.InstIDTxtBox = new System.Windows.Forms.TextBox();
            this.DayLbl = new System.Windows.Forms.Label();
            this.SemesterLbl = new System.Windows.Forms.Label();
            this.YearLbl = new System.Windows.Forms.Label();
            this.PointLbl = new System.Windows.Forms.Label();
            this.StatusLbl = new System.Windows.Forms.Label();
            this.ClassIDLbl = new System.Windows.Forms.Label();
            this.InstIDLbl = new System.Windows.Forms.Label();
            this.CourseIDTxtBox = new System.Windows.Forms.TextBox();
            this.CourseIDLbl = new System.Windows.Forms.Label();
            this.FTimeLbl = new System.Windows.Forms.Label();
            this.BgTimeLbl = new System.Windows.Forms.Label();
            this.EnrollFormLbl = new System.Windows.Forms.Label();
            this.CourseBeginTimePicker = new System.Windows.Forms.DateTimePicker();
            this.CourseFinishTimePicker = new System.Windows.Forms.DateTimePicker();
            this.IDLbl = new System.Windows.Forms.Label();
            this.IDTxtBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // DeleteBut
            // 
            this.DeleteBut.Location = new System.Drawing.Point(623, 249);
            this.DeleteBut.Name = "DeleteBut";
            this.DeleteBut.Size = new System.Drawing.Size(82, 28);
            this.DeleteBut.TabIndex = 55;
            this.DeleteBut.Text = "Delete";
            this.DeleteBut.UseVisualStyleBackColor = true;
            this.DeleteBut.Click += new System.EventHandler(this.DeleteBut_Click);
            // 
            // AddBut
            // 
            this.AddBut.Location = new System.Drawing.Point(496, 249);
            this.AddBut.Name = "AddBut";
            this.AddBut.Size = new System.Drawing.Size(90, 28);
            this.AddBut.TabIndex = 54;
            this.AddBut.Text = "Add";
            this.AddBut.UseVisualStyleBackColor = true;
            this.AddBut.Click += new System.EventHandler(this.AddBut_Click);
            // 
            // UpdateBut
            // 
            this.UpdateBut.Location = new System.Drawing.Point(370, 249);
            this.UpdateBut.Name = "UpdateBut";
            this.UpdateBut.Size = new System.Drawing.Size(92, 28);
            this.UpdateBut.TabIndex = 53;
            this.UpdateBut.Text = "Update";
            this.UpdateBut.UseVisualStyleBackColor = true;
            this.UpdateBut.Click += new System.EventHandler(this.UpdateBut_Click);
            // 
            // SearchBut
            // 
            this.SearchBut.Location = new System.Drawing.Point(671, 188);
            this.SearchBut.Name = "SearchBut";
            this.SearchBut.Size = new System.Drawing.Size(75, 23);
            this.SearchBut.TabIndex = 52;
            this.SearchBut.Text = "Search";
            this.SearchBut.UseVisualStyleBackColor = true;
            this.SearchBut.Click += new System.EventHandler(this.SearchBut_Click);
            // 
            // SearchTxtBox
            // 
            this.SearchTxtBox.Location = new System.Drawing.Point(479, 188);
            this.SearchTxtBox.Name = "SearchTxtBox";
            this.SearchTxtBox.Size = new System.Drawing.Size(167, 22);
            this.SearchTxtBox.TabIndex = 51;
            // 
            // SearchIDLbl
            // 
            this.SearchIDLbl.AutoSize = true;
            this.SearchIDLbl.Location = new System.Drawing.Point(376, 188);
            this.SearchIDLbl.Name = "SearchIDLbl";
            this.SearchIDLbl.Size = new System.Drawing.Size(21, 17);
            this.SearchIDLbl.TabIndex = 50;
            this.SearchIDLbl.Text = "ID";
            // 
            // LastEnrollBut
            // 
            this.LastEnrollBut.Location = new System.Drawing.Point(682, 108);
            this.LastEnrollBut.Name = "LastEnrollBut";
            this.LastEnrollBut.Size = new System.Drawing.Size(88, 44);
            this.LastEnrollBut.TabIndex = 49;
            this.LastEnrollBut.Text = "Last";
            this.LastEnrollBut.UseVisualStyleBackColor = true;
            this.LastEnrollBut.Click += new System.EventHandler(this.LastEnrollBut_Click);
            // 
            // PreviousEnrollBut
            // 
            this.PreviousEnrollBut.Location = new System.Drawing.Point(473, 108);
            this.PreviousEnrollBut.Name = "PreviousEnrollBut";
            this.PreviousEnrollBut.Size = new System.Drawing.Size(83, 44);
            this.PreviousEnrollBut.TabIndex = 48;
            this.PreviousEnrollBut.Text = "Previous";
            this.PreviousEnrollBut.UseVisualStyleBackColor = true;
            this.PreviousEnrollBut.Click += new System.EventHandler(this.PreviousEnrollBut_Click);
            // 
            // NextEnrollBut
            // 
            this.NextEnrollBut.Location = new System.Drawing.Point(579, 108);
            this.NextEnrollBut.Name = "NextEnrollBut";
            this.NextEnrollBut.Size = new System.Drawing.Size(82, 44);
            this.NextEnrollBut.TabIndex = 47;
            this.NextEnrollBut.Text = "Next";
            this.NextEnrollBut.UseVisualStyleBackColor = true;
            this.NextEnrollBut.Click += new System.EventHandler(this.NextEnrollBut_Click);
            // 
            // LoadFirstEnrollBut
            // 
            this.LoadFirstEnrollBut.Location = new System.Drawing.Point(370, 108);
            this.LoadFirstEnrollBut.Name = "LoadFirstEnrollBut";
            this.LoadFirstEnrollBut.Size = new System.Drawing.Size(83, 44);
            this.LoadFirstEnrollBut.TabIndex = 46;
            this.LoadFirstEnrollBut.Text = "Load First Enroll";
            this.LoadFirstEnrollBut.UseVisualStyleBackColor = true;
            this.LoadFirstEnrollBut.Click += new System.EventHandler(this.LoadFirstEnrollBut_Click);
            // 
            // SIDTxtBox
            // 
            this.SIDTxtBox.Location = new System.Drawing.Point(150, 108);
            this.SIDTxtBox.Name = "SIDTxtBox";
            this.SIDTxtBox.Size = new System.Drawing.Size(131, 22);
            this.SIDTxtBox.TabIndex = 45;
            // 
            // StudentIDLbl
            // 
            this.StudentIDLbl.AutoSize = true;
            this.StudentIDLbl.Location = new System.Drawing.Point(31, 113);
            this.StudentIDLbl.Name = "StudentIDLbl";
            this.StudentIDLbl.Size = new System.Drawing.Size(74, 17);
            this.StudentIDLbl.TabIndex = 44;
            this.StudentIDLbl.Text = "Student ID";
            // 
            // DayTxtBox
            // 
            this.DayTxtBox.Location = new System.Drawing.Point(150, 401);
            this.DayTxtBox.Name = "DayTxtBox";
            this.DayTxtBox.Size = new System.Drawing.Size(131, 22);
            this.DayTxtBox.TabIndex = 43;
            // 
            // SemesterTxtBox
            // 
            this.SemesterTxtBox.Location = new System.Drawing.Point(150, 364);
            this.SemesterTxtBox.Name = "SemesterTxtBox";
            this.SemesterTxtBox.Size = new System.Drawing.Size(131, 22);
            this.SemesterTxtBox.TabIndex = 42;
            // 
            // YearTxtBox
            // 
            this.YearTxtBox.Location = new System.Drawing.Point(150, 322);
            this.YearTxtBox.Name = "YearTxtBox";
            this.YearTxtBox.Size = new System.Drawing.Size(131, 22);
            this.YearTxtBox.TabIndex = 41;
            // 
            // PointTxtBox
            // 
            this.PointTxtBox.Location = new System.Drawing.Point(150, 287);
            this.PointTxtBox.Name = "PointTxtBox";
            this.PointTxtBox.Size = new System.Drawing.Size(131, 22);
            this.PointTxtBox.TabIndex = 40;
            // 
            // StatusTxtBox
            // 
            this.StatusTxtBox.Location = new System.Drawing.Point(150, 255);
            this.StatusTxtBox.Name = "StatusTxtBox";
            this.StatusTxtBox.Size = new System.Drawing.Size(131, 22);
            this.StatusTxtBox.TabIndex = 39;
            // 
            // ClassIDTxtBox
            // 
            this.ClassIDTxtBox.Location = new System.Drawing.Point(150, 222);
            this.ClassIDTxtBox.Name = "ClassIDTxtBox";
            this.ClassIDTxtBox.Size = new System.Drawing.Size(131, 22);
            this.ClassIDTxtBox.TabIndex = 38;
            // 
            // InstIDTxtBox
            // 
            this.InstIDTxtBox.Location = new System.Drawing.Point(150, 189);
            this.InstIDTxtBox.Name = "InstIDTxtBox";
            this.InstIDTxtBox.Size = new System.Drawing.Size(131, 22);
            this.InstIDTxtBox.TabIndex = 37;
            // 
            // DayLbl
            // 
            this.DayLbl.AutoSize = true;
            this.DayLbl.Location = new System.Drawing.Point(31, 401);
            this.DayLbl.Name = "DayLbl";
            this.DayLbl.Size = new System.Drawing.Size(33, 17);
            this.DayLbl.TabIndex = 36;
            this.DayLbl.Text = "Day";
            // 
            // SemesterLbl
            // 
            this.SemesterLbl.AutoSize = true;
            this.SemesterLbl.Location = new System.Drawing.Point(31, 364);
            this.SemesterLbl.Name = "SemesterLbl";
            this.SemesterLbl.Size = new System.Drawing.Size(68, 17);
            this.SemesterLbl.TabIndex = 35;
            this.SemesterLbl.Text = "Semester";
            // 
            // YearLbl
            // 
            this.YearLbl.AutoSize = true;
            this.YearLbl.Location = new System.Drawing.Point(31, 325);
            this.YearLbl.Name = "YearLbl";
            this.YearLbl.Size = new System.Drawing.Size(38, 17);
            this.YearLbl.TabIndex = 34;
            this.YearLbl.Text = "Year";
            // 
            // PointLbl
            // 
            this.PointLbl.AutoSize = true;
            this.PointLbl.Location = new System.Drawing.Point(31, 292);
            this.PointLbl.Name = "PointLbl";
            this.PointLbl.Size = new System.Drawing.Size(40, 17);
            this.PointLbl.TabIndex = 33;
            this.PointLbl.Text = "Point";
            // 
            // StatusLbl
            // 
            this.StatusLbl.AutoSize = true;
            this.StatusLbl.Location = new System.Drawing.Point(31, 258);
            this.StatusLbl.Name = "StatusLbl";
            this.StatusLbl.Size = new System.Drawing.Size(48, 17);
            this.StatusLbl.TabIndex = 32;
            this.StatusLbl.Text = "Status";
            // 
            // ClassIDLbl
            // 
            this.ClassIDLbl.AutoSize = true;
            this.ClassIDLbl.Location = new System.Drawing.Point(31, 227);
            this.ClassIDLbl.Name = "ClassIDLbl";
            this.ClassIDLbl.Size = new System.Drawing.Size(59, 17);
            this.ClassIDLbl.TabIndex = 31;
            this.ClassIDLbl.Text = "Class ID";
            // 
            // InstIDLbl
            // 
            this.InstIDLbl.AutoSize = true;
            this.InstIDLbl.Location = new System.Drawing.Point(31, 194);
            this.InstIDLbl.Name = "InstIDLbl";
            this.InstIDLbl.Size = new System.Drawing.Size(84, 17);
            this.InstIDLbl.TabIndex = 30;
            this.InstIDLbl.Text = "Instructor ID";
            // 
            // CourseIDTxtBox
            // 
            this.CourseIDTxtBox.Location = new System.Drawing.Point(150, 147);
            this.CourseIDTxtBox.Name = "CourseIDTxtBox";
            this.CourseIDTxtBox.Size = new System.Drawing.Size(131, 22);
            this.CourseIDTxtBox.TabIndex = 29;
            // 
            // CourseIDLbl
            // 
            this.CourseIDLbl.AutoSize = true;
            this.CourseIDLbl.Location = new System.Drawing.Point(31, 152);
            this.CourseIDLbl.Name = "CourseIDLbl";
            this.CourseIDLbl.Size = new System.Drawing.Size(70, 17);
            this.CourseIDLbl.TabIndex = 28;
            this.CourseIDLbl.Text = "Course ID";
            // 
            // FTimeLbl
            // 
            this.FTimeLbl.AutoSize = true;
            this.FTimeLbl.Location = new System.Drawing.Point(31, 477);
            this.FTimeLbl.Name = "FTimeLbl";
            this.FTimeLbl.Size = new System.Drawing.Size(121, 17);
            this.FTimeLbl.TabIndex = 57;
            this.FTimeLbl.Text = "CourseFinishTime";
            // 
            // BgTimeLbl
            // 
            this.BgTimeLbl.AutoSize = true;
            this.BgTimeLbl.Location = new System.Drawing.Point(31, 440);
            this.BgTimeLbl.Name = "BgTimeLbl";
            this.BgTimeLbl.Size = new System.Drawing.Size(120, 17);
            this.BgTimeLbl.TabIndex = 56;
            this.BgTimeLbl.Text = "CourseBeginTime";
            // 
            // EnrollFormLbl
            // 
            this.EnrollFormLbl.AutoSize = true;
            this.EnrollFormLbl.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.EnrollFormLbl.Location = new System.Drawing.Point(96, 31);
            this.EnrollFormLbl.Name = "EnrollFormLbl";
            this.EnrollFormLbl.Size = new System.Drawing.Size(80, 17);
            this.EnrollFormLbl.TabIndex = 60;
            this.EnrollFormLbl.Text = "Enroll Form";
            // 
            // CourseBeginTimePicker
            // 
            this.CourseBeginTimePicker.Location = new System.Drawing.Point(150, 440);
            this.CourseBeginTimePicker.Name = "CourseBeginTimePicker";
            this.CourseBeginTimePicker.Size = new System.Drawing.Size(200, 22);
            this.CourseBeginTimePicker.TabIndex = 61;
            this.CourseBeginTimePicker.Value = new System.DateTime(2021, 7, 8, 0, 0, 0, 0);
            // 
            // CourseFinishTimePicker
            // 
            this.CourseFinishTimePicker.Location = new System.Drawing.Point(150, 477);
            this.CourseFinishTimePicker.Name = "CourseFinishTimePicker";
            this.CourseFinishTimePicker.Size = new System.Drawing.Size(200, 22);
            this.CourseFinishTimePicker.TabIndex = 62;
            // 
            // IDLbl
            // 
            this.IDLbl.AutoSize = true;
            this.IDLbl.Location = new System.Drawing.Point(31, 77);
            this.IDLbl.Name = "IDLbl";
            this.IDLbl.Size = new System.Drawing.Size(21, 17);
            this.IDLbl.TabIndex = 63;
            this.IDLbl.Text = "ID";
            // 
            // IDTxtBox
            // 
            this.IDTxtBox.Location = new System.Drawing.Point(150, 74);
            this.IDTxtBox.Name = "IDTxtBox";
            this.IDTxtBox.Size = new System.Drawing.Size(131, 22);
            this.IDTxtBox.TabIndex = 64;
            // 
            // EnrollForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 555);
            this.Controls.Add(this.IDTxtBox);
            this.Controls.Add(this.IDLbl);
            this.Controls.Add(this.CourseFinishTimePicker);
            this.Controls.Add(this.CourseBeginTimePicker);
            this.Controls.Add(this.EnrollFormLbl);
            this.Controls.Add(this.FTimeLbl);
            this.Controls.Add(this.BgTimeLbl);
            this.Controls.Add(this.DeleteBut);
            this.Controls.Add(this.AddBut);
            this.Controls.Add(this.UpdateBut);
            this.Controls.Add(this.SearchBut);
            this.Controls.Add(this.SearchTxtBox);
            this.Controls.Add(this.SearchIDLbl);
            this.Controls.Add(this.LastEnrollBut);
            this.Controls.Add(this.PreviousEnrollBut);
            this.Controls.Add(this.NextEnrollBut);
            this.Controls.Add(this.LoadFirstEnrollBut);
            this.Controls.Add(this.SIDTxtBox);
            this.Controls.Add(this.StudentIDLbl);
            this.Controls.Add(this.DayTxtBox);
            this.Controls.Add(this.SemesterTxtBox);
            this.Controls.Add(this.YearTxtBox);
            this.Controls.Add(this.PointTxtBox);
            this.Controls.Add(this.StatusTxtBox);
            this.Controls.Add(this.ClassIDTxtBox);
            this.Controls.Add(this.InstIDTxtBox);
            this.Controls.Add(this.DayLbl);
            this.Controls.Add(this.SemesterLbl);
            this.Controls.Add(this.YearLbl);
            this.Controls.Add(this.PointLbl);
            this.Controls.Add(this.StatusLbl);
            this.Controls.Add(this.ClassIDLbl);
            this.Controls.Add(this.InstIDLbl);
            this.Controls.Add(this.CourseIDTxtBox);
            this.Controls.Add(this.CourseIDLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EnrollForm";
            this.Text = "EnrollForm";
            this.Load += new System.EventHandler(this.EnrollForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DeleteBut;
        private System.Windows.Forms.Button AddBut;
        private System.Windows.Forms.Button UpdateBut;
        private System.Windows.Forms.Button SearchBut;
        private System.Windows.Forms.TextBox SearchTxtBox;
        private System.Windows.Forms.Label SearchIDLbl;
        private System.Windows.Forms.Button LastEnrollBut;
        private System.Windows.Forms.Button PreviousEnrollBut;
        private System.Windows.Forms.Button NextEnrollBut;
        private System.Windows.Forms.Button LoadFirstEnrollBut;
        private System.Windows.Forms.TextBox SIDTxtBox;
        private System.Windows.Forms.Label StudentIDLbl;
        private System.Windows.Forms.TextBox DayTxtBox;
        private System.Windows.Forms.TextBox SemesterTxtBox;
        private System.Windows.Forms.TextBox YearTxtBox;
        private System.Windows.Forms.TextBox PointTxtBox;
        private System.Windows.Forms.TextBox StatusTxtBox;
        private System.Windows.Forms.TextBox ClassIDTxtBox;
        private System.Windows.Forms.TextBox InstIDTxtBox;
        private System.Windows.Forms.Label DayLbl;
        private System.Windows.Forms.Label SemesterLbl;
        private System.Windows.Forms.Label YearLbl;
        private System.Windows.Forms.Label PointLbl;
        private System.Windows.Forms.Label StatusLbl;
        private System.Windows.Forms.Label ClassIDLbl;
        private System.Windows.Forms.Label InstIDLbl;
        private System.Windows.Forms.TextBox CourseIDTxtBox;
        private System.Windows.Forms.Label CourseIDLbl;
        private System.Windows.Forms.Label FTimeLbl;
        private System.Windows.Forms.Label BgTimeLbl;
        private System.Windows.Forms.Label EnrollFormLbl;
        private System.Windows.Forms.DateTimePicker CourseBeginTimePicker;
        private System.Windows.Forms.DateTimePicker CourseFinishTimePicker;
        private System.Windows.Forms.Label IDLbl;
        private System.Windows.Forms.TextBox IDTxtBox;
    }
}