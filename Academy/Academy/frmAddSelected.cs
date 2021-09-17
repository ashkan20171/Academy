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
    public partial class frmAddSelected : Form
    {
        public frmAddSelected()
        {
            InitializeComponent();
        }
        public new bool Update = false;
        private void btnOk_Click(object sender, EventArgs e)
        {
            if (txtIdCard1.Text.Trim() != string.Empty && txtLessonId.Text.Trim() != string.Empty && mtxtDate.Text != string.Empty)
            {
                if (Selected._SearchLessonId(txtLessonId.Text) == true)
                {
                    if (Selected._SearchIdCard1(txtIdCard1.Text) == true)
                    {
                        if (Update == false)
                        {
                            Selected.Date = Selected.ShamsiToMiladi(mtxtDate.Text);
                            Selected.IdCard1 = txtIdCard1.Text.Trim();
                            Selected.LeesonId = txtLessonId.Text.Trim();
                            if (Selected._AddSelected() == true)
                            {
                                if (Selected._AddPecunary() == true)
                                {
                                    FarsiMessageBox.MessageBox.Show("موفقیت", "درس با موفقیت اخذ شد.", FarsiMessageBox.MessageBox.Buttons.OK, FarsiMessageBox.MessageBox.Icons.Information);
                                }
                            }
                        }

                        else
                        {
                            Selected.Date = Selected.ShamsiToMiladi(mtxtDate.Text);
                            Selected.IdCard1 = txtIdCard1.Text.Trim();
                            Selected.LeesonId = txtLessonId.Text.Trim();
                            if (Selected._UpdateSelected() == true)
                                FarsiMessageBox.MessageBox.Show("موفقیت", "درس اخذ شده با موفقیت ویرایش شد.", FarsiMessageBox.MessageBox.Buttons.OK, FarsiMessageBox.MessageBox.Icons.Information);
                        }

                    }
                }

            }
            else
                FarsiMessageBox.MessageBox.Show("خطا", "لطفا همه مقادیر را وارد نمایید.", FarsiMessageBox.MessageBox.Buttons.OK, FarsiMessageBox.MessageBox.Icons.Error);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtIdCard1.Text = "";
            txtLessonId.Text = "";
            mtxtDate.Text = "";
            txtIdCard1.Focus();
        }

        private void frmAddSelected_Load(object sender, EventArgs e)
        {
            if (Update == true)
            {
                txtIdCard1.Text = Selected.IdCard1;
                txtLessonId.Text = Selected.LeesonId;
                mtxtDate.Text = Selected.MiladiToShamsi(Convert.ToDateTime(Selected.Date));
                this.Text = "ویرایش درس اخذ شده";
                txtLessonId.Focus();
            }
        }
    }
}
