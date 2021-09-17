namespace Academy
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            this.btnStudent = new System.Windows.Forms.Button();
            this.btnTeacher = new System.Windows.Forms.Button();
            this.btnLesson = new System.Windows.Forms.Button();
            this.btnPecunary = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnUser = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.btnAddSelected = new System.Windows.Forms.Button();
            this.btnDeleteStudent = new System.Windows.Forms.Button();
            this.btnDeleteSelected = new System.Windows.Forms.Button();
            this.btnUpdateStudent = new System.Windows.Forms.Button();
            this.btnUpdateSelected = new System.Windows.Forms.Button();
            this.btnAddTeacher = new System.Windows.Forms.Button();
            this.btnUpdateTeacher = new System.Windows.Forms.Button();
            this.btnDeleteTeacher = new System.Windows.Forms.Button();
            this.btnTeacherList = new System.Windows.Forms.Button();
            this.btnAddGroup = new System.Windows.Forms.Button();
            this.btnDeleteGroup = new System.Windows.Forms.Button();
            this.btnAddLesson = new System.Windows.Forms.Button();
            this.btnUpdateLesson = new System.Windows.Forms.Button();
            this.btnDeleteLesson = new System.Windows.Forms.Button();
            this.btnLessonList = new System.Windows.Forms.Button();
            this.btnAddPecunaru = new System.Windows.Forms.Button();
            this.btnUpdatePecunary = new System.Windows.Forms.Button();
            this.btnDeletePecunary = new System.Windows.Forms.Button();
            this.btnAllPecunary = new System.Windows.Forms.Button();
            this.btnSearchStudent = new System.Windows.Forms.Button();
            this.btnSearchPecunary = new System.Windows.Forms.Button();
            this.btnSearchLesson = new System.Windows.Forms.Button();
            this.btnSearchUser = new System.Windows.Forms.Button();
            this.btnSearchTeacher = new System.Windows.Forms.Button();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.btnStudentList = new System.Windows.Forms.Button();
            this.btnSelectedList = new System.Windows.Forms.Button();
            this.btnSearchSelected = new System.Windows.Forms.Button();
            this.flpStudent = new System.Windows.Forms.FlowLayoutPanel();
            this.flpTeacher = new System.Windows.Forms.FlowLayoutPanel();
            this.flpLesson = new System.Windows.Forms.FlowLayoutPanel();
            this.flpPecunary = new System.Windows.Forms.FlowLayoutPanel();
            this.flpSearch = new System.Windows.Forms.FlowLayoutPanel();
            this.flpUser = new System.Windows.Forms.FlowLayoutPanel();
            this.picExit = new System.Windows.Forms.PictureBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.llblAbout = new System.Windows.Forms.LinkLabel();
            this.llblSetting = new System.Windows.Forms.LinkLabel();
            this.TR = new System.Windows.Forms.Timer(this.components);
            this.picArrow = new System.Windows.Forms.PictureBox();
            this.pnlDetail = new System.Windows.Forms.Panel();
            this.lblName = new System.Windows.Forms.Label();
            this.picUser = new System.Windows.Forms.PictureBox();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            this.flpStudent.SuspendLayout();
            this.flpTeacher.SuspendLayout();
            this.flpLesson.SuspendLayout();
            this.flpPecunary.SuspendLayout();
            this.flpSearch.SuspendLayout();
            this.flpUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picArrow)).BeginInit();
            this.pnlDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStudent
            // 
            this.btnStudent.BackgroundImage = global::Academy.Properties.Resources.Student;
            this.btnStudent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStudent.Location = new System.Drawing.Point(6, 145);
            this.btnStudent.Name = "btnStudent";
            this.btnStudent.Size = new System.Drawing.Size(130, 130);
            this.btnStudent.TabIndex = 0;
            this.toolTip1.SetToolTip(this.btnStudent, "امور هنر جویان");
            this.btnStudent.UseVisualStyleBackColor = true;
            this.btnStudent.MouseEnter += new System.EventHandler(this.btnStudent_MouseEnter);
            // 
            // btnTeacher
            // 
            this.btnTeacher.BackgroundImage = global::Academy.Properties.Resources.Teacher;
            this.btnTeacher.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTeacher.Location = new System.Drawing.Point(141, 145);
            this.btnTeacher.Name = "btnTeacher";
            this.btnTeacher.Size = new System.Drawing.Size(130, 130);
            this.btnTeacher.TabIndex = 0;
            this.toolTip1.SetToolTip(this.btnTeacher, "امور مربیان");
            this.btnTeacher.UseVisualStyleBackColor = true;
            this.btnTeacher.MouseEnter += new System.EventHandler(this.btnTeacher_MouseEnter);
            // 
            // btnLesson
            // 
            this.btnLesson.BackgroundImage = global::Academy.Properties.Resources.Lesson;
            this.btnLesson.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLesson.Location = new System.Drawing.Point(276, 145);
            this.btnLesson.Name = "btnLesson";
            this.btnLesson.Size = new System.Drawing.Size(130, 130);
            this.btnLesson.TabIndex = 0;
            this.toolTip1.SetToolTip(this.btnLesson, "امور دروس");
            this.btnLesson.UseVisualStyleBackColor = true;
            this.btnLesson.MouseEnter += new System.EventHandler(this.btnLesson_MouseEnter);
            // 
            // btnPecunary
            // 
            this.btnPecunary.BackgroundImage = global::Academy.Properties.Resources.Pecuniary;
            this.btnPecunary.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPecunary.Location = new System.Drawing.Point(411, 145);
            this.btnPecunary.Name = "btnPecunary";
            this.btnPecunary.Size = new System.Drawing.Size(130, 130);
            this.btnPecunary.TabIndex = 0;
            this.toolTip1.SetToolTip(this.btnPecunary, "امور مالی");
            this.btnPecunary.UseVisualStyleBackColor = true;
            this.btnPecunary.MouseEnter += new System.EventHandler(this.btnPecunary_MouseEnter);
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImage = global::Academy.Properties.Resources.Search;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearch.Location = new System.Drawing.Point(546, 145);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(130, 130);
            this.btnSearch.TabIndex = 0;
            this.toolTip1.SetToolTip(this.btnSearch, "جستجو");
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.MouseEnter += new System.EventHandler(this.btnSearch_MouseEnter);
            // 
            // btnUser
            // 
            this.btnUser.BackgroundImage = global::Academy.Properties.Resources.User;
            this.btnUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUser.Location = new System.Drawing.Point(681, 145);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(130, 130);
            this.btnUser.TabIndex = 0;
            this.toolTip1.SetToolTip(this.btnUser, "امور کاربران");
            this.btnUser.UseVisualStyleBackColor = true;
            this.btnUser.MouseEnter += new System.EventHandler(this.btnUser_MouseEnter);
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.BackgroundImage = global::Academy.Properties.Resources.AddStudent;
            this.btnAddStudent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddStudent.Location = new System.Drawing.Point(0, 0);
            this.btnAddStudent.Margin = new System.Windows.Forms.Padding(0);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(44, 44);
            this.btnAddStudent.TabIndex = 0;
            this.toolTip1.SetToolTip(this.btnAddStudent, "ثبت نام هنرجو");
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Visible = false;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // btnAddSelected
            // 
            this.btnAddSelected.BackgroundImage = global::Academy.Properties.Resources.AddSelected;
            this.btnAddSelected.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddSelected.Location = new System.Drawing.Point(44, 0);
            this.btnAddSelected.Margin = new System.Windows.Forms.Padding(0);
            this.btnAddSelected.Name = "btnAddSelected";
            this.btnAddSelected.Size = new System.Drawing.Size(44, 44);
            this.btnAddSelected.TabIndex = 0;
            this.toolTip1.SetToolTip(this.btnAddSelected, "اخذ درس");
            this.btnAddSelected.UseVisualStyleBackColor = true;
            this.btnAddSelected.Visible = false;
            this.btnAddSelected.Click += new System.EventHandler(this.btnAddSelected_Click);
            // 
            // btnDeleteStudent
            // 
            this.btnDeleteStudent.BackgroundImage = global::Academy.Properties.Resources.DeleteStudent;
            this.btnDeleteStudent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDeleteStudent.Location = new System.Drawing.Point(0, 44);
            this.btnDeleteStudent.Margin = new System.Windows.Forms.Padding(0);
            this.btnDeleteStudent.Name = "btnDeleteStudent";
            this.btnDeleteStudent.Size = new System.Drawing.Size(44, 44);
            this.btnDeleteStudent.TabIndex = 0;
            this.toolTip1.SetToolTip(this.btnDeleteStudent, "حذف هنرحو");
            this.btnDeleteStudent.UseVisualStyleBackColor = true;
            this.btnDeleteStudent.Visible = false;
            this.btnDeleteStudent.Click += new System.EventHandler(this.btnDeleteStudent_Click);
            // 
            // btnDeleteSelected
            // 
            this.btnDeleteSelected.BackgroundImage = global::Academy.Properties.Resources.DeleteSelected;
            this.btnDeleteSelected.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDeleteSelected.Location = new System.Drawing.Point(44, 44);
            this.btnDeleteSelected.Margin = new System.Windows.Forms.Padding(0);
            this.btnDeleteSelected.Name = "btnDeleteSelected";
            this.btnDeleteSelected.Size = new System.Drawing.Size(44, 44);
            this.btnDeleteSelected.TabIndex = 0;
            this.toolTip1.SetToolTip(this.btnDeleteSelected, "حذف درس اخذ شده");
            this.btnDeleteSelected.UseVisualStyleBackColor = true;
            this.btnDeleteSelected.Visible = false;
            this.btnDeleteSelected.Click += new System.EventHandler(this.btnDeleteSelected_Click);
            // 
            // btnUpdateStudent
            // 
            this.btnUpdateStudent.BackgroundImage = global::Academy.Properties.Resources.UpdateStudent;
            this.btnUpdateStudent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUpdateStudent.Location = new System.Drawing.Point(0, 88);
            this.btnUpdateStudent.Margin = new System.Windows.Forms.Padding(0);
            this.btnUpdateStudent.Name = "btnUpdateStudent";
            this.btnUpdateStudent.Size = new System.Drawing.Size(44, 44);
            this.btnUpdateStudent.TabIndex = 0;
            this.toolTip1.SetToolTip(this.btnUpdateStudent, "به روز رسانی هنرجو");
            this.btnUpdateStudent.UseVisualStyleBackColor = true;
            this.btnUpdateStudent.Visible = false;
            this.btnUpdateStudent.Click += new System.EventHandler(this.btnUpdateStudent_Click);
            // 
            // btnUpdateSelected
            // 
            this.btnUpdateSelected.BackgroundImage = global::Academy.Properties.Resources.UpdateSelected;
            this.btnUpdateSelected.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUpdateSelected.Location = new System.Drawing.Point(44, 88);
            this.btnUpdateSelected.Margin = new System.Windows.Forms.Padding(0);
            this.btnUpdateSelected.Name = "btnUpdateSelected";
            this.btnUpdateSelected.Size = new System.Drawing.Size(44, 44);
            this.btnUpdateSelected.TabIndex = 0;
            this.toolTip1.SetToolTip(this.btnUpdateSelected, "به روز رسانی درس اخذ شده");
            this.btnUpdateSelected.UseVisualStyleBackColor = true;
            this.btnUpdateSelected.Visible = false;
            this.btnUpdateSelected.Click += new System.EventHandler(this.btnUpdateSelected_Click);
            // 
            // btnAddTeacher
            // 
            this.btnAddTeacher.BackgroundImage = global::Academy.Properties.Resources.AddTeacher;
            this.btnAddTeacher.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddTeacher.Location = new System.Drawing.Point(0, 0);
            this.btnAddTeacher.Margin = new System.Windows.Forms.Padding(0);
            this.btnAddTeacher.Name = "btnAddTeacher";
            this.btnAddTeacher.Size = new System.Drawing.Size(44, 44);
            this.btnAddTeacher.TabIndex = 0;
            this.toolTip1.SetToolTip(this.btnAddTeacher, "استخدام مربی");
            this.btnAddTeacher.UseVisualStyleBackColor = true;
            this.btnAddTeacher.Visible = false;
            this.btnAddTeacher.Click += new System.EventHandler(this.btnAddTeacher_Click);
            // 
            // btnUpdateTeacher
            // 
            this.btnUpdateTeacher.BackgroundImage = global::Academy.Properties.Resources.UpdateTeacher;
            this.btnUpdateTeacher.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUpdateTeacher.Location = new System.Drawing.Point(44, 0);
            this.btnUpdateTeacher.Margin = new System.Windows.Forms.Padding(0);
            this.btnUpdateTeacher.Name = "btnUpdateTeacher";
            this.btnUpdateTeacher.Size = new System.Drawing.Size(44, 44);
            this.btnUpdateTeacher.TabIndex = 0;
            this.toolTip1.SetToolTip(this.btnUpdateTeacher, "به روز رسانی مربی");
            this.btnUpdateTeacher.UseVisualStyleBackColor = true;
            this.btnUpdateTeacher.Visible = false;
            this.btnUpdateTeacher.Click += new System.EventHandler(this.btnUpdateTeacher_Click);
            // 
            // btnDeleteTeacher
            // 
            this.btnDeleteTeacher.BackgroundImage = global::Academy.Properties.Resources.DeleteTeacher;
            this.btnDeleteTeacher.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDeleteTeacher.Location = new System.Drawing.Point(0, 44);
            this.btnDeleteTeacher.Margin = new System.Windows.Forms.Padding(0);
            this.btnDeleteTeacher.Name = "btnDeleteTeacher";
            this.btnDeleteTeacher.Size = new System.Drawing.Size(44, 44);
            this.btnDeleteTeacher.TabIndex = 0;
            this.toolTip1.SetToolTip(this.btnDeleteTeacher, "حذف مربی");
            this.btnDeleteTeacher.UseVisualStyleBackColor = true;
            this.btnDeleteTeacher.Visible = false;
            this.btnDeleteTeacher.Click += new System.EventHandler(this.btnDeleteTeacher_Click);
            // 
            // btnTeacherList
            // 
            this.btnTeacherList.BackgroundImage = global::Academy.Properties.Resources.TeacherList;
            this.btnTeacherList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTeacherList.Location = new System.Drawing.Point(44, 44);
            this.btnTeacherList.Margin = new System.Windows.Forms.Padding(0);
            this.btnTeacherList.Name = "btnTeacherList";
            this.btnTeacherList.Size = new System.Drawing.Size(44, 44);
            this.btnTeacherList.TabIndex = 0;
            this.toolTip1.SetToolTip(this.btnTeacherList, "لیست مربیان");
            this.btnTeacherList.UseVisualStyleBackColor = true;
            this.btnTeacherList.Visible = false;
            this.btnTeacherList.Click += new System.EventHandler(this.btnTeacherList_Click);
            // 
            // btnAddGroup
            // 
            this.btnAddGroup.BackgroundImage = global::Academy.Properties.Resources.AddGroup;
            this.btnAddGroup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddGroup.Location = new System.Drawing.Point(0, 0);
            this.btnAddGroup.Margin = new System.Windows.Forms.Padding(0);
            this.btnAddGroup.Name = "btnAddGroup";
            this.btnAddGroup.Size = new System.Drawing.Size(44, 44);
            this.btnAddGroup.TabIndex = 0;
            this.toolTip1.SetToolTip(this.btnAddGroup, "ایجاد گروه درسی");
            this.btnAddGroup.UseVisualStyleBackColor = true;
            this.btnAddGroup.Visible = false;
            this.btnAddGroup.Click += new System.EventHandler(this.btnAddGroup_Click);
            // 
            // btnDeleteGroup
            // 
            this.btnDeleteGroup.BackgroundImage = global::Academy.Properties.Resources.DeleteGroup;
            this.btnDeleteGroup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDeleteGroup.Location = new System.Drawing.Point(44, 0);
            this.btnDeleteGroup.Margin = new System.Windows.Forms.Padding(0);
            this.btnDeleteGroup.Name = "btnDeleteGroup";
            this.btnDeleteGroup.Size = new System.Drawing.Size(44, 44);
            this.btnDeleteGroup.TabIndex = 0;
            this.toolTip1.SetToolTip(this.btnDeleteGroup, "حذف گروه درسی");
            this.btnDeleteGroup.UseVisualStyleBackColor = true;
            this.btnDeleteGroup.Visible = false;
            this.btnDeleteGroup.Click += new System.EventHandler(this.btnDeleteGroup_Click);
            // 
            // btnAddLesson
            // 
            this.btnAddLesson.BackgroundImage = global::Academy.Properties.Resources.AddLesson;
            this.btnAddLesson.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddLesson.Location = new System.Drawing.Point(0, 44);
            this.btnAddLesson.Margin = new System.Windows.Forms.Padding(0);
            this.btnAddLesson.Name = "btnAddLesson";
            this.btnAddLesson.Size = new System.Drawing.Size(44, 44);
            this.btnAddLesson.TabIndex = 0;
            this.toolTip1.SetToolTip(this.btnAddLesson, "ارائه درس");
            this.btnAddLesson.UseVisualStyleBackColor = true;
            this.btnAddLesson.Visible = false;
            this.btnAddLesson.Click += new System.EventHandler(this.btnAddLesson_Click);
            // 
            // btnUpdateLesson
            // 
            this.btnUpdateLesson.BackgroundImage = global::Academy.Properties.Resources.UpdateLesson;
            this.btnUpdateLesson.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUpdateLesson.Location = new System.Drawing.Point(44, 44);
            this.btnUpdateLesson.Margin = new System.Windows.Forms.Padding(0);
            this.btnUpdateLesson.Name = "btnUpdateLesson";
            this.btnUpdateLesson.Size = new System.Drawing.Size(44, 44);
            this.btnUpdateLesson.TabIndex = 0;
            this.toolTip1.SetToolTip(this.btnUpdateLesson, "به روز رسانی درس ارائه شده");
            this.btnUpdateLesson.UseVisualStyleBackColor = true;
            this.btnUpdateLesson.Visible = false;
            this.btnUpdateLesson.Click += new System.EventHandler(this.btnUpdateLesson_Click);
            // 
            // btnDeleteLesson
            // 
            this.btnDeleteLesson.BackgroundImage = global::Academy.Properties.Resources.DeleteLesson;
            this.btnDeleteLesson.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDeleteLesson.Location = new System.Drawing.Point(0, 88);
            this.btnDeleteLesson.Margin = new System.Windows.Forms.Padding(0);
            this.btnDeleteLesson.Name = "btnDeleteLesson";
            this.btnDeleteLesson.Size = new System.Drawing.Size(44, 44);
            this.btnDeleteLesson.TabIndex = 0;
            this.toolTip1.SetToolTip(this.btnDeleteLesson, "حدف درس ارائه شده");
            this.btnDeleteLesson.UseVisualStyleBackColor = true;
            this.btnDeleteLesson.Visible = false;
            this.btnDeleteLesson.Click += new System.EventHandler(this.btnDeleteLesson_Click);
            // 
            // btnLessonList
            // 
            this.btnLessonList.BackgroundImage = global::Academy.Properties.Resources.LessonList;
            this.btnLessonList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLessonList.Location = new System.Drawing.Point(44, 88);
            this.btnLessonList.Margin = new System.Windows.Forms.Padding(0);
            this.btnLessonList.Name = "btnLessonList";
            this.btnLessonList.Size = new System.Drawing.Size(44, 44);
            this.btnLessonList.TabIndex = 0;
            this.toolTip1.SetToolTip(this.btnLessonList, "لیست دروی ارائه شده");
            this.btnLessonList.UseVisualStyleBackColor = true;
            this.btnLessonList.Visible = false;
            this.btnLessonList.Click += new System.EventHandler(this.btnLessonList_Click);
            // 
            // btnAddPecunaru
            // 
            this.btnAddPecunaru.BackgroundImage = global::Academy.Properties.Resources.AddPecuniary;
            this.btnAddPecunaru.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddPecunaru.Location = new System.Drawing.Point(0, 0);
            this.btnAddPecunaru.Margin = new System.Windows.Forms.Padding(0);
            this.btnAddPecunaru.Name = "btnAddPecunaru";
            this.btnAddPecunaru.Size = new System.Drawing.Size(44, 44);
            this.btnAddPecunaru.TabIndex = 0;
            this.toolTip1.SetToolTip(this.btnAddPecunaru, "پرداخت شهریه");
            this.btnAddPecunaru.UseVisualStyleBackColor = true;
            this.btnAddPecunaru.Click += new System.EventHandler(this.btnAddPecunaru_Click);
            // 
            // btnUpdatePecunary
            // 
            this.btnUpdatePecunary.BackgroundImage = global::Academy.Properties.Resources.UpdatePecuniary;
            this.btnUpdatePecunary.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUpdatePecunary.Location = new System.Drawing.Point(44, 0);
            this.btnUpdatePecunary.Margin = new System.Windows.Forms.Padding(0);
            this.btnUpdatePecunary.Name = "btnUpdatePecunary";
            this.btnUpdatePecunary.Size = new System.Drawing.Size(44, 44);
            this.btnUpdatePecunary.TabIndex = 0;
            this.toolTip1.SetToolTip(this.btnUpdatePecunary, "به روز رسانی شهریه پرداخت شده");
            this.btnUpdatePecunary.UseVisualStyleBackColor = true;
            this.btnUpdatePecunary.Click += new System.EventHandler(this.btnUpdatePecunary_Click);
            // 
            // btnDeletePecunary
            // 
            this.btnDeletePecunary.BackgroundImage = global::Academy.Properties.Resources.DeletePecuniary;
            this.btnDeletePecunary.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDeletePecunary.Location = new System.Drawing.Point(0, 44);
            this.btnDeletePecunary.Margin = new System.Windows.Forms.Padding(0);
            this.btnDeletePecunary.Name = "btnDeletePecunary";
            this.btnDeletePecunary.Size = new System.Drawing.Size(44, 44);
            this.btnDeletePecunary.TabIndex = 0;
            this.toolTip1.SetToolTip(this.btnDeletePecunary, "حذف شهریه پرداخت شده");
            this.btnDeletePecunary.UseVisualStyleBackColor = true;
            this.btnDeletePecunary.Click += new System.EventHandler(this.btnDeletePecunary_Click);
            // 
            // btnAllPecunary
            // 
            this.btnAllPecunary.BackgroundImage = global::Academy.Properties.Resources.AllPecuniaryList;
            this.btnAllPecunary.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAllPecunary.Location = new System.Drawing.Point(44, 44);
            this.btnAllPecunary.Margin = new System.Windows.Forms.Padding(0);
            this.btnAllPecunary.Name = "btnAllPecunary";
            this.btnAllPecunary.Size = new System.Drawing.Size(44, 44);
            this.btnAllPecunary.TabIndex = 0;
            this.toolTip1.SetToolTip(this.btnAllPecunary, "لیست پرداخت ها");
            this.btnAllPecunary.UseVisualStyleBackColor = true;
            this.btnAllPecunary.Click += new System.EventHandler(this.btnAllPecunary_Click);
            // 
            // btnSearchStudent
            // 
            this.btnSearchStudent.BackgroundImage = global::Academy.Properties.Resources.SearchStudent;
            this.btnSearchStudent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearchStudent.Location = new System.Drawing.Point(0, 0);
            this.btnSearchStudent.Margin = new System.Windows.Forms.Padding(0);
            this.btnSearchStudent.Name = "btnSearchStudent";
            this.btnSearchStudent.Size = new System.Drawing.Size(44, 44);
            this.btnSearchStudent.TabIndex = 0;
            this.toolTip1.SetToolTip(this.btnSearchStudent, "جستجو هنرجو");
            this.btnSearchStudent.UseVisualStyleBackColor = true;
            this.btnSearchStudent.Click += new System.EventHandler(this.btnSearchStudent_Click);
            // 
            // btnSearchPecunary
            // 
            this.btnSearchPecunary.BackgroundImage = global::Academy.Properties.Resources.SearchPecuniary;
            this.btnSearchPecunary.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearchPecunary.Location = new System.Drawing.Point(44, 0);
            this.btnSearchPecunary.Margin = new System.Windows.Forms.Padding(0);
            this.btnSearchPecunary.Name = "btnSearchPecunary";
            this.btnSearchPecunary.Size = new System.Drawing.Size(44, 44);
            this.btnSearchPecunary.TabIndex = 0;
            this.toolTip1.SetToolTip(this.btnSearchPecunary, "جستجو مالی");
            this.btnSearchPecunary.UseVisualStyleBackColor = true;
            this.btnSearchPecunary.Click += new System.EventHandler(this.btnSearchPecunary_Click);
            // 
            // btnSearchLesson
            // 
            this.btnSearchLesson.BackgroundImage = global::Academy.Properties.Resources.SearchLesson;
            this.btnSearchLesson.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearchLesson.Location = new System.Drawing.Point(0, 44);
            this.btnSearchLesson.Margin = new System.Windows.Forms.Padding(0);
            this.btnSearchLesson.Name = "btnSearchLesson";
            this.btnSearchLesson.Size = new System.Drawing.Size(44, 44);
            this.btnSearchLesson.TabIndex = 0;
            this.toolTip1.SetToolTip(this.btnSearchLesson, "جستجو دروس");
            this.btnSearchLesson.UseVisualStyleBackColor = true;
            this.btnSearchLesson.Click += new System.EventHandler(this.btnSearchLesson_Click);
            // 
            // btnSearchUser
            // 
            this.btnSearchUser.BackgroundImage = global::Academy.Properties.Resources.SearchUser;
            this.btnSearchUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearchUser.Location = new System.Drawing.Point(44, 44);
            this.btnSearchUser.Margin = new System.Windows.Forms.Padding(0);
            this.btnSearchUser.Name = "btnSearchUser";
            this.btnSearchUser.Size = new System.Drawing.Size(44, 44);
            this.btnSearchUser.TabIndex = 0;
            this.toolTip1.SetToolTip(this.btnSearchUser, "جستجو کاربر");
            this.btnSearchUser.UseVisualStyleBackColor = true;
            this.btnSearchUser.Click += new System.EventHandler(this.btnSearchUser_Click);
            // 
            // btnSearchTeacher
            // 
            this.btnSearchTeacher.BackgroundImage = global::Academy.Properties.Resources.SearchTeacher;
            this.btnSearchTeacher.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearchTeacher.Location = new System.Drawing.Point(0, 88);
            this.btnSearchTeacher.Margin = new System.Windows.Forms.Padding(0);
            this.btnSearchTeacher.Name = "btnSearchTeacher";
            this.btnSearchTeacher.Size = new System.Drawing.Size(44, 44);
            this.btnSearchTeacher.TabIndex = 0;
            this.toolTip1.SetToolTip(this.btnSearchTeacher, "جستجو مربی");
            this.btnSearchTeacher.UseVisualStyleBackColor = true;
            this.btnSearchTeacher.Click += new System.EventHandler(this.btnSearchTeacher_Click);
            // 
            // btnAddUser
            // 
            this.btnAddUser.BackgroundImage = global::Academy.Properties.Resources.AddUser;
            this.btnAddUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddUser.Location = new System.Drawing.Point(0, 0);
            this.btnAddUser.Margin = new System.Windows.Forms.Padding(0);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(44, 44);
            this.btnAddUser.TabIndex = 0;
            this.toolTip1.SetToolTip(this.btnAddUser, "ایجاد کاربر");
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Visible = false;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.BackgroundImage = global::Academy.Properties.Resources.DeleteUser;
            this.btnDeleteUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDeleteUser.Location = new System.Drawing.Point(44, 0);
            this.btnDeleteUser.Margin = new System.Windows.Forms.Padding(0);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(44, 44);
            this.btnDeleteUser.TabIndex = 0;
            this.toolTip1.SetToolTip(this.btnDeleteUser, "حذف کاربر");
            this.btnDeleteUser.UseVisualStyleBackColor = true;
            this.btnDeleteUser.Visible = false;
            this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_Click);
            // 
            // btnStudentList
            // 
            this.btnStudentList.BackgroundImage = global::Academy.Properties.Resources.StudentList;
            this.btnStudentList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStudentList.Location = new System.Drawing.Point(0, 132);
            this.btnStudentList.Margin = new System.Windows.Forms.Padding(0);
            this.btnStudentList.Name = "btnStudentList";
            this.btnStudentList.Size = new System.Drawing.Size(44, 44);
            this.btnStudentList.TabIndex = 1;
            this.toolTip1.SetToolTip(this.btnStudentList, "لیست هنرجویان");
            this.btnStudentList.UseVisualStyleBackColor = true;
            this.btnStudentList.Visible = false;
            this.btnStudentList.Click += new System.EventHandler(this.btnStudentList_Click);
            // 
            // btnSelectedList
            // 
            this.btnSelectedList.BackgroundImage = global::Academy.Properties.Resources.SelectedList;
            this.btnSelectedList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSelectedList.Location = new System.Drawing.Point(44, 132);
            this.btnSelectedList.Margin = new System.Windows.Forms.Padding(0);
            this.btnSelectedList.Name = "btnSelectedList";
            this.btnSelectedList.Size = new System.Drawing.Size(44, 44);
            this.btnSelectedList.TabIndex = 2;
            this.toolTip1.SetToolTip(this.btnSelectedList, "لیست دروس اخذ شده");
            this.btnSelectedList.UseVisualStyleBackColor = true;
            this.btnSelectedList.Visible = false;
            this.btnSelectedList.Click += new System.EventHandler(this.btnSelectedList_Click);
            // 
            // btnSearchSelected
            // 
            this.btnSearchSelected.BackgroundImage = global::Academy.Properties.Resources.SearchSelected;
            this.btnSearchSelected.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearchSelected.Location = new System.Drawing.Point(44, 88);
            this.btnSearchSelected.Margin = new System.Windows.Forms.Padding(0);
            this.btnSearchSelected.Name = "btnSearchSelected";
            this.btnSearchSelected.Size = new System.Drawing.Size(44, 44);
            this.btnSearchSelected.TabIndex = 1;
            this.toolTip1.SetToolTip(this.btnSearchSelected, "جستجو دروس اخذ شده");
            this.btnSearchSelected.UseVisualStyleBackColor = true;
            this.btnSearchSelected.Click += new System.EventHandler(this.btnSearchSelected_Click);
            // 
            // flpStudent
            // 
            this.flpStudent.BackColor = System.Drawing.Color.Transparent;
            this.flpStudent.Controls.Add(this.btnAddStudent);
            this.flpStudent.Controls.Add(this.btnAddSelected);
            this.flpStudent.Controls.Add(this.btnDeleteStudent);
            this.flpStudent.Controls.Add(this.btnDeleteSelected);
            this.flpStudent.Controls.Add(this.btnUpdateStudent);
            this.flpStudent.Controls.Add(this.btnUpdateSelected);
            this.flpStudent.Controls.Add(this.btnStudentList);
            this.flpStudent.Controls.Add(this.btnSelectedList);
            this.flpStudent.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flpStudent.Location = new System.Drawing.Point(28, 272);
            this.flpStudent.Margin = new System.Windows.Forms.Padding(0);
            this.flpStudent.Name = "flpStudent";
            this.flpStudent.Size = new System.Drawing.Size(90, 178);
            this.flpStudent.TabIndex = 1;
            this.flpStudent.Visible = false;
            // 
            // flpTeacher
            // 
            this.flpTeacher.BackColor = System.Drawing.Color.Transparent;
            this.flpTeacher.Controls.Add(this.btnAddTeacher);
            this.flpTeacher.Controls.Add(this.btnUpdateTeacher);
            this.flpTeacher.Controls.Add(this.btnDeleteTeacher);
            this.flpTeacher.Controls.Add(this.btnTeacherList);
            this.flpTeacher.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flpTeacher.Location = new System.Drawing.Point(162, 273);
            this.flpTeacher.Margin = new System.Windows.Forms.Padding(0);
            this.flpTeacher.Name = "flpTeacher";
            this.flpTeacher.Size = new System.Drawing.Size(90, 89);
            this.flpTeacher.TabIndex = 2;
            this.flpTeacher.Visible = false;
            // 
            // flpLesson
            // 
            this.flpLesson.BackColor = System.Drawing.Color.Transparent;
            this.flpLesson.Controls.Add(this.btnAddGroup);
            this.flpLesson.Controls.Add(this.btnDeleteGroup);
            this.flpLesson.Controls.Add(this.btnAddLesson);
            this.flpLesson.Controls.Add(this.btnUpdateLesson);
            this.flpLesson.Controls.Add(this.btnDeleteLesson);
            this.flpLesson.Controls.Add(this.btnLessonList);
            this.flpLesson.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flpLesson.Location = new System.Drawing.Point(298, 274);
            this.flpLesson.Margin = new System.Windows.Forms.Padding(0);
            this.flpLesson.Name = "flpLesson";
            this.flpLesson.Size = new System.Drawing.Size(90, 136);
            this.flpLesson.TabIndex = 2;
            this.flpLesson.Visible = false;
            // 
            // flpPecunary
            // 
            this.flpPecunary.BackColor = System.Drawing.Color.Transparent;
            this.flpPecunary.Controls.Add(this.btnAddPecunaru);
            this.flpPecunary.Controls.Add(this.btnUpdatePecunary);
            this.flpPecunary.Controls.Add(this.btnDeletePecunary);
            this.flpPecunary.Controls.Add(this.btnAllPecunary);
            this.flpPecunary.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flpPecunary.Location = new System.Drawing.Point(434, 274);
            this.flpPecunary.Margin = new System.Windows.Forms.Padding(0);
            this.flpPecunary.Name = "flpPecunary";
            this.flpPecunary.Size = new System.Drawing.Size(90, 88);
            this.flpPecunary.TabIndex = 2;
            this.flpPecunary.Visible = false;
            // 
            // flpSearch
            // 
            this.flpSearch.BackColor = System.Drawing.Color.Transparent;
            this.flpSearch.Controls.Add(this.btnSearchStudent);
            this.flpSearch.Controls.Add(this.btnSearchPecunary);
            this.flpSearch.Controls.Add(this.btnSearchLesson);
            this.flpSearch.Controls.Add(this.btnSearchUser);
            this.flpSearch.Controls.Add(this.btnSearchTeacher);
            this.flpSearch.Controls.Add(this.btnSearchSelected);
            this.flpSearch.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flpSearch.Location = new System.Drawing.Point(569, 273);
            this.flpSearch.Margin = new System.Windows.Forms.Padding(0);
            this.flpSearch.Name = "flpSearch";
            this.flpSearch.Size = new System.Drawing.Size(90, 133);
            this.flpSearch.TabIndex = 2;
            this.flpSearch.Visible = false;
            // 
            // flpUser
            // 
            this.flpUser.BackColor = System.Drawing.Color.Transparent;
            this.flpUser.Controls.Add(this.btnAddUser);
            this.flpUser.Controls.Add(this.btnDeleteUser);
            this.flpUser.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flpUser.Location = new System.Drawing.Point(706, 271);
            this.flpUser.Margin = new System.Windows.Forms.Padding(0);
            this.flpUser.Name = "flpUser";
            this.flpUser.Size = new System.Drawing.Size(90, 47);
            this.flpUser.TabIndex = 2;
            this.flpUser.Visible = false;
            // 
            // picExit
            // 
            this.picExit.BackgroundImage = global::Academy.Properties.Resources.Exit;
            this.picExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picExit.Location = new System.Drawing.Point(742, 77);
            this.picExit.Name = "picExit";
            this.picExit.Size = new System.Drawing.Size(36, 38);
            this.picExit.TabIndex = 3;
            this.picExit.TabStop = false;
            this.picExit.Click += new System.EventHandler(this.picExit_Click);
            // 
            // lblTime
            // 
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.Font = new System.Drawing.Font("B Yekan", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblTime.Location = new System.Drawing.Point(626, 81);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(100, 39);
            this.lblTime.TabIndex = 4;
            this.lblTime.Text = "ساعت";
            // 
            // lblDate
            // 
            this.lblDate.BackColor = System.Drawing.Color.Transparent;
            this.lblDate.Font = new System.Drawing.Font("B Yekan", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblDate.Location = new System.Drawing.Point(429, 81);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(158, 39);
            this.lblDate.TabIndex = 4;
            this.lblDate.Text = "تاریخ";
            // 
            // llblAbout
            // 
            this.llblAbout.AutoSize = true;
            this.llblAbout.BackColor = System.Drawing.Color.Transparent;
            this.llblAbout.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.llblAbout.Location = new System.Drawing.Point(37, 484);
            this.llblAbout.Name = "llblAbout";
            this.llblAbout.Size = new System.Drawing.Size(84, 25);
            this.llblAbout.TabIndex = 5;
            this.llblAbout.TabStop = true;
            this.llblAbout.Text = "درباره ما";
            this.llblAbout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblAbout_LinkClicked);
            // 
            // llblSetting
            // 
            this.llblSetting.AutoSize = true;
            this.llblSetting.BackColor = System.Drawing.Color.Transparent;
            this.llblSetting.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.llblSetting.Location = new System.Drawing.Point(162, 484);
            this.llblSetting.Name = "llblSetting";
            this.llblSetting.Size = new System.Drawing.Size(83, 25);
            this.llblSetting.TabIndex = 5;
            this.llblSetting.TabStop = true;
            this.llblSetting.Text = "تنظیمات";
            this.llblSetting.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblSetting_LinkClicked);
            // 
            // TR
            // 
            this.TR.Enabled = true;
            this.TR.Interval = 1000;
            this.TR.Tick += new System.EventHandler(this.TR_Tick);
            // 
            // picArrow
            // 
            this.picArrow.BackColor = System.Drawing.Color.Transparent;
            this.picArrow.BackgroundImage = global::Academy.Properties.Resources.Arrow;
            this.picArrow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picArrow.Location = new System.Drawing.Point(810, 341);
            this.picArrow.Name = "picArrow";
            this.picArrow.Size = new System.Drawing.Size(10, 108);
            this.picArrow.TabIndex = 6;
            this.picArrow.TabStop = false;
            this.picArrow.MouseEnter += new System.EventHandler(this.picArrow_MouseEnter);
            this.picArrow.MouseLeave += new System.EventHandler(this.picArrow_MouseLeave);
            // 
            // pnlDetail
            // 
            this.pnlDetail.BackColor = System.Drawing.Color.DarkSalmon;
            this.pnlDetail.Controls.Add(this.lblName);
            this.pnlDetail.Controls.Add(this.picUser);
            this.pnlDetail.Location = new System.Drawing.Point(569, 342);
            this.pnlDetail.Name = "pnlDetail";
            this.pnlDetail.Size = new System.Drawing.Size(243, 107);
            this.pnlDetail.TabIndex = 7;
            this.pnlDetail.Visible = false;
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblName.Location = new System.Drawing.Point(3, 4);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(145, 100);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "label1";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // picUser
            // 
            this.picUser.BackColor = System.Drawing.Color.Transparent;
            this.picUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picUser.Location = new System.Drawing.Point(154, 3);
            this.picUser.Name = "picUser";
            this.picUser.Size = new System.Drawing.Size(81, 101);
            this.picUser.TabIndex = 0;
            this.picUser.TabStop = false;
            // 
            // skinEngine1
            // 
            this.skinEngine1.Active = false;
            this.skinEngine1.SerialNumber = "";
            this.skinEngine1.SkinFile = null;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.BackgroundImage = global::Academy.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(820, 550);
            this.Controls.Add(this.picArrow);
            this.Controls.Add(this.llblSetting);
            this.Controls.Add(this.llblAbout);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.picExit);
            this.Controls.Add(this.flpStudent);
            this.Controls.Add(this.btnUser);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnPecunary);
            this.Controls.Add(this.btnLesson);
            this.Controls.Add(this.btnTeacher);
            this.Controls.Add(this.flpUser);
            this.Controls.Add(this.flpSearch);
            this.Controls.Add(this.flpPecunary);
            this.Controls.Add(this.flpLesson);
            this.Controls.Add(this.flpTeacher);
            this.Controls.Add(this.btnStudent);
            this.Controls.Add(this.pnlDetail);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TransparencyKey = System.Drawing.Color.Yellow;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.MouseEnter += new System.EventHandler(this.frmMain_MouseEnter);
            this.flpStudent.ResumeLayout(false);
            this.flpTeacher.ResumeLayout(false);
            this.flpLesson.ResumeLayout(false);
            this.flpPecunary.ResumeLayout(false);
            this.flpSearch.ResumeLayout(false);
            this.flpUser.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picArrow)).EndInit();
            this.pnlDetail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStudent;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnTeacher;
        private System.Windows.Forms.Button btnLesson;
        private System.Windows.Forms.Button btnPecunary;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnUser;
        private System.Windows.Forms.FlowLayoutPanel flpStudent;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.Button btnAddSelected;
        private System.Windows.Forms.Button btnDeleteStudent;
        private System.Windows.Forms.Button btnDeleteSelected;
        private System.Windows.Forms.Button btnUpdateStudent;
        private System.Windows.Forms.Button btnUpdateSelected;
        private System.Windows.Forms.FlowLayoutPanel flpTeacher;
        private System.Windows.Forms.Button btnAddTeacher;
        private System.Windows.Forms.Button btnTeacherList;
        private System.Windows.Forms.Button btnDeleteTeacher;
        private System.Windows.Forms.Button btnUpdateTeacher;
        private System.Windows.Forms.FlowLayoutPanel flpLesson;
        private System.Windows.Forms.Button btnAddGroup;
        private System.Windows.Forms.Button btnDeleteGroup;
        private System.Windows.Forms.Button btnAddLesson;
        private System.Windows.Forms.Button btnUpdateLesson;
        private System.Windows.Forms.Button btnDeleteLesson;
        private System.Windows.Forms.Button btnLessonList;
        private System.Windows.Forms.FlowLayoutPanel flpPecunary;
        private System.Windows.Forms.Button btnAddPecunaru;
        private System.Windows.Forms.Button btnAllPecunary;
        private System.Windows.Forms.Button btnDeletePecunary;
        private System.Windows.Forms.Button btnUpdatePecunary;
        private System.Windows.Forms.FlowLayoutPanel flpSearch;
        private System.Windows.Forms.Button btnSearchStudent;
        private System.Windows.Forms.Button btnSearchPecunary;
        private System.Windows.Forms.Button btnSearchLesson;
        private System.Windows.Forms.Button btnSearchUser;
        private System.Windows.Forms.Button btnSearchTeacher;
        private System.Windows.Forms.FlowLayoutPanel flpUser;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Button btnDeleteUser;
        private System.Windows.Forms.PictureBox picExit;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.LinkLabel llblAbout;
        private System.Windows.Forms.LinkLabel llblSetting;
        private System.Windows.Forms.Button btnStudentList;
        private System.Windows.Forms.Button btnSelectedList;
        private System.Windows.Forms.Button btnSearchSelected;
        private System.Windows.Forms.Timer TR;
        private System.Windows.Forms.PictureBox picArrow;
        private System.Windows.Forms.Panel pnlDetail;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.PictureBox picUser;
        private Sunisoft.IrisSkin.SkinEngine skinEngine1;
    }
}