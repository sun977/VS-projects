namespace 访问控制
{
    partial class client
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
            this.username = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.LBuser = new System.Windows.Forms.Label();
            this.LBpwd = new System.Windows.Forms.Label();
            this.BtnRegister = new System.Windows.Forms.Button();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.Check = new System.Windows.Forms.Button();
            this.TextBox = new System.Windows.Forms.TextBox();
            this.VisitFile = new System.Windows.Forms.Button();
            this.LBFile = new System.Windows.Forms.Label();
            this.FileBox = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // username
            // 
            this.username.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.username.Location = new System.Drawing.Point(128, 12);
            this.username.MaxLength = 10;
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(169, 36);
            this.username.TabIndex = 0;
            // 
            // password
            // 
            this.password.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.password.Location = new System.Drawing.Point(128, 65);
            this.password.MaxLength = 10;
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(169, 36);
            this.password.TabIndex = 1;
            // 
            // LBuser
            // 
            this.LBuser.AutoSize = true;
            this.LBuser.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LBuser.Location = new System.Drawing.Point(26, 23);
            this.LBuser.Name = "LBuser";
            this.LBuser.Size = new System.Drawing.Size(87, 25);
            this.LBuser.TabIndex = 2;
            this.LBuser.Text = "用户名";
            // 
            // LBpwd
            // 
            this.LBpwd.AutoSize = true;
            this.LBpwd.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LBpwd.Location = new System.Drawing.Point(25, 76);
            this.LBpwd.Name = "LBpwd";
            this.LBpwd.Size = new System.Drawing.Size(88, 25);
            this.LBpwd.TabIndex = 3;
            this.LBpwd.Text = "密  码";
            // 
            // BtnRegister
            // 
            this.BtnRegister.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnRegister.Location = new System.Drawing.Point(318, 12);
            this.BtnRegister.Name = "BtnRegister";
            this.BtnRegister.Size = new System.Drawing.Size(120, 36);
            this.BtnRegister.TabIndex = 4;
            this.BtnRegister.Text = "注册";
            this.BtnRegister.UseVisualStyleBackColor = true;
            this.BtnRegister.Click += new System.EventHandler(this.BtnRegister_Click);
            // 
            // BtnLogin
            // 
            this.BtnLogin.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BtnLogin.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnLogin.Location = new System.Drawing.Point(318, 65);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(120, 36);
            this.BtnLogin.TabIndex = 5;
            this.BtnLogin.Text = "登录";
            this.BtnLogin.UseVisualStyleBackColor = false;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // Check
            // 
            this.Check.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Check.Location = new System.Drawing.Point(30, 110);
            this.Check.Name = "Check";
            this.Check.Size = new System.Drawing.Size(408, 36);
            this.Check.TabIndex = 6;
            this.Check.Text = "查看当前权限";
            this.Check.UseVisualStyleBackColor = true;
            this.Check.Click += new System.EventHandler(this.Check_Click);
            // 
            // TextBox
            // 
            this.TextBox.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TextBox.Location = new System.Drawing.Point(30, 152);
            this.TextBox.Multiline = true;
            this.TextBox.Name = "TextBox";
            this.TextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextBox.Size = new System.Drawing.Size(408, 119);
            this.TextBox.TabIndex = 7;
            this.TextBox.TabStop = false;
            // 
            // VisitFile
            // 
            this.VisitFile.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.VisitFile.Location = new System.Drawing.Point(28, 277);
            this.VisitFile.Name = "VisitFile";
            this.VisitFile.Size = new System.Drawing.Size(140, 36);
            this.VisitFile.TabIndex = 8;
            this.VisitFile.Text = "访问文件";
            this.VisitFile.UseVisualStyleBackColor = true;
            this.VisitFile.Click += new System.EventHandler(this.VisitFile_Click);
            // 
            // LBFile
            // 
            this.LBFile.AutoSize = true;
            this.LBFile.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LBFile.Location = new System.Drawing.Point(225, 283);
            this.LBFile.Name = "LBFile";
            this.LBFile.Size = new System.Drawing.Size(62, 25);
            this.LBFile.TabIndex = 9;
            this.LBFile.Text = "文件";
            // 
            // FileBox
            // 
            this.FileBox.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FileBox.Location = new System.Drawing.Point(295, 277);
            this.FileBox.MaxLength = 1;
            this.FileBox.Name = "FileBox";
            this.FileBox.Size = new System.Drawing.Size(100, 36);
            this.FileBox.TabIndex = 10;
            this.FileBox.Text = "0";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(464, 323);
            this.Controls.Add(this.FileBox);
            this.Controls.Add(this.LBFile);
            this.Controls.Add(this.VisitFile);
            this.Controls.Add(this.TextBox);
            this.Controls.Add(this.Check);
            this.Controls.Add(this.BtnLogin);
            this.Controls.Add(this.BtnRegister);
            this.Controls.Add(this.LBpwd);
            this.Controls.Add(this.LBuser);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "client";
            this.Text = "客户端";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label LBuser;
        private System.Windows.Forms.Label LBpwd;
        private System.Windows.Forms.Button BtnRegister;
        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.Button Check;
        private System.Windows.Forms.TextBox TextBox;
        private System.Windows.Forms.Button VisitFile;
        private System.Windows.Forms.Label LBFile;
        private System.Windows.Forms.TextBox FileBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

