namespace Academy
{
    partial class frmDeleteSelected
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
            this.dgvSelected = new System.Windows.Forms.DataGridView();
            this.grbSelected = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelected)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSelected
            // 
            this.dgvSelected.AllowUserToAddRows = false;
            this.dgvSelected.AllowUserToDeleteRows = false;
            this.dgvSelected.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSelected.Location = new System.Drawing.Point(32, 41);
            this.dgvSelected.MultiSelect = false;
            this.dgvSelected.Name = "dgvSelected";
            this.dgvSelected.ReadOnly = true;
            this.dgvSelected.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSelected.Size = new System.Drawing.Size(789, 255);
            this.dgvSelected.TabIndex = 6;
            this.dgvSelected.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSelected_CellClick);
            // 
            // grbSelected
            // 
            this.grbSelected.Location = new System.Drawing.Point(12, 13);
            this.grbSelected.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbSelected.Name = "grbSelected";
            this.grbSelected.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbSelected.Size = new System.Drawing.Size(822, 294);
            this.grbSelected.TabIndex = 5;
            this.grbSelected.TabStop = false;
            this.grbSelected.Text = "اطلاعات دروس اخذ شده";
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(378, 324);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(98, 33);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "حذف";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // frmDeleteSelected
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 371);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dgvSelected);
            this.Controls.Add(this.grbSelected);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDeleteSelected";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "حذف دروس اخذ شده";
            this.Load += new System.EventHandler(this.frmDeleteSelected_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelected)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSelected;
        private System.Windows.Forms.GroupBox grbSelected;
        private System.Windows.Forms.Button btnDelete;
    }
}