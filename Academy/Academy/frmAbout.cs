using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace Academy
{
    public partial class frmAbout : Form
    {
        public frmAbout()
        {
            InitializeComponent();
        }

        private void frmAbout_Load(object sender, EventArgs e)
        {
            try
            {
                lblDiscription.Text = Registry.GetValue(@"HKEY_CURRENT_USER\Software\LearnFiles.com", "Discription", "").ToString();
                lblFax.Text = Registry.GetValue(@"HKEY_CURRENT_USER\Software\LearnFiles.com", "Fax", "").ToString();
                lblTell.Text = Registry.GetValue(@"HKEY_CURRENT_USER\Software\LearnFiles.com", "Tell", "").ToString();
                lblName.Text = Registry.GetValue(@"HKEY_CURRENT_USER\Software\LearnFiles.com", "Name", "").ToString();
            }
            catch
            {
                FarsiMessageBox.MessageBox.Show("خطا", "تنظیماتی وجود ندارد.از صفحه تنظیمات اشتفاده کنید.", FarsiMessageBox.MessageBox.Buttons.OK, FarsiMessageBox.MessageBox.Icons.Error);
                this.Close();
            }
        }
    }
}
