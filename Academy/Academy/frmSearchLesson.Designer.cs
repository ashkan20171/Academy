namespace Academy
{
    partial class frmSearchLesson
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLessonName = new System.Windows.Forms.TextBox();
            this.txtLessonId = new System.Windows.Forms.TextBox();
            this.cmbGroup = new System.Windows.Forms.ComboBox();
            this.cmbTeacherName = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbSex = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvLesson = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLesson)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(777, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "نام درس :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(475, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "گروه درسی :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(777, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "شناسه درس :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(475, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "نام مربی :";
            // 
            // txtLessonName
            // 
            this.txtLessonName.Location = new System.Drawing.Point(603, 23);
            this.txtLessonName.Name = "txtLessonName";
            this.txtLessonName.Size = new System.Drawing.Size(168, 24);
            this.txtLessonName.TabIndex = 0;
            // 
            // txtLessonId
            // 
            this.txtLessonId.Location = new System.Drawing.Point(603, 65);
            this.txtLessonId.Name = "txtLessonId";
            this.txtLessonId.Size = new System.Drawing.Size(168, 24);
            this.txtLessonId.TabIndex = 3;
            // 
            // cmbGroup
            // 
            this.cmbGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGroup.FormattingEnabled = true;
            this.cmbGroup.Location = new System.Drawing.Point(282, 23);
            this.cmbGroup.Name = "cmbGroup";
            this.cmbGroup.Size = new System.Drawing.Size(187, 24);
            this.cmbGroup.TabIndex = 1;
            // 
            // cmbTeacherName
            // 
            this.cmbTeacherName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTeacherName.FormattingEnabled = true;
            this.cmbTeacherName.Location = new System.Drawing.Point(282, 62);
            this.cmbTeacherName.Name = "cmbTeacherName";
            this.cmbTeacherName.Size = new System.Drawing.Size(187, 24);
            this.cmbTeacherName.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(178, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "جنسیت :";
            // 
            // cmbSex
            // 
            this.cmbSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSex.FormattingEnabled = true;
            this.cmbSex.Location = new System.Drawing.Point(23, 19);
            this.cmbSex.Name = "cmbSex";
            this.cmbSex.Size = new System.Drawing.Size(149, 24);
            this.cmbSex.TabIndex = 2;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(23, 55);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(96, 31);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "جستجو";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dgvLesson
            // 
            this.dgvLesson.AllowUserToAddRows = false;
            this.dgvLesson.AllowUserToDeleteRows = false;
            this.dgvLesson.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLesson.Location = new System.Drawing.Point(16, 110);
            this.dgvLesson.MultiSelect = false;
            this.dgvLesson.Name = "dgvLesson";
            this.dgvLesson.ReadOnly = true;
            this.dgvLesson.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLesson.Size = new System.Drawing.Size(853, 284);
            this.dgvLesson.TabIndex = 6;
            this.dgvLesson.Visible = false;
            // 
            // frmSearchLesson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 406);
            this.Controls.Add(this.dgvLesson);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.cmbTeacherName);
            this.Controls.Add(this.cmbSex);
            this.Controls.Add(this.cmbGroup);
            this.Controls.Add(this.txtLessonId);
            this.Controls.Add(this.txtLessonName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSearchLesson";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "جستجو دروس";
            this.Load += new System.EventHandler(this.frmSearchLesson_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLesson)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLessonName;
        private System.Windows.Forms.TextBox txtLessonId;
        private System.Windows.Forms.ComboBox cmbGroup;
        private System.Windows.Forms.ComboBox cmbTeacherName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbSex;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvLesson;
    }
}