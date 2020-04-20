namespace 身份验证
{
    partial class Server
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
            this.TextGetR = new System.Windows.Forms.TextBox();
            this.GetR = new System.Windows.Forms.Label();
            this.TextGetN = new System.Windows.Forms.TextBox();
            this.GetN = new System.Windows.Forms.Label();
            this.BtnStratSer = new System.Windows.Forms.Button();
            this.TextMsg = new System.Windows.Forms.TextBox();
            this.BtnSendMsg = new System.Windows.Forms.Button();
            this.LbShow = new System.Windows.Forms.Label();
            this.SelectNR = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextGetR
            // 
            this.TextGetR.Font = new System.Drawing.Font("楷体", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TextGetR.Location = new System.Drawing.Point(116, 100);
            this.TextGetR.MaxLength = 10000;
            this.TextGetR.Name = "TextGetR";
            this.TextGetR.Size = new System.Drawing.Size(294, 46);
            this.TextGetR.TabIndex = 8;
            // 
            // GetR
            // 
            this.GetR.AutoSize = true;
            this.GetR.Font = new System.Drawing.Font("楷体", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.GetR.Location = new System.Drawing.Point(46, 112);
            this.GetR.Name = "GetR";
            this.GetR.Size = new System.Drawing.Size(32, 34);
            this.GetR.TabIndex = 7;
            this.GetR.Text = "R";
            // 
            // TextGetN
            // 
            this.TextGetN.Font = new System.Drawing.Font("楷体", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TextGetN.Location = new System.Drawing.Point(116, 28);
            this.TextGetN.MaxLength = 10000;
            this.TextGetN.Name = "TextGetN";
            this.TextGetN.Size = new System.Drawing.Size(294, 46);
            this.TextGetN.TabIndex = 6;
            // 
            // GetN
            // 
            this.GetN.AutoSize = true;
            this.GetN.Font = new System.Drawing.Font("楷体", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.GetN.Location = new System.Drawing.Point(46, 37);
            this.GetN.Name = "GetN";
            this.GetN.Size = new System.Drawing.Size(32, 34);
            this.GetN.TabIndex = 5;
            this.GetN.Text = "N";
            // 
            // BtnStratSer
            // 
            this.BtnStratSer.Font = new System.Drawing.Font("楷体", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnStratSer.Location = new System.Drawing.Point(432, 28);
            this.BtnStratSer.Name = "BtnStratSer";
            this.BtnStratSer.Size = new System.Drawing.Size(152, 122);
            this.BtnStratSer.TabIndex = 10;
            this.BtnStratSer.Text = "启动";
            this.BtnStratSer.UseVisualStyleBackColor = true;
            this.BtnStratSer.Click += new System.EventHandler(this.BtnStratSer_Click);
            // 
            // TextMsg
            // 
            this.TextMsg.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TextMsg.Location = new System.Drawing.Point(18, 217);
            this.TextMsg.Multiline = true;
            this.TextMsg.Name = "TextMsg";
            this.TextMsg.Size = new System.Drawing.Size(572, 227);
            this.TextMsg.TabIndex = 12;
            // 
            // BtnSendMsg
            // 
            this.BtnSendMsg.Font = new System.Drawing.Font("楷体", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnSendMsg.Location = new System.Drawing.Point(18, 450);
            this.BtnSendMsg.Name = "BtnSendMsg";
            this.BtnSendMsg.Size = new System.Drawing.Size(245, 47);
            this.BtnSendMsg.TabIndex = 13;
            this.BtnSendMsg.Text = "随机生成N,R";
            this.BtnSendMsg.UseVisualStyleBackColor = true;
            this.BtnSendMsg.Click += new System.EventHandler(this.BtnSendMsg_Click);
            // 
            // LbShow
            // 
            this.LbShow.AutoSize = true;
            this.LbShow.Font = new System.Drawing.Font("楷体", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LbShow.Location = new System.Drawing.Point(12, 166);
            this.LbShow.Name = "LbShow";
            this.LbShow.Size = new System.Drawing.Size(151, 34);
            this.LbShow.TabIndex = 14;
            this.LbShow.Text = "显示窗口";
            // 
            // SelectNR
            // 
            this.SelectNR.Font = new System.Drawing.Font("楷体", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SelectNR.Location = new System.Drawing.Point(345, 450);
            this.SelectNR.Name = "SelectNR";
            this.SelectNR.Size = new System.Drawing.Size(245, 47);
            this.SelectNR.TabIndex = 16;
            this.SelectNR.Text = "查找当前N,R";
            this.SelectNR.UseVisualStyleBackColor = true;
            this.SelectNR.Click += new System.EventHandler(this.SelectNR_Click);
            // 
            // Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 527);
            this.Controls.Add(this.SelectNR);
            this.Controls.Add(this.LbShow);
            this.Controls.Add(this.BtnSendMsg);
            this.Controls.Add(this.TextMsg);
            this.Controls.Add(this.BtnStratSer);
            this.Controls.Add(this.TextGetR);
            this.Controls.Add(this.GetR);
            this.Controls.Add(this.TextGetN);
            this.Controls.Add(this.GetN);
            this.Name = "Server";
            this.Text = "服务端";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TextGetR;
        private System.Windows.Forms.Label GetR;
        private System.Windows.Forms.TextBox TextGetN;
        private System.Windows.Forms.Label GetN;
        private System.Windows.Forms.Button BtnStratSer;
        private System.Windows.Forms.TextBox TextMsg;
        private System.Windows.Forms.Button BtnSendMsg;
        private System.Windows.Forms.Label LbShow;
        private System.Windows.Forms.Button SelectNR;
    }
}

