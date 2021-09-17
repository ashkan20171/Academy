namespace Academy
{
    partial class frmSetting
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtTell = new System.Windows.Forms.TextBox();
            this.txtFax = new System.Windows.Forms.TextBox();
            this.txtDiscription = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbSkin = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(246, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "نام آموزشگاه :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(246, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "تلفن :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(246, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "فکس :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(246, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "توضیحات :";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(12, 12);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(228, 23);
            this.txtName.TabIndex = 0;
            // 
            // txtTell
            // 
            this.txtTell.Location = new System.Drawing.Point(12, 42);
            this.txtTell.Name = "txtTell";
            this.txtTell.Size = new System.Drawing.Size(228, 23);
            this.txtTell.TabIndex = 1;
            // 
            // txtFax
            // 
            this.txtFax.Location = new System.Drawing.Point(12, 73);
            this.txtFax.Name = "txtFax";
            this.txtFax.Size = new System.Drawing.Size(228, 23);
            this.txtFax.TabIndex = 2;
            // 
            // txtDiscription
            // 
            this.txtDiscription.Location = new System.Drawing.Point(12, 102);
            this.txtDiscription.Multiline = true;
            this.txtDiscription.Name = "txtDiscription";
            this.txtDiscription.Size = new System.Drawing.Size(228, 67);
            this.txtDiscription.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(246, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "نمای برنامه :";
            // 
            // cmbSkin
            // 
            this.cmbSkin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSkin.FormattingEnabled = true;
            this.cmbSkin.Location = new System.Drawing.Point(12, 182);
            this.cmbSkin.Name = "cmbSkin";
            this.cmbSkin.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbSkin.Size = new System.Drawing.Size(228, 24);
            this.cmbSkin.TabIndex = 4;
            this.cmbSkin.SelectedIndexChanged += new System.EventHandler(this.cmbSkin_SelectedIndexChanged);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(125, 212);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(85, 31);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "ذخیره";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // skinEngine1
            // 
            this.skinEngine1.Active = false;
            this.skinEngine1.SerialNumber = "";
            this.skinEngine1.SkinFile = null;
            // 
            // frmSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 255);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cmbSkin);
            this.Controls.Add(this.txtDiscription);
            this.Controls.Add(this.txtFax);
            this.Controls.Add(this.txtTell);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSetting";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تنظیمات";
            this.Load += new System.EventHandler(this.frmSetting_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtTell;
        private System.Windows.Forms.TextBox txtFax;
        private System.Windows.Forms.TextBox txtDiscription;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbSkin;
        private System.Windows.Forms.Button btnSave;
        private Sunisoft.IrisSkin.SkinEngine skinEngine1;
    }
}