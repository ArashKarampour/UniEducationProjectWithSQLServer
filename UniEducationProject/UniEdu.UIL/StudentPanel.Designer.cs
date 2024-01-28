namespace UniEdu.UIL
{
    partial class StudentPanel
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
            this.StudentPanelLbl = new System.Windows.Forms.Label();
            this.YearcomboBox = new System.Windows.Forms.ComboBox();
            this.SemcomboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.StShowCourseBut = new System.Windows.Forms.Button();
            this.CoursedataGridView = new System.Windows.Forms.DataGridView();
            this.ShowClassMate = new System.Windows.Forms.Button();
            this.StChangePassBut = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CoursedataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // StudentPanelLbl
            // 
            this.StudentPanelLbl.AutoSize = true;
            this.StudentPanelLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentPanelLbl.Location = new System.Drawing.Point(22, 36);
            this.StudentPanelLbl.Name = "StudentPanelLbl";
            this.StudentPanelLbl.Size = new System.Drawing.Size(59, 20);
            this.StudentPanelLbl.TabIndex = 0;
            this.StudentPanelLbl.Text = "Hello ";
            // 
            // YearcomboBox
            // 
            this.YearcomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.YearcomboBox.FormattingEnabled = true;
            this.YearcomboBox.Location = new System.Drawing.Point(101, 152);
            this.YearcomboBox.Name = "YearcomboBox";
            this.YearcomboBox.Size = new System.Drawing.Size(86, 24);
            this.YearcomboBox.TabIndex = 1;
            // 
            // SemcomboBox
            // 
            this.SemcomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SemcomboBox.FormattingEnabled = true;
            this.SemcomboBox.Items.AddRange(new object[] {
            "first",
            "second"});
            this.SemcomboBox.Location = new System.Drawing.Point(101, 216);
            this.SemcomboBox.Name = "SemcomboBox";
            this.SemcomboBox.Size = new System.Drawing.Size(86, 24);
            this.SemcomboBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Year:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Semester:";
            // 
            // StShowCourseBut
            // 
            this.StShowCourseBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StShowCourseBut.Location = new System.Drawing.Point(101, 318);
            this.StShowCourseBut.Name = "StShowCourseBut";
            this.StShowCourseBut.Size = new System.Drawing.Size(129, 61);
            this.StShowCourseBut.TabIndex = 5;
            this.StShowCourseBut.Text = "Show Courses";
            this.StShowCourseBut.UseVisualStyleBackColor = true;
            this.StShowCourseBut.Click += new System.EventHandler(this.StShowCourseBut_Click);
            // 
            // CoursedataGridView
            // 
            this.CoursedataGridView.AllowUserToAddRows = false;
            this.CoursedataGridView.AllowUserToDeleteRows = false;
            this.CoursedataGridView.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.CoursedataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CoursedataGridView.Location = new System.Drawing.Point(258, 36);
            this.CoursedataGridView.Name = "CoursedataGridView";
            this.CoursedataGridView.ReadOnly = true;
            this.CoursedataGridView.RowTemplate.Height = 24;
            this.CoursedataGridView.Size = new System.Drawing.Size(751, 523);
            this.CoursedataGridView.TabIndex = 6;
            // 
            // ShowClassMate
            // 
            this.ShowClassMate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowClassMate.Location = new System.Drawing.Point(101, 399);
            this.ShowClassMate.Name = "ShowClassMate";
            this.ShowClassMate.Size = new System.Drawing.Size(129, 61);
            this.ShowClassMate.TabIndex = 5;
            this.ShowClassMate.Text = "Show Class Members";
            this.ShowClassMate.UseVisualStyleBackColor = true;
            this.ShowClassMate.Click += new System.EventHandler(this.ShowClassMateBut_Click);
            // 
            // StChangePassBut
            // 
            this.StChangePassBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StChangePassBut.Location = new System.Drawing.Point(101, 483);
            this.StChangePassBut.Name = "StChangePassBut";
            this.StChangePassBut.Size = new System.Drawing.Size(129, 60);
            this.StChangePassBut.TabIndex = 5;
            this.StChangePassBut.Text = "Change Password";
            this.StChangePassBut.UseVisualStyleBackColor = true;
            this.StChangePassBut.Click += new System.EventHandler(this.StChangePassBut_Click);
            // 
            // StudentPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1021, 583);
            this.Controls.Add(this.CoursedataGridView);
            this.Controls.Add(this.StChangePassBut);
            this.Controls.Add(this.ShowClassMate);
            this.Controls.Add(this.StShowCourseBut);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SemcomboBox);
            this.Controls.Add(this.YearcomboBox);
            this.Controls.Add(this.StudentPanelLbl);
            this.Name = "StudentPanel";
            this.Text = "StudentPanel";
            this.Load += new System.EventHandler(this.StudentPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CoursedataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label StudentPanelLbl;
        private System.Windows.Forms.ComboBox YearcomboBox;
        private System.Windows.Forms.ComboBox SemcomboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button StShowCourseBut;
        private System.Windows.Forms.DataGridView CoursedataGridView;
        private System.Windows.Forms.Button ShowClassMate;
        private System.Windows.Forms.Button StChangePassBut;
    }
}