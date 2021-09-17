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
    public partial class frmRecoveryPassword : Form
    {
        public frmRecoveryPassword()
        {
            InitializeComponent();
        }

        private void frmRecoveryPassword_Load(object sender, EventArgs e)
        {
            lblQuestion.Text = Login.Question;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (txtAnswer.Text.Trim() == string.Empty)
                FarsiMessageBox.MessageBox.Show("خطا", "لطفا پاسخ را وارد نمایید.", FarsiMessageBox.MessageBox.Buttons.OK, FarsiMessageBox.MessageBox.Icons.Error);
            else
                if(txtAnswer.Text.Trim()==Login.Answer)
                    FarsiMessageBox.MessageBox.Show("موفقیت", "رمز ورود شما  :  "+Login.Password, FarsiMessageBox.MessageBox.Buttons.OK, FarsiMessageBox.MessageBox.Icons.Information);
                else
                    FarsiMessageBox.MessageBox.Show("خطا", "پاسخ شما اشتباه است.", FarsiMessageBox.MessageBox.Buttons.OK, FarsiMessageBox.MessageBox.Icons.Error);
        }
    }
}
