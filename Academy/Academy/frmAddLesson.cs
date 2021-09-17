using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Academy
{
    public partial class frmAddLesson : Form
    {
        public frmAddLesson()
        {
            InitializeComponent();
        }
        public new bool Update = false;
        string _LessonId = "";
        private void btnOk_Click(object sender, EventArgs e)
        {
            if (Update == true)
            {
                if (txtLessonId.Text.Trim() != string.Empty && txtLessonName.Text.Trim() != string.Empty && txtSalary.Text.Trim() != string.Empty)
                {
                    Lesson.LessonName = txtLessonName.Text.Trim();
                    Lesson.LessonId = txtLessonId.Text.Trim();
                    Lesson.Salary = txtSalary.Text.Trim();
                    Lesson.GroupName = cmbGroupName.Text;
                    Lesson.TeacherName = cmbTeacherName.Text;
                    Lesson.Sex = cmbSex.Text;
                    if (Lesson._UpdateLesson(_LessonId) == true)
                        FarsiMessageBox.MessageBox.Show("موفقیت", "درس با موفقیت ویرایش شد.", FarsiMessageBox.MessageBox.Buttons.OK, FarsiMessageBox.MessageBox.Icons.Information);
                }
                else
                    FarsiMessageBox.MessageBox.Show("خطا", "لطفا همه مقادیر را وارد نمایید.", FarsiMessageBox.MessageBox.Buttons.OK, FarsiMessageBox.MessageBox.Icons.Error);
            }
            else
            {
                if (txtLessonId.Text.Trim() != string.Empty && txtLessonName.Text.Trim() != string.Empty && txtSalary.Text.Trim() != string.Empty)
                {
                    Lesson.LessonName = txtLessonName.Text.Trim();
                    Lesson.LessonId = txtLessonId.Text.Trim();
                    Lesson.Salary = txtSalary.Text.Trim();
                    Lesson.GroupName = cmbGroupName.Text;
                    Lesson.TeacherName = cmbTeacherName.Text;
                    Lesson.Sex = cmbSex.Text;
                    if (Lesson._AddLesson() == true)
                        FarsiMessageBox.MessageBox.Show("موفقیت", "درس با موفقیت ارائه شد.", FarsiMessageBox.MessageBox.Buttons.OK, FarsiMessageBox.MessageBox.Icons.Information);
                }
                else
                    FarsiMessageBox.MessageBox.Show("خطا", "لطفا همه مقادیر را وارد نمایید.", FarsiMessageBox.MessageBox.Buttons.OK, FarsiMessageBox.MessageBox.Icons.Error);
            }


            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtLessonId.Text = "";
            txtLessonName.Text = "";
            txtSalary.Text = "";
            cmbGroupName.SelectedIndex = 0;
            cmbSex.SelectedIndex = 0;
            cmbTeacherName.SelectedIndex = 0;
            txtLessonId.Focus();
        }

        private void frmAddLesson_Load(object sender, EventArgs e)
        {

            cmbTeacherName.DataSource = Teacher._All();
            cmbTeacherName.DisplayMember = "TeacherName";

            cmbGroupName.DataSource = Group._All();
            cmbGroupName.DisplayMember = "GroupName";

            cmbSex.Items.Add("زن");
            cmbSex.Items.Add("مرد");
            cmbSex.Items.Add("مختلط");

            if (Update == true)
            {
                txtLessonId.Text = Lesson.LessonId;
                txtLessonName.Text = Lesson.LessonName;
                txtSalary.Text = Lesson.Salary;
                cmbGroupName.Text = Lesson.GroupName;
                cmbSex.Text = Lesson.Sex;
                cmbTeacherName.Text = Lesson.TeacherName;
                _LessonId = Lesson.LessonId;
            }
            else
            {
                cmbTeacherName.SelectedIndex = 0;
                cmbGroupName.SelectedIndex = 0;
                cmbSex.SelectedIndex = 0;
            }
            
            
        }
    }
}
