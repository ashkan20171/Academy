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
    public partial class frmDeleteTeacher : Form
    {
        public frmDeleteTeacher()
        {
            InitializeComponent();
        }
        string _TeacherName = "";
        private void frmDeleteTeacher_Load(object sender, EventArgs e)
        {
            dgvTeacher.DataSource = Teacher._AllTeacher();
            dgvTeacher.Columns["TeacherName"].HeaderText = "نام مربی";
            dgvTeacher.Columns["IdCard1"].HeaderText = "شماره ملی";
            dgvTeacher.Columns["IdCard2"].HeaderText = "شماره شناسنامه";
            dgvTeacher.Columns["Picture"].Visible = false;
            dgvTeacher.Columns["TeacherName"].Width = 200;
            dgvTeacher.Columns["IdCard1"].Width = 200;
            dgvTeacher.Columns["IdCard2"].Width = 200;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (Teacher._DeleteTeacher(_TeacherName) == true)
            {

                FarsiMessageBox.MessageBox.Show("موفقیت", "مربی با موفقیت حذف شد.", FarsiMessageBox.MessageBox.Buttons.OK, FarsiMessageBox.MessageBox.Icons.Information);
                frmDeleteTeacher_Load(null, null);
                picTeacher.BackgroundImage = null;
            }
        }

        private void dgvTeacher_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            byte[] Array = (byte[])dgvTeacher["Picture", dgvTeacher.CurrentRow.Index].Value;
            MemoryStream MS = new MemoryStream(Array);
            picTeacher.BackgroundImage = Image.FromStream(MS);
            _TeacherName = dgvTeacher["TeacherName", dgvTeacher.CurrentRow.Index].Value.ToString();
        }
    }
}
