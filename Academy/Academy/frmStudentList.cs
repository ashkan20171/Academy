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
    public partial class frmStudentList : Form
    {
        public frmStudentList()
        {
            InitializeComponent();
        }

        private void frmStudentList_Load(object sender, EventArgs e)
        {
            dgvStudentList.DataSource = Student._All();
            dgvStudentList.Columns["StudentName"].HeaderText = "نام هنرجو";
            dgvStudentList.Columns["FatherName"].HeaderText = "نام پدر";
            dgvStudentList.Columns["IdCard1"].HeaderText = "شماره ملی";
            dgvStudentList.Columns["IdCard2"].HeaderText = "شماره شناسنامه";
            dgvStudentList.Columns["Sex"].HeaderText = "جنسیت";
            dgvStudentList.Columns["Tell"].HeaderText = "تلفن";
            dgvStudentList.Columns["Mobile"].HeaderText = "تلفن همراه";
            dgvStudentList.Columns["Address"].HeaderText = "آدرس";
            dgvStudentList.Columns["Discription"].HeaderText = "توضیحات";
            dgvStudentList.Columns["Picture"].Visible = false;
            dgvStudentList.Columns["Id"].Visible = false;
        }
    }
}
