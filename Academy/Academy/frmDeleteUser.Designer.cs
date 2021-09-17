namespace Academy
{
    partial class frmDeleteUser
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
            this.grbUser = new System.Windows.Forms.GroupBox();
            this.grbPicUser = new System.Windows.Forms.GroupBox();
            this.dgvUser = new System.Windows.Forms.DataGridView();
            this.picUser = new System.Windows.Forms.PictureBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.grbUser.SuspendLayout();
            this.grbPicUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).BeginInit();
            this.SuspendLayout();
            // 
            // grbUser
            // 
            this.grbUser.Controls.Add(this.btnDelete);
            this.grbUser.Controls.Add(this.grbPicUser);
            this.grbUser.Location = new System.Drawing.Point(12, 13);
            this.grbUser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbUser.Name = "grbUser";
            this.grbUser.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbUser.Size = new System.Drawing.Size(745, 294);
            this.grbUser.TabIndex = 0;
            this.grbUser.TabStop = false;
            this.grbUser.Text = "اطلاعات کاربران";
            // 
            // grbPicUser
            // 
            this.grbPicUser.Controls.Add(this.picUser);
            this.grbPicUser.Location = new System.Drawing.Point(6, 24);
            this.grbPicUser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbPicUser.Name = "grbPicUser";
            this.grbPicUser.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbPicUser.Size = new System.Drawing.Size(113, 141);
            this.grbPicUser.TabIndex = 1;
            this.grbPicUser.TabStop = false;
            // 
            // dgvUser
            // 
            this.dgvUser.AllowUserToAddRows = false;
            this.dgvUser.AllowUserToDeleteRows = false;
            this.dgvUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUser.Location = new System.Drawing.Point(137, 37);
            this.dgvUser.MultiSelect = false;
            this.dgvUser.Name = "dgvUser";
            this.dgvUser.ReadOnly = true;
            this.dgvUser.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUser.Size = new System.Drawing.Size(614, 255);
            this.dgvUser.TabIndex = 2;
            this.dgvUser.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUser_CellClick);
            // 
            // picUser
            // 
            this.picUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picUser.Location = new System.Drawing.Point(7, 16);
            this.picUser.Name = "picUser";
            this.picUser.Size = new System.Drawing.Size(98, 118);
            this.picUser.TabIndex = 2;
            this.picUser.TabStop = false;
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
            // frmDeleteUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 319);
            this.Controls.Add(this.dgvUser);
            this.Controls.Add(this.grbUser);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDeleteUser";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "حذف کاربر";
            this.Load += new System.EventHandler(this.frmDeleteUser_Load);
            this.grbUser.ResumeLayout(false);
            this.grbPicUser.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbUser;
        private System.Windows.Forms.DataGridView dgvUser;
        private System.Windows.Forms.GroupBox grbPicUser;
        private System.Windows.Forms.PictureBox picUser;
        private System.Windows.Forms.Button btnDelete;
    }
}