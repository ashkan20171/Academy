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
    public partial class frmAllPecunari : Form
    {
        public frmAllPecunari()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            int sum = 0;
            DGVPecuniary.DataSource = Pecunary._Search(Pecunary.ShamsiToMiladi( mtxtFrom.Text),Pecunary.ShamsiToMiladi( mtxtTo.Text));
            DGVPecuniary.Columns["PaidType"].HeaderText = "نوع پرداختی";
            DGVPecuniary.Columns["BankName"].HeaderText = "نام بانک";
            DGVPecuniary.Columns["Bakch"].HeaderText = "نام شعبه";
            DGVPecuniary.Columns["Mony"].HeaderText = "مبلغ";
            DGVPecuniary.Columns["Date"].HeaderText = "تاربخ";
            DGVPecuniary.Columns["Seril"].HeaderText = "سریال فیش";
            DGVPecuniary.Columns["Id"].Visible = false;
            DGVPecuniary.Columns["IdPec"].Visible = false;
            for (int i = 0; i < DGVPecuniary.Rows.Count; i++)
            {
                DGVPecuniary["Date", i].Value = Pecunary.MiladiToShamsi(Convert.ToDateTime(DGVPecuniary["Date", i].Value.ToString()));
                sum += Convert.ToInt32(DGVPecuniary["Mony", i].Value.ToString());
            }
            DGVPecuniary.Visible = true;
            lblSum.Text = sum.ToString();
        }
    }
}
