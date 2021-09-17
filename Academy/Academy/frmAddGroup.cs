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
    public partial class frmAddGroup : Form
    {
        public frmAddGroup()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (txtGroupName.Text.Trim() != string.Empty)
            {
                Group.GroupName = txtGroupName.Text.Trim();
                if(Group._AddGroup()==true)
                    FarsiMessageBox.MessageBox.Show("موفقیت", "گروه درسی با موفقیت اضافه شد.", FarsiMessageBox.MessageBox.Buttons.OK, FarsiMessageBox.MessageBox.Icons.Information);
            }
            else
                FarsiMessageBox.MessageBox.Show("خطا", "لطفا نام گروه درسی را وارد نمایید.", FarsiMessageBox.MessageBox.Buttons.OK, FarsiMessageBox.MessageBox.Icons.Error);
        }

        private void frmAddGroup_Load(object sender, EventArgs e)
        {
            skinEngine1.SkinFile = Application.StartupPath + @"\Skin\" + Registry.GetValue(@"HKEY_CURRENT_USER\Software\LearnFiles.com", "Skin", "").ToString() + ".ssk";
            skinEngine1.Active = true;
        }
    }
}
