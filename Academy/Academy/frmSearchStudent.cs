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
    public partial class frmSearchStudent : Form
    {
        public frmSearchStudent()
        {
            InitializeComponent();
        }

        private void frmSearchStudent_Load(object sender, EventArgs e)
        {
            cmbSex.Items.Add("زن");
            cmbSex.Items.Add("مرد");
            cmbSex.SelectedIndex = 0;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvStudent.DataSource = Student._SearchStudent(txtName.Text.Trim(), txtIdCard1.Text.Trim(), cmbSex.Text);
            if (dgvStudent.Rows.Count > 0)
            {
                dgvStudent.Visible = true;
                dgvStudent.Columns["StudentName"].HeaderText = "نام هنرجو";
                dgvStudent.Columns["FatherName"].HeaderText = "نام پدر";
                dgvStudent.Columns["Sex"].HeaderText = "جنسیت";
                dgvStudent.Columns["IdCard1"].HeaderText = "شماره ملی";
                dgvStudent.Columns["IdCard2"].HeaderText = "شماره شناسنامه";
                dgvStudent.Columns["Tell"].HeaderText = "تلفن";
                dgvStudent.Columns["Mobile"].HeaderText = "تلفن همراه";
                dgvStudent.Columns["Address"].HeaderText = "آدرس";
                dgvStudent.Columns["Discription"].HeaderText = "توضیحات";
                dgvStudent.Columns["Id"].Visible = false;
                dgvStudent.Columns["Picture"].Visible = false;
            }
            else
                dgvStudent.Visible = false;
        }
    }
}
