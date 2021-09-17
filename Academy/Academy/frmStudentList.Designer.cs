namespace Academy
{
    partial class frmStudentList
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
            this.grbStudentList = new System.Windows.Forms.GroupBox();
            this.dgvStudentList = new System.Windows.Forms.DataGridView();
            this.grbStudentList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentList)).BeginInit();
            this.SuspendLayout();
            // 
            // grbStudentList
            // 
            this.grbStudentList.Controls.Add(this.dgvStudentList);
            this.grbStudentList.Location = new System.Drawing.Point(6, 14);
            this.grbStudentList.Name = "grbStudentList";
            this.grbStudentList.Size = new System.Drawing.Size(966, 345);
            this.grbStudentList.TabIndex = 1;
            this.grbStudentList.TabStop = false;
            this.grbStudentList.Text = "لیست هنرجویان";
            // 
            // dgvStudentList
            // 
            this.dgvStudentList.AllowUserToAddRows = false;
            this.dgvStudentList.AllowUserToDeleteRows = false;
            this.dgvStudentList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudentList.Location = new System.Drawing.Point(9, 22);
            this.dgvStudentList.MultiSelect = false;
            this.dgvStudentList.Name = "dgvStudentList";
            this.dgvStudentList.ReadOnly = true;
            this.dgvStudentList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStudentList.Size = new System.Drawing.Size(942, 313);
            this.dgvStudentList.TabIndex = 0;
            // 
            // frmStudentList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 371);
            this.Controls.Add(this.grbStudentList);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmStudentList";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "لیست هنرجویان";
            this.Load += new System.EventHandler(this.frmStudentList_Load);
            this.grbStudentList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbStudentList;
        private System.Windows.Forms.DataGridView dgvStudentList;
    }
}