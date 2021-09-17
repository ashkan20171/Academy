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

namespace Academy
{
    public partial class frmDeleteStudent : Form
    {
        public frmDeleteStudent()
        {
            InitializeComponent();
        }
        string IdCard1 = "";
        private void frmDeleteStudent_Load(object sender, EventArgs e)
        {
            dgvStudent.DataSource = Student._AllStudent();
            dgvStudent.Columns["StudentName"].HeaderText = "نام هنرجو";
            dgvStudent.Columns["FatherName"].HeaderText = "نام پدر";
            dgvStudent.Columns["IdCard1"].HeaderText = "شماره ملی";
            dgvStudent.Columns["IdCard2"].HeaderText = "شماره شناسنامه";
            dgvStudent.Columns["Picture"].Visible = false;
            dgvStudent.Columns["StudentName"].Width = 180;
            dgvStudent.Columns["FatherName"].Width=150;
            dgvStudent.Columns["IdCard1"].Width=150;
            dgvStudent.Columns["IdCard2"].Width=150;
        }

        private void dgvStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            byte[] Array = (byte[])dgvStudent["Picture", dgvStudent.CurrentRow.Index].Value;
            MemoryStream MS = new MemoryStream(Array);
            picStudent.BackgroundImage = Image.FromStream(MS);
            IdCard1 = dgvStudent["IdCard1", dgvStudent.CurrentRow.Index].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dr;
            dr = FarsiMessageBox.MessageBox.Show("سوال", "آیا مطمئن هستید؟", FarsiMessageBox.MessageBox.Buttons.YesNo, FarsiMessageBox.MessageBox.Icons.Question);
            if (dr == DialogResult.Yes)
            {
                if (Student._DeleteStudent() == true)
                {
                    FarsiMessageBox.MessageBox.Show("موفقیت", "هنرجو با موفقیت حذف شد.", FarsiMessageBox.MessageBox.Buttons.OK, FarsiMessageBox.MessageBox.Icons.Information);
                    frmDeleteStudent_Load(null, null);
                }
            }
        }
    }
}
