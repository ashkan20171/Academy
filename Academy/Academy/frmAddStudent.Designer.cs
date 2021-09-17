namespace Academy
{
    partial class frmAddStudent
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
            this.grbStudent = new System.Windows.Forms.GroupBox();
            this.btnBrows = new System.Windows.Forms.Button();
            this.cmbSex = new System.Windows.Forms.ComboBox();
            this.txtDiscription = new System.Windows.Forms.TextBox();
            this.txtAddresss = new System.Windows.Forms.TextBox();
            this.txtMobile = new System.Windows.Forms.TextBox();
            this.txtIdCard2 = new System.Windows.Forms.TextBox();
            this.txtTell = new System.Windows.Forms.TextBox();
            this.txtIdCard1 = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtFatherName = new System.Windows.Forms.TextBox();
            this.txtPicture = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grbPicStudent = new System.Windows.Forms.GroupBox();
            this.PicStudent = new System.Windows.Forms.PictureBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.grbStudent.SuspendLayout();
            this.grbPicStudent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // grbStudent
            // 
            this.grbStudent.Controls.Add(this.btnBrows);
            this.grbStudent.Controls.Add(this.cmbSex);
            this.grbStudent.Controls.Add(this.txtDiscription);
            this.grbStudent.Controls.Add(this.txtAddresss);
            this.grbStudent.Controls.Add(this.txtMobile);
            this.grbStudent.Controls.Add(this.txtIdCard2);
            this.grbStudent.Controls.Add(this.txtTell);
            this.grbStudent.Controls.Add(this.txtIdCard1);
            this.grbStudent.Controls.Add(this.txtName);
            this.grbStudent.Controls.Add(this.txtFatherName);
            this.grbStudent.Controls.Add(this.txtPicture);
            this.grbStudent.Controls.Add(this.label10);
            this.grbStudent.Controls.Add(this.label6);
            this.grbStudent.Controls.Add(this.label5);
            this.grbStudent.Controls.Add(this.label4);
            this.grbStudent.Controls.Add(this.label9);
            this.grbStudent.Controls.Add(this.label8);
            this.grbStudent.Controls.Add(this.label7);
            this.grbStudent.Controls.Add(this.label3);
            this.grbStudent.Controls.Add(this.label2);
            this.grbStudent.Controls.Add(this.label1);
            this.grbStudent.Controls.Add(this.grbPicStudent);
            this.grbStudent.Location = new System.Drawing.Point(12, 12);
            this.grbStudent.Name = "grbStudent";
            this.grbStudent.Size = new System.Drawing.Size(823, 239);
            this.grbStudent.TabIndex = 0;
            this.grbStudent.TabStop = false;
            this.grbStudent.Text = "اطلاعات هنرجو";
            // 
            // btnBrows
            // 
            this.btnBrows.Location = new System.Drawing.Point(150, 19);
            this.btnBrows.Name = "btnBrows";
            this.btnBrows.Size = new System.Drawing.Size(102, 32);
            this.btnBrows.TabIndex = 2;
            this.btnBrows.Text = "انتخاب عکس";
            this.btnBrows.UseVisualStyleBackColor = true;
            this.btnBrows.Click += new System.EventHandler(this.btnBrows_Click);
            // 
            // cmbSex
            // 
            this.cmbSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSex.FormattingEnabled = true;
            this.cmbSex.Location = new System.Drawing.Point(183, 82);
            this.cmbSex.Name = "cmbSex";
            this.cmbSex.Size = new System.Drawing.Size(198, 24);
            this.cmbSex.TabIndex = 5;
            this.cmbSex.SelectedIndexChanged += new System.EventHandler(this.cmbSex_SelectedIndexChanged);
            // 
            // txtDiscription
            // 
            this.txtDiscription.Location = new System.Drawing.Point(14, 204);
            this.txtDiscription.Name = "txtDiscription";
            this.txtDiscription.Size = new System.Drawing.Size(687, 23);
            this.txtDiscription.TabIndex = 11;
            // 
            // txtAddresss
            // 
            this.txtAddresss.Location = new System.Drawing.Point(14, 175);
            this.txtAddresss.Name = "txtAddresss";
            this.txtAddresss.Size = new System.Drawing.Size(687, 23);
            this.txtAddresss.TabIndex = 10;
            // 
            // txtMobile
            // 
            this.txtMobile.Location = new System.Drawing.Point(183, 141);
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Size = new System.Drawing.Size(198, 23);
            this.txtMobile.TabIndex = 9;
            this.txtMobile.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdCard1_KeyPress);
            // 
            // txtIdCard2
            // 
            this.txtIdCard2.Location = new System.Drawing.Point(183, 112);
            this.txtIdCard2.Name = "txtIdCard2";
            this.txtIdCard2.Size = new System.Drawing.Size(198, 23);
            this.txtIdCard2.TabIndex = 7;
            this.txtIdCard2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdCard1_KeyPress);
            // 
            // txtTell
            // 
            this.txtTell.Location = new System.Drawing.Point(503, 142);
            this.txtTell.Name = "txtTell";
            this.txtTell.Size = new System.Drawing.Size(198, 23);
            this.txtTell.TabIndex = 8;
            this.txtTell.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdCard1_KeyPress);
            // 
            // txtIdCard1
            // 
            this.txtIdCard1.Location = new System.Drawing.Point(503, 109);
            this.txtIdCard1.Name = "txtIdCard1";
            this.txtIdCard1.Size = new System.Drawing.Size(198, 23);
            this.txtIdCard1.TabIndex = 6;
            this.txtIdCard1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdCard1_KeyPress);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(387, 52);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(314, 23);
            this.txtName.TabIndex = 3;
            this.txtName.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtFatherName
            // 
            this.txtFatherName.Location = new System.Drawing.Point(503, 80);
            this.txtFatherName.Name = "txtFatherName";
            this.txtFatherName.Size = new System.Drawing.Size(198, 23);
            this.txtFatherName.TabIndex = 4;
            this.txtFatherName.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtPicture
            // 
            this.txtPicture.Location = new System.Drawing.Point(258, 22);
            this.txtPicture.Name = "txtPicture";
            this.txtPicture.Size = new System.Drawing.Size(443, 23);
            this.txtPicture.TabIndex = 1;
            this.txtPicture.TextChanged += new System.EventHandler(this.txtPicture_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(703, 202);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 16);
            this.label10.TabIndex = 2;
            this.label10.Text = "توضیحات :";
            this.label10.Click += new System.EventHandler(this.label6_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(703, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 16);
            this.label6.TabIndex = 2;
            this.label6.Text = "آدرس :";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(703, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "تلفن :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(703, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "شماره ملی :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(387, 144);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 16);
            this.label9.TabIndex = 2;
            this.label9.Text = "تلفن همراه :";
            this.label9.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(387, 113);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 16);
            this.label8.TabIndex = 2;
            this.label8.Text = "شماره شناسنامه :";
            this.label8.Click += new System.EventHandler(this.label7_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(387, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 16);
            this.label7.TabIndex = 2;
            this.label7.Text = "جنسیت :";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(703, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "نام پدر :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(703, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "نام و نام حانوادگی :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(703, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "عکس :";
            // 
            // grbPicStudent
            // 
            this.grbPicStudent.Controls.Add(this.PicStudent);
            this.grbPicStudent.Location = new System.Drawing.Point(6, 13);
            this.grbPicStudent.Name = "grbPicStudent";
            this.grbPicStudent.Size = new System.Drawing.Size(119, 153);
            this.grbPicStudent.TabIndex = 1;
            this.grbPicStudent.TabStop = false;
            // 
            // PicStudent
            // 
            this.PicStudent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PicStudent.Location = new System.Drawing.Point(8, 12);
            this.PicStudent.Name = "PicStudent";
            this.PicStudent.Size = new System.Drawing.Size(103, 133);
            this.PicStudent.TabIndex = 2;
            this.PicStudent.TabStop = false;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(426, 264);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(102, 33);
            this.btnOk.TabIndex = 12;
            this.btnOk.Text = "تایید";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(318, 264);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(102, 33);
            this.btnClear.TabIndex = 13;
            this.btnClear.Text = "پاک کردن";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // frmAddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 306);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.grbStudent);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddStudent";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ثبت نام هنرجو";
            this.Load += new System.EventHandler(this.frmAddStudent_Load);
            this.grbStudent.ResumeLayout(false);
            this.grbStudent.PerformLayout();
            this.grbPicStudent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PicStudent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbStudent;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grbPicStudent;
        private System.Windows.Forms.PictureBox PicStudent;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDiscription;
        private System.Windows.Forms.TextBox txtAddresss;
        private System.Windows.Forms.TextBox txtMobile;
        private System.Windows.Forms.TextBox txtIdCard2;
        private System.Windows.Forms.TextBox txtTell;
        private System.Windows.Forms.TextBox txtIdCard1;
        private System.Windows.Forms.TextBox txtFatherName;
        private System.Windows.Forms.TextBox txtPicture;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnBrows;
        private System.Windows.Forms.ComboBox cmbSex;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnClear;
    }
}