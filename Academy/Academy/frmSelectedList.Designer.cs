namespace Academy
{
    partial class frmSelectedList
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelected)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSelected
            // 
            this.dgvSelected.AllowUserToAddRows = false;
            this.dgvSelected.AllowUserToDeleteRows = false;
            this.dgvSelected.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSelected.Location = new System.Drawing.Point(18, 41);
            this.dgvSelected.MultiSelect = false;
            this.dgvSelected.Name = "dgvSelected";
            this.dgvSelected.ReadOnly = true;
            this.dgvSelected.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSelected.Size = new System.Drawing.Size(803, 295);
            this.dgvSelected.TabIndex = 8;
            // 
            // grbSelected
            // 
            this.grbSelected.Location = new System.Drawing.Point(12, 13);
            this.grbSelected.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbSelected.Name = "grbSelected";
            this.grbSelected.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbSelected.Size = new System.Drawing.Size(822, 334);
            this.grbSelected.TabIndex = 7;
            this.grbSelected.TabStop = false;
            this.grbSelected.Text = "لیست دروس اخذ شده";
            // 
            // frmSelectedList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 368);
            this.Controls.Add(this.dgvSelected);
            this.Controls.Add(this.grbSelected);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSelectedList";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "لیست دروس اخذ شده";
            this.Load += new System.EventHandler(this.frmSelectedList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelected)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSelected;
        private System.Windows.Forms.GroupBox grbSelected;
    }
}