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
    public partial class frmSearchLesson : Form
    {
        public frmSearchLesson()
        {
            InitializeComponent();
        }

        private void frmSearchLesson_Load(object sender, EventArgs e)
        {
            cmbSex.Items.Add("زن");
            cmbSex.Items.Add("مرد");
            cmbSex.Items.Add("مختلط");
            cmbSex.SelectedIndex = 0;

            cmbGroup.DataSource = Group._All();
            cmbGroup.DisplayMember = "GroupName";
            cmbGroup.SelectedIndex = 0;

            cmbTeacherName.DataSource = Teacher._All();
            cmbTeacherName.DisplayMember = "TeacherName";
            cmbTeacherName.SelectedIndex = 0;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvLesson.DataSource = Lesson._SearchLesson(txtLessonName.Text.Trim(), cmbGroup.Text, cmbSex.Text, txtLessonId.Text.Trim(), cmbTeacherName.Text);
            if (dgvLesson.Rows.Count > 0)
            {
                dgvLesson.Visible = true;
                dgvLesson.Columns["TeacherName"].HeaderText = "نام مربی";
                dgvLesson.Columns["LessonId"].HeaderText = "شناسه درس";
                dgvLesson.Columns["LessonName"].HeaderText = "نام درس";
                dgvLesson.Columns["Salary"].HeaderText = "شهریه";
                dgvLesson.Columns["Sex"].HeaderText = "جنسیت";
                dgvLesson.Columns["GroupName"].HeaderText = "نام گروه درسی";

                dgvLesson.Columns["TeacherName"].Width = 150;
                dgvLesson.Columns["LessonId"].Width = 150;
                dgvLesson.Columns["LessonName"].Width = 150;
                dgvLesson.Columns["Salary"].Width = 150;
                dgvLesson.Columns["Sex"].Width = 150;
                dgvLesson.Columns["GroupName"].Width = 150;
            }
            else
                dgvLesson.Visible = false;
        }
    }
}
