using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Microsoft.Win32;
namespace Academy
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        DateTime Dt;
        MemoryStream ms;
        private readonly byte[] myarray1;

        public byte[] GetMyarray1()
        {
            return myarray1;
        }

        private void picExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            //Pecunary.d();
            System.Globalization.CultureInfo Language=new System.Globalization.CultureInfo("fa-ir");
            InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(Language);
            Dt = DateTime.Now;
            lblTime.Text = Dt.Hour.ToString() + ":" + Dt.Minute.ToString() + ":" + Dt.Second.ToString();
            lblDate.Text = Dt.Year + "/" + Dt.Month + "/" + Dt.Day;
            System.Globalization.PersianCalendar PC = new System.Globalization.PersianCalendar();
            Dt = DateTime.Parse(lblDate.Text);
            lblDate.Text = PC.GetYear(Dt) + "/" + PC.GetMonth(Dt) + "/" + PC.GetDayOfMonth(Dt);
            lblName.Text = Perrmision.Name;
            ms = new MemoryStream(Perrmision.Picture);
            picUser.BackgroundImage = Image.FromStream(ms);
            btnAddGroup.Visible = Perrmision.AddGroup;
            btnAddLesson.Visible = Perrmision.AddLesson;
            btnAddSelected.Visible = Perrmision.AddSelected;
            btnAddStudent.Visible = Perrmision.AddStudent;
            btnAddTeacher.Visible = Perrmision.AddTeacher;
            btnAddUser.Visible = Perrmision.AddUser;
            btnDeleteGroup.Visible = Perrmision.DeleteGroup;
            btnDeleteLesson.Visible = Perrmision.DeleteLesson;
            btnDeleteSelected.Visible = Perrmision.DeleteSelected;
            btnDeleteStudent.Visible = Perrmision.DeleteStudent;
            btnDeleteTeacher.Visible = Perrmision.DeleteTeacher;
            btnDeleteUser.Visible = Perrmision.DeleteUser;
            btnLessonList.Visible = Perrmision.Show;
            btnStudentList.Visible = Perrmision.Show;
            btnTeacherList.Visible = Perrmision.Show;
            btnSelectedList.Visible = Perrmision.Show;
            btnUpdateLesson.Visible = Perrmision.UpdateLesson;
            btnUpdateSelected.Visible = Perrmision.UpdateSelected;
            btnUpdateStudent.Visible = Perrmision.UpdateStudent;
            btnUpdateTeacher.Visible = Perrmision.UpdateTeacher;
        }

        private void TR_Tick(object sender, EventArgs e)
        {
            Dt = DateTime.Now;
            lblTime.Text = Dt.Hour + ":" + Dt.Minute + ":" + Dt.Second;
        }

        private void picArrow_MouseEnter(object sender, EventArgs e)
        {
            pnlDetail.Visible = true;
        }

        private void picArrow_MouseLeave(object sender, EventArgs e)
        {
            pnlDetail.Visible = false;
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            frmAddUser AddUser = new frmAddUser();
            AddUser.ShowDialog();
        }

        private void frmMain_MouseEnter(object sender, EventArgs e)
        {
            flpLesson.Visible = false;
            flpPecunary.Visible = false;
            flpSearch.Visible = false;
            flpStudent.Visible = false;
            flpTeacher.Visible = false;
            flpUser.Visible = false;
        }

        private void btnUser_MouseEnter(object sender, EventArgs e)
        {
            frmMain_MouseEnter(null, null);
            flpUser.Visible = true;
        }

        private void btnSearch_MouseEnter(object sender, EventArgs e)
        {
            frmMain_MouseEnter(null, null);
            flpSearch.Visible = true;
        }

        private void btnPecunary_MouseEnter(object sender, EventArgs e)
        {
            frmMain_MouseEnter(null, null);
            flpPecunary.Visible = true;
        }

        private void btnLesson_MouseEnter(object sender, EventArgs e)
        {
            frmMain_MouseEnter(null, null);
            flpLesson.Visible = true;
        }

        private void btnTeacher_MouseEnter(object sender, EventArgs e)
        {
            frmMain_MouseEnter(null, null);
            flpTeacher.Visible = true;
        }

        private void btnStudent_MouseEnter(object sender, EventArgs e)
        {
            frmMain_MouseEnter(null, null);
            flpStudent.Visible = true;
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            frmDeleteUser DelteUser = new frmDeleteUser();
            DelteUser.ShowDialog();
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            frmAddStudent AddStudent = new frmAddStudent();
            AddStudent.ShowDialog();
        }

        private void btnDeleteStudent_Click(object sender, EventArgs e)
        {
            frmDeleteStudent DeleteStudent = new frmDeleteStudent();
            DeleteStudent.ShowDialog();
        }

        private void btnUpdateStudent_Click(object sender, EventArgs e)
        {
            frmUpdateStudent UpdateStudent = new frmUpdateStudent();
            UpdateStudent.ShowDialog();
        }

        private void btnAddTeacher_Click(object sender, EventArgs e)
        {
            frmAddTeacher AddTeacher = new frmAddTeacher();
            AddTeacher.ShowDialog();
        }

        private void btnDeleteTeacher_Click(object sender, EventArgs e)
        {
            frmDeleteTeacher DeleteTeacher = new frmDeleteTeacher();
            DeleteTeacher.ShowDialog();
        }

        private void btnUpdateTeacher_Click(object sender, EventArgs e)
        {
            frmUpdateTeacher UpdateTeacher = new frmUpdateTeacher();
            UpdateTeacher.ShowDialog();
        }

        private void btnTeacherList_Click(object sender, EventArgs e)
        {
            frmTeacherList TeacherList = new frmTeacherList();
            TeacherList.ShowDialog();
        }

        private void btnStudentList_Click(object sender, EventArgs e)
        {
            frmStudentList StudentList = new frmStudentList();
            StudentList.ShowDialog();
        }

        private void btnAddGroup_Click(object sender, EventArgs e)
        {
            frmAddGroup AddGroup = new frmAddGroup();
            AddGroup.ShowDialog();
        }

        private void btnDeleteGroup_Click(object sender, EventArgs e)
        {
            frmDeleteGroup DeleteGroup = new frmDeleteGroup();
            DeleteGroup.ShowDialog();
        }

        private void btnAddLesson_Click(object sender, EventArgs e)
        {
            frmAddLesson AddLesson = new frmAddLesson();
            AddLesson.ShowDialog();
        }

        private void btnDeleteLesson_Click(object sender, EventArgs e)
        {
            frmDeleteLesson DeleteLesson = new frmDeleteLesson();
            DeleteLesson.ShowDialog();
        }

        private void btnUpdateLesson_Click(object sender, EventArgs e)
        {
            frmUpdateLesson UpdateLesson = new frmUpdateLesson();
            UpdateLesson.ShowDialog();
        }

        private void btnLessonList_Click(object sender, EventArgs e)
        {
            frmLessonList LessonList = new frmLessonList();
            LessonList.ShowDialog();
        }

        private void btnAddSelected_Click(object sender, EventArgs e)
        {
            frmAddSelected AddSelected = new frmAddSelected();
            AddSelected.ShowDialog();
        }

        private void btnDeleteSelected_Click(object sender, EventArgs e)
        {
            frmDeleteSelected DeleteSelected = new frmDeleteSelected();
            DeleteSelected.ShowDialog();
        }

        private void btnSelectedList_Click(object sender, EventArgs e)
        {
            frmSelectedList SelectedList = new frmSelectedList();
            SelectedList.ShowDialog();
        }

        private void btnUpdateSelected_Click(object sender, EventArgs e)
        {
            frmUpdateSelected UpdateSelected = new frmUpdateSelected();
            UpdateSelected.ShowDialog();
        }

        private void btnAddPecunaru_Click(object sender, EventArgs e)
        {
            frmAddPecunary AddPecunary = new frmAddPecunary();
            AddPecunary.ShowDialog();
        }

        private void btnDeletePecunary_Click(object sender, EventArgs e)
        {
            frmDeletePecunari DeletePecunary = new frmDeletePecunari();
            DeletePecunary.ShowDialog();
        }

        private void btnAllPecunary_Click(object sender, EventArgs e)
        {
            frmAllPecunari AllPecunary = new frmAllPecunari();
            AllPecunary.ShowDialog();
        }

        private void btnUpdatePecunary_Click(object sender, EventArgs e)
        {
            frmUpdatePcuniary UpdatePcuniary = new frmUpdatePcuniary();
            UpdatePcuniary.ShowDialog();
        }

        private void btnSearchStudent_Click(object sender, EventArgs e)
        {
            frmSearchStudent SearchStudent = new frmSearchStudent();
            SearchStudent.ShowDialog();
        }

        private void btnSearchSelected_Click(object sender, EventArgs e)
        {
            frmSearchSelected SearchSelected = new frmSearchSelected();
            SearchSelected.ShowDialog();
        }

        private void btnSearchLesson_Click(object sender, EventArgs e)
        {
            frmSearchLesson SearchLesson = new frmSearchLesson();
            SearchLesson.ShowDialog();
        }

        private void btnSearchTeacher_Click(object sender, EventArgs e)
        {
            frmSearchTeacher SearchTeacher = new frmSearchTeacher();
            SearchTeacher.ShowDialog();
        }

        private void btnSearchUser_Click(object sender, EventArgs e)
        {
            frmSearchUser SearchUser = new frmSearchUser();
            SearchUser.ShowDialog();
        }

        private void btnSearchPecunary_Click(object sender, EventArgs e)
        {
            frmSearchPecuniray SearchPecuniary = new frmSearchPecuniray();
            SearchPecuniary.ShowDialog();
        }

        private void llblSetting_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmSetting Setting = new frmSetting();
            Setting.ShowDialog();
        }

        private void llblAbout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAbout About = new frmAbout();
            About.ShowDialog();
        }

        public override bool Equals(object obj)
        {
            return obj is frmMain main &&
                   EqualityComparer<byte[]>.Default.Equals(GetMyarray1(), main.GetMyarray1());
        }
    }
}
