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
    public partial class frmDeleteGroup : Form
    {
        public frmDeleteGroup()
        {
            InitializeComponent();
        }

        private void frmDeleteGroup_Load(object sender, EventArgs e)
        {
            cmbGroupName.DataSource = Group._All();
            cmbGroupName.DisplayMember = "GroupName";
            cmbGroupName.SelectedIndex = 0;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (Group._DeleteGroup(cmbGroupName.Text) == true)
            {
                FarsiMessageBox.MessageBox.Show("موفقیت", "گروه درسی با موفقیت حذف شد.", FarsiMessageBox.MessageBox.Buttons.OK, FarsiMessageBox.MessageBox.Icons.Information);
                frmDeleteGroup_Load(null, null);
            }
        }
    }
}
