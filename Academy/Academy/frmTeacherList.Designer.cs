namespace Academy
{
    partial class frmTeacherList
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
            this.grbTeacherList = new System.Windows.Forms.GroupBox();
            this.dgvTeacherList = new System.Windows.Forms.DataGridView();
            this.grbTeacherList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeacherList)).BeginInit();
            this.SuspendLayout();
            // 
            // grbTeacherList
            // 
            this.grbTeacherList.Controls.Add(this.dgvTeacherList);
            this.grbTeacherList.Location = new System.Drawing.Point(10, 18);
            this.grbTeacherList.Name = "grbTeacherList";
            this.grbTeacherList.Size = new System.Drawing.Size(966, 345);
            this.grbTeacherList.TabIndex = 0;
            this.grbTeacherList.TabStop = false;
            this.grbTeacherList.Text = "لیست مربیان";
            // 
            // dgvTeacherList
            // 
            this.dgvTeacherList.AllowUserToAddRows = false;
            this.dgvTeacherList.AllowUserToDeleteRows = false;
            this.dgvTeacherList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTeacherList.Location = new System.Drawing.Point(9, 22);
            this.dgvTeacherList.MultiSelect = false;
            this.dgvTeacherList.Name = "dgvTeacherList";
            this.dgvTeacherList.ReadOnly = true;
            this.dgvTeacherList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTeacherList.Size = new System.Drawing.Size(942, 313);
            this.dgvTeacherList.TabIndex = 0;
            // 
            // frmTeacherList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 371);
            this.Controls.Add(this.grbTeacherList);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTeacherList";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "لیست مربیان";
            this.Load += new System.EventHandler(this.frmTeacherList_Load);
            this.grbTeacherList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeacherList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbTeacherList;
        private System.Windows.Forms.DataGridView dgvTeacherList;
    }
}