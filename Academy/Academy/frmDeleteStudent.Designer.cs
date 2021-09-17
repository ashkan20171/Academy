namespace Academy
{
    partial class frmDeleteStudent
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
            this.dgvStudent = new System.Windows.Forms.DataGridView();
            this.grbStudent = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.grbPicStudent = new System.Windows.Forms.GroupBox();
            this.picStudent = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).BeginInit();
            this.grbStudent.SuspendLayout();
            this.grbPicStudent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvStudent
            // 
            this.dgvStudent.AllowUserToAddRows = false;
            this.dgvStudent.AllowUserToDeleteRows = false;
            this.dgvStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudent.Location = new System.Drawing.Point(137, 37);
            this.dgvStudent.MultiSelect = false;
            this.dgvStudent.Name = "dgvStudent";
            this.dgvStudent.ReadOnly = true;
            this.dgvStudent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStudent.Size = new System.Drawing.Size(691, 255);
            this.dgvStudent.TabIndex = 4;
            this.dgvStudent.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudent_CellClick);
            // 
            // grbStudent
            // 
            this.grbStudent.Controls.Add(this.btnDelete);
            this.grbStudent.Controls.Add(this.grbPicStudent);
            this.grbStudent.Location = new System.Drawing.Point(12, 13);
            this.grbStudent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbStudent.Name = "grbStudent";
            this.grbStudent.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbStudent.Size = new System.Drawing.Size(822, 294);
            this.grbStudent.TabIndex = 3;
            this.grbStudent.TabStop = false;
            this.grbStudent.Text = "اطلاعات کاربران";
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
            // grbPicStudent
            // 
            this.grbPicStudent.Controls.Add(this.picStudent);
            this.grbPicStudent.Location = new System.Drawing.Point(6, 24);
            this.grbPicStudent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbPicStudent.Name = "grbPicStudent";
            this.grbPicStudent.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbPicStudent.Size = new System.Drawing.Size(113, 141);
            this.grbPicStudent.TabIndex = 1;
            this.grbPicStudent.TabStop = false;
            // 
            // picStudent
            // 
            this.picStudent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picStudent.Location = new System.Drawing.Point(7, 16);
            this.picStudent.Name = "picStudent";
            this.picStudent.Size = new System.Drawing.Size(98, 118);
            this.picStudent.TabIndex = 2;
            this.picStudent.TabStop = false;
            // 
            // frmDeleteStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 306);
            this.Controls.Add(this.dgvStudent);
            this.Controls.Add(this.grbStudent);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDeleteStudent";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "حذف هنرجو";
            this.Load += new System.EventHandler(this.frmDeleteStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).EndInit();
            this.grbStudent.ResumeLayout(false);
            this.grbPicStudent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picStudent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStudent;
        private System.Windows.Forms.GroupBox grbStudent;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox grbPicStudent;
        private System.Windows.Forms.PictureBox picStudent;
    }
}