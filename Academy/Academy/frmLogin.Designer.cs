namespace Academy
{
    partial class frmLogin
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
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.llblForgotPassword = new System.Windows.Forms.LinkLabel();
            this.grpLogin = new System.Windows.Forms.GroupBox();
            this.picLogin = new System.Windows.Forms.PictureBox();
            this.picExit = new System.Windows.Forms.PictureBox();
            this.grpLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(376, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "نام کاربری :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(376, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "رمز عبور   :";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(207, 90);
            this.txtUserName.MaxLength = 50;
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(163, 23);
            this.txtUserName.TabIndex = 0;
            this.txtUserName.Text = "123";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(207, 119);
            this.txtPassword.MaxLength = 50;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '•';
            this.txtPassword.Size = new System.Drawing.Size(163, 23);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.Text = "123";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(207, 160);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 29);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "ورود";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // llblForgotPassword
            // 
            this.llblForgotPassword.AutoSize = true;
            this.llblForgotPassword.BackColor = System.Drawing.Color.Transparent;
            this.llblForgotPassword.Location = new System.Drawing.Point(311, 198);
            this.llblForgotPassword.Name = "llblForgotPassword";
            this.llblForgotPassword.Size = new System.Drawing.Size(137, 16);
            this.llblForgotPassword.TabIndex = 3;
            this.llblForgotPassword.TabStop = true;
            this.llblForgotPassword.Text = "رمز ورود را فراموش کردم";
            this.llblForgotPassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblForgotPassword_LinkClicked);
            // 
            // grpLogin
            // 
            this.grpLogin.BackColor = System.Drawing.Color.Transparent;
            this.grpLogin.Controls.Add(this.picLogin);
            this.grpLogin.Location = new System.Drawing.Point(12, 73);
            this.grpLogin.Name = "grpLogin";
            this.grpLogin.Size = new System.Drawing.Size(141, 153);
            this.grpLogin.TabIndex = 4;
            this.grpLogin.TabStop = false;
            // 
            // picLogin
            // 
            this.picLogin.BackgroundImage = global::Academy.Properties.Resources.Login;
            this.picLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picLogin.Location = new System.Drawing.Point(6, 17);
            this.picLogin.Name = "picLogin";
            this.picLogin.Size = new System.Drawing.Size(123, 122);
            this.picLogin.TabIndex = 0;
            this.picLogin.TabStop = false;
            // 
            // picExit
            // 
            this.picExit.BackColor = System.Drawing.Color.Transparent;
            this.picExit.BackgroundImage = global::Academy.Properties.Resources.Exit;
            this.picExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picExit.Location = new System.Drawing.Point(376, 26);
            this.picExit.Name = "picExit";
            this.picExit.Size = new System.Drawing.Size(34, 33);
            this.picExit.TabIndex = 5;
            this.picExit.TabStop = false;
            this.picExit.Click += new System.EventHandler(this.picExit_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.BackgroundImage = global::Academy.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(458, 279);
            this.Controls.Add(this.picExit);
            this.Controls.Add(this.grpLogin);
            this.Controls.Add(this.llblForgotPassword);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmLogin";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TransparencyKey = System.Drawing.Color.Yellow;
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.grpLogin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.LinkLabel llblForgotPassword;
        private System.Windows.Forms.GroupBox grpLogin;
        private System.Windows.Forms.PictureBox picLogin;
        private System.Windows.Forms.PictureBox picExit;
    }
}