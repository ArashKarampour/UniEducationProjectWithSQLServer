namespace UniEdu.UIL
{
    partial class CourseForm
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
            this.CouDeleteBut = new System.Windows.Forms.Button();
            this.CouAddBut = new System.Windows.Forms.Button();
            this.CouUpdateBut = new System.Windows.Forms.Button();
            this.CouSearchBut = new System.Windows.Forms.Button();
            this.CouTitleSearchTxtBox = new System.Windows.Forms.TextBox();
            this.CouSearchLbl = new System.Windows.Forms.Label();
            this.LastCouBut = new System.Windows.Forms.Button();
            this.PreviousCouBut = new System.Windows.Forms.Button();
            this.NextCouBut = new System.Windows.Forms.Button();
            this.LoadFirstCouBut = new System.Windows.Forms.Button();
            this.CouIDTxtBox = new System.Windows.Forms.TextBox();
            this.CourseIDLbl = new System.Windows.Forms.Label();
            this.CouRequirementTxtBox = new System.Windows.Forms.TextBox();
            this.UnitNumTxtBox = new System.Windows.Forms.TextBox();
            this.GroupNumTxtBox = new System.Windows.Forms.TextBox();
            this.ReqLbl = new System.Windows.Forms.Label();
            this.UnitNumLbl = new System.Windows.Forms.Label();
            this.GroupNumLbl = new System.Windows.Forms.Label();
            this.CouTitleTxtBox = new System.Windows.Forms.TextBox();
            this.CourseTitleLbl = new System.Windows.Forms.Label();
            this.CourseLbl = new System.Windows.Forms.Label();
            this.CouGNSearchTxtBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CouDeleteBut
            // 
            this.CouDeleteBut.Location = new System.Drawing.Point(622, 299);
            this.CouDeleteBut.Name = "CouDeleteBut";
            this.CouDeleteBut.Size = new System.Drawing.Size(96, 28);
            this.CouDeleteBut.TabIndex = 83;
            this.CouDeleteBut.Text = "Delete";
            this.CouDeleteBut.UseVisualStyleBackColor = true;
            this.CouDeleteBut.Click += new System.EventHandler(this.CouDeleteBut_Click);
            // 
            // CouAddBut
            // 
            this.CouAddBut.Location = new System.Drawing.Point(485, 299);
            this.CouAddBut.Name = "CouAddBut";
            this.CouAddBut.Size = new System.Drawing.Size(90, 28);
            this.CouAddBut.TabIndex = 82;
            this.CouAddBut.Text = "Add";
            this.CouAddBut.UseVisualStyleBackColor = true;
            this.CouAddBut.Click += new System.EventHandler(this.CouAddBut_Click);
            // 
            // CouUpdateBut
            // 
            this.CouUpdateBut.Location = new System.Drawing.Point(346, 299);
            this.CouUpdateBut.Name = "CouUpdateBut";
            this.CouUpdateBut.Size = new System.Drawing.Size(92, 28);
            this.CouUpdateBut.TabIndex = 81;
            this.CouUpdateBut.Text = "Update";
            this.CouUpdateBut.UseVisualStyleBackColor = true;
            this.CouUpdateBut.Click += new System.EventHandler(this.CouUpdateBut_Click);
            // 
            // CouSearchBut
            // 
            this.CouSearchBut.Location = new System.Drawing.Point(464, 233);
            this.CouSearchBut.Name = "CouSearchBut";
            this.CouSearchBut.Size = new System.Drawing.Size(75, 23);
            this.CouSearchBut.TabIndex = 80;
            this.CouSearchBut.Text = "Search";
            this.CouSearchBut.UseVisualStyleBackColor = true;
            this.CouSearchBut.Click += new System.EventHandler(this.CouSearchBut_Click);
            // 
            // CouTitleSearchTxtBox
            // 
            this.CouTitleSearchTxtBox.Location = new System.Drawing.Point(464, 168);
            this.CouTitleSearchTxtBox.Name = "CouTitleSearchTxtBox";
            this.CouTitleSearchTxtBox.Size = new System.Drawing.Size(167, 22);
            this.CouTitleSearchTxtBox.TabIndex = 79;
            // 
            // CouSearchLbl
            // 
            this.CouSearchLbl.AutoSize = true;
            this.CouSearchLbl.Location = new System.Drawing.Point(343, 168);
            this.CouSearchLbl.Name = "CouSearchLbl";
            this.CouSearchLbl.Size = new System.Drawing.Size(84, 17);
            this.CouSearchLbl.TabIndex = 78;
            this.CouSearchLbl.Text = "Course Title";
            // 
            // LastCouBut
            // 
            this.LastCouBut.Location = new System.Drawing.Point(667, 88);
            this.LastCouBut.Name = "LastCouBut";
            this.LastCouBut.Size = new System.Drawing.Size(88, 44);
            this.LastCouBut.TabIndex = 77;
            this.LastCouBut.Text = "Last";
            this.LastCouBut.UseVisualStyleBackColor = true;
            this.LastCouBut.Click += new System.EventHandler(this.LastCouBut_Click);
            // 
            // PreviousCouBut
            // 
            this.PreviousCouBut.Location = new System.Drawing.Point(458, 88);
            this.PreviousCouBut.Name = "PreviousCouBut";
            this.PreviousCouBut.Size = new System.Drawing.Size(83, 44);
            this.PreviousCouBut.TabIndex = 76;
            this.PreviousCouBut.Text = "Previous";
            this.PreviousCouBut.UseVisualStyleBackColor = true;
            this.PreviousCouBut.Click += new System.EventHandler(this.PreviousCouBut_Click);
            // 
            // NextCouBut
            // 
            this.NextCouBut.Location = new System.Drawing.Point(564, 88);
            this.NextCouBut.Name = "NextCouBut";
            this.NextCouBut.Size = new System.Drawing.Size(82, 44);
            this.NextCouBut.TabIndex = 75;
            this.NextCouBut.Text = "Next";
            this.NextCouBut.UseVisualStyleBackColor = true;
            this.NextCouBut.Click += new System.EventHandler(this.NextCouBut_Click);
            // 
            // LoadFirstCouBut
            // 
            this.LoadFirstCouBut.Location = new System.Drawing.Point(355, 88);
            this.LoadFirstCouBut.Name = "LoadFirstCouBut";
            this.LoadFirstCouBut.Size = new System.Drawing.Size(83, 44);
            this.LoadFirstCouBut.TabIndex = 74;
            this.LoadFirstCouBut.Text = "Load First Course";
            this.LoadFirstCouBut.UseVisualStyleBackColor = true;
            this.LoadFirstCouBut.Click += new System.EventHandler(this.LoadFirstCouBut_Click);
            // 
            // CouIDTxtBox
            // 
            this.CouIDTxtBox.Location = new System.Drawing.Point(146, 112);
            this.CouIDTxtBox.Name = "CouIDTxtBox";
            this.CouIDTxtBox.Size = new System.Drawing.Size(131, 22);
            this.CouIDTxtBox.TabIndex = 73;
            // 
            // CourseIDLbl
            // 
            this.CourseIDLbl.AutoSize = true;
            this.CourseIDLbl.Location = new System.Drawing.Point(27, 112);
            this.CourseIDLbl.Name = "CourseIDLbl";
            this.CourseIDLbl.Size = new System.Drawing.Size(21, 17);
            this.CourseIDLbl.TabIndex = 72;
            this.CourseIDLbl.Text = "ID";
            // 
            // CouRequirementTxtBox
            // 
            this.CouRequirementTxtBox.Location = new System.Drawing.Point(146, 270);
            this.CouRequirementTxtBox.Name = "CouRequirementTxtBox";
            this.CouRequirementTxtBox.Size = new System.Drawing.Size(131, 22);
            this.CouRequirementTxtBox.TabIndex = 68;
            // 
            // UnitNumTxtBox
            // 
            this.UnitNumTxtBox.Location = new System.Drawing.Point(146, 231);
            this.UnitNumTxtBox.Name = "UnitNumTxtBox";
            this.UnitNumTxtBox.Size = new System.Drawing.Size(131, 22);
            this.UnitNumTxtBox.TabIndex = 67;
            // 
            // GroupNumTxtBox
            // 
            this.GroupNumTxtBox.Location = new System.Drawing.Point(146, 192);
            this.GroupNumTxtBox.Name = "GroupNumTxtBox";
            this.GroupNumTxtBox.Size = new System.Drawing.Size(131, 22);
            this.GroupNumTxtBox.TabIndex = 66;
            // 
            // ReqLbl
            // 
            this.ReqLbl.AutoSize = true;
            this.ReqLbl.Location = new System.Drawing.Point(27, 273);
            this.ReqLbl.Name = "ReqLbl";
            this.ReqLbl.Size = new System.Drawing.Size(89, 17);
            this.ReqLbl.TabIndex = 62;
            this.ReqLbl.Text = "Requirement";
            // 
            // UnitNumLbl
            // 
            this.UnitNumLbl.AutoSize = true;
            this.UnitNumLbl.Location = new System.Drawing.Point(27, 231);
            this.UnitNumLbl.Name = "UnitNumLbl";
            this.UnitNumLbl.Size = new System.Drawing.Size(87, 17);
            this.UnitNumLbl.TabIndex = 61;
            this.UnitNumLbl.Text = "Unit Number";
            // 
            // GroupNumLbl
            // 
            this.GroupNumLbl.AutoSize = true;
            this.GroupNumLbl.Location = new System.Drawing.Point(27, 192);
            this.GroupNumLbl.Name = "GroupNumLbl";
            this.GroupNumLbl.Size = new System.Drawing.Size(102, 17);
            this.GroupNumLbl.TabIndex = 60;
            this.GroupNumLbl.Text = "Group Number";
            // 
            // CouTitleTxtBox
            // 
            this.CouTitleTxtBox.Location = new System.Drawing.Point(146, 151);
            this.CouTitleTxtBox.Name = "CouTitleTxtBox";
            this.CouTitleTxtBox.Size = new System.Drawing.Size(131, 22);
            this.CouTitleTxtBox.TabIndex = 59;
            // 
            // CourseTitleLbl
            // 
            this.CourseTitleLbl.AutoSize = true;
            this.CourseTitleLbl.Location = new System.Drawing.Point(27, 151);
            this.CourseTitleLbl.Name = "CourseTitleLbl";
            this.CourseTitleLbl.Size = new System.Drawing.Size(84, 17);
            this.CourseTitleLbl.TabIndex = 58;
            this.CourseTitleLbl.Text = "Course Title";
            // 
            // CourseLbl
            // 
            this.CourseLbl.AutoSize = true;
            this.CourseLbl.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.CourseLbl.Location = new System.Drawing.Point(27, 52);
            this.CourseLbl.Name = "CourseLbl";
            this.CourseLbl.Size = new System.Drawing.Size(93, 17);
            this.CourseLbl.TabIndex = 84;
            this.CourseLbl.Text = "Course Form:";
            // 
            // CouGNSearchTxtBox
            // 
            this.CouGNSearchTxtBox.Location = new System.Drawing.Point(464, 196);
            this.CouGNSearchTxtBox.Name = "CouGNSearchTxtBox";
            this.CouGNSearchTxtBox.Size = new System.Drawing.Size(135, 22);
            this.CouGNSearchTxtBox.TabIndex = 85;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(343, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 17);
            this.label1.TabIndex = 86;
            this.label1.Text = "Group Number";
            // 
            // CourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CouGNSearchTxtBox);
            this.Controls.Add(this.CourseLbl);
            this.Controls.Add(this.CouDeleteBut);
            this.Controls.Add(this.CouAddBut);
            this.Controls.Add(this.CouUpdateBut);
            this.Controls.Add(this.CouSearchBut);
            this.Controls.Add(this.CouTitleSearchTxtBox);
            this.Controls.Add(this.CouSearchLbl);
            this.Controls.Add(this.LastCouBut);
            this.Controls.Add(this.PreviousCouBut);
            this.Controls.Add(this.NextCouBut);
            this.Controls.Add(this.LoadFirstCouBut);
            this.Controls.Add(this.CouIDTxtBox);
            this.Controls.Add(this.CourseIDLbl);
            this.Controls.Add(this.CouRequirementTxtBox);
            this.Controls.Add(this.UnitNumTxtBox);
            this.Controls.Add(this.GroupNumTxtBox);
            this.Controls.Add(this.ReqLbl);
            this.Controls.Add(this.UnitNumLbl);
            this.Controls.Add(this.GroupNumLbl);
            this.Controls.Add(this.CouTitleTxtBox);
            this.Controls.Add(this.CourseTitleLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CourseForm";
            this.Text = "CourseForm";
            this.Load += new System.EventHandler(this.CourseForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button CouDeleteBut;
        private System.Windows.Forms.Button CouAddBut;
        private System.Windows.Forms.Button CouUpdateBut;
        private System.Windows.Forms.Button CouSearchBut;
        private System.Windows.Forms.TextBox CouTitleSearchTxtBox;
        private System.Windows.Forms.Label CouSearchLbl;
        private System.Windows.Forms.Button LastCouBut;
        private System.Windows.Forms.Button PreviousCouBut;
        private System.Windows.Forms.Button NextCouBut;
        private System.Windows.Forms.Button LoadFirstCouBut;
        private System.Windows.Forms.TextBox CouIDTxtBox;
        private System.Windows.Forms.Label CourseIDLbl;
        private System.Windows.Forms.TextBox CouRequirementTxtBox;
        private System.Windows.Forms.TextBox UnitNumTxtBox;
        private System.Windows.Forms.TextBox GroupNumTxtBox;
        private System.Windows.Forms.Label ReqLbl;
        private System.Windows.Forms.Label UnitNumLbl;
        private System.Windows.Forms.Label GroupNumLbl;
        private System.Windows.Forms.TextBox CouTitleTxtBox;
        private System.Windows.Forms.Label CourseTitleLbl;
        private System.Windows.Forms.Label CourseLbl;
        private System.Windows.Forms.TextBox CouGNSearchTxtBox;
        private System.Windows.Forms.Label label1;
    }
}