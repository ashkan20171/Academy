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
    public partial class frmDeletePecunari : Form
    {
        public frmDeletePecunari()
        {
            InitializeComponent();
        }
        
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtIdCard1.Text.Trim() != string.Empty)
            {
                DataTable dd = new DataTable();
                dd = Pecunary._AllSelected(txtIdCard1.Text);
                if (dd.Rows.Count > 0)
                {
                    DGVSelected.DataSource = dd;
                    DGVSelected.Visible = true;
                    DGVSelected.Columns["Id"].Visible = false;
                    DGVSelected.Columns["LessonId"].Visible = false;
                    DGVSelected.Columns["IdCard1"].Visible = false;
                    DGVSelected.Columns["Date"].HeaderText = "تاریخ اخذ";
                    DGVSelected.Columns["Date"].Width = 300;
                    DGVSelected.Columns["LessonName"].Width = 300;
                    for (int i = 0; i < dd.Rows.Count; i++)
                    {
                        DGVSelected["Date", i].Value = Pecunary.MiladiToShamsi(Convert.ToDateTime(DGVSelected["Date", i].Value.ToString()));
                        DGVSelected["LessonName", i].Value = Pecunary._SearchLessonName(DGVSelected["LessonId", i].Value.ToString());
                    }

                }
                else
                {
                    DGVSelected.DataSource = null;
                    DGVSelected.Visible = false;
                    FarsiMessageBox.MessageBox.Show("خطا", "این هنرجو درسی را اخذ نکرده است.", FarsiMessageBox.MessageBox.Buttons.OK, FarsiMessageBox.MessageBox.Icons.Error);
                }
            }
            else
                FarsiMessageBox.MessageBox.Show("خطا", "شماره ملی هنرجو را وارد کنید", FarsiMessageBox.MessageBox.Buttons.OK, FarsiMessageBox.MessageBox.Icons.Error);
        }

        private void DGVSelected_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DGVPecuniary.DataSource = Pecunary._SearchAllPecunary(DGVSelected["Id", DGVSelected.CurrentRow.Index].Value.ToString());
            DGVPecuniary.Columns["PaidType"].HeaderText = "نوع پرداختی";
            DGVPecuniary.Columns["BankName"].HeaderText = "نام بانک";
            DGVPecuniary.Columns["Bakch"].HeaderText = "نام شعبه";
            DGVPecuniary.Columns["Mony"].HeaderText = "مبلغ";
            DGVPecuniary.Columns["Date"].HeaderText = "تاربخ";
            DGVPecuniary.Columns["Seril"].HeaderText = "سریال فیش";
            DGVPecuniary.Columns["Id"].Visible = false;
            DGVPecuniary.Columns["IdPec"].Visible = false;
            DGVPecuniary.Visible = true;

        }

        private void DGVPecuniary_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnDelete.Enabled = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string _Id = DGVSelected["Id", DGVSelected.CurrentRow.Index].Value.ToString();
            DataTable dd = new DataTable();
            dd = Pecunary._SearchPecunary(_Id);
            int Mony = Convert.ToInt32(DGVPecuniary["Mony", DGVPecuniary.CurrentRow.Index].Value.ToString());
            int Creditor = Convert.ToInt32(dd.Rows[0]["Creditor"].ToString());
            int Debort = Convert.ToInt32(dd.Rows[0]["Debtor"].ToString());
            int Paid = Convert.ToInt32(dd.Rows[0]["Paid"].ToString());
            if (Creditor > 0)
            {
                Pecunary.Creditor = Creditor - Mony;
                Pecunary.Paid = Paid - Mony;
                if (Pecunary.Creditor < 0)
                {
                    Pecunary.Debtor = Pecunary.Creditor * (-1);
                    Pecunary.Creditor = 0;
                }
            }
            else
            {
                Pecunary.Debtor = Debort + Mony;
                Pecunary.Paid = Paid - Mony;
            }
            Pecunary._UpdatePecuniary(_Id);
            Pecunary._Delete(DGVPecuniary["IdPec", DGVPecuniary.CurrentRow.Index].Value.ToString());
            DGVPecuniary.Rows.Remove(DGVPecuniary.CurrentRow);
        }

        private void frmDeletePecunari_Load(object sender, EventArgs e)
        {
            DGVSelected.Columns.Add("LessonName", "نام درس");
        }
    }
}
