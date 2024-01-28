namespace UniEdu.UIL
{
    partial class ClassForm
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
            this.ClassFormLbl = new System.Windows.Forms.Label();
            this.DeleteBut = new System.Windows.Forms.Button();
            this.AddBut = new System.Windows.Forms.Button();
            this.UpdateBut = new System.Windows.Forms.Button();
            this.SearchBut = new System.Windows.Forms.Button();
            this.SearchTxtBox = new System.Windows.Forms.TextBox();
            this.SearchIDLbl = new System.Windows.Forms.Label();
            this.LastClassBut = new System.Windows.Forms.Button();
            this.PreviousClassBut = new System.Windows.Forms.Button();
            this.NextClassBut = new System.Windows.Forms.Button();
            this.LoadFirstClassBut = new System.Windows.Forms.Button();
            this.RoomNumberTxtBox = new System.Windows.Forms.TextBox();
            this.RoomNumberLbl = new System.Windows.Forms.Label();
            this.DepartmentTxtBox = new System.Windows.Forms.TextBox();
            this.DepartmentLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // IDTxtBox
            // 
            this.IDTxtBox.Location = new System.Drawing.Point(160, 124);
            this.IDTxtBox.Name = "IDTxtBox";
            this.IDTxtBox.Size = new System.Drawing.Size(131, 22);
            this.IDTxtBox.TabIndex = 143;
            // 
            // IDLbl
            // 
            this.IDLbl.AutoSize = true;
            this.IDLbl.Location = new System.Drawing.Point(41, 127);
            this.IDLbl.Name = "IDLbl";
            this.IDLbl.Size = new System.Drawing.Size(21, 17);
            this.IDLbl.TabIndex = 142;
            this.IDLbl.Text = "ID";
            // 
            // ClassFormLbl
            // 
            this.ClassFormLbl.AutoSize = true;
            this.ClassFormLbl.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.ClassFormLbl.Location = new System.Drawing.Point(82, 58);
            this.ClassFormLbl.Name = "ClassFormLbl";
            this.ClassFormLbl.Size = new System.Drawing.Size(78, 17);
            this.ClassFormLbl.TabIndex = 141;
            this.ClassFormLbl.Text = "Class Form";
            // 
            // DeleteBut
            // 
            this.DeleteBut.Location = new System.Drawing.Point(623, 266);
            this.DeleteBut.Name = "DeleteBut";
            this.DeleteBut.Size = new System.Drawing.Size(82, 28);
            this.DeleteBut.TabIndex = 140;
            this.DeleteBut.Text = "Delete";
            this.DeleteBut.UseVisualStyleBackColor = true;
            this.DeleteBut.Click += new System.EventHandler(this.DeleteBut_Click);
            // 
            // AddBut
            // 
            this.AddBut.Location = new System.Drawing.Point(496, 266);
            this.AddBut.Name = "AddBut";
            this.AddBut.Size = new System.Drawing.Size(90, 28);
            this.AddBut.TabIndex = 139;
            this.AddBut.Text = "Add";
            this.AddBut.UseVisualStyleBackColor = true;
            this.AddBut.Click += new System.EventHandler(this.AddBut_Click);
            // 
            // UpdateBut
            // 
            this.UpdateBut.Location = new System.Drawing.Point(370, 266);
            this.UpdateBut.Name = "UpdateBut";
            this.UpdateBut.Size = new System.Drawing.Size(92, 28);
            this.UpdateBut.TabIndex = 138;
            this.UpdateBut.Text = "Update";
            this.UpdateBut.UseVisualStyleBackColor = true;
            this.UpdateBut.Click += new System.EventHandler(this.UpdateBut_Click);
            // 
            // SearchBut
            // 
            this.SearchBut.Location = new System.Drawing.Point(660, 207);
            this.SearchBut.Name = "SearchBut";
            this.SearchBut.Size = new System.Drawing.Size(75, 23);
            this.SearchBut.TabIndex = 137;
            this.SearchBut.Text = "Search";
            this.SearchBut.UseVisualStyleBackColor = true;
            this.SearchBut.Click += new System.EventHandler(this.SearchBut_Click);
            // 
            // SearchTxtBox
            // 
            this.SearchTxtBox.Location = new System.Drawing.Point(452, 205);
            this.SearchTxtBox.Name = "SearchTxtBox";
            this.SearchTxtBox.Size = new System.Drawing.Size(167, 22);
            this.SearchTxtBox.TabIndex = 136;
            // 
            // SearchIDLbl
            // 
            this.SearchIDLbl.AutoSize = true;
            this.SearchIDLbl.Location = new System.Drawing.Point(376, 205);
            this.SearchIDLbl.Name = "SearchIDLbl";
            this.SearchIDLbl.Size = new System.Drawing.Size(21, 17);
            this.SearchIDLbl.TabIndex = 135;
            this.SearchIDLbl.Text = "ID";
            // 
            // LastClassBut
            // 
            this.LastClassBut.Location = new System.Drawing.Point(682, 125);
            this.LastClassBut.Name = "LastClassBut";
            this.LastClassBut.Size = new System.Drawing.Size(88, 44);
            this.LastClassBut.TabIndex = 134;
            this.LastClassBut.Text = "Last";
            this.LastClassBut.UseVisualStyleBackColor = true;
            this.LastClassBut.Click += new System.EventHandler(this.LastClassBut_Click);
            // 
            // PreviousClassBut
            // 
            this.PreviousClassBut.Location = new System.Drawing.Point(473, 125);
            this.PreviousClassBut.Name = "PreviousClassBut";
            this.PreviousClassBut.Size = new System.Drawing.Size(83, 44);
            this.PreviousClassBut.TabIndex = 133;
            this.PreviousClassBut.Text = "Previous";
            this.PreviousClassBut.UseVisualStyleBackColor = true;
            this.PreviousClassBut.Click += new System.EventHandler(this.PreviousClassBut_Click);
            // 
            // NextClassBut
            // 
            this.NextClassBut.Location = new System.Drawing.Point(579, 125);
            this.NextClassBut.Name = "NextClassBut";
            this.NextClassBut.Size = new System.Drawing.Size(82, 44);
            this.NextClassBut.TabIndex = 132;
            this.NextClassBut.Text = "Next";
            this.NextClassBut.UseVisualStyleBackColor = true;
            this.NextClassBut.Click += new System.EventHandler(this.NextClassBut_Click);
            // 
            // LoadFirstClassBut
            // 
            this.LoadFirstClassBut.Location = new System.Drawing.Point(370, 125);
            this.LoadFirstClassBut.Name = "LoadFirstClassBut";
            this.LoadFirstClassBut.Size = new System.Drawing.Size(83, 44);
            this.LoadFirstClassBut.TabIndex = 131;
            this.LoadFirstClassBut.Text = "Load First Class";
            this.LoadFirstClassBut.UseVisualStyleBackColor = true;
            this.LoadFirstClassBut.Click += new System.EventHandler(this.LoadFirstClassBut_Click);
            // 
            // RoomNumberTxtBox
            // 
            this.RoomNumberTxtBox.Location = new System.Drawing.Point(160, 162);
            this.RoomNumberTxtBox.Name = "RoomNumberTxtBox";
            this.RoomNumberTxtBox.Size = new System.Drawing.Size(131, 22);
            this.RoomNumberTxtBox.TabIndex = 128;
            // 
            // RoomNumberLbl
            // 
            this.RoomNumberLbl.AutoSize = true;
            this.RoomNumberLbl.Location = new System.Drawing.Point(41, 167);
            this.RoomNumberLbl.Name = "RoomNumberLbl";
            this.RoomNumberLbl.Size = new System.Drawing.Size(99, 17);
            this.RoomNumberLbl.TabIndex = 125;
            this.RoomNumberLbl.Text = "Room Number";
            // 
            // DepartmentTxtBox
            // 
            this.DepartmentTxtBox.Location = new System.Drawing.Point(160, 202);
            this.DepartmentTxtBox.Name = "DepartmentTxtBox";
            this.DepartmentTxtBox.Size = new System.Drawing.Size(131, 22);
            this.DepartmentTxtBox.TabIndex = 124;
            // 
            // DepartmentLbl
            // 
            this.DepartmentLbl.AutoSize = true;
            this.DepartmentLbl.Location = new System.Drawing.Point(41, 207);
            this.DepartmentLbl.Name = "DepartmentLbl";
            this.DepartmentLbl.Size = new System.Drawing.Size(82, 17);
            this.DepartmentLbl.TabIndex = 123;
            this.DepartmentLbl.Text = "Department";
            // 
            // ClassForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.IDTxtBox);
            this.Controls.Add(this.IDLbl);
            this.Controls.Add(this.ClassFormLbl);
            this.Controls.Add(this.DeleteBut);
            this.Controls.Add(this.AddBut);
            this.Controls.Add(this.UpdateBut);
            this.Controls.Add(this.SearchBut);
            this.Controls.Add(this.SearchTxtBox);
            this.Controls.Add(this.SearchIDLbl);
            this.Controls.Add(this.LastClassBut);
            this.Controls.Add(this.PreviousClassBut);
            this.Controls.Add(this.NextClassBut);
            this.Controls.Add(this.LoadFirstClassBut);
            this.Controls.Add(this.RoomNumberTxtBox);
            this.Controls.Add(this.RoomNumberLbl);
            this.Controls.Add(this.DepartmentTxtBox);
            this.Controls.Add(this.DepartmentLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ClassForm";
            this.Text = "ClassForm";
            this.Load += new System.EventHandler(this.ClassForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox IDTxtBox;
        private System.Windows.Forms.Label IDLbl;
        private System.Windows.Forms.Label ClassFormLbl;
        private System.Windows.Forms.Button DeleteBut;
        private System.Windows.Forms.Button AddBut;
        private System.Windows.Forms.Button UpdateBut;
        private System.Windows.Forms.Button SearchBut;
        private System.Windows.Forms.TextBox SearchTxtBox;
        private System.Windows.Forms.Label SearchIDLbl;
        private System.Windows.Forms.Button LastClassBut;
        private System.Windows.Forms.Button PreviousClassBut;
        private System.Windows.Forms.Button NextClassBut;
        private System.Windows.Forms.Button LoadFirstClassBut;
        private System.Windows.Forms.TextBox RoomNumberTxtBox;
        private System.Windows.Forms.Label RoomNumberLbl;
        private System.Windows.Forms.TextBox DepartmentTxtBox;
        private System.Windows.Forms.Label DepartmentLbl;
    }
}