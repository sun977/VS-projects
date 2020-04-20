namespace 访问控制_管理员
{
    partial class admin
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
            this.BtnXiuGai = new System.Windows.Forms.Button();
            this.LBUser = new System.Windows.Forms.Label();
            this.TextUser = new System.Windows.Forms.TextBox();
            this.LBFile = new System.Windows.Forms.Label();
            this.TextFile = new System.Windows.Forms.TextBox();
            this.LBquan = new System.Windows.Forms.Label();
            this.TextQuan = new System.Windows.Forms.TextBox();
            this.BtnDLAd = new System.Windows.Forms.Button();
            this.DataGridView = new System.Windows.Forms.DataGridView();
            this.LBtitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnXiuGai
            // 
            this.BtnXiuGai.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnXiuGai.Location = new System.Drawing.Point(766, 371);
            this.BtnXiuGai.Name = "BtnXiuGai";
            this.BtnXiuGai.Size = new System.Drawing.Size(79, 46);
            this.BtnXiuGai.TabIndex = 1;
            this.BtnXiuGai.Text = "修改";
            this.BtnXiuGai.UseVisualStyleBackColor = true;
            this.BtnXiuGai.Click += new System.EventHandler(this.Check_Click);
            // 
            // LBUser
            // 
            this.LBUser.AutoSize = true;
            this.LBUser.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LBUser.Location = new System.Drawing.Point(25, 383);
            this.LBUser.Name = "LBUser";
            this.LBUser.Size = new System.Drawing.Size(87, 25);
            this.LBUser.TabIndex = 3;
            this.LBUser.Text = "用户：";
            // 
            // TextUser
            // 
            this.TextUser.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TextUser.Location = new System.Drawing.Point(104, 381);
            this.TextUser.MaxLength = 10;
            this.TextUser.Name = "TextUser";
            this.TextUser.Size = new System.Drawing.Size(118, 36);
            this.TextUser.TabIndex = 4;
            this.TextUser.Text = "用户名";
            // 
            // LBFile
            // 
            this.LBFile.AutoSize = true;
            this.LBFile.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LBFile.Location = new System.Drawing.Point(237, 384);
            this.LBFile.Name = "LBFile";
            this.LBFile.Size = new System.Drawing.Size(87, 25);
            this.LBFile.TabIndex = 5;
            this.LBFile.Text = "文件：";
            // 
            // TextFile
            // 
            this.TextFile.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TextFile.Location = new System.Drawing.Point(330, 380);
            this.TextFile.MaxLength = 1;
            this.TextFile.Name = "TextFile";
            this.TextFile.Size = new System.Drawing.Size(118, 36);
            this.TextFile.TabIndex = 6;
            this.TextFile.Text = "文件名";
            // 
            // LBquan
            // 
            this.LBquan.AutoSize = true;
            this.LBquan.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LBquan.Location = new System.Drawing.Point(454, 384);
            this.LBquan.Name = "LBquan";
            this.LBquan.Size = new System.Drawing.Size(87, 25);
            this.LBquan.TabIndex = 7;
            this.LBquan.Text = "权限：";
            // 
            // TextQuan
            // 
            this.TextQuan.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TextQuan.Location = new System.Drawing.Point(535, 381);
            this.TextQuan.MaxLength = 1;
            this.TextQuan.Name = "TextQuan";
            this.TextQuan.Size = new System.Drawing.Size(118, 36);
            this.TextQuan.TabIndex = 8;
            this.TextQuan.Text = "0";
            // 
            // BtnDLAd
            // 
            this.BtnDLAd.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnDLAd.Location = new System.Drawing.Point(670, 372);
            this.BtnDLAd.Name = "BtnDLAd";
            this.BtnDLAd.Size = new System.Drawing.Size(79, 46);
            this.BtnDLAd.TabIndex = 9;
            this.BtnDLAd.Text = "刷新";
            this.BtnDLAd.UseVisualStyleBackColor = true;
            this.BtnDLAd.Click += new System.EventHandler(this.BtnDLAd_Click);
            // 
            // DataGridView
            // 
            this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView.Location = new System.Drawing.Point(13, 37);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.RowHeadersWidth = 51;
            this.DataGridView.RowTemplate.Height = 27;
            this.DataGridView.Size = new System.Drawing.Size(832, 326);
            this.DataGridView.TabIndex = 11;
            // 
            // LBtitle
            // 
            this.LBtitle.AutoSize = true;
            this.LBtitle.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LBtitle.Location = new System.Drawing.Point(325, 0);
            this.LBtitle.Name = "LBtitle";
            this.LBtitle.Size = new System.Drawing.Size(162, 25);
            this.LBtitle.TabIndex = 12;
            this.LBtitle.Text = "用户权限列表";
            // 
            // admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 430);
            this.Controls.Add(this.LBtitle);
            this.Controls.Add(this.DataGridView);
            this.Controls.Add(this.BtnDLAd);
            this.Controls.Add(this.TextQuan);
            this.Controls.Add(this.LBquan);
            this.Controls.Add(this.TextFile);
            this.Controls.Add(this.LBFile);
            this.Controls.Add(this.TextUser);
            this.Controls.Add(this.LBUser);
            this.Controls.Add(this.BtnXiuGai);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "admin";
            this.Text = "管理员";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnXiuGai;
        private System.Windows.Forms.Label LBUser;
        private System.Windows.Forms.TextBox TextUser;
        private System.Windows.Forms.Label LBFile;
        private System.Windows.Forms.TextBox TextFile;
        private System.Windows.Forms.Label LBquan;
        private System.Windows.Forms.TextBox TextQuan;
        private System.Windows.Forms.Button BtnDLAd;
        private System.Windows.Forms.DataGridView DataGridView;
        private System.Windows.Forms.Label LBtitle;
    }
}

