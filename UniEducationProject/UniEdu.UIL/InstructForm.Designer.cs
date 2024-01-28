namespace UniEdu.UIL
{
    partial class InstructForm
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
            this.InstructFormLbl = new System.Windows.Forms.Label();
            this.DeleteBut = new System.Windows.Forms.Button();
            this.AddBut = new System.Windows.Forms.Button();
            this.UpdateBut = new System.Windows.Forms.Button();
            this.SearchBut = new System.Windows.Forms.Button();
            this.SearchTxtBox = new System.Windows.Forms.TextBox();
            this.SearchIDLbl = new System.Windows.Forms.Label();
            this.LastInstructBut = new System.Windows.Forms.Button();
            this.PreviousInstructBut = new System.Windows.Forms.Button();
            this.NextInstructBut = new System.Windows.Forms.Button();
            this.LoadFirstInstructBut = new System.Windows.Forms.Button();
            this.SemesterTxtBox = new System.Windows.Forms.TextBox();
            this.YearTxtBox = new System.Windows.Forms.TextBox();
            this.InstIDTxtBox = new System.Windows.Forms.TextBox();
            this.SemesterLbl = new System.Windows.Forms.Label();
            this.YearLbl = new System.Windows.Forms.Label();
            this.InstIDLbl = new System.Windows.Forms.Label();
            this.CourseIDTxtBox = new System.Windows.Forms.TextBox();
            this.CourseIDLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // IDTxtBox
            // 
            this.IDTxtBox.Location = new System.Drawing.Point(154, 91);
            this.IDTxtBox.Name = "IDTxtBox";
            this.IDTxtBox.Size = new System.Drawing.Size(131, 22);
            this.IDTxtBox.TabIndex = 122;
            // 
            // IDLbl
            // 
            this.IDLbl.AutoSize = true;
            this.IDLbl.Location = new System.Drawing.Point(35, 94);
            this.IDLbl.Name = "IDLbl";
            this.IDLbl.Size = new System.Drawing.Size(21, 17);
            this.IDLbl.TabIndex = 121;
            this.IDLbl.Text = "ID";
            // 
            // InstructFormLbl
            // 
            this.InstructFormLbl.AutoSize = true;
            this.InstructFormLbl.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.InstructFormLbl.Location = new System.Drawing.Point(86, 41);
            this.InstructFormLbl.Name = "InstructFormLbl";
            this.InstructFormLbl.Size = new System.Drawing.Size(90, 17);
            this.InstructFormLbl.TabIndex = 120;
            this.InstructFormLbl.Text = "Instruct Form";
            // 
            // DeleteBut
            // 
            this.DeleteBut.Location = new System.Drawing.Point(627, 249);
            this.DeleteBut.Name = "DeleteBut";
            this.DeleteBut.Size = new System.Drawing.Size(82, 28);
            this.DeleteBut.TabIndex = 119;
            this.DeleteBut.Text = "Delete";
            this.DeleteBut.UseVisualStyleBackColor = true;
            this.DeleteBut.Click += new System.EventHandler(this.DeleteBut_Click);
            // 
            // AddBut
            // 
            this.AddBut.Location = new System.Drawing.Point(500, 249);
            this.AddBut.Name = "AddBut";
            this.AddBut.Size = new System.Drawing.Size(90, 28);
            this.AddBut.TabIndex = 118;
            this.AddBut.Text = "Add";
            this.AddBut.UseVisualStyleBackColor = true;
            this.AddBut.Click += new System.EventHandler(this.AddBut_Click);
            // 
            // UpdateBut
            // 
            this.UpdateBut.Location = new System.Drawing.Point(374, 249);
            this.UpdateBut.Name = "UpdateBut";
            this.UpdateBut.Size = new System.Drawing.Size(92, 28);
            this.UpdateBut.TabIndex = 117;
            this.UpdateBut.Text = "Update";
            this.UpdateBut.UseVisualStyleBackColor = true;
            this.UpdateBut.Click += new System.EventHandler(this.UpdateBut_Click);
            // 
            // SearchBut
            // 
            this.SearchBut.Location = new System.Drawing.Point(664, 190);
            this.SearchBut.Name = "SearchBut";
            this.SearchBut.Size = new System.Drawing.Size(75, 23);
            this.SearchBut.TabIndex = 116;
            this.SearchBut.Text = "Search";
            this.SearchBut.UseVisualStyleBackColor = true;
            this.SearchBut.Click += new System.EventHandler(this.SearchBut_Click);
            // 
            // SearchTxtBox
            // 
            this.SearchTxtBox.Location = new System.Drawing.Point(456, 188);
            this.SearchTxtBox.Name = "SearchTxtBox";
            this.SearchTxtBox.Size = new System.Drawing.Size(167, 22);
            this.SearchTxtBox.TabIndex = 115;
            // 
            // SearchIDLbl
            // 
            this.SearchIDLbl.AutoSize = true;
            this.SearchIDLbl.Location = new System.Drawing.Point(380, 188);
            this.SearchIDLbl.Name = "SearchIDLbl";
            this.SearchIDLbl.Size = new System.Drawing.Size(21, 17);
            this.SearchIDLbl.TabIndex = 114;
            this.SearchIDLbl.Text = "ID";
            // 
            // LastInstructBut
            // 
            this.LastInstructBut.Location = new System.Drawing.Point(686, 108);
            this.LastInstructBut.Name = "LastInstructBut";
            this.LastInstructBut.Size = new System.Drawing.Size(88, 44);
            this.LastInstructBut.TabIndex = 113;
            this.LastInstructBut.Text = "Last";
            this.LastInstructBut.UseVisualStyleBackColor = true;
            this.LastInstructBut.Click += new System.EventHandler(this.LastInstructBut_Click);
            // 
            // PreviousInstructBut
            // 
            this.PreviousInstructBut.Location = new System.Drawing.Point(477, 108);
            this.PreviousInstructBut.Name = "PreviousInstructBut";
            this.PreviousInstructBut.Size = new System.Drawing.Size(83, 44);
            this.PreviousInstructBut.TabIndex = 112;
            this.PreviousInstructBut.Text = "Previous";
            this.PreviousInstructBut.UseVisualStyleBackColor = true;
            this.PreviousInstructBut.Click += new System.EventHandler(this.PreviousInstructBut_Click);
            // 
            // NextInstructBut
            // 
            this.NextInstructBut.Location = new System.Drawing.Point(583, 108);
            this.NextInstructBut.Name = "NextInstructBut";
            this.NextInstructBut.Size = new System.Drawing.Size(82, 44);
            this.NextInstructBut.TabIndex = 111;
            this.NextInstructBut.Text = "Next";
            this.NextInstructBut.UseVisualStyleBackColor = true;
            this.NextInstructBut.Click += new System.EventHandler(this.NextInstructBut_Click);
            // 
            // LoadFirstInstructBut
            // 
            this.LoadFirstInstructBut.Location = new System.Drawing.Point(374, 108);
            this.LoadFirstInstructBut.Name = "LoadFirstInstructBut";
            this.LoadFirstInstructBut.Size = new System.Drawing.Size(83, 44);
            this.LoadFirstInstructBut.TabIndex = 110;
            this.LoadFirstInstructBut.Text = "Load First Instruct";
            this.LoadFirstInstructBut.UseVisualStyleBackColor = true;
            this.LoadFirstInstructBut.Click += new System.EventHandler(this.LoadFirstInstructBut_Click);
            // 
            // SemesterTxtBox
            // 
            this.SemesterTxtBox.Location = new System.Drawing.Point(154, 255);
            this.SemesterTxtBox.Name = "SemesterTxtBox";
            this.SemesterTxtBox.Size = new System.Drawing.Size(131, 22);
            this.SemesterTxtBox.TabIndex = 109;
            // 
            // YearTxtBox
            // 
            this.YearTxtBox.Location = new System.Drawing.Point(154, 213);
            this.YearTxtBox.Name = "YearTxtBox";
            this.YearTxtBox.Size = new System.Drawing.Size(131, 22);
            this.YearTxtBox.TabIndex = 108;
            // 
            // InstIDTxtBox
            // 
            this.InstIDTxtBox.Location = new System.Drawing.Point(154, 129);
            this.InstIDTxtBox.Name = "InstIDTxtBox";
            this.InstIDTxtBox.Size = new System.Drawing.Size(131, 22);
            this.InstIDTxtBox.TabIndex = 106;
            // 
            // SemesterLbl
            // 
            this.SemesterLbl.AutoSize = true;
            this.SemesterLbl.Location = new System.Drawing.Point(35, 255);
            this.SemesterLbl.Name = "SemesterLbl";
            this.SemesterLbl.Size = new System.Drawing.Size(68, 17);
            this.SemesterLbl.TabIndex = 105;
            this.SemesterLbl.Text = "Semester";
            // 
            // YearLbl
            // 
            this.YearLbl.AutoSize = true;
            this.YearLbl.Location = new System.Drawing.Point(35, 216);
            this.YearLbl.Name = "YearLbl";
            this.YearLbl.Size = new System.Drawing.Size(38, 17);
            this.YearLbl.TabIndex = 104;
            this.YearLbl.Text = "Year";
            // 
            // InstIDLbl
            // 
            this.InstIDLbl.AutoSize = true;
            this.InstIDLbl.Location = new System.Drawing.Point(35, 134);
            this.InstIDLbl.Name = "InstIDLbl";
            this.InstIDLbl.Size = new System.Drawing.Size(84, 17);
            this.InstIDLbl.TabIndex = 102;
            this.InstIDLbl.Text = "Instructor ID";
            // 
            // CourseIDTxtBox
            // 
            this.CourseIDTxtBox.Location = new System.Drawing.Point(154, 169);
            this.CourseIDTxtBox.Name = "CourseIDTxtBox";
            this.CourseIDTxtBox.Size = new System.Drawing.Size(131, 22);
            this.CourseIDTxtBox.TabIndex = 101;
            // 
            // CourseIDLbl
            // 
            this.CourseIDLbl.AutoSize = true;
            this.CourseIDLbl.Location = new System.Drawing.Point(35, 174);
            this.CourseIDLbl.Name = "CourseIDLbl";
            this.CourseIDLbl.Size = new System.Drawing.Size(70, 17);
            this.CourseIDLbl.TabIndex = 100;
            this.CourseIDLbl.Text = "Course ID";
            // 
            // InstructForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.IDTxtBox);
            this.Controls.Add(this.IDLbl);
            this.Controls.Add(this.InstructFormLbl);
            this.Controls.Add(this.DeleteBut);
            this.Controls.Add(this.AddBut);
            this.Controls.Add(this.UpdateBut);
            this.Controls.Add(this.SearchBut);
            this.Controls.Add(this.SearchTxtBox);
            this.Controls.Add(this.SearchIDLbl);
            this.Controls.Add(this.LastInstructBut);
            this.Controls.Add(this.PreviousInstructBut);
            this.Controls.Add(this.NextInstructBut);
            this.Controls.Add(this.LoadFirstInstructBut);
            this.Controls.Add(this.SemesterTxtBox);
            this.Controls.Add(this.YearTxtBox);
            this.Controls.Add(this.InstIDTxtBox);
            this.Controls.Add(this.SemesterLbl);
            this.Controls.Add(this.YearLbl);
            this.Controls.Add(this.InstIDLbl);
            this.Controls.Add(this.CourseIDTxtBox);
            this.Controls.Add(this.CourseIDLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InstructForm";
            this.Text = "InstructForm";
            this.Load += new System.EventHandler(this.InstructForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox IDTxtBox;
        private System.Windows.Forms.Label IDLbl;
        private System.Windows.Forms.Label InstructFormLbl;
        private System.Windows.Forms.Button DeleteBut;
        private System.Windows.Forms.Button AddBut;
        private System.Windows.Forms.Button UpdateBut;
        private System.Windows.Forms.Button SearchBut;
        private System.Windows.Forms.TextBox SearchTxtBox;
        private System.Windows.Forms.Label SearchIDLbl;
        private System.Windows.Forms.Button LastInstructBut;
        private System.Windows.Forms.Button PreviousInstructBut;
        private System.Windows.Forms.Button NextInstructBut;
        private System.Windows.Forms.Button LoadFirstInstructBut;
        private System.Windows.Forms.TextBox SemesterTxtBox;
        private System.Windows.Forms.TextBox YearTxtBox;
        private System.Windows.Forms.TextBox InstIDTxtBox;
        private System.Windows.Forms.Label SemesterLbl;
        private System.Windows.Forms.Label YearLbl;
        private System.Windows.Forms.Label InstIDLbl;
        private System.Windows.Forms.TextBox CourseIDTxtBox;
        private System.Windows.Forms.Label CourseIDLbl;
    }
}