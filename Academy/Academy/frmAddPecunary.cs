using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Academy
{
    public partial class frmAddPecunary : Form
    {
        public frmAddPecunary()
        {
            InitializeComponent();
        }

        public static  int _Mony, _Debtor, _Creditor, _Paid;
        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            if (txtIdCard1.Text.Trim() != string.Empty)
            {
                DataTable dd = new DataTable();
                dd=Pecunary._AllSelected(txtIdCard1.Text);
                if (dd.Rows.Count > 0)
                {
                    DGVSelected.DataSource = dd;
                    DGVSelected.Visible = true;
                    DGVSelected.Columns["Id"].Visible = false;
                    DGVSelected.Columns["LessonId"].Visible = false;
                    DGVSelected.Columns["IdCard1"].Visible = false ;
                    DGVSelected.Columns["Date"].HeaderText = "تاریخ اخذ";
                    DGVSelected.Columns["Date"].Width = 300;
                    DGVSelected.Columns["LessonName"].Width = 300;
                    for (int i = 0; i < dd.Rows.Count; i++)
                    {
                        DGVSelected["Date", i].Value = Pecunary.MiladiToShamsi(Convert.ToDateTime(DGVSelected["Date", i].Value.ToString()));
                        DGVSelected["LessonName",i].Value=Pecunary._SearchLessonName(DGVSelected["LessonId",i].Value.ToString());
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
            DGVPecuniary.DataSource = Pecunary._SearchPecunary(DGVSelected["Id", DGVSelected.CurrentRow.Index].Value.ToString());
            DGVPecuniary.Columns["Id"].Visible = false;
            DGVPecuniary.Columns["Debtor"].HeaderText = "بدهکاری";
            DGVPecuniary.Columns["Creditor"].HeaderText = "بستانکاری";
            DGVPecuniary.Columns["Discription"].HeaderText = "توضیحات";
            DGVPecuniary.Columns["Paid"].HeaderText = "پرداخت شده";
            DGVPecuniary.Columns["Salary"].HeaderText = "شهریه";
            DGVPecuniary.Columns["Discription"].Width = 200;
            DGVPecuniary.Visible = true;
        }

        private void DGVPecuniary_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            grpPaidInformation.Enabled = true;
            btnOk.Enabled = true;
        }

        private void rdbPec_CheckedChanged(object sender, EventArgs e)
        {
            grpPec.Enabled = rdbPec.Checked;
        }

        private void rdbBank_CheckedChanged(object sender, EventArgs e)
        {
            grpBank.Enabled = rdbBank.Checked;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (rdbBank.Checked == true)
            {
                Pecunary.BanchName = txtBanch.Text.Trim();
                Pecunary.BankName = txtBankName.Text.Trim();
                Pecunary.Serial = txtSerial.Text.Trim();
                Pecunary.Mony =Convert.ToInt32( txtMony.Text.Trim());
                Pecunary.Date = Pecunary.ShamsiToMiladi(mtxtDate.Text);
                Pecunary.Discription = txtDiscription.Text.Trim();
                Pecunary.PaidType = "فیش بانکی";
                PaidSalary();
            }
            else
            {
                Pecunary.BanchName = "";
                Pecunary.BankName = "";
                Pecunary.Serial = "";
                Pecunary.Mony = Convert.ToInt32(txtMony2.Text.Trim());
                Pecunary.Date = Pecunary.ShamsiToMiladi(mtxtDate2.Text);
                Pecunary.Discription = txtDiscription.Text.Trim();
                Pecunary.PaidType = "نقدی";
                PaidSalary();
            }
        }

        private  void PaidSalary()
        {
            _Debtor = Convert.ToInt32(DGVPecuniary["Debtor", 0].Value.ToString());
            _Creditor = Convert.ToInt32(DGVPecuniary["Creditor", 0].Value.ToString());
            _Paid = Pecunary.Mony;
            if (_Debtor <= 0)
            {
                Pecunary.Debtor = 0;
                Pecunary.Creditor = _Creditor + _Paid;
            }
            else
            {
                Pecunary.Debtor = _Debtor - _Paid;
                if (_Debtor < 0)
                {
                    Pecunary.Creditor = _Creditor -_Debtor;
                    Pecunary.Debtor = 0;
                }
            }
            Pecunary.Paid = Convert.ToInt32(DGVPecuniary["Paid", 0].Value.ToString()) + _Paid;
            string Id = DGVPecuniary["Id", 0].Value.ToString();
            Pecunary.Id = Id;
            if (Pecunary._AddPecunary() == true)
            {
                Pecunary._UpdatePecuniary(Id);
                FarsiMessageBox.MessageBox.Show("موفقیت", "پرداخت شهریه با موفقیت انجام شد.", FarsiMessageBox.MessageBox.Buttons.OK, FarsiMessageBox.MessageBox.Icons.Information);
                DGVSelected_CellClick(null, null);
            }
            else
            {
                FarsiMessageBox.MessageBox.Show("خطا", "خطا در پرداخت شهریه", FarsiMessageBox.MessageBox.Buttons.OK, FarsiMessageBox.MessageBox.Icons.Error);
            }
        }

        private void frmAddPecunary_Load(object sender, EventArgs e)
        {
            DGVSelected.Columns.Add("LessonName", "نام درس");
        }

    }
}
