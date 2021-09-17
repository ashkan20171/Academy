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
    public partial class frmSearchSelected : Form
    {
        public frmSearchSelected()
        {
            InitializeComponent();
        }
        string st = "Desc";
        private void rdbMax_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbMax.Checked == true)
                st = "Desc";
        }

        private void rdbMin_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbMin.Checked == true)
                st = "Asc";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvSelected.DataSource = Selected._SearchSe(st);
            if (dgvSelected.Rows.Count > 0)
            {
                dgvSelected.Visible = true;
                dgvSelected.Columns.Add("Name", "نام هنرجو");
                for(int i=0;i<dgvSelected.Rows.Count;i++)
                    dgvSelected["Name",i].Value=Selected._SearchStName(dgvSelected["IDCARD1",i].Value.ToString());
                dgvSelected.Columns["IDCARD1"].HeaderText = "شماره ملی هنرجو";
                dgvSelected.Columns["COUNT"].HeaderText = "تعداد تقاضا";
                dgvSelected.Columns["IDCARD1"].Width = 150;
                dgvSelected.Columns["COUNT"].Width = 150;
            }
            else
                dgvSelected.Visible = false;
        }
    }
}
