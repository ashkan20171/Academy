namespace Academy
{
    partial class frmDeleteTeacher
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
            this.dgvTeacher = new System.Windows.Forms.DataGridView();
            this.grbTeacher = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.grbPicTeacher = new System.Windows.Forms.GroupBox();
            this.picTeacher = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeacher)).BeginInit();
            this.grbTeacher.SuspendLayout();
            this.grbPicTeacher.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTeacher)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTeacher
            // 
            this.dgvTeacher.AllowUserToAddRows = false;
            this.dgvTeacher.AllowUserToDeleteRows = false;
            this.dgvTeacher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTeacher.Location = new System.Drawing.Point(137, 37);
            this.dgvTeacher.MultiSelect = false;
            this.dgvTeacher.Name = "dgvTeacher";
            this.dgvTeacher.ReadOnly = true;
            this.dgvTeacher.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTeacher.Size = new System.Drawing.Size(691, 255);
            this.dgvTeacher.TabIndex = 6;
            this.dgvTeacher.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTeacher_CellClick);
            // 
            // grbTeacher
            // 
            this.grbTeacher.Controls.Add(this.btnDelete);
            this.grbTeacher.Controls.Add(this.grbPicTeacher);
            this.grbTeacher.Location = new System.Drawing.Point(12, 13);
            this.grbTeacher.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbTeacher.Name = "grbTeacher";
            this.grbTeacher.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbTeacher.Size = new System.Drawing.Size(822, 294);
            this.grbTeacher.TabIndex = 5;
            this.grbTeacher.TabStop = false;
            this.grbTeacher.Text = "اطلاعات مربی";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(13, 172);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(98, 33);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "حذف";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // grbPicTeacher
            // 
            this.grbPicTeacher.Controls.Add(this.picTeacher);
            this.grbPicTeacher.Location = new System.Drawing.Point(6, 24);
            this.grbPicTeacher.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbPicTeacher.Name = "grbPicTeacher";
            this.grbPicTeacher.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbPicTeacher.Size = new System.Drawing.Size(113, 141);
            this.grbPicTeacher.TabIndex = 1;
            this.grbPicTeacher.TabStop = false;
            // 
            // picTeacher
            // 
            this.picTeacher.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picTeacher.Location = new System.Drawing.Point(7, 16);
            this.picTeacher.Name = "picTeacher";
            this.picTeacher.Size = new System.Drawing.Size(98, 118);
            this.picTeacher.TabIndex = 2;
            this.picTeacher.TabStop = false;
            // 
            // frmDeleteTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 322);
            this.Controls.Add(this.dgvTeacher);
            this.Controls.Add(this.grbTeacher);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDeleteTeacher";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "حذف مربی";
            this.Load += new System.EventHandler(this.frmDeleteTeacher_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeacher)).EndInit();
            this.grbTeacher.ResumeLayout(false);
            this.grbPicTeacher.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picTeacher)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTeacher;
        private System.Windows.Forms.GroupBox grbTeacher;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox grbPicTeacher;
        private System.Windows.Forms.PictureBox picTeacher;

    }
}