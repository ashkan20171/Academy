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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void picExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            if (txtUserName.Text.Trim() != string.Empty && txtPassword.Text.Trim() != string.Empty)
            {
                Login.UserName = txtUserName.Text.Trim();
                Login.Password = txtPassword.Text.Trim();
                if (Login.Search() == true)
                {
                    frmMain Main = new frmMain();
                    Main.Show();
                    this.Hide();
                }
            }
            else
                FarsiMessageBox.MessageBox.Show("خطا", "لطفا مقادیر نام کاربری و رمز ورود را وارد نمایید.", FarsiMessageBox.MessageBox.Buttons.OK, FarsiMessageBox.MessageBox.Icons.Error);
            this.Cursor = Cursors.Default;
        }

        private void llblForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            if (txtUserName.Text.Trim() == string.Empty)
                FarsiMessageBox.MessageBox.Show("خطا", "لطفا نام کاربری را وارد نمایید.", FarsiMessageBox.MessageBox.Buttons.OK, FarsiMessageBox.MessageBox.Icons.Error);
            else
            {
                Login.UserName = txtUserName.Text.Trim();
                if (Login.RecoveryPassword() == true)
                {
                    frmRecoveryPassword Recovery = new frmRecoveryPassword();
                    Recovery.ShowDialog();
                }
            }
            this.Cursor = Cursors.Default;
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
