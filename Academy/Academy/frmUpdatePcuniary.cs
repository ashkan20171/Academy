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
    public partial class frmUpdatePcuniary : Form
    {
        public frmUpdatePcuniary()
        {
            InitializeComponent();
        }
        static int Paid, Debtor, Creditor, Mony;
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
                    DGVSelected.Columns.Add("LessonName", "نام درس");
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
            DGVPecuniary.Columns["Id"].Visible = false;
            DGVPecuniary.Columns["IdPec"].Visible = false;
            DGVPecuniary.Columns["PaidType"].HeaderText = "نوع پرداخت";
            DGVPecuniary.Columns["Mony"].HeaderText = "مبلغ";
            DGVPecuniary.Columns["Date"].HeaderText = "تاریخ";
            DGVPecuniary.Columns["BankName"].HeaderText = "نام بانک";
            DGVPecuniary.Columns["Bakch"].HeaderText = "نام شعبه";
            DGVPecuniary.Columns["Seril"].HeaderText = "سریال فیش";
            for (int i = 0; i < DGVPecuniary.Rows.Count; i++)
                DGVPecuniary["Date", i].Value = Pecunary.MiladiToShamsi(Convert.ToDateTime(DGVPecuniary["Date", i].Value.ToString()));
            DGVPecuniary.Visible = true;
        }

        private void rdbPec_CheckedChanged(object sender, EventArgs e)
        {
            grpPec.Enabled = rdbPec.Checked;
        }

        private void rdbBank_CheckedChanged(object sender, EventArgs e)
        {
            grpBank.Enabled = rdbBank.Checked;
        }

        private void DGVPecuniary_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DGVPecuniary["PaidType", DGVPecuniary.CurrentRow.Index].Value.ToString() == "نقدی")
            {
                rdbPec.Checked = false;
                rdbPec.Checked = true;
                txtMony2.Text = DGVPecuniary["Mony", DGVPecuniary.CurrentRow.Index].Value.ToString();
                //mtxtDate2.Text = DGVPecuniary["Date", DGVPecuniary.CurrentRow.Index].Value.ToString();
                string o = DGVPecuniary["Date", DGVPecuniary.CurrentRow.Index].Value.ToString();
                string[] p = o.Split('/');
                mtxtDate2.Text = p[2].Substring(0, p[2].IndexOf(' ')) + Convert.ToInt32(p[0]).ToString("00") + Convert.ToInt32(p[1]).ToString("00");
                txtSerial.Text = "";
                txtMony.Text = "";
                txtBankName.Text = "";
                txtBanch.Text = "";
                mtxtDate.Text = "";
                txtMony2.Focus();
            }
            else
            {
                rdbBank.Checked = true;
                txtMony2.Text = "";
                mtxtDate2.Text = "";
                string o = DGVPecuniary["Date", DGVPecuniary.CurrentRow.Index].Value.ToString();
                string[] p = o.Split('/');
                mtxtDate.Text = p[2].Substring(0, p[2].IndexOf(' ')) + Convert.ToInt32(p[0]).ToString("00") + Convert.ToInt32(p[1]).ToString("00");
                txtSerial.Text = DGVPecuniary["Seril", DGVPecuniary.CurrentRow.Index].Value.ToString();
                txtMony.Text = DGVPecuniary["Mony", DGVPecuniary.CurrentRow.Index].Value.ToString();
                txtBankName.Text = DGVPecuniary["BankName", DGVPecuniary.CurrentRow.Index].Value.ToString();
                txtBanch.Text = DGVPecuniary["Bakch", DGVPecuniary.CurrentRow.Index].Value.ToString();
                txtMony.Focus();
            }

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            DataTable dd = new DataTable();
            dd = Pecunary._SearchPecunary(DGVSelected["Id", DGVSelected.CurrentRow.Index].Value.ToString());
            Debtor = Convert.ToInt32(dd.Rows[0]["Debtor"].ToString());
            Creditor = Convert.ToInt32(dd.Rows[0]["Creditor"].ToString());
            Paid = Convert.ToInt32(dd.Rows[0]["Paid"].ToString());
            Mony = Convert.ToInt32(DGVPecuniary["Mony", DGVPecuniary.CurrentRow.Index].Value.ToString());

            if (Creditor > 0)
            {
                Pecunary.Creditor = Creditor + Mony;
                Pecunary.Paid = Paid + Mony;
                if (Pecunary.Creditor < 0)
                {
                    Pecunary.Debtor = Pecunary.Creditor * (-1);
                    Pecunary.Creditor = 0;
                }
            }
            else
            {
                Pecunary.Debtor = Debtor + Mony;
                Pecunary.Paid = Paid - Mony;
            }

            if (rdbBank.Checked == true)
            {
                Pecunary.Mony = Convert.ToInt32(txtMony.Text);
                Pecunary.BankName = txtBankName.Text.Trim();
                Pecunary.BanchName = txtBanch.Text.Trim();
                Pecunary.Date = Pecunary.ShamsiToMiladi(mtxtDate.Text);
                Pecunary.Serial = txtSerial.Text.Trim();
            }
            else
            {
                Pecunary.Mony = Convert.ToInt32(txtMony2.Text);
                Pecunary.Date = Pecunary.ShamsiToMiladi(mtxtDate2.Text);
            }
            Pecunary.Discription = dd.Rows[0]["Discription"].ToString();
            Pecunary.Id = DGVSelected["Id", DGVSelected.CurrentRow.Index].Value.ToString();
            Pecunary._UpdatePecuniary(DGVSelected["Id", DGVSelected.CurrentRow.Index].Value.ToString());
            Pecunary._Delete(DGVPecuniary["IdPec",DGVPecuniary.CurrentRow.Index].Value.ToString());

            if (rdbBank.Checked == true)
            {
                if (txtBankName.Text.Trim() == "" && txtMony.Text.Trim() == "" && txtSerial.Text.Trim() == "" && txtSerial.Text.Trim() == "")
                   FarsiMessageBox.MessageBox.Show("خطا", "لطفا تمامی مقادیر را وارد نمایید", FarsiMessageBox.MessageBox.Buttons.OK, FarsiMessageBox.MessageBox.Icons.Error);
                else
                    UpdateSalary();
            }
            else
            {
                if (txtMony2.Text.Trim() == "")
                    FarsiMessageBox.MessageBox.Show("خطا", "لطفا تمامی مقادیر را وارد نمایید", FarsiMessageBox.MessageBox.Buttons.OK, FarsiMessageBox.MessageBox.Icons.Error);
                else
                    UpdateSalary();
            }


        }

        private void UpdateSalary()
        {
            DataTable dd = new DataTable();
            dd = Pecunary._SearchPecunary(DGVSelected["Id", DGVSelected.CurrentRow.Index].Value.ToString());
            Mony = Pecunary.Mony;
            Debtor = Convert.ToInt32(dd.Rows[0]["Debtor"].ToString());
            Creditor = Convert.ToInt32(dd.Rows[0]["Creditor"].ToString());
            if (Debtor <= 0)
            {
                Pecunary.Debtor = 0;
                Pecunary.Creditor = Creditor + Mony;
            }
            else
            {
                Pecunary.Debtor = Debtor - Mony;
                if (Pecunary.Debtor < 0)
                {
                    Pecunary.Creditor = Creditor - Pecunary.Debtor;
                    Pecunary.Debtor = 0;
                }
            }
            Pecunary.Paid = Convert.ToInt32(dd.Rows[0]["Paid"].ToString()) + Mony;
            Pecunary.Id = DGVSelected["Id", DGVSelected.CurrentRow.Index].Value.ToString();
            if (Pecunary._AddPecunary() == true)
            {
                Pecunary._UpdatePecuniary(DGVSelected["Id",DGVSelected.CurrentRow.Index].Value.ToString());
                DGVSelected_CellClick(null, null);
                FarsiMessageBox.MessageBox.Show("موفقیت", "به روز رسانی شهریه با موفقیت انجام شد", FarsiMessageBox.MessageBox.Buttons.OK, FarsiMessageBox.MessageBox.Icons.Information);
            }
            else
            {
                FarsiMessageBox.MessageBox.Show("خطا", "خطا در به روز رسانی شهریه", FarsiMessageBox.MessageBox.Buttons.OK, FarsiMessageBox.MessageBox.Icons.Error);
            }
        }
    }
}
