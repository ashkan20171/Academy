namespace Academy
{
    partial class frmSearchPecuniray
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
            this.rdbDebtor = new System.Windows.Forms.RadioButton();
            this.rdbCreditor = new System.Windows.Forms.RadioButton();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvPecuniary = new System.Windows.Forms.DataGridView();
            this.picStudent = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPecuniary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // rdbDebtor
            // 
            this.rdbDebtor.AutoSize = true;
            this.rdbDebtor.Checked = true;
            this.rdbDebtor.Location = new System.Drawing.Point(414, 12);
            this.rdbDebtor.Name = "rdbDebtor";
            this.rdbDebtor.Size = new System.Drawing.Size(74, 20);
            this.rdbDebtor.TabIndex = 0;
            this.rdbDebtor.TabStop = true;
            this.rdbDebtor.Text = "بدهکاران";
            this.rdbDebtor.UseVisualStyleBackColor = true;
            this.rdbDebtor.CheckedChanged += new System.EventHandler(this.rdbDebtor_CheckedChanged);
            // 
            // rdbCreditor
            // 
            this.rdbCreditor.AutoSize = true;
            this.rdbCreditor.Location = new System.Drawing.Point(252, 12);
            this.rdbCreditor.Name = "rdbCreditor";
            this.rdbCreditor.Size = new System.Drawing.Size(85, 20);
            this.rdbCreditor.TabIndex = 1;
            this.rdbCreditor.Text = "بستانکاران";
            this.rdbCreditor.UseVisualStyleBackColor = true;
            this.rdbCreditor.CheckedChanged += new System.EventHandler(this.rdbCreditor_CheckedChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(26, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(85, 29);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "جستجو";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dgvPecuniary
            // 
            this.dgvPecuniary.AllowUserToAddRows = false;
            this.dgvPecuniary.AllowUserToDeleteRows = false;
            this.dgvPecuniary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPecuniary.Location = new System.Drawing.Point(161, 48);
            this.dgvPecuniary.MultiSelect = false;
            this.dgvPecuniary.Name = "dgvPecuniary";
            this.dgvPecuniary.ReadOnly = true;
            this.dgvPecuniary.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPecuniary.Size = new System.Drawing.Size(327, 261);
            this.dgvPecuniary.TabIndex = 3;
            this.dgvPecuniary.Visible = false;
            this.dgvPecuniary.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPecuniary_CellClick);
            // 
            // picStudent
            // 
            this.picStudent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picStudent.Location = new System.Drawing.Point(26, 92);
            this.picStudent.Name = "picStudent";
            this.picStudent.Size = new System.Drawing.Size(100, 130);
            this.picStudent.TabIndex = 4;
            this.picStudent.TabStop = false;
            // 
            // frmSearchPecuniray
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 328);
            this.Controls.Add(this.picStudent);
            this.Controls.Add(this.dgvPecuniary);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.rdbCreditor);
            this.Controls.Add(this.rdbDebtor);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSearchPecuniray";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "جستجو مالی";
            this.Load += new System.EventHandler(this.frmSearchPecuniray_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPecuniary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdbDebtor;
        private System.Windows.Forms.RadioButton rdbCreditor;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvPecuniary;
        private System.Windows.Forms.PictureBox picStudent;
    }
}