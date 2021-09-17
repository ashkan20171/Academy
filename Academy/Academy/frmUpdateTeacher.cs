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
    public partial class frmUpdateTeacher : Form
    {
        public frmUpdateTeacher()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (Teacher._Search(txtIdCard1.Text.Trim()) == true)
            {
                frmAddTeacher UpTeacher = new frmAddTeacher();
                UpTeacher.Update = true;
                this.Hide();
                UpTeacher.ShowDialog();
            }
        }
    }
}
