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
    public partial class frmSetting : Form
    {
        public frmSetting()
        {
            InitializeComponent();
        }

        private void frmSetting_Load(object sender, EventArgs e)
        {
            cmbSkin.Items.Add("پیش فرض");
            for (int i = 1; i < 60; i++)
                cmbSkin.Items.Add("Hamid ("+i+")");
            try
            {
                txtDiscription.Text = Registry.GetValue(@"HKEY_CURRENT_USER\Software\LearnFiles.com", "Discription", "").ToString();
                txtFax.Text = Registry.GetValue(@"HKEY_CURRENT_USER\Software\LearnFiles.com", "Fax", "").ToString();
                txtTell.Text = Registry.GetValue(@"HKEY_CURRENT_USER\Software\LearnFiles.com", "Tell", "").ToString();
                txtName.Text = Registry.GetValue(@"HKEY_CURRENT_USER\Software\LearnFiles.com", "Name", "").ToString();
                cmbSkin.Text = Registry.GetValue(@"HKEY_CURRENT_USER\Software\LearnFiles.com", "Skin", "").ToString();
            }

            catch
            {
                Registry.SetValue(@"HKEY_CURRENT_USER\Software\LearnFiles.com", "Discription", "");
                Registry.SetValue(@"HKEY_CURRENT_USER\Software\LearnFiles.com", "Fax", "");
                Registry.SetValue(@"HKEY_CURRENT_USER\Software\LearnFiles.com", "Tell", "");
                Registry.SetValue(@"HKEY_CURRENT_USER\Software\LearnFiles.com", "Name", "");
                Registry.SetValue(@"HKEY_CURRENT_USER\Software\LearnFiles.com", "Skin", "");
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Registry.SetValue(@"HKEY_CURRENT_USER\Software\LearnFiles.com", "Discription", txtDiscription.Text);
            Registry.SetValue(@"HKEY_CURRENT_USER\Software\LearnFiles.com", "Fax", txtFax.Text);
            Registry.SetValue(@"HKEY_CURRENT_USER\Software\LearnFiles.com", "Tell", txtTell.Text);
            Registry.SetValue(@"HKEY_CURRENT_USER\Software\LearnFiles.com", "Name", txtName.Text);
            Registry.SetValue(@"HKEY_CURRENT_USER\Software\LearnFiles.com", "Skin", cmbSkin.Text);
            FarsiMessageBox.MessageBox.Show("موفقیت", "تنظیمات با موفقیت ذخیره شد.", FarsiMessageBox.MessageBox.Buttons.OK, FarsiMessageBox.MessageBox.Icons.Information);
        }

        private void cmbSkin_SelectedIndexChanged(object sender, EventArgs e)
        {
            skinEngine1.SkinFile = Application.StartupPath + @"\Skin\"+cmbSkin.Text+".ssk";
            skinEngine1.Active = true;
        }
    }
}
