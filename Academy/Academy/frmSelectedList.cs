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
    public partial class frmSelectedList : Form
    {
        public frmSelectedList()
        {
            InitializeComponent();
        }

        private void frmSelectedList_Load(object sender, EventArgs e)
        {
            DataTable dd = new DataTable();
            dd = Selected._AllSelected();
            if (dd.Rows.Count > 0)
            {
                dgvSelected.DataSource = dd;
                dgvSelected.Columns["IdCard1"].HeaderText = "شماره ملی هنرجو";
                dgvSelected.Columns["LessonId"].HeaderText = "شناسه درس";
                dgvSelected.Columns["Date"].HeaderText = "تاریخ";
                dgvSelected.Columns["Id"].HeaderText = "شناسه";
                dgvSelected.Columns["IdCard1"].Width = 300;
                dgvSelected.Columns["LessonId"].Width = 200;
                dgvSelected.Columns["Date"].Width = 150;
                for (int i = 0; i < dd.Rows.Count; i++)
                    dgvSelected["Date", i].Value = Selected.MiladiToShamsi(Convert.ToDateTime(dgvSelected["Date", i].Value.ToString()));
            }
            else
                dgvSelected.DataSource = null;
        }
    }
}
