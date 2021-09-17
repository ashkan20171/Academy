using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.IO;
namespace Academy
{
    public partial class frmAddUser : Form
    {
        public frmAddUser()
        {
            InitializeComponent();
        }

        OpenFileDialog Open;
        MemoryStream MS;
        Image img;
        ImageFormat imgFormat = ImageFormat.Jpeg;
        bool SelectedPicture = false;
        private void cmbQuestio_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmAddUser_Load(object sender, EventArgs e)
        {
            DataTable dd = new DataTable();
            dd = User._Question();
            for(int i=0;i<dd.Rows.Count;i++)
                cmbQuestio.Items.Add(dd.Rows[i]["Question"].ToString());
            cmbQuestio.SelectedIndex = 0;
            PicUser.BackgroundImage = Bitmap.FromFile(Application.StartupPath + @"\Default-User.jpg");
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            Open = new OpenFileDialog();
            Open.Filter = "All picture files |*.jpg;*.png;*.bmp";
            if (Open.ShowDialog() == DialogResult.OK)
            {
                SelectedPicture = true;
                PicUser.BackgroundImage = Bitmap.FromFile(Open.FileName);
                txtPicture.Text = Open.FileName;
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (txtAnswer.Text.Trim() != string.Empty && txtConfrimPassword.Text.Trim() != string.Empty && txtName.Text.Trim() != string.Empty && txtPassword.Text.Trim() != string.Empty && txtUserName.Text.Trim() != string.Empty)
            {
                if (txtPassword.Text.Trim() == txtConfrimPassword.Text.Trim())
                {
                    User.AddGroup = chbAddGroup.Checked;
                    User.AddLesson = chbAddLesson.Checked;
                    User.AddSelected = chbAddSelected.Checked;
                    User.AddStudent = ChbAddStudent.Checked;
                    User.AddTeacher = chbAddTeacher.Checked;
                    User.AddUser = chbAddUser.Checked;
                    User.Answer = txtAnswer.Text.Trim();
                    User.DeleteGroup = chbDeleteGroup.Checked;
                    User.DeleteLesson = chbDeleteLesson.Checked;
                    User.DeleteSelected = chbDeleteSelected.Checked;
                    User.DeleteStudent = chbDeleteStudent.Checked;
                    User.DeleteTeacher = chbDeleteTeacher.Checked;
                    User.DeleteUser = chbDeleteUser.Checked;
                    User.Id = (cmbQuestio.SelectedIndex+1).ToString();
                    User.Name = txtName.Text.Trim();
                    User.Password = txtPassword.Text.Trim();
                    User.Show = chbShow.Checked;
                    User.UpdateLesson = chbUpdateLesson.Checked;
                    User.UpdateSelected = chbUpdateSelected.Checked; ;
                    User.UpdateStudent = chbUpdateStudent.Checked;
                    User.UpdateTeacher = chbUpdateTeacher.Checked;
                    User.UserName = txtUserName.Text.Trim();
                    if (SelectedPicture == true)
                    {
                        img = Image.FromFile(Open.FileName);
                        imgFormat = PicUser.BackgroundImage.RawFormat;
                    }
                    else
                    {
                        img = Image.FromFile(Application.StartupPath + @"\Default-User.jpg");
                        imgFormat = ImageFormat.Jpeg;
                    }
                    MS = new MemoryStream();
                    img.Save(MS, imgFormat);
                    byte[] Array = MS.GetBuffer();
                    User.Picture = Array;
                    if (User._AddUser() == true)
                        FarsiMessageBox.MessageBox.Show("موفقیت", "کاربر جدید ایجاد شد.", FarsiMessageBox.MessageBox.Buttons.OK, FarsiMessageBox.MessageBox.Icons.Information);
                }
                else
                    FarsiMessageBox.MessageBox.Show("خطا", "رمز ورود یکسان می باشد.", FarsiMessageBox.MessageBox.Buttons.OK, FarsiMessageBox.MessageBox.Icons.Error);
            }
            else
                FarsiMessageBox.MessageBox.Show("خطا", "لطفا همه مقادیر را وارد نمایید.", FarsiMessageBox.MessageBox.Buttons.OK, FarsiMessageBox.MessageBox.Icons.Error);
        }

        private void chbAll_CheckedChanged(object sender, EventArgs e)
        {
            if (chbAll.Text == "انتخاب همه")
                chbAll.Text = "لغو همه";
            else
                chbAll.Text = "انتخاب همه";
            chbAddGroup.Checked = chbAll.Checked;
            chbAddLesson.Checked = chbAll.Checked;
            chbAddSelected.Checked = chbAll.Checked;
            ChbAddStudent.Checked = chbAll.Checked;
            chbAddTeacher.Checked = chbAll.Checked;
            chbAddUser.Checked = chbAll.Checked;
            chbDeleteGroup.Checked = chbAll.Checked;
            chbDeleteLesson.Checked = chbAll.Checked;
            chbDeleteSelected.Checked = chbAll.Checked;
            chbDeleteStudent.Checked = chbAll.Checked;
            chbDeleteTeacher.Checked = chbAll.Checked;
            chbDeleteUser.Checked = chbAll.Checked;
            chbShow.Checked = chbAll.Checked;
            chbUpdateLesson.Checked = chbAll.Checked;
            chbUpdateSelected.Checked = chbAll.Checked;
            chbUpdateStudent.Checked = chbAll.Checked;
            chbUpdateTeacher.Checked = chbAll.Checked;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtAnswer.Text = "";
            txtConfrimPassword.Text = "";
            txtName.Text = "";
            txtPassword.Text = "";
            txtPicture.Text = "";
            txtUserName.Text = "";
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
            chbAll.Checked = false;
            cmbQuestio.SelectedIndex = 0;
            PicUser.BackgroundImage = Bitmap.FromFile(Application.StartupPath + @"\Default-User.jpg");
            txtPicture.Focus();
            SelectedPicture = false;
        }

        private void txtPicture_TextChanged(object sender, EventArgs e)
        {
            if(File.Exists(txtPicture.Text.Trim()))
            {
                SelectedPicture=true;
                PicUser.BackgroundImage=Bitmap.FromFile(txtPicture.Text);
            }
            else
            {
                SelectedPicture=false;
                PicUser.BackgroundImage = Bitmap.FromFile(Application.StartupPath + @"\Default-User.jpg");
            }
        }        
    }
}
