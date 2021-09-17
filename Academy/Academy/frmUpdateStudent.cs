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
    public partial class frmUpdateStudent : Form
    {
        public frmUpdateStudent()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (Student._Search(txtIdCard1.Text.Trim()) == true)
            {
                frmAddStudent UpStudent = new frmAddStudent();
                UpStudent.Update = true;
                this.Hide();
                UpStudent.ShowDialog();
            }
        }
    }
}
