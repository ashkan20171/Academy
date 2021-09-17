namespace Academy
{
    partial class frmSearchUser
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
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.grbInformation = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.chbUpdateSelected = new System.Windows.Forms.CheckBox();
            this.chbDeleteUser = new System.Windows.Forms.CheckBox();
            this.chbDeleteSelected = new System.Windows.Forms.CheckBox();
            this.chbUpdateLesson = new System.Windows.Forms.CheckBox();
            this.chbAddUser = new System.Windows.Forms.CheckBox();
            this.chbAddSelected = new System.Windows.Forms.CheckBox();
            this.chbDeleteLesson = new System.Windows.Forms.CheckBox();
            this.chbAddLesson = new System.Windows.Forms.CheckBox();
            this.chbUpdateTeacher = new System.Windows.Forms.CheckBox();
            this.chbDeleteTeacher = new System.Windows.Forms.CheckBox();
            this.chbAddTeacher = new System.Windows.Forms.CheckBox();
            this.chbUpdateStudent = new System.Windows.Forms.CheckBox();
            this.chbDeleteStudent = new System.Windows.Forms.CheckBox();
            this.ChbAddStudent = new System.Windows.Forms.CheckBox();
            this.chbShow = new System.Windows.Forms.CheckBox();
            this.chbDeleteGroup = new System.Windows.Forms.CheckBox();
            this.chbAddGroup = new System.Windows.Forms.CheckBox();
            this.grbInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(375, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "نام کاربری :";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(186, 6);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(183, 23);
            this.txtUserName.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(12, 6);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(84, 28);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "جستجو";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // grbInformation
            // 
            this.grbInformation.Controls.Add(this.chbAddUser);
            this.grbInformation.Controls.Add(this.chbDeleteUser);
            this.grbInformation.Controls.Add(this.chbAddSelected);
            this.grbInformation.Controls.Add(this.chbUpdateSelected);
            this.grbInformation.Controls.Add(this.chbAddLesson);
            this.grbInformation.Controls.Add(this.chbDeleteSelected);
            this.grbInformation.Controls.Add(this.chbAddTeacher);
            this.grbInformation.Controls.Add(this.lblName);
            this.grbInformation.Controls.Add(this.ChbAddStudent);
            this.grbInformation.Controls.Add(this.label2);
            this.grbInformation.Controls.Add(this.chbAddGroup);
            this.grbInformation.Controls.Add(this.chbUpdateLesson);
            this.grbInformation.Controls.Add(this.chbDeleteLesson);
            this.grbInformation.Controls.Add(this.chbShow);
            this.grbInformation.Controls.Add(this.chbUpdateStudent);
            this.grbInformation.Controls.Add(this.chbDeleteTeacher);
            this.grbInformation.Controls.Add(this.chbUpdateTeacher);
            this.grbInformation.Controls.Add(this.chbDeleteStudent);
            this.grbInformation.Controls.Add(this.chbDeleteGroup);
            this.grbInformation.Enabled = false;
            this.grbInformation.Location = new System.Drawing.Point(12, 63);
            this.grbInformation.Name = "grbInformation";
            this.grbInformation.Size = new System.Drawing.Size(439, 232);
            this.grbInformation.TabIndex = 3;
            this.grbInformation.TabStop = false;
            this.grbInformation.Text = "اطلاعات کاربر";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(397, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "نام :";
            // 
            // lblName
            // 
            this.lblName.Location = new System.Drawing.Point(21, 26);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(371, 27);
            this.lblName.TabIndex = 0;
            // 
            // chbUpdateSelected
            // 
            this.chbUpdateSelected.AutoSize = true;
            this.chbUpdateSelected.Location = new System.Drawing.Point(6, 169);
            this.chbUpdateSelected.Name = "chbUpdateSelected";
            this.chbUpdateSelected.Size = new System.Drawing.Size(149, 20);
            this.chbUpdateSelected.TabIndex = 42;
            this.chbUpdateSelected.Text = "ویرایش درس اخذ شده";
            this.chbUpdateSelected.UseVisualStyleBackColor = true;
            // 
            // chbDeleteUser
            // 
            this.chbDeleteUser.AutoSize = true;
            this.chbDeleteUser.Location = new System.Drawing.Point(220, 195);
            this.chbDeleteUser.Name = "chbDeleteUser";
            this.chbDeleteUser.Size = new System.Drawing.Size(82, 20);
            this.chbDeleteUser.TabIndex = 44;
            this.chbDeleteUser.Text = "حذف کاربر";
            this.chbDeleteUser.UseVisualStyleBackColor = true;
            // 
            // chbDeleteSelected
            // 
            this.chbDeleteSelected.AutoSize = true;
            this.chbDeleteSelected.Location = new System.Drawing.Point(164, 169);
            this.chbDeleteSelected.Name = "chbDeleteSelected";
            this.chbDeleteSelected.Size = new System.Drawing.Size(138, 20);
            this.chbDeleteSelected.TabIndex = 41;
            this.chbDeleteSelected.Text = "حذف درس اخذ شده";
            this.chbDeleteSelected.UseVisualStyleBackColor = true;
            // 
            // chbUpdateLesson
            // 
            this.chbUpdateLesson.AutoSize = true;
            this.chbUpdateLesson.Location = new System.Drawing.Point(59, 143);
            this.chbUpdateLesson.Name = "chbUpdateLesson";
            this.chbUpdateLesson.Size = new System.Drawing.Size(96, 20);
            this.chbUpdateLesson.TabIndex = 39;
            this.chbUpdateLesson.Text = "ویرایش درس";
            this.chbUpdateLesson.UseVisualStyleBackColor = true;
            // 
            // chbAddUser
            // 
            this.chbAddUser.AutoSize = true;
            this.chbAddUser.Location = new System.Drawing.Point(346, 195);
            this.chbAddUser.Name = "chbAddUser";
            this.chbAddUser.Size = new System.Drawing.Size(81, 20);
            this.chbAddUser.TabIndex = 43;
            this.chbAddUser.Text = "ایجاد کاربر";
            this.chbAddUser.UseVisualStyleBackColor = true;
            // 
            // chbAddSelected
            // 
            this.chbAddSelected.AutoSize = true;
            this.chbAddSelected.Location = new System.Drawing.Point(350, 169);
            this.chbAddSelected.Name = "chbAddSelected";
            this.chbAddSelected.Size = new System.Drawing.Size(77, 20);
            this.chbAddSelected.TabIndex = 40;
            this.chbAddSelected.Text = "اخذ درس";
            this.chbAddSelected.UseVisualStyleBackColor = true;
            // 
            // chbDeleteLesson
            // 
            this.chbDeleteLesson.AutoSize = true;
            this.chbDeleteLesson.Location = new System.Drawing.Point(217, 143);
            this.chbDeleteLesson.Name = "chbDeleteLesson";
            this.chbDeleteLesson.Size = new System.Drawing.Size(85, 20);
            this.chbDeleteLesson.TabIndex = 38;
            this.chbDeleteLesson.Text = "حذف درس";
            this.chbDeleteLesson.UseVisualStyleBackColor = true;
            // 
            // chbAddLesson
            // 
            this.chbAddLesson.AutoSize = true;
            this.chbAddLesson.Location = new System.Drawing.Point(347, 143);
            this.chbAddLesson.Name = "chbAddLesson";
            this.chbAddLesson.Size = new System.Drawing.Size(80, 20);
            this.chbAddLesson.TabIndex = 37;
            this.chbAddLesson.Text = "ارائه درس";
            this.chbAddLesson.UseVisualStyleBackColor = true;
            // 
            // chbUpdateTeacher
            // 
            this.chbUpdateTeacher.AutoSize = true;
            this.chbUpdateTeacher.Location = new System.Drawing.Point(57, 117);
            this.chbUpdateTeacher.Name = "chbUpdateTeacher";
            this.chbUpdateTeacher.Size = new System.Drawing.Size(98, 20);
            this.chbUpdateTeacher.TabIndex = 36;
            this.chbUpdateTeacher.Text = "ویرایش مربی";
            this.chbUpdateTeacher.UseVisualStyleBackColor = true;
            // 
            // chbDeleteTeacher
            // 
            this.chbDeleteTeacher.AutoSize = true;
            this.chbDeleteTeacher.Location = new System.Drawing.Point(215, 117);
            this.chbDeleteTeacher.Name = "chbDeleteTeacher";
            this.chbDeleteTeacher.Size = new System.Drawing.Size(87, 20);
            this.chbDeleteTeacher.TabIndex = 35;
            this.chbDeleteTeacher.Text = "حذف مربی";
            this.chbDeleteTeacher.UseVisualStyleBackColor = true;
            // 
            // chbAddTeacher
            // 
            this.chbAddTeacher.AutoSize = true;
            this.chbAddTeacher.Location = new System.Drawing.Point(319, 117);
            this.chbAddTeacher.Name = "chbAddTeacher";
            this.chbAddTeacher.Size = new System.Drawing.Size(108, 20);
            this.chbAddTeacher.TabIndex = 34;
            this.chbAddTeacher.Text = "استخدام مربی";
            this.chbAddTeacher.UseVisualStyleBackColor = true;
            // 
            // chbUpdateStudent
            // 
            this.chbUpdateStudent.AutoSize = true;
            this.chbUpdateStudent.Location = new System.Drawing.Point(52, 91);
            this.chbUpdateStudent.Name = "chbUpdateStudent";
            this.chbUpdateStudent.Size = new System.Drawing.Size(103, 20);
            this.chbUpdateStudent.TabIndex = 33;
            this.chbUpdateStudent.Text = "ویرایش هنرجو";
            this.chbUpdateStudent.UseVisualStyleBackColor = true;
            // 
            // chbDeleteStudent
            // 
            this.chbDeleteStudent.AutoSize = true;
            this.chbDeleteStudent.Location = new System.Drawing.Point(210, 91);
            this.chbDeleteStudent.Name = "chbDeleteStudent";
            this.chbDeleteStudent.Size = new System.Drawing.Size(92, 20);
            this.chbDeleteStudent.TabIndex = 32;
            this.chbDeleteStudent.Text = "حذف هنرجو";
            this.chbDeleteStudent.UseVisualStyleBackColor = true;
            // 
            // ChbAddStudent
            // 
            this.ChbAddStudent.AutoSize = true;
            this.ChbAddStudent.Location = new System.Drawing.Point(321, 91);
            this.ChbAddStudent.Name = "ChbAddStudent";
            this.ChbAddStudent.Size = new System.Drawing.Size(106, 20);
            this.ChbAddStudent.TabIndex = 31;
            this.ChbAddStudent.Text = "ثبت نام هنرجو";
            this.ChbAddStudent.UseVisualStyleBackColor = true;
            // 
            // chbShow
            // 
            this.chbShow.AutoSize = true;
            this.chbShow.Location = new System.Drawing.Point(43, 65);
            this.chbShow.Name = "chbShow";
            this.chbShow.Size = new System.Drawing.Size(112, 20);
            this.chbShow.TabIndex = 30;
            this.chbShow.Text = "نمایش اطلاعات";
            this.chbShow.UseVisualStyleBackColor = true;
            // 
            // chbDeleteGroup
            // 
            this.chbDeleteGroup.AutoSize = true;
            this.chbDeleteGroup.Location = new System.Drawing.Point(222, 65);
            this.chbDeleteGroup.Name = "chbDeleteGroup";
            this.chbDeleteGroup.Size = new System.Drawing.Size(80, 20);
            this.chbDeleteGroup.TabIndex = 29;
            this.chbDeleteGroup.Text = "حذف گروه";
            this.chbDeleteGroup.UseVisualStyleBackColor = true;
            // 
            // chbAddGroup
            // 
            this.chbAddGroup.AutoSize = true;
            this.chbAddGroup.Location = new System.Drawing.Point(348, 65);
            this.chbAddGroup.Name = "chbAddGroup";
            this.chbAddGroup.Size = new System.Drawing.Size(79, 20);
            this.chbAddGroup.TabIndex = 28;
            this.chbAddGroup.Text = "ایجاد گروه";
            this.chbAddGroup.UseVisualStyleBackColor = true;
            // 
            // frmSearchUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 303);
            this.Controls.Add(this.grbInformation);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSearchUser";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "جستجو کاربر";
            this.grbInformation.ResumeLayout(false);
            this.grbInformation.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox grbInformation;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label2;
        protected System.Windows.Forms.CheckBox chbAddUser;
        protected System.Windows.Forms.CheckBox chbDeleteUser;
        protected System.Windows.Forms.CheckBox chbAddSelected;
        protected System.Windows.Forms.CheckBox chbUpdateSelected;
        protected System.Windows.Forms.CheckBox chbAddLesson;
        protected System.Windows.Forms.CheckBox chbDeleteSelected;
        protected System.Windows.Forms.CheckBox chbAddTeacher;
        protected System.Windows.Forms.CheckBox ChbAddStudent;
        protected System.Windows.Forms.CheckBox chbAddGroup;
        protected System.Windows.Forms.CheckBox chbUpdateLesson;
        protected System.Windows.Forms.CheckBox chbDeleteLesson;
        protected System.Windows.Forms.CheckBox chbShow;
        protected System.Windows.Forms.CheckBox chbUpdateStudent;
        protected System.Windows.Forms.CheckBox chbDeleteTeacher;
        protected System.Windows.Forms.CheckBox chbUpdateTeacher;
        protected System.Windows.Forms.CheckBox chbDeleteStudent;
        protected System.Windows.Forms.CheckBox chbDeleteGroup;
    }
}