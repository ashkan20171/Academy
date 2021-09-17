namespace Academy
{
    partial class frmLessonList
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
            this.grbLessonList = new System.Windows.Forms.GroupBox();
            this.dgvLessonList = new System.Windows.Forms.DataGridView();
            this.grbLessonList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLessonList)).BeginInit();
            this.SuspendLayout();
            // 
            // grbLessonList
            // 
            this.grbLessonList.Controls.Add(this.dgvLessonList);
            this.grbLessonList.Location = new System.Drawing.Point(12, 12);
            this.grbLessonList.Name = "grbLessonList";
            this.grbLessonList.Size = new System.Drawing.Size(966, 345);
            this.grbLessonList.TabIndex = 2;
            this.grbLessonList.TabStop = false;
            this.grbLessonList.Text = "لیست دروس ارائه شده";
            // 
            // dgvLessonList
            // 
            this.dgvLessonList.AllowUserToAddRows = false;
            this.dgvLessonList.AllowUserToDeleteRows = false;
            this.dgvLessonList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLessonList.Location = new System.Drawing.Point(9, 22);
            this.dgvLessonList.MultiSelect = false;
            this.dgvLessonList.Name = "dgvLessonList";
            this.dgvLessonList.ReadOnly = true;
            this.dgvLessonList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLessonList.Size = new System.Drawing.Size(942, 313);
            this.dgvLessonList.TabIndex = 0;
            // 
            // frmLessonList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 367);
            this.Controls.Add(this.grbLessonList);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLessonList";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "لیست دروس ارائه شده";
            this.Load += new System.EventHandler(this.frmLessonList_Load);
            this.grbLessonList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLessonList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbLessonList;
        private System.Windows.Forms.DataGridView dgvLessonList;
    }
}