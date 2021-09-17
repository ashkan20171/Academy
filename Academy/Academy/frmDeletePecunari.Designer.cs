namespace Academy
{
    partial class frmDeletePecunari
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grpPecuniary = new System.Windows.Forms.GroupBox();
            this.DGVPecuniary = new System.Windows.Forms.DataGridView();
            this.grpSelectedList = new System.Windows.Forms.GroupBox();
            this.DGVSelected = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtIdCard1 = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.grpPecuniary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVPecuniary)).BeginInit();
            this.grpSelectedList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVSelected)).BeginInit();
            this.SuspendLayout();
            // 
            // grpPecuniary
            // 
            this.grpPecuniary.Controls.Add(this.DGVPecuniary);
            this.grpPecuniary.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.grpPecuniary.Location = new System.Drawing.Point(13, 194);
            this.grpPecuniary.Name = "grpPecuniary";
            this.grpPecuniary.Size = new System.Drawing.Size(716, 238);
            this.grpPecuniary.TabIndex = 82;
            this.grpPecuniary.TabStop = false;
            this.grpPecuniary.Text = "وضعیت مالی";
            // 
            // DGVPecuniary
            // 
            this.DGVPecuniary.AllowUserToAddRows = false;
            this.DGVPecuniary.AllowUserToDeleteRows = false;
            this.DGVPecuniary.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.DGVPecuniary.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVPecuniary.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.DGVPecuniary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVPecuniary.Location = new System.Drawing.Point(11, 29);
            this.DGVPecuniary.MultiSelect = false;
            this.DGVPecuniary.Name = "DGVPecuniary";
            this.DGVPecuniary.ReadOnly = true;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVPecuniary.RowHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.DGVPecuniary.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVPecuniary.Size = new System.Drawing.Size(690, 203);
            this.DGVPecuniary.TabIndex = 5;
            this.DGVPecuniary.Visible = false;
            this.DGVPecuniary.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVPecuniary_CellClick);
            // 
            // grpSelectedList
            // 
            this.grpSelectedList.Controls.Add(this.DGVSelected);
            this.grpSelectedList.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.grpSelectedList.Location = new System.Drawing.Point(12, 37);
            this.grpSelectedList.Name = "grpSelectedList";
            this.grpSelectedList.Size = new System.Drawing.Size(716, 151);
            this.grpSelectedList.TabIndex = 81;
            this.grpSelectedList.TabStop = false;
            this.grpSelectedList.Text = "لیست دروس اخذ شده توسط این هنرجو";
            // 
            // DGVSelected
            // 
            this.DGVSelected.AllowUserToAddRows = false;
            this.DGVSelected.AllowUserToDeleteRows = false;
            this.DGVSelected.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.DGVSelected.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVSelected.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.DGVSelected.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVSelected.DefaultCellStyle = dataGridViewCellStyle12;
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
            this.btnSearch.Location = new System.Drawing.Point(348, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 32);
            this.btnSearch.TabIndex = 80;
            this.btnSearch.Text = "جستجو";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label13.Location = new System.Drawing.Point(627, 8);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(115, 16);
            this.label13.TabIndex = 83;
            this.label13.Text = "شماره ملی هنر جو";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label9.Location = new System.Drawing.Point(599, 8);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(15, 24);
            this.label9.TabIndex = 84;
            this.label9.Text = ":";
            // 
            // txtIdCard1
            // 
            this.txtIdCard1.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.txtIdCard1.Location = new System.Drawing.Point(429, 6);
            this.txtIdCard1.MaxLength = 10;
            this.txtIdCard1.Name = "txtIdCard1";
            this.txtIdCard1.Size = new System.Drawing.Size(168, 23);
            this.txtIdCard1.TabIndex = 79;
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnDelete.Location = new System.Drawing.Point(319, 438);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 32);
            this.btnDelete.TabIndex = 80;
            this.btnDelete.Text = "حذف";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // frmDeletePecunari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 476);
            this.Controls.Add(this.grpPecuniary);
            this.Controls.Add(this.grpSelectedList);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtIdCard1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDeletePecunari";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "حذف شهریه پرداخت شده";
            this.Load += new System.EventHandler(this.frmDeletePecunari_Load);
            this.grpPecuniary.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVPecuniary)).EndInit();
            this.grpSelectedList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVSelected)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpPecuniary;
        private System.Windows.Forms.DataGridView DGVPecuniary;
        private System.Windows.Forms.GroupBox grpSelectedList;
        private System.Windows.Forms.DataGridView DGVSelected;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtIdCard1;
        private System.Windows.Forms.Button btnDelete;
    }
}