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
    public partial class frmDeleteSelected : Form
    {
        public frmDeleteSelected()
        {
            InitializeComponent();
        }

        private void dgvSelected_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnDelete.Enabled = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string _Id=dgvSelected["Id",dgvSelected.CurrentRow.Index].Value.ToString();
            //if(Selected._DeletePecunary(_Id)==true)
                if (Selected._DeleteSelected(_Id) == true)
                {
                    FarsiMessageBox.MessageBox.Show("موفقیت", "درس اخذ شده حذف شد.", FarsiMessageBox.MessageBox.Buttons.OK, FarsiMessageBox.MessageBox.Icons.Information);
                    frmDeleteSelected_Load(null, null);
                }
        }

        private void frmDeleteSelected_Load(object sender, EventArgs e)
        {
            btnDelete.Enabled = false;
            DataTable dd = new DataTable();
            dd = Selected._AllSelected();
            if (dd.Rows.Count > 0)
            {
                dgvSelected.DataSource = dd;
                dgvSelected.Columns["Id"].Visible = false;
                dgvSelected.Columns["IdCard1"].HeaderText = "شماره ملی هنرجو";
                dgvSelected.Columns["LessonId"].HeaderText = "شناسه درس";
                dgvSelected.Columns["Date"].HeaderText = "تاریخ";
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
