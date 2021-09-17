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
using System.Drawing.Imaging;
namespace Academy
{
    public partial class frmAddTeacher : Form
    {
        public frmAddTeacher()
        {
            InitializeComponent();
        }
        OpenFileDialog Open;
        MemoryStream MS;
        ImageFormat imgFormat;
        Image img;
        bool SelectedPicture = false;
        public new bool Update = false;
        string OldIdCard1 = "";
        private void btnBrows_Click(object sender, EventArgs e)
        {
            Open = new OpenFileDialog();
            Open.Filter = "All picture files |*.jpg;*.png;*.bmp";
            if (Open.ShowDialog() == DialogResult.OK)
            {
                SelectedPicture = true;
                PicTeacher.BackgroundImage = Bitmap.FromFile(Open.FileName);
                txtPicture.Text = Open.FileName;
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Trim() != string.Empty && txtFatherName.Text.Trim() != string.Empty && txtIdCard1.Text.Trim() != string.Empty && txtIdCard2.Text.Trim() != string.Empty)
            {
                if (Update == false)
                {
                    Teacher.TeacherName = txtName.Text.Trim();
                    Teacher.FatherName = txtFatherName.Text.Trim();
                    Teacher.Sex = cmbSex.Text;
                    Teacher.IdCard1 = txtIdCard1.Text.Trim();
                    Teacher.IdCard2 = txtIdCard2.Text.Trim();
                    Teacher.Tell = txtTell.Text.Trim();
                    Teacher.Mobile = txtMobile.Text.Trim();
                    Teacher.Address = txtAddresss.Text.Trim();
                    Teacher.Discription = txtDiscription.Text.Trim();
                    Teacher.Study = cmbStudy.Text;
                    Teacher.Date =Teacher.ShamsiToMiladi( mtxtDate.Text);
                    if (SelectedPicture == true)
                    {
                        img = Image.FromFile(Open.FileName);
                        imgFormat = PicTeacher.BackgroundImage.RawFormat;
                    }
                    else
                    {
                        if (cmbSex.SelectedIndex == 0)
                            img = Image.FromFile(Application.StartupPath + @"\Default-Teacher-Women.jpg");
                        else
                            img = Image.FromFile(Application.StartupPath + @"\Default-Teacher-Men.jpg");
                        imgFormat = ImageFormat.Jpeg;
                    }
                    MS = new MemoryStream();
                    img.Save(MS, imgFormat);
                    byte[] Array = MS.GetBuffer();
                    Teacher.Picture = Array;
                    if (Teacher._AddTeacher() == true)
                        FarsiMessageBox.MessageBox.Show("موفقیت", "مربی با موفقیت استخدام شد.", FarsiMessageBox.MessageBox.Buttons.OK, FarsiMessageBox.MessageBox.Icons.Information);
                }
                else
                {
                    Teacher.TeacherName = txtName.Text.Trim();
                    Teacher.FatherName = txtFatherName.Text.Trim();
                    Teacher.Sex = cmbSex.Text;
                    Teacher.IdCard1 = txtIdCard1.Text.Trim();
                    Teacher.IdCard2 = txtIdCard2.Text.Trim();
                    Teacher.Tell = txtTell.Text.Trim();
                    Teacher.Mobile = txtMobile.Text.Trim();
                    Teacher.Address = txtAddresss.Text.Trim();
                    Teacher.Discription = txtDiscription.Text.Trim();
                    Teacher.Study = cmbStudy.Text;
                    Teacher.Date = Teacher.ShamsiToMiladi(mtxtDate.Text);
                    if (SelectedPicture == true)
                    {
                        img = Image.FromFile(Open.FileName);
                        imgFormat = PicTeacher.BackgroundImage.RawFormat;
                    }
                    else
                    {
                        if (cmbSex.SelectedIndex == 0)
                            img = Image.FromFile(Application.StartupPath + @"\Default-Teacher-Women.jpg");
                        else
                            img = Image.FromFile(Application.StartupPath + @"\Default-Teacher-Men.jpg");
                        imgFormat = ImageFormat.Jpeg;
                    }
                    MS = new MemoryStream();
                    img.Save(MS, imgFormat);
                    byte[] Array = MS.GetBuffer();
                    Teacher.Picture = Array;
                    if (Teacher._UpdateTeacher(OldIdCard1) == true)
                        FarsiMessageBox.MessageBox.Show("موفقیت", "مربی  با موفقیت ویرایش شد.", FarsiMessageBox.MessageBox.Buttons.OK, FarsiMessageBox.MessageBox.Icons.Information);
                }
            }
            else
                FarsiMessageBox.MessageBox.Show("خطا", "لطفا همه مقادیر را وارد نمایید.", FarsiMessageBox.MessageBox.Buttons.OK, FarsiMessageBox.MessageBox.Icons.Error);
        }

        private void cmbSex_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SelectedPicture == false)
            {
                if (cmbSex.SelectedIndex == 0)
                    PicTeacher.BackgroundImage = Bitmap.FromFile(Application.StartupPath + @"\Default-Teacher-Women.jpg");
                else
                    PicTeacher.BackgroundImage = Bitmap.FromFile(Application.StartupPath + @"\Default-Teacher-Men.jpg");
            }
        }

        private void frmAddTeacher_Load(object sender, EventArgs e)
        {
            if (Update == true)
            {
                SelectedPicture = true;
                cmbSex.Items.Add("زن");
                cmbSex.Items.Add("مرد");
                cmbSex.SelectedIndex = 0;
                OldIdCard1 = Teacher.IdCard1;
                txtAddresss.Text = Teacher.Address;
                txtDiscription.Text = Teacher.Discription;
                txtFatherName.Text = Teacher.FatherName;
                txtIdCard1.Text = Teacher.IdCard1;
                txtIdCard2.Text = Teacher.IdCard2;
                txtMobile.Text = Teacher.Mobile;
                txtName.Text = Teacher.TeacherName;
                txtTell.Text = Teacher.Tell;
                mtxtDate.Text =Teacher.MiladiToShamsi(Convert.ToDateTime(Teacher.Date)).ToString();
                cmbStudy.Text = Teacher.Study;
                byte[] Array = Teacher.Picture;
                MS = new MemoryStream(Array);
                PicTeacher.BackgroundImage = Image.FromStream(MS);
                if (Teacher.Sex == "زن")
                    cmbSex.SelectedIndex = 0;
                else
                    cmbSex.SelectedIndex = 1;
                cmbStudy.DataSource = Teacher._AllStudy();
                cmbStudy.DisplayMember = "Study";
                cmbStudy.Text = Teacher.Study;
                SelectedPicture = false;
                btnClear.Enabled = false;
            }
            else
            {
                PicTeacher.BackgroundImage = Bitmap.FromFile(Application.StartupPath + @"\Default-Teacher-Women.jpg");
                cmbSex.Items.Add("زن");
                cmbSex.Items.Add("مرد");
                cmbSex.SelectedIndex = 0;
                btnClear.Enabled = true;
                cmbStudy.DataSource = Teacher._AllStudy();
                cmbStudy.DisplayMember = "Study";
                cmbStudy.SelectedIndex = 0;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtAddresss.Text = "";
            txtDiscription.Text = "";
            txtFatherName.Text = "";
            txtIdCard1.Text = "";
            txtIdCard2.Text = "";
            txtMobile.Text = "";
            txtName.Text = "";
            txtPicture.Text = "";
            txtTell.Text = "";
            mtxtDate.Text = "";
            cmbStudy.SelectedIndex = 0;
            txtPicture.Focus();
            SelectedPicture = false;
            PicTeacher.BackgroundImage = Bitmap.FromFile(Application.StartupPath + @"\Default-Teacher-Women.jpg");
        }

        private void txtTell_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar <= '9' && e.KeyChar >= '0' || e.KeyChar == '\b')
                e.Handled = false;
            else
                e.Handled = true;
        }

    }
}