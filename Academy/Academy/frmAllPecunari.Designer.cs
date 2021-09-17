namespace Academy
{
    partial class frmAllPecunari
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DGVPecuniary = new System.Windows.Forms.DataGridView();
            this.mtxtFrom = new System.Windows.Forms.MaskedTextBox();
            this.mtxtTo = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnShow = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSum = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGVPecuniary)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVPecuniary
            // 
            this.DGVPecuniary.AllowUserToAddRows = false;
            this.DGVPecuniary.AllowUserToDeleteRows = false;
            this.DGVPecuniary.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.DGVPecuniary.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVPecuniary.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DGVPecuniary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVPecuniary.Location = new System.Drawing.Point(12, 54);
            this.DGVPecuniary.MultiSelect = false;
            this.DGVPecuniary.Name = "DGVPecuniary";
            this.DGVPecuniary.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVPecuniary.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DGVPecuniary.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVPecuniary.Size = new System.Drawing.Size(804, 396);
            this.DGVPecuniary.TabIndex = 3;
            this.DGVPecuniary.Visible = false;
            // 
            // mtxtFrom
            // 
            this.mtxtFrom.Location = new System.Drawing.Point(611, 14);
            this.mtxtFrom.Mask = "0000/00/00";
            this.mtxtFrom.Name = "mtxtFrom";
            this.mtxtFrom.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mtxtFrom.Size = new System.Drawing.Size(169, 23);
            this.mtxtFrom.TabIndex = 0;
            // 
            // mtxtTo
            // 
            this.mtxtTo.Location = new System.Drawing.Point(386, 14);
            this.mtxtTo.Mask = "0000/00/00";
            this.mtxtTo.Name = "mtxtTo";
            this.mtxtTo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mtxtTo.Size = new System.Drawing.Size(169, 23);
            this.mtxtTo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(786, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "از :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(561, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "تا :";
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(12, 9);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(90, 25);
            this.btnShow.TabIndex = 2;
            this.btnShow.Text = "نمایش";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(698, 470);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "مجموع دریافتی ها :";
            // 
            // lblSum
            // 
            this.lblSum.Location = new System.Drawing.Point(474, 470);
            this.lblSum.Name = "lblSum";
            this.lblSum.Size = new System.Drawing.Size(218, 33);
            this.lblSum.TabIndex = 8;
            // 
            // frmAllPecunari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 512);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblSum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mtxtTo);
            this.Controls.Add(this.mtxtFrom);
            this.Controls.Add(this.DGVPecuniary);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAllPecunari";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ریز تراکنش ها";
            ((System.ComponentModel.ISupportInitialize)(this.DGVPecuniary)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVPecuniary;
        private System.Windows.Forms.MaskedTextBox mtxtFrom;
        private System.Windows.Forms.MaskedTextBox mtxtTo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSum;
    }
}