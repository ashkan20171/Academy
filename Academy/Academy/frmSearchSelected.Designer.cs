namespace Academy
{
    partial class frmSearchSelected
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
            this.rdbMax = new System.Windows.Forms.RadioButton();
            this.rdbMin = new System.Windows.Forms.RadioButton();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvSelected = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelected)).BeginInit();
            this.SuspendLayout();
            // 
            // rdbMax
            // 
            this.rdbMax.AutoSize = true;
            this.rdbMax.Checked = true;
            this.rdbMax.Location = new System.Drawing.Point(356, 27);
            this.rdbMax.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdbMax.Name = "rdbMax";
            this.rdbMax.Size = new System.Drawing.Size(114, 20);
            this.rdbMax.TabIndex = 0;
            this.rdbMax.TabStop = true;
            this.rdbMax.Text = "فعال ترین هنرجو";
            this.rdbMax.UseVisualStyleBackColor = true;
            this.rdbMax.CheckedChanged += new System.EventHandler(this.rdbMax_CheckedChanged);
            // 
            // rdbMin
            // 
            this.rdbMin.AutoSize = true;
            this.rdbMin.Location = new System.Drawing.Point(198, 27);
            this.rdbMin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdbMin.Name = "rdbMin";
            this.rdbMin.Size = new System.Drawing.Size(125, 20);
            this.rdbMin.TabIndex = 0;
            this.rdbMin.Text = "کم کار ترین هنرجو";
            this.rdbMin.UseVisualStyleBackColor = true;
            this.rdbMin.CheckedChanged += new System.EventHandler(this.rdbMin_CheckedChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(86, 27);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(81, 25);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "جستجو";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dgvSelected
            // 
            this.dgvSelected.AllowUserToAddRows = false;
            this.dgvSelected.AllowUserToDeleteRows = false;
            this.dgvSelected.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSelected.Location = new System.Drawing.Point(12, 79);
            this.dgvSelected.MultiSelect = false;
            this.dgvSelected.Name = "dgvSelected";
            this.dgvSelected.ReadOnly = true;
            this.dgvSelected.Size = new System.Drawing.Size(457, 214);
            this.dgvSelected.TabIndex = 2;
            this.dgvSelected.Visible = false;
            // 
            // frmSearchSelected
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 305);
            this.Controls.Add(this.dgvSelected);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.rdbMin);
            this.Controls.Add(this.rdbMax);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSearchSelected";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "جستجو دروس اخذ شده";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelected)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdbMax;
        private System.Windows.Forms.RadioButton rdbMin;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvSelected;
    }
}