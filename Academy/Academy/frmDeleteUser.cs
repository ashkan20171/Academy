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
    public partial class frmDeleteUser : Form
    {
        public frmDeleteUser()
        {
            InitializeComponent();
        }
        string UserName = "";
        private void dgvUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            byte[] Array = (byte[])dgvUser["Picture", dgvUser.CurrentRow.Index].Value;
            MemoryStream MS = new MemoryStream(Array);
            picUser.BackgroundImage = Image.FromStream(MS);
            UserName = dgvUser["UserName", dgvUser.CurrentRow.Index].Value.ToString();
        }

        private void frmDeleteUser_Load(object sender, EventArgs e)
        {
            DataTable dd = User._AllUser();
            dgvUser.DataSource = dd;
            dgvUser.Columns["UserName"].HeaderText = "نام کاربری";
            dgvUser.Columns["Name"].HeaderText = "نام ";
            dgvUser.Columns["UserName"].Width = 280;
            dgvUser.Columns["Name"].Width=280;
            dgvUser.Columns["Picture"].Visible = false;
        }

        [Obsolete]
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (User._DeleteUser(UserName) == true)
            {
                FarsiMessageBox.MessageBox.Show("موفقیت", "کاربر با موفقیت حذف شد.", FarsiMessageBox.MessageBox.Buttons.OK, FarsiMessageBox.MessageBox.Icons.Information);
                frmDeleteUser_Load(null, null);
            }
        }
    }
}
