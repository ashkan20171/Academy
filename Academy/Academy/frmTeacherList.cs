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
    public partial class frmTeacherList : Form
    {
        public frmTeacherList()
        {
            InitializeComponent();
        }

        private void frmTeacherList_Load(object sender, EventArgs e)
        {
            dgvTeacherList.DataSource = Teacher._All();
            dgvTeacherList.Columns["TeacherName"].HeaderText = "نام مربی";
            dgvTeacherList.Columns["FatherName"].HeaderText = "نام پدر";
            dgvTeacherList.Columns["IdCard1"].HeaderText = "شماره ملی";
            dgvTeacherList.Columns["IdCard2"].HeaderText = "شماره شناسنامه";
            dgvTeacherList.Columns["Study"].HeaderText = "تحصیلات";
            dgvTeacherList.Columns["Sex"].HeaderText = "جنسیت";
            dgvTeacherList.Columns["Tell"].HeaderText = "تلفن";
            dgvTeacherList.Columns["Mobile"].HeaderText = "تلفن همراه";
            dgvTeacherList.Columns["Address"].HeaderText = "آدرس";
            dgvTeacherList.Columns["Discription"].HeaderText = "توضیحات";
            dgvTeacherList.Columns["DateEmploy"].HeaderText = "تاریخ استخدام";
            dgvTeacherList.Columns["Picture"].Visible = false;
            dgvTeacherList.Columns["Id"].Visible = false;
            for (int i = 0; i < dgvTeacherList.Rows.Count; i++)
                dgvTeacherList["DateEmploy", i].Value = Teacher.MiladiToShamsi(Convert.ToDateTime(dgvTeacherList["DateEmploy", i].Value.ToString()));
        }
    }
}
