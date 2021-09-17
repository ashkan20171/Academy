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
    public partial class frmAddStudent : Form
    {
        public frmAddStudent()
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
        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBrows_Click(object sender, EventArgs e)
        {
            Open = new OpenFileDialog();
            Open.Filter = "All picture files |*.jpg;*.png;*.bmp";
            if (Open.ShowDialog() == DialogResult.OK)
            {
                SelectedPicture = true;
                PicStudent.BackgroundImage = Bitmap.FromFile(Open.FileName);
                txtPicture.Text = Open.FileName;
            }
        }

        private void txtPicture_TextChanged(object sender, EventArgs e)
        {
            if (File.Exists(txtPicture.Text.Trim()))
            {
                SelectedPicture = true;
                PicStudent.BackgroundImage = Bitmap.FromFile(txtPicture.Text);
            }
            else
            {
                SelectedPicture = false;
                PicStudent.BackgroundImage = Bitmap.FromFile(Application.StartupPath + @"\Default-User.jpg");
            }
        }

        private void frmAddStudent_Load(object sender, EventArgs e)
        {
            if (Update == true)
            {
                SelectedPicture = true;
                cmbSex.Items.Add("زن");
                cmbSex.Items.Add("مرد");
                cmbSex.SelectedIndex = 0;
                OldIdCard1 = Student.IdCard1;
                txtAddresss.Text = Student.Address;
                txtDiscription.Text = Student.Discription;
                txtFatherName.Text = Student.FatherName;
                txtIdCard1.Text = Student.IdCard1;
                txtIdCard2.Text = Student.IdCard2;
                txtMobile.Text = Student.Mobile;
                txtName.Text = Student.StudentName;
                txtTell.Text = Student.Tell;
                byte[] Array = Student.Picture;
                MS = new MemoryStream(Array);
                PicStudent.BackgroundImage = Image.FromStream(MS);
                if (Student.Sex == "زن")
                    cmbSex.SelectedIndex = 0;
                else
                    cmbSex.SelectedIndex = 1;
                SelectedPicture = false;
                btnClear.Enabled = false;
            }
            else
            {
                PicStudent.BackgroundImage = Bitmap.FromFile(Application.StartupPath + @"\Default-Student-Women.jpg");
                cmbSex.Items.Add("زن");
                cmbSex.Items.Add("مرد");
                cmbSex.SelectedIndex = 0;
                btnClear.Enabled = true;
            }
        }

        private void cmbSex_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SelectedPicture == false)
            {
                if(cmbSex.SelectedIndex==0)
                    PicStudent.BackgroundImage = Bitmap.FromFile(Application.StartupPath + @"\Default-Student-Women.jpg");
                else
                    PicStudent.BackgroundImage = Bitmap.FromFile(Application.StartupPath + @"\Default-Student-Men.jpg");
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Trim() != string.Empty && txtFatherName.Text.Trim() != string.Empty && txtIdCard1.Text.Trim() != string.Empty && txtIdCard2.Text.Trim() != string.Empty)
            {
                if (Update == false)
                {
                    Student.StudentName = txtName.Text.Trim();
                    Student.FatherName = txtFatherName.Text.Trim();
                    Student.Sex = cmbSex.Text;
                    Student.IdCard1 = txtIdCard1.Text.Trim();
                    Student.IdCard2 = txtIdCard2.Text.Trim();
                    Student.Tell = txtTell.Text.Trim();
                    Student.Mobile = txtMobile.Text.Trim();
                    Student.Address = txtAddresss.Text.Trim();
                    Student.Discription = txtDiscription.Text.Trim();
                    if (SelectedPicture == true)
                    {
                        img = Image.FromFile(Open.FileName);
                        imgFormat = PicStudent.BackgroundImage.RawFormat;
                    }
                    else
                    {
                        if (cmbSex.SelectedIndex == 0)
                            img = Image.FromFile(Application.StartupPath + @"\Default-Student-Women.jpg");
                        else
                            img = Image.FromFile(Application.StartupPath + @"\Default-Student-Men.jpg");
                        imgFormat = ImageFormat.Jpeg;
                    }
                    MS = new MemoryStream();
                    img.Save(MS, imgFormat);
                    byte[] Array = MS.GetBuffer();
                    Student.Picture = Array;
                    if (Student._AddStudent() == true)
                        FarsiMessageBox.MessageBox.Show("موفقیت", "هنرجو با موفقیت ثبت نام شد.", FarsiMessageBox.MessageBox.Buttons.OK, FarsiMessageBox.MessageBox.Icons.Information);
                }
                else
                {
                    Student.StudentName = txtName.Text.Trim();
                    Student.FatherName = txtFatherName.Text.Trim();
                    Student.Sex = cmbSex.Text;
                    Student.IdCard1 = txtIdCard1.Text.Trim();
                    Student.IdCard2 = txtIdCard2.Text.Trim();
                    Student.Tell = txtTell.Text.Trim();
                    Student.Mobile = txtMobile.Text.Trim();
                    Student.Address = txtAddresss.Text.Trim();
                    Student.Discription = txtDiscription.Text.Trim();
                    if (SelectedPicture == true)
                    {
                        img = Image.FromFile(Open.FileName);
                        imgFormat = PicStudent.BackgroundImage.RawFormat;
                    }
                    else
                    {
                        if (cmbSex.SelectedIndex == 0)
                            img = Image.FromFile(Application.StartupPath + @"\Default-Student-Women.jpg");
                        else
                            img = Image.FromFile(Application.StartupPath + @"\Default-Student-Men.jpg");
                        imgFormat = ImageFormat.Jpeg;
                    }
                    MS = new MemoryStream();
                    img.Save(MS, imgFormat);
                    byte[] Array = MS.GetBuffer();
                    Student.Picture = Array;
                    if (Student._UpdateStudent(OldIdCard1) == true)
                        FarsiMessageBox.MessageBox.Show("موفقیت", "هنرجو با موفقیت ویرایش شد.", FarsiMessageBox.MessageBox.Buttons.OK, FarsiMessageBox.MessageBox.Icons.Information);
                }
            }
            else
                FarsiMessageBox.MessageBox.Show("خطا", "لطفا همه مقادیر را وارد نمایید.", FarsiMessageBox.MessageBox.Buttons.OK, FarsiMessageBox.MessageBox.Icons.Error);
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
            txtPicture.Focus();
            SelectedPicture = false;
            PicStudent.BackgroundImage = Bitmap.FromFile(Application.StartupPath + @"\Default-Student-Women.jpg");
        }

        private void txtIdCard1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar <= '9' && e.KeyChar >= '0' || e.KeyChar == '\b')
                e.Handled = false;
            else
                e.Handled = true;
        }
    }
}
