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
    public partial class frmUpdateSelected : Form
    {
        public frmUpdateSelected()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (txtId.Text.Trim() != string.Empty)
            {
                if (Selected._SearchSelected(txtId.Text.Trim()) == true)
                {
                    frmAddSelected upSelected = new frmAddSelected();
                    upSelected.Update = true;
                    upSelected.ShowDialog();

                }
            }
            else
                FarsiMessageBox.MessageBox.Show("خطا", "لطفا شناسه درس اخذ شده را وارد نمایید.", FarsiMessageBox.MessageBox.Buttons.OK, FarsiMessageBox.MessageBox.Icons.Error);
        }
    }
}
