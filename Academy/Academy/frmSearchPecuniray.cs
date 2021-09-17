using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Academy
{
    public partial class frmSearchPecuniray : Form
    {
        public frmSearchPecuniray()
        {
            InitializeComponent();
        }
        string Type = "Debtor";
        private void frmSearchPecuniray_Load(object sender, EventArgs e)
        {
            dgvPecuniary.Columns.Add("IdCard1", "شماره ملی هنرجو");
            dgvPecuniary.Columns.Add("Picture", "Picture");
            dgvPecuniary.Columns["IdCard1"].Width = 180;
        }

        private void rdbDebtor_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbDebtor.Checked == true)
                Type = "Debtor";
        }

        private void rdbCreditor_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbCreditor.Checked == true)
                Type = "Creditor";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvPecuniary.DataSource = Pecunary._SearchPec(Type);
            if (dgvPecuniary.Rows.Count > 0)
            {
                dgvPecuniary.Visible = true;
                dgvPecuniary.Columns["Id"].Visible = false;
                dgvPecuniary.Columns["Discription"].Visible = false;
                dgvPecuniary.Columns["Salary"].Visible = false;
                dgvPecuniary.Columns["Paid"].Visible = false;
                dgvPecuniary.Columns["Picture"].Visible = false;
                dgvPecuniary.Columns["Creditor"].HeaderText = "بستانکاری";
                dgvPecuniary.Columns["Debtor"].HeaderText = "بدهکاری";
                if(Type=="Debtor")
                    dgvPecuniary.Columns["Creditor"].Visible = false;
                else
                    dgvPecuniary.Columns["Debtor"].Visible = false;
                for (int i = 0; i < dgvPecuniary.Rows.Count; i++)
                {
                    dgvPecuniary["IdCard1", i].Value = Pecunary._SearchIdCard1(dgvPecuniary["Id", i].Value.ToString());
                    dgvPecuniary["Picture", i].Value = Pecunary._SearchPicture(dgvPecuniary["IdCard1", i].Value.ToString());
                }
            }
            else
            {
                dgvPecuniary.Visible = false;
                if(picStudent.BackgroundImage!=null)
                    picStudent.BackgroundImage = null;
            }
        }

        private void dgvPecuniary_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            byte[] Array = (byte[])dgvPecuniary["Picture", dgvPecuniary.CurrentRow.Index].Value;
            MemoryStream MS = new MemoryStream(Array);
            picStudent.BackgroundImage = Image.FromStream(MS);
            
        }
    }
}
