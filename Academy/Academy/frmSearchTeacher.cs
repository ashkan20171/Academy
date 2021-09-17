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
    public partial class frmSearchTeacher : Form
    {
        public frmSearchTeacher()
        {
            InitializeComponent();
        }

        private void frmSearchTeacher_Load(object sender, EventArgs e)
        {
            cmbSex.Items.Add("زن");
            cmbSex.Items.Add("مرد");
            cmbSex.SelectedIndex = 0;

            cmbTeacherName.DataSource = Teacher._All();
            cmbTeacherName.DisplayMember = "TeacherName";
            cmbTeacherName.SelectedIndex = 0;

            cmbStudy.DataSource = Teacher._AllStudy();
            cmbStudy.DisplayMember = "Study";
            cmbStudy.SelectedIndex = 0;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvTeacher.DataSource = Teacher._SearchTeacher(txtIdCard1.Text.Trim(), cmbTeacherName.Text, cmbSex.Text, cmbStudy.Text);
            if (dgvTeacher.Rows.Count > 0)
            {
                dgvTeacher.Visible = true;
                dgvTeacher.Columns["TeacherName"].HeaderText = "نام مربی";
                dgvTeacher.Columns["FatherName"].HeaderText = "نام پدر";
                dgvTeacher.Columns["IdCard1"].HeaderText = "شماره ملی";
                dgvTeacher.Columns["IdCard2"].HeaderText = "شماره شناسنامه";
                dgvTeacher.Columns["Study"].HeaderText = "تحصیلات";
                dgvTeacher.Columns["Sex"].HeaderText = "جنسیت";
                dgvTeacher.Columns["Tell"].HeaderText = "تلفن";
                dgvTeacher.Columns["Mobile"].HeaderText = "تلفن همراه";
                dgvTeacher.Columns["Address"].HeaderText = "آدرس";
                dgvTeacher.Columns["Discription"].HeaderText = "توضیحات";
                dgvTeacher.Columns["DateEmploy"].HeaderText = "تاریخ استخدام";
                dgvTeacher.Columns["Picture"].Visible = false;
                dgvTeacher.Columns["Id"].Visible = false;
                for (int i = 0; i < dgvTeacher.Rows.Count; i++)
                    dgvTeacher["DateEmploy", i].Value = Teacher.MiladiToShamsi(Convert.ToDateTime(dgvTeacher["DateEmploy", i].Value.ToString()));
            }
            else
                dgvTeacher.Visible = false;
        }
    }
}
