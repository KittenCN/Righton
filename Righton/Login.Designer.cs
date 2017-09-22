namespace Righton
{
    partial class form_Login
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_Login));
            this.pb_Logo = new System.Windows.Forms.PictureBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtPWD = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_Logo
            // 
            this.pb_Logo.Image = ((System.Drawing.Image)(resources.GetObject("pb_Logo.Image")));
            this.pb_Logo.Location = new System.Drawing.Point(0, 0);
            this.pb_Logo.Margin = new System.Windows.Forms.Padding(0);
            this.pb_Logo.Name = "pb_Logo";
            this.pb_Logo.Size = new System.Drawing.Size(864, 790);
            this.pb_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pb_Logo.TabIndex = 0;
            this.pb_Logo.TabStop = false;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(268, 261);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(337, 21);
            this.txtUserName.TabIndex = 1;
            this.txtUserName.Text = "UserName";
            this.txtUserName.Click += new System.EventHandler(this.txtUserName_Click);
            // 
            // txtPWD
            // 
            this.txtPWD.Location = new System.Drawing.Point(268, 300);
            this.txtPWD.Name = "txtPWD";
            this.txtPWD.PasswordChar = '*';
            this.txtPWD.Size = new System.Drawing.Size(337, 21);
            this.txtPWD.TabIndex = 2;
            this.txtPWD.Text = "Password";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(209, 367);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(458, 55);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // form_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(865, 792);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPWD);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.pb_Logo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "form_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Righton";
            this.Load += new System.EventHandler(this.form_Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_Logo;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtPWD;
        private System.Windows.Forms.Button btnLogin;
    }
}

