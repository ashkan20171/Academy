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
    public partial class frmSearchUser : Form
    {
        public frmSearchUser()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DataTable dd = User._SearchUser(txtUserName.Text.Trim());
            if (dd.Rows.Count == 0)
            {
                FarsiMessageBox.MessageBox.Show("خطا", "چنین کاربری وجود ندارد.", FarsiMessageBox.MessageBox.Buttons.OK, FarsiMessageBox.MessageBox.Icons.Error);
                chbAddGroup.Checked = false;
                chbAddLesson.Checked = false;
                chbAddSelected.Checked = false;
                ChbAddStudent.Checked = false;
                chbAddTeacher.Checked = false;
                chbAddUser.Checked = false;
                chbDeleteGroup.Checked = false;
                chbDeleteLesson.Checked = false;
                chbDeleteSelected.Checked = false;
                chbDeleteStudent.Checked = false;
                chbDeleteTeacher.Checked = false;
                chbDeleteUser.Checked = false;
                chbShow.Checked = false;
                chbUpdateLesson.Checked = false;
                chbUpdateSelected.Checked = false;
                chbUpdateStudent.Checked = false;
                chbUpdateTeacher.Checked = false;
            }
            else
            {
                lblName.Text = dd.Rows[0]["Name"].ToString();
                chbAddGroup.Checked = Convert.ToBoolean(dd.Rows[0]["AddGroup"].ToString());
                chbAddLesson.Checked = Convert.ToBoolean(dd.Rows[0]["AddLesson"].ToString());
                chbAddSelected.Checked = Convert.ToBoolean(dd.Rows[0]["AddSelected"].ToString());
                ChbAddStudent.Checked = Convert.ToBoolean(dd.Rows[0]["AddStudent"].ToString());
                chbAddTeacher.Checked = Convert.ToBoolean(dd.Rows[0]["AddTeacher"].ToString());
                chbAddUser.Checked = Convert.ToBoolean(dd.Rows[0]["AddUser"].ToString());
                chbDeleteGroup.Checked = Convert.ToBoolean(dd.Rows[0]["DeleteGroup"].ToString());
                chbDeleteLesson.Checked = Convert.ToBoolean(dd.Rows[0]["DeleteLesson"].ToString());
                chbDeleteSelected.Checked = Convert.ToBoolean(dd.Rows[0]["DeleteSelected"].ToString());
                chbDeleteStudent.Checked = Convert.ToBoolean(dd.Rows[0]["DeleteStudent"].ToString());
                chbDeleteTeacher.Checked = Convert.ToBoolean(dd.Rows[0]["DeleteTeacher"].ToString());
                chbDeleteUser.Checked = Convert.ToBoolean(dd.Rows[0]["DeleteUser"].ToString());
                chbShow.Checked = Convert.ToBoolean(dd.Rows[0]["Show"].ToString());
                chbUpdateLesson.Checked = Convert.ToBoolean(dd.Rows[0]["UpdateLesson"].ToString());
                chbUpdateSelected.Checked = Convert.ToBoolean(dd.Rows[0]["UpdateSelected"].ToString());
                chbUpdateStudent.Checked = Convert.ToBoolean(dd.Rows[0]["UpdateStudent"].ToString());
                chbUpdateTeacher.Checked = Convert.ToBoolean(dd.Rows[0]["UpdateTeacher"].ToString());

            }
        }
    }
}
