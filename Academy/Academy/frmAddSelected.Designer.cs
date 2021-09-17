namespace Academy
{
    partial class frmAddSelected
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLessonId = new System.Windows.Forms.TextBox();
            this.txtIdCard1 = new System.Windows.Forms.TextBox();
            this.mtxtDate = new System.Windows.Forms.MaskedTextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(237, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "شناسه درس :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(237, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "کد ملی هنرجو :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(237, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "تاریخ :";
            // 
            // txtLessonId
            // 
            this.txtLessonId.Location = new System.Drawing.Point(13, 16);
            this.txtLessonId.Name = "txtLessonId";
            this.txtLessonId.Size = new System.Drawing.Size(218, 23);
            this.txtLessonId.TabIndex = 0;
            // 
            // txtIdCard1
            // 
            this.txtIdCard1.Location = new System.Drawing.Point(13, 51);
            this.txtIdCard1.Name = "txtIdCard1";
            this.txtIdCard1.Size = new System.Drawing.Size(218, 23);
            this.txtIdCard1.TabIndex = 1;
            // 
            // mtxtDate
            // 
            this.mtxtDate.Location = new System.Drawing.Point(13, 86);
            this.mtxtDate.Mask = "0000/00/00";
            this.mtxtDate.Name = "mtxtDate";
            this.mtxtDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mtxtDate.Size = new System.Drawing.Size(218, 23);
            this.mtxtDate.TabIndex = 2;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(159, 115);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(83, 33);
            this.btnOk.TabIndex = 3;
            this.btnOk.Text = "تایید";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(70, 115);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(83, 33);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "پاک کردن";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // frmAddSelected
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 150);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.mtxtDate);
            this.Controls.Add(this.txtIdCard1);
            this.Controls.Add(this.txtLessonId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddSelected";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اخذ درس";
            this.Load += new System.EventHandler(this.frmAddSelected_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLessonId;
        private System.Windows.Forms.TextBox txtIdCard1;
        private System.Windows.Forms.MaskedTextBox mtxtDate;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnClear;
    }
}