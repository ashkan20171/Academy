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
    public partial class frmLessonList : Form
    {
        public frmLessonList()
        {
            InitializeComponent();
        }

        private void frmLessonList_Load(object sender, EventArgs e)
        {
            dgvLessonList.DataSource = Lesson._All();
            dgvLessonList.Columns["TeacherName"].HeaderText = "نام مربی";
            dgvLessonList.Columns["LessonId"].HeaderText = "شناسه درس";
            dgvLessonList.Columns["LessonName"].HeaderText = "نام درس";
            dgvLessonList.Columns["Salary"].HeaderText = "شهریه";
            dgvLessonList.Columns["Sex"].HeaderText = "جنسیت";
            dgvLessonList.Columns["GroupName"].HeaderText = "نام گروه درسی";

            dgvLessonList.Columns["TeacherName"].Width = 150;
            dgvLessonList.Columns["LessonId"].Width = 150;
            dgvLessonList.Columns["LessonName"].Width = 150;
            dgvLessonList.Columns["Salary"].Width = 150;
            dgvLessonList.Columns["Sex"].Width = 150;
            dgvLessonList.Columns["GroupName"].Width = 150;
            
        }
    }
}
