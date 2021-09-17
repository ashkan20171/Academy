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
    public partial class frmUpdateLesson : Form
    {
        public frmUpdateLesson()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (txtLessonId.Text.Trim() != string.Empty)
            {
                if(Lesson._SearchLessonId(txtLessonId.Text.Trim())==true)
                {
                    frmAddLesson upLesson = new frmAddLesson();
                    upLesson.Update = true;
                    this.Hide();
                    upLesson.ShowDialog();
                }
            }
            else
                FarsiMessageBox.MessageBox.Show("خطا", "لطفا شناسه درس را وارد کنید.", FarsiMessageBox.MessageBox.Buttons.OK, FarsiMessageBox.MessageBox.Icons.Error);
        }
    }
}
