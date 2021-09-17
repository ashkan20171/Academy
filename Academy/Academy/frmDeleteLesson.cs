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
    public partial class frmDeleteLesson : Form
    {
        public frmDeleteLesson()
        {
            InitializeComponent();
        }

        private void frmDeleteLesson_Load(object sender, EventArgs e)
        {
            cmbLessonId.DataSource = Lesson._AllLessonId();
            cmbLessonId.DisplayMember = "LessonId";
            cmbLessonId.SelectedIndex = 0;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (Lesson._DeleteLesson(cmbLessonId.Text) == true)
            {
                FarsiMessageBox.MessageBox.Show("موفقیت", "درس با موفقیت حذف شد.", FarsiMessageBox.MessageBox.Buttons.OK, FarsiMessageBox.MessageBox.Icons.Information);
                frmDeleteLesson_Load(null, null);
            }
        }
    }
}
