namespace 身份验证client
{
    partial class Client
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
            this.BtnConnectSer = new System.Windows.Forms.Button();
            this.LbName = new System.Windows.Forms.Label();
            this.TextName = new System.Windows.Forms.TextBox();
            this.LbPwd = new System.Windows.Forms.Label();
            this.TextPwd = new System.Windows.Forms.TextBox();
            this.BtnDL = new System.Windows.Forms.Button();
            this.BtnZC = new System.Windows.Forms.Button();
            this.TextMsg = new System.Windows.Forms.TextBox();
            this.RecNR = new System.Windows.Forms.Label();
            this.BtnCheck = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnConnectSer
            // 
            this.BtnConnectSer.Font = new System.Drawing.Font("楷体", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnConnectSer.Location = new System.Drawing.Point(432, 32);
            this.BtnConnectSer.Name = "BtnConnectSer";
            this.BtnConnectSer.Size = new System.Drawing.Size(185, 198);
            this.BtnConnectSer.TabIndex = 4;
            this.BtnConnectSer.Text = "连接服务端";
            this.BtnConnectSer.UseVisualStyleBackColor = true;
            this.BtnConnectSer.Click += new System.EventHandler(this.BtnConnectSer_Click);
            // 
            // LbName
            // 
            this.LbName.AutoSize = true;
            this.LbName.Font = new System.Drawing.Font("楷体", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LbName.Location = new System.Drawing.Point(12, 44);
            this.LbName.Name = "LbName";
            this.LbName.Size = new System.Drawing.Size(117, 34);
            this.LbName.TabIndex = 5;
            this.LbName.Text = "用户名";
            // 
            // TextName
            // 
            this.TextName.Font = new System.Drawing.Font("楷体", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TextName.Location = new System.Drawing.Point(155, 32);
            this.TextName.MaxLength = 10;
            this.TextName.Name = "TextName";
            this.TextName.Size = new System.Drawing.Size(253, 46);
            this.TextName.TabIndex = 6;
            // 
            // LbPwd
            // 
            this.LbPwd.AutoSize = true;
            this.LbPwd.Font = new System.Drawing.Font("楷体", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LbPwd.Location = new System.Drawing.Point(12, 115);
            this.LbPwd.Name = "LbPwd";
            this.LbPwd.Size = new System.Drawing.Size(117, 34);
            this.LbPwd.TabIndex = 7;
            this.LbPwd.Text = "密  码";
            // 
            // TextPwd
            // 
            this.TextPwd.Font = new System.Drawing.Font("楷体", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TextPwd.Location = new System.Drawing.Point(155, 103);
            this.TextPwd.MaxLength = 10;
            this.TextPwd.Name = "TextPwd";
            this.TextPwd.Size = new System.Drawing.Size(253, 46);
            this.TextPwd.TabIndex = 8;
            // 
            // BtnDL
            // 
            this.BtnDL.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.BtnDL.Font = new System.Drawing.Font("华文中宋", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnDL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BtnDL.Location = new System.Drawing.Point(18, 280);
            this.BtnDL.Name = "BtnDL";
            this.BtnDL.Size = new System.Drawing.Size(185, 65);
            this.BtnDL.TabIndex = 9;
            this.BtnDL.Text = "登录";
            this.BtnDL.UseVisualStyleBackColor = false;
            this.BtnDL.Click += new System.EventHandler(this.BtnDL_Click);
            // 
            // BtnZC
            // 
            this.BtnZC.Font = new System.Drawing.Font("楷体", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnZC.Location = new System.Drawing.Point(223, 280);
            this.BtnZC.Name = "BtnZC";
            this.BtnZC.Size = new System.Drawing.Size(185, 65);
            this.BtnZC.TabIndex = 10;
            this.BtnZC.Text = "注册";
            this.BtnZC.UseVisualStyleBackColor = true;
            this.BtnZC.Click += new System.EventHandler(this.BtnZC_Click);
            // 
            // TextMsg
            // 
            this.TextMsg.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TextMsg.Location = new System.Drawing.Point(155, 184);
            this.TextMsg.MaxLength = 10;
            this.TextMsg.Multiline = true;
            this.TextMsg.Name = "TextMsg";
            this.TextMsg.Size = new System.Drawing.Size(253, 46);
            this.TextMsg.TabIndex = 11;
            // 
            // RecNR
            // 
            this.RecNR.AutoSize = true;
            this.RecNR.Font = new System.Drawing.Font("楷体", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.RecNR.Location = new System.Drawing.Point(-5, 196);
            this.RecNR.Name = "RecNR";
            this.RecNR.Size = new System.Drawing.Size(134, 34);
            this.RecNR.TabIndex = 12;
            this.RecNR.Text = "当前N,R";
            // 
            // BtnCheck
            // 
            this.BtnCheck.Font = new System.Drawing.Font("楷体", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnCheck.Location = new System.Drawing.Point(432, 280);
            this.BtnCheck.Name = "BtnCheck";
            this.BtnCheck.Size = new System.Drawing.Size(185, 65);
            this.BtnCheck.TabIndex = 13;
            this.BtnCheck.Text = "检查";
            this.BtnCheck.UseVisualStyleBackColor = true;
            this.BtnCheck.Click += new System.EventHandler(this.BtnCheck_Click);
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(643, 366);
            this.Controls.Add(this.BtnCheck);
            this.Controls.Add(this.RecNR);
            this.Controls.Add(this.TextMsg);
            this.Controls.Add(this.BtnZC);
            this.Controls.Add(this.BtnDL);
            this.Controls.Add(this.TextPwd);
            this.Controls.Add(this.LbPwd);
            this.Controls.Add(this.TextName);
            this.Controls.Add(this.LbName);
            this.Controls.Add(this.BtnConnectSer);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Client";
            this.Text = "客户端";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnConnectSer;
        private System.Windows.Forms.Label LbName;
        private System.Windows.Forms.TextBox TextName;
        private System.Windows.Forms.Label LbPwd;
        private System.Windows.Forms.TextBox TextPwd;
        private System.Windows.Forms.Button BtnDL;
        private System.Windows.Forms.Button BtnZC;
        private System.Windows.Forms.TextBox TextMsg;
        private System.Windows.Forms.Label RecNR;
        private System.Windows.Forms.Button BtnCheck;
    }
}

