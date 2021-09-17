namespace Academy
{
    partial class frmAddUser
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
            this.grbUser = new System.Windows.Forms.GroupBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.cmbQuestio = new System.Windows.Forms.ComboBox();
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.txtConfrimPassword = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPicture = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grbPic = new System.Windows.Forms.GroupBox();
            this.PicUser = new System.Windows.Forms.PictureBox();
            this.grbPermision = new System.Windows.Forms.GroupBox();
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
            this.chbAll = new System.Windows.Forms.CheckBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.grbUser.SuspendLayout();
            this.grbPic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicUser)).BeginInit();
            this.grbPermision.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbUser
            // 
            this.grbUser.Controls.Add(this.btnBrowse);
            this.grbUser.Controls.Add(this.cmbQuestio);
            this.grbUser.Controls.Add(this.txtAnswer);
            this.grbUser.Controls.Add(this.txtConfrimPassword);
            this.grbUser.Controls.Add(this.txtUserName);
            this.grbUser.Controls.Add(this.txtPassword);
            this.grbUser.Controls.Add(this.txtName);
            this.grbUser.Controls.Add(this.txtPicture);
            this.grbUser.Controls.Add(this.label7);
            this.grbUser.Controls.Add(this.label6);
            this.grbUser.Controls.Add(this.label5);
            this.grbUser.Controls.Add(this.label4);
            this.grbUser.Controls.Add(this.label3);
            this.grbUser.Controls.Add(this.label2);
            this.grbUser.Controls.Add(this.label1);
            this.grbUser.Controls.Add(this.grbPic);
            this.grbUser.Location = new System.Drawing.Point(22, 22);
            this.grbUser.Name = "grbUser";
            this.grbUser.Size = new System.Drawing.Size(814, 194);
            this.grbUser.TabIndex = 0;
            this.grbUser.TabStop = false;
            this.grbUser.Text = "اطلاعات کاربر";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(139, 31);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(95, 25);
            this.btnBrowse.TabIndex = 2;
            this.btnBrowse.Text = "انتخاب عکس";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // cmbQuestio
            // 
            this.cmbQuestio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbQuestio.FormattingEnabled = true;
            this.cmbQuestio.Location = new System.Drawing.Point(139, 126);
            this.cmbQuestio.Name = "cmbQuestio";
            this.cmbQuestio.Size = new System.Drawing.Size(573, 24);
            this.cmbQuestio.TabIndex = 7;
            this.cmbQuestio.SelectedIndexChanged += new System.EventHandler(this.cmbQuestio_SelectedIndexChanged);
            // 
            // txtAnswer
            // 
            this.txtAnswer.Location = new System.Drawing.Point(23, 156);
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.Size = new System.Drawing.Size(689, 23);
            this.txtAnswer.TabIndex = 8;
            // 
            // txtConfrimPassword
            // 
            this.txtConfrimPassword.Location = new System.Drawing.Point(139, 93);
            this.txtConfrimPassword.Name = "txtConfrimPassword";
            this.txtConfrimPassword.PasswordChar = '•';
            this.txtConfrimPassword.Size = new System.Drawing.Size(234, 23);
            this.txtConfrimPassword.TabIndex = 6;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(139, 62);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(234, 23);
            this.txtUserName.TabIndex = 4;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(472, 96);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '•';
            this.txtPassword.Size = new System.Drawing.Size(240, 23);
            this.txtPassword.TabIndex = 5;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(472, 62);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(240, 23);
            this.txtName.TabIndex = 3;
            // 
            // txtPicture
            // 
            this.txtPicture.Location = new System.Drawing.Point(240, 33);
            this.txtPicture.Name = "txtPicture";
            this.txtPicture.Size = new System.Drawing.Size(472, 23);
            this.txtPicture.TabIndex = 1;
            this.txtPicture.TextChanged += new System.EventHandler(this.txtPicture_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(718, 156);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 16);
            this.label7.TabIndex = 1;
            this.label7.Text = "پاسخ :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(718, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "سوال امنیتی :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(374, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "تکرار رمز ورود :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(718, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "رمز ورود :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(374, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "نام کاربری :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(718, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "نام    :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(718, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "عکس :";
            // 
            // grbPic
            // 
            this.grbPic.Controls.Add(this.PicUser);
            this.grbPic.Location = new System.Drawing.Point(17, 11);
            this.grbPic.Name = "grbPic";
            this.grbPic.Size = new System.Drawing.Size(116, 143);
            this.grbPic.TabIndex = 0;
            this.grbPic.TabStop = false;
            // 
            // PicUser
            // 
            this.PicUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PicUser.Location = new System.Drawing.Point(6, 12);
            this.PicUser.Name = "PicUser";
            this.PicUser.Size = new System.Drawing.Size(104, 125);
            this.PicUser.TabIndex = 1;
            this.PicUser.TabStop = false;
            // 
            // grbPermision
            // 
            this.grbPermision.Controls.Add(this.chbUpdateSelected);
            this.grbPermision.Controls.Add(this.chbDeleteUser);
            this.grbPermision.Controls.Add(this.chbDeleteSelected);
            this.grbPermision.Controls.Add(this.chbUpdateLesson);
            this.grbPermision.Controls.Add(this.chbAddUser);
            this.grbPermision.Controls.Add(this.chbAddSelected);
            this.grbPermision.Controls.Add(this.chbDeleteLesson);
            this.grbPermision.Controls.Add(this.chbAddLesson);
            this.grbPermision.Controls.Add(this.chbUpdateTeacher);
            this.grbPermision.Controls.Add(this.chbDeleteTeacher);
            this.grbPermision.Controls.Add(this.chbAddTeacher);
            this.grbPermision.Controls.Add(this.chbUpdateStudent);
            this.grbPermision.Controls.Add(this.chbDeleteStudent);
            this.grbPermision.Controls.Add(this.ChbAddStudent);
            this.grbPermision.Controls.Add(this.chbShow);
            this.grbPermision.Controls.Add(this.chbDeleteGroup);
            this.grbPermision.Controls.Add(this.chbAddGroup);
            this.grbPermision.Controls.Add(this.chbAll);
            this.grbPermision.Location = new System.Drawing.Point(22, 226);
            this.grbPermision.Name = "grbPermision";
            this.grbPermision.Size = new System.Drawing.Size(814, 210);
            this.grbPermision.TabIndex = 9;
            this.grbPermision.TabStop = false;
            this.grbPermision.Text = "سطح دسترسی";
            // 
            // chbUpdateSelected
            // 
            this.chbUpdateSelected.AutoSize = true;
            this.chbUpdateSelected.Location = new System.Drawing.Point(98, 152);
            this.chbUpdateSelected.Name = "chbUpdateSelected";
            this.chbUpdateSelected.Size = new System.Drawing.Size(149, 20);
            this.chbUpdateSelected.TabIndex = 25;
            this.chbUpdateSelected.Text = "ویرایش درس اخذ شده";
            this.chbUpdateSelected.UseVisualStyleBackColor = true;
            // 
            // chbDeleteUser
            // 
            this.chbDeleteUser.AutoSize = true;
            this.chbDeleteUser.Location = new System.Drawing.Point(386, 178);
            this.chbDeleteUser.Name = "chbDeleteUser";
            this.chbDeleteUser.Size = new System.Drawing.Size(82, 20);
            this.chbDeleteUser.TabIndex = 27;
            this.chbDeleteUser.Text = "حذف کاربر";
            this.chbDeleteUser.UseVisualStyleBackColor = true;
            // 
            // chbDeleteSelected
            // 
            this.chbDeleteSelected.AutoSize = true;
            this.chbDeleteSelected.Location = new System.Drawing.Point(330, 152);
            this.chbDeleteSelected.Name = "chbDeleteSelected";
            this.chbDeleteSelected.Size = new System.Drawing.Size(138, 20);
            this.chbDeleteSelected.TabIndex = 24;
            this.chbDeleteSelected.Text = "حذف درس اخذ شده";
            this.chbDeleteSelected.UseVisualStyleBackColor = true;
            // 
            // chbUpdateLesson
            // 
            this.chbUpdateLesson.AutoSize = true;
            this.chbUpdateLesson.Location = new System.Drawing.Point(151, 126);
            this.chbUpdateLesson.Name = "chbUpdateLesson";
            this.chbUpdateLesson.Size = new System.Drawing.Size(96, 20);
            this.chbUpdateLesson.TabIndex = 22;
            this.chbUpdateLesson.Text = "ویرایش درس";
            this.chbUpdateLesson.UseVisualStyleBackColor = true;
            // 
            // chbAddUser
            // 
            this.chbAddUser.AutoSize = true;
            this.chbAddUser.Location = new System.Drawing.Point(715, 178);
            this.chbAddUser.Name = "chbAddUser";
            this.chbAddUser.Size = new System.Drawing.Size(81, 20);
            this.chbAddUser.TabIndex = 26;
            this.chbAddUser.Text = "ایجاد کاربر";
            this.chbAddUser.UseVisualStyleBackColor = true;
            // 
            // chbAddSelected
            // 
            this.chbAddSelected.AutoSize = true;
            this.chbAddSelected.Location = new System.Drawing.Point(719, 152);
            this.chbAddSelected.Name = "chbAddSelected";
            this.chbAddSelected.Size = new System.Drawing.Size(77, 20);
            this.chbAddSelected.TabIndex = 23;
            this.chbAddSelected.Text = "اخذ درس";
            this.chbAddSelected.UseVisualStyleBackColor = true;
            // 
            // chbDeleteLesson
            // 
            this.chbDeleteLesson.AutoSize = true;
            this.chbDeleteLesson.Location = new System.Drawing.Point(383, 126);
            this.chbDeleteLesson.Name = "chbDeleteLesson";
            this.chbDeleteLesson.Size = new System.Drawing.Size(85, 20);
            this.chbDeleteLesson.TabIndex = 21;
            this.chbDeleteLesson.Text = "حذف درس";
            this.chbDeleteLesson.UseVisualStyleBackColor = true;
            // 
            // chbAddLesson
            // 
            this.chbAddLesson.AutoSize = true;
            this.chbAddLesson.Location = new System.Drawing.Point(716, 126);
            this.chbAddLesson.Name = "chbAddLesson";
            this.chbAddLesson.Size = new System.Drawing.Size(80, 20);
            this.chbAddLesson.TabIndex = 20;
            this.chbAddLesson.Text = "ارائه درس";
            this.chbAddLesson.UseVisualStyleBackColor = true;
            // 
            // chbUpdateTeacher
            // 
            this.chbUpdateTeacher.AutoSize = true;
            this.chbUpdateTeacher.Location = new System.Drawing.Point(149, 100);
            this.chbUpdateTeacher.Name = "chbUpdateTeacher";
            this.chbUpdateTeacher.Size = new System.Drawing.Size(98, 20);
            this.chbUpdateTeacher.TabIndex = 19;
            this.chbUpdateTeacher.Text = "ویرایش مربی";
            this.chbUpdateTeacher.UseVisualStyleBackColor = true;
            // 
            // chbDeleteTeacher
            // 
            this.chbDeleteTeacher.AutoSize = true;
            this.chbDeleteTeacher.Location = new System.Drawing.Point(381, 100);
            this.chbDeleteTeacher.Name = "chbDeleteTeacher";
            this.chbDeleteTeacher.Size = new System.Drawing.Size(87, 20);
            this.chbDeleteTeacher.TabIndex = 18;
            this.chbDeleteTeacher.Text = "حذف مربی";
            this.chbDeleteTeacher.UseVisualStyleBackColor = true;
            // 
            // chbAddTeacher
            // 
            this.chbAddTeacher.AutoSize = true;
            this.chbAddTeacher.Location = new System.Drawing.Point(688, 100);
            this.chbAddTeacher.Name = "chbAddTeacher";
            this.chbAddTeacher.Size = new System.Drawing.Size(108, 20);
            this.chbAddTeacher.TabIndex = 17;
            this.chbAddTeacher.Text = "استخدام مربی";
            this.chbAddTeacher.UseVisualStyleBackColor = true;
            // 
            // chbUpdateStudent
            // 
            this.chbUpdateStudent.AutoSize = true;
            this.chbUpdateStudent.Location = new System.Drawing.Point(144, 74);
            this.chbUpdateStudent.Name = "chbUpdateStudent";
            this.chbUpdateStudent.Size = new System.Drawing.Size(103, 20);
            this.chbUpdateStudent.TabIndex = 16;
            this.chbUpdateStudent.Text = "ویرایش هنرجو";
            this.chbUpdateStudent.UseVisualStyleBackColor = true;
            // 
            // chbDeleteStudent
            // 
            this.chbDeleteStudent.AutoSize = true;
            this.chbDeleteStudent.Location = new System.Drawing.Point(376, 74);
            this.chbDeleteStudent.Name = "chbDeleteStudent";
            this.chbDeleteStudent.Size = new System.Drawing.Size(92, 20);
            this.chbDeleteStudent.TabIndex = 15;
            this.chbDeleteStudent.Text = "حذف هنرجو";
            this.chbDeleteStudent.UseVisualStyleBackColor = true;
            // 
            // ChbAddStudent
            // 
            this.ChbAddStudent.AutoSize = true;
            this.ChbAddStudent.Location = new System.Drawing.Point(690, 74);
            this.ChbAddStudent.Name = "ChbAddStudent";
            this.ChbAddStudent.Size = new System.Drawing.Size(106, 20);
            this.ChbAddStudent.TabIndex = 14;
            this.ChbAddStudent.Text = "ثبت نام هنرجو";
            this.ChbAddStudent.UseVisualStyleBackColor = true;
            // 
            // chbShow
            // 
            this.chbShow.AutoSize = true;
            this.chbShow.Location = new System.Drawing.Point(135, 48);
            this.chbShow.Name = "chbShow";
            this.chbShow.Size = new System.Drawing.Size(112, 20);
            this.chbShow.TabIndex = 13;
            this.chbShow.Text = "نمایش اطلاعات";
            this.chbShow.UseVisualStyleBackColor = true;
            // 
            // chbDeleteGroup
            // 
            this.chbDeleteGroup.AutoSize = true;
            this.chbDeleteGroup.Location = new System.Drawing.Point(388, 48);
            this.chbDeleteGroup.Name = "chbDeleteGroup";
            this.chbDeleteGroup.Size = new System.Drawing.Size(80, 20);
            this.chbDeleteGroup.TabIndex = 12;
            this.chbDeleteGroup.Text = "حذف گروه";
            this.chbDeleteGroup.UseVisualStyleBackColor = true;
            // 
            // chbAddGroup
            // 
            this.chbAddGroup.AutoSize = true;
            this.chbAddGroup.Location = new System.Drawing.Point(717, 48);
            this.chbAddGroup.Name = "chbAddGroup";
            this.chbAddGroup.Size = new System.Drawing.Size(79, 20);
            this.chbAddGroup.TabIndex = 11;
            this.chbAddGroup.Text = "ایجاد گروه";
            this.chbAddGroup.UseVisualStyleBackColor = true;
            // 
            // chbAll
            // 
            this.chbAll.AutoSize = true;
            this.chbAll.Location = new System.Drawing.Point(704, 22);
            this.chbAll.Name = "chbAll";
            this.chbAll.Size = new System.Drawing.Size(91, 20);
            this.chbAll.TabIndex = 10;
            this.chbAll.Text = "انتخاب همه";
            this.chbAll.UseVisualStyleBackColor = true;
            this.chbAll.CheckedChanged += new System.EventHandler(this.chbAll_CheckedChanged);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(426, 441);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(95, 25);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "تایید";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(325, 441);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(95, 25);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "پاک کردن";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // frmAddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 478);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.grbPermision);
            this.Controls.Add(this.grbUser);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddUser";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ایجاد کاربر";
            this.Load += new System.EventHandler(this.frmAddUser_Load);
            this.grbUser.ResumeLayout(false);
            this.grbUser.PerformLayout();
            this.grbPic.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PicUser)).EndInit();
            this.grbPermision.ResumeLayout(false);
            this.grbPermision.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbUser;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.ComboBox cmbQuestio;
        private System.Windows.Forms.TextBox txtAnswer;
        private System.Windows.Forms.TextBox txtConfrimPassword;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPicture;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grbPic;
        private System.Windows.Forms.PictureBox PicUser;
        private System.Windows.Forms.GroupBox grbPermision;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnClear;
        protected System.Windows.Forms.CheckBox chbUpdateSelected;
        protected System.Windows.Forms.CheckBox chbDeleteUser;
        protected System.Windows.Forms.CheckBox chbDeleteSelected;
        protected System.Windows.Forms.CheckBox chbUpdateLesson;
        protected System.Windows.Forms.CheckBox chbAddUser;
        protected System.Windows.Forms.CheckBox chbAddSelected;
        protected System.Windows.Forms.CheckBox chbDeleteLesson;
        protected System.Windows.Forms.CheckBox chbAddLesson;
        protected System.Windows.Forms.CheckBox chbUpdateTeacher;
        protected System.Windows.Forms.CheckBox chbDeleteTeacher;
        protected System.Windows.Forms.CheckBox chbAddTeacher;
        protected System.Windows.Forms.CheckBox chbUpdateStudent;
        protected System.Windows.Forms.CheckBox chbDeleteStudent;
        protected System.Windows.Forms.CheckBox ChbAddStudent;
        protected System.Windows.Forms.CheckBox chbShow;
        protected System.Windows.Forms.CheckBox chbDeleteGroup;
        protected System.Windows.Forms.CheckBox chbAddGroup;
        protected System.Windows.Forms.CheckBox chbAll;
    }
}