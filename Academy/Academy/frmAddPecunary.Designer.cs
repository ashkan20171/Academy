namespace Academy
{
    partial class frmAddPecunary
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grpPecuniary = new System.Windows.Forms.GroupBox();
            this.DGVPecuniary = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBankName = new System.Windows.Forms.TextBox();
            this.txtMony = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.txtDiscription = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBanch = new System.Windows.Forms.TextBox();
            this.txtMony2 = new System.Windows.Forms.TextBox();
            this.grpPaidInformation = new System.Windows.Forms.GroupBox();
            this.grpBank = new System.Windows.Forms.GroupBox();
            this.mtxtDate = new System.Windows.Forms.MaskedTextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.txtSerial = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.rdbBank = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.grpPec = new System.Windows.Forms.GroupBox();
            this.mtxtDate2 = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.rdbPec = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.grpSelectedList = new System.Windows.Forms.GroupBox();
            this.DGVSelected = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtIdCard1 = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.grpPecuniary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVPecuniary)).BeginInit();
            this.grpPaidInformation.SuspendLayout();
            this.grpBank.SuspendLayout();
            this.grpPec.SuspendLayout();
            this.grpSelectedList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVSelected)).BeginInit();
            this.SuspendLayout();
            // 
            // grpPecuniary
            // 
            this.grpPecuniary.Controls.Add(this.DGVPecuniary);
            this.grpPecuniary.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.grpPecuniary.Location = new System.Drawing.Point(10, 201);
            this.grpPecuniary.Name = "grpPecuniary";
            this.grpPecuniary.Size = new System.Drawing.Size(716, 94);
            this.grpPecuniary.TabIndex = 75;
            this.grpPecuniary.TabStop = false;
            this.grpPecuniary.Text = "وضعیت مالی";
            // 
            // DGVPecuniary
            // 
            this.DGVPecuniary.AllowUserToAddRows = false;
            this.DGVPecuniary.AllowUserToDeleteRows = false;
            this.DGVPecuniary.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.DGVPecuniary.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVPecuniary.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVPecuniary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVPecuniary.Location = new System.Drawing.Point(11, 29);
            this.DGVPecuniary.MultiSelect = false;
            this.DGVPecuniary.Name = "DGVPecuniary";
            this.DGVPecuniary.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVPecuniary.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGVPecuniary.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVPecuniary.Size = new System.Drawing.Size(690, 55);
            this.DGVPecuniary.TabIndex = 5;
            this.DGVPecuniary.Visible = false;
            this.DGVPecuniary.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVPecuniary_CellClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label7.Location = new System.Drawing.Point(16, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 16);
            this.label7.TabIndex = 78;
            this.label7.Text = "تومان";
            // 
            // txtBankName
            // 
            this.txtBankName.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtBankName.Location = new System.Drawing.Point(16, 70);
            this.txtBankName.MaxLength = 50;
            this.txtBankName.Name = "txtBankName";
            this.txtBankName.Size = new System.Drawing.Size(168, 23);
            this.txtBankName.TabIndex = 17;
            // 
            // txtMony
            // 
            this.txtMony.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtMony.Location = new System.Drawing.Point(58, 29);
            this.txtMony.MaxLength = 50;
            this.txtMony.Name = "txtMony";
            this.txtMony.Size = new System.Drawing.Size(126, 23);
            this.txtMony.TabIndex = 16;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label24.Location = new System.Drawing.Point(211, 197);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(113, 16);
            this.label24.TabIndex = 73;
            this.label24.Text = "شماره سریال فیش";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label32.Location = new System.Drawing.Point(282, 157);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(34, 16);
            this.label32.TabIndex = 29;
            this.label32.Text = "تاریخ";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label34.Location = new System.Drawing.Point(266, 116);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(59, 16);
            this.label34.TabIndex = 26;
            this.label34.Text = "نام شعبه";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label36.Location = new System.Drawing.Point(265, 74);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(53, 16);
            this.label36.TabIndex = 23;
            this.label36.Text = "نام بانک";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label38.Location = new System.Drawing.Point(287, 32);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(33, 16);
            this.label38.TabIndex = 20;
            this.label38.Text = "مبلغ";
            // 
            // txtDiscription
            // 
            this.txtDiscription.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtDiscription.Location = new System.Drawing.Point(365, 188);
            this.txtDiscription.MaxLength = 200;
            this.txtDiscription.Multiline = true;
            this.txtDiscription.Name = "txtDiscription";
            this.txtDiscription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDiscription.Size = new System.Drawing.Size(263, 108);
            this.txtDiscription.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.Location = new System.Drawing.Point(644, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 16);
            this.label4.TabIndex = 80;
            this.label4.Text = "توضیحات";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label6.Location = new System.Drawing.Point(6, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 16);
            this.label6.TabIndex = 76;
            this.label6.Text = "تومان";
            // 
            // txtBanch
            // 
            this.txtBanch.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtBanch.Location = new System.Drawing.Point(16, 112);
            this.txtBanch.MaxLength = 50;
            this.txtBanch.Name = "txtBanch";
            this.txtBanch.Size = new System.Drawing.Size(168, 23);
            this.txtBanch.TabIndex = 18;
            // 
            // txtMony2
            // 
            this.txtMony2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtMony2.Location = new System.Drawing.Point(51, 29);
            this.txtMony2.MaxLength = 50;
            this.txtMony2.Name = "txtMony2";
            this.txtMony2.Size = new System.Drawing.Size(133, 23);
            this.txtMony2.TabIndex = 9;
            // 
            // grpPaidInformation
            // 
            this.grpPaidInformation.Controls.Add(this.grpBank);
            this.grpPaidInformation.Controls.Add(this.rdbBank);
            this.grpPaidInformation.Controls.Add(this.txtDiscription);
            this.grpPaidInformation.Controls.Add(this.label1);
            this.grpPaidInformation.Controls.Add(this.grpPec);
            this.grpPaidInformation.Controls.Add(this.label4);
            this.grpPaidInformation.Controls.Add(this.rdbPec);
            this.grpPaidInformation.Controls.Add(this.label2);
            this.grpPaidInformation.Controls.Add(this.label3);
            this.grpPaidInformation.Enabled = false;
            this.grpPaidInformation.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.grpPaidInformation.Location = new System.Drawing.Point(9, 301);
            this.grpPaidInformation.Name = "grpPaidInformation";
            this.grpPaidInformation.Size = new System.Drawing.Size(721, 305);
            this.grpPaidInformation.TabIndex = 76;
            this.grpPaidInformation.TabStop = false;
            this.grpPaidInformation.Text = "اطلاعات پرداخت";
            // 
            // grpBank
            // 
            this.grpBank.Controls.Add(this.mtxtDate);
            this.grpBank.Controls.Add(this.label7);
            this.grpBank.Controls.Add(this.txtBanch);
            this.grpBank.Controls.Add(this.txtBankName);
            this.grpBank.Controls.Add(this.txtMony);
            this.grpBank.Controls.Add(this.label22);
            this.grpBank.Controls.Add(this.txtSerial);
            this.grpBank.Controls.Add(this.label23);
            this.grpBank.Controls.Add(this.label24);
            this.grpBank.Controls.Add(this.label31);
            this.grpBank.Controls.Add(this.label32);
            this.grpBank.Controls.Add(this.label33);
            this.grpBank.Controls.Add(this.label34);
            this.grpBank.Controls.Add(this.label35);
            this.grpBank.Controls.Add(this.label36);
            this.grpBank.Controls.Add(this.label37);
            this.grpBank.Controls.Add(this.label38);
            this.grpBank.Enabled = false;
            this.grpBank.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.grpBank.Location = new System.Drawing.Point(12, 57);
            this.grpBank.Name = "grpBank";
            this.grpBank.Size = new System.Drawing.Size(337, 239);
            this.grpBank.TabIndex = 16;
            this.grpBank.TabStop = false;
            this.grpBank.Text = "اطلاعات پرداخت";
            // 
            // mtxtDate
            // 
            this.mtxtDate.Location = new System.Drawing.Point(16, 154);
            this.mtxtDate.Mask = "0000/00/00";
            this.mtxtDate.Name = "mtxtDate";
            this.mtxtDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mtxtDate.Size = new System.Drawing.Size(168, 23);
            this.mtxtDate.TabIndex = 77;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label22.ForeColor = System.Drawing.Color.Red;
            this.label22.Location = new System.Drawing.Point(522, 283);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(14, 18);
            this.label22.TabIndex = 75;
            this.label22.Text = "*";
            // 
            // txtSerial
            // 
            this.txtSerial.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtSerial.Location = new System.Drawing.Point(16, 195);
            this.txtSerial.MaxLength = 50;
            this.txtSerial.Name = "txtSerial";
            this.txtSerial.Size = new System.Drawing.Size(168, 23);
            this.txtSerial.TabIndex = 20;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label23.Location = new System.Drawing.Point(186, 197);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(15, 24);
            this.label23.TabIndex = 74;
            this.label23.Text = ":";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label31.Location = new System.Drawing.Point(186, 157);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(13, 20);
            this.label31.TabIndex = 30;
            this.label31.Text = ":";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label33.Location = new System.Drawing.Point(186, 115);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(13, 20);
            this.label33.TabIndex = 27;
            this.label33.Text = ":";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label35.Location = new System.Drawing.Point(186, 74);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(13, 20);
            this.label35.TabIndex = 24;
            this.label35.Text = ":";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label37.Location = new System.Drawing.Point(186, 32);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(13, 20);
            this.label37.TabIndex = 21;
            this.label37.Text = ":";
            // 
            // rdbBank
            // 
            this.rdbBank.AutoSize = true;
            this.rdbBank.Location = new System.Drawing.Point(277, 25);
            this.rdbBank.Name = "rdbBank";
            this.rdbBank.Size = new System.Drawing.Size(89, 20);
            this.rdbBank.TabIndex = 8;
            this.rdbBank.Text = "فیش بانکی";
            this.rdbBank.UseVisualStyleBackColor = true;
            this.rdbBank.CheckedChanged += new System.EventHandler(this.rdbBank_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(632, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 20);
            this.label1.TabIndex = 81;
            this.label1.Text = ":";
            // 
            // grpPec
            // 
            this.grpPec.Controls.Add(this.mtxtDate2);
            this.grpPec.Controls.Add(this.label6);
            this.grpPec.Controls.Add(this.txtMony2);
            this.grpPec.Controls.Add(this.label5);
            this.grpPec.Controls.Add(this.label11);
            this.grpPec.Controls.Add(this.label12);
            this.grpPec.Controls.Add(this.label19);
            this.grpPec.Controls.Add(this.label25);
            this.grpPec.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.grpPec.Location = new System.Drawing.Point(365, 57);
            this.grpPec.Name = "grpPec";
            this.grpPec.Size = new System.Drawing.Size(337, 114);
            this.grpPec.TabIndex = 8;
            this.grpPec.TabStop = false;
            this.grpPec.Text = "اطلاعات پرداخت";
            // 
            // mtxtDate2
            // 
            this.mtxtDate2.Location = new System.Drawing.Point(52, 76);
            this.mtxtDate2.Mask = "0000/00/00";
            this.mtxtDate2.Name = "mtxtDate2";
            this.mtxtDate2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mtxtDate2.Size = new System.Drawing.Size(130, 23);
            this.mtxtDate2.TabIndex = 77;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(522, 283);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 18);
            this.label5.TabIndex = 75;
            this.label5.Text = "*";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label11.Location = new System.Drawing.Point(186, 72);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(13, 20);
            this.label11.TabIndex = 30;
            this.label11.Text = ":";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label12.Location = new System.Drawing.Point(282, 72);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(34, 16);
            this.label12.TabIndex = 29;
            this.label12.Text = "تاریخ";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label19.Location = new System.Drawing.Point(186, 32);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(13, 20);
            this.label19.TabIndex = 21;
            this.label19.Text = ":";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label25.Location = new System.Drawing.Point(287, 32);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(33, 16);
            this.label25.TabIndex = 20;
            this.label25.Text = "مبلغ";
            // 
            // rdbPec
            // 
            this.rdbPec.AutoSize = true;
            this.rdbPec.Checked = true;
            this.rdbPec.Location = new System.Drawing.Point(519, 25);
            this.rdbPec.Name = "rdbPec";
            this.rdbPec.Size = new System.Drawing.Size(55, 20);
            this.rdbPec.TabIndex = 7;
            this.rdbPec.TabStop = true;
            this.rdbPec.Text = "نقدی";
            this.rdbPec.UseVisualStyleBackColor = true;
            this.rdbPec.CheckedChanged += new System.EventHandler(this.rdbPec_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(585, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 24);
            this.label2.TabIndex = 18;
            this.label2.Text = ":";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(631, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "نوع پرداخت";
            // 
            // grpSelectedList
            // 
            this.grpSelectedList.Controls.Add(this.DGVSelected);
            this.grpSelectedList.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.grpSelectedList.Location = new System.Drawing.Point(9, 44);
            this.grpSelectedList.Name = "grpSelectedList";
            this.grpSelectedList.Size = new System.Drawing.Size(716, 151);
            this.grpSelectedList.TabIndex = 74;
            this.grpSelectedList.TabStop = false;
            this.grpSelectedList.Text = "لیست دروس اخذ شده توسط این هنرجو";
            // 
            // DGVSelected
            // 
            this.DGVSelected.AllowUserToAddRows = false;
            this.DGVSelected.AllowUserToDeleteRows = false;
            this.DGVSelected.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.DGVSelected.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVSelected.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DGVSelected.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVSelected.DefaultCellStyle = dataGridViewCellStyle4;
            this.DGVSelected.Location = new System.Drawing.Point(12, 29);
            this.DGVSelected.MultiSelect = false;
            this.DGVSelected.Name = "DGVSelected";
            this.DGVSelected.ReadOnly = true;
            this.DGVSelected.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVSelected.Size = new System.Drawing.Size(690, 116);
            this.DGVSelected.TabIndex = 3;
            this.DGVSelected.Visible = false;
            this.DGVSelected.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVSelected_CellClick);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnSearch.Location = new System.Drawing.Point(345, 9);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 32);
            this.btnSearch.TabIndex = 73;
            this.btnSearch.Text = "جستجو";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click_1);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label13.Location = new System.Drawing.Point(624, 15);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(115, 16);
            this.label13.TabIndex = 77;
            this.label13.Text = "شماره ملی هنر جو";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label9.Location = new System.Drawing.Point(596, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(15, 24);
            this.label9.TabIndex = 78;
            this.label9.Text = ":";
            // 
            // txtIdCard1
            // 
            this.txtIdCard1.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.txtIdCard1.Location = new System.Drawing.Point(426, 13);
            this.txtIdCard1.MaxLength = 10;
            this.txtIdCard1.Name = "txtIdCard1";
            this.txtIdCard1.Size = new System.Drawing.Size(168, 23);
            this.txtIdCard1.TabIndex = 72;
            // 
            // btnOk
            // 
            this.btnOk.Enabled = false;
            this.btnOk.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnOk.Location = new System.Drawing.Point(317, 612);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(85, 32);
            this.btnOk.TabIndex = 80;
            this.btnOk.Text = "تائید";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // frmAddPecunary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 650);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.grpPecuniary);
            this.Controls.Add(this.grpPaidInformation);
            this.Controls.Add(this.grpSelectedList);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtIdCard1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddPecunary";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "پرداخت شهریه";
            this.Load += new System.EventHandler(this.frmAddPecunary_Load);
            this.grpPecuniary.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVPecuniary)).EndInit();
            this.grpPaidInformation.ResumeLayout(false);
            this.grpPaidInformation.PerformLayout();
            this.grpBank.ResumeLayout(false);
            this.grpBank.PerformLayout();
            this.grpPec.ResumeLayout(false);
            this.grpPec.PerformLayout();
            this.grpSelectedList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVSelected)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpPecuniary;
        private System.Windows.Forms.DataGridView DGVPecuniary;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBankName;
        private System.Windows.Forms.TextBox txtMony;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.TextBox txtDiscription;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBanch;
        private System.Windows.Forms.TextBox txtMony2;
        private System.Windows.Forms.GroupBox grpPaidInformation;
        private System.Windows.Forms.GroupBox grpBank;
        private System.Windows.Forms.MaskedTextBox mtxtDate;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtSerial;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.RadioButton rdbBank;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpPec;
        private System.Windows.Forms.MaskedTextBox mtxtDate2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.RadioButton rdbPec;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox grpSelectedList;
        private System.Windows.Forms.DataGridView DGVSelected;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtIdCard1;
        private System.Windows.Forms.Button btnOk;
    }
}