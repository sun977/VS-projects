namespace 身份验证client
{
    partial class ZhuCe
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
            this.LbName = new System.Windows.Forms.Label();
            this.TextName = new System.Windows.Forms.TextBox();
            this.LbPwd = new System.Windows.Forms.Label();
            this.TextPwd = new System.Windows.Forms.TextBox();
            this.BtnZhuCe = new System.Windows.Forms.Button();
            this.GetN = new System.Windows.Forms.TextBox();
            this.GetR = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LbName
            // 
            this.LbName.AutoSize = true;
            this.LbName.Font = new System.Drawing.Font("楷体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LbName.Location = new System.Drawing.Point(48, 50);
            this.LbName.Name = "LbName";
            this.LbName.Size = new System.Drawing.Size(90, 25);
            this.LbName.TabIndex = 0;
            this.LbName.Text = "用户名";
            // 
            // TextName
            // 
            this.TextName.Font = new System.Drawing.Font("楷体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TextName.Location = new System.Drawing.Point(160, 39);
            this.TextName.Name = "TextName";
            this.TextName.Size = new System.Drawing.Size(258, 36);
            this.TextName.TabIndex = 1;
            this.TextName.Text = "TextName";
            // 
            // LbPwd
            // 
            this.LbPwd.AutoSize = true;
            this.LbPwd.Font = new System.Drawing.Font("楷体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LbPwd.Location = new System.Drawing.Point(48, 134);
            this.LbPwd.Name = "LbPwd";
            this.LbPwd.Size = new System.Drawing.Size(90, 25);
            this.LbPwd.TabIndex = 2;
            this.LbPwd.Text = "密  码";
            // 
            // TextPwd
            // 
            this.TextPwd.Font = new System.Drawing.Font("楷体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TextPwd.Location = new System.Drawing.Point(160, 123);
            this.TextPwd.Name = "TextPwd";
            this.TextPwd.Size = new System.Drawing.Size(258, 36);
            this.TextPwd.TabIndex = 3;
            this.TextPwd.Text = "TextPwd";
            // 
            // BtnZhuCe
            // 
            this.BtnZhuCe.Font = new System.Drawing.Font("楷体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnZhuCe.Location = new System.Drawing.Point(53, 273);
            this.BtnZhuCe.Name = "BtnZhuCe";
            this.BtnZhuCe.Size = new System.Drawing.Size(365, 48);
            this.BtnZhuCe.TabIndex = 4;
            this.BtnZhuCe.Text = "注册";
            this.BtnZhuCe.UseVisualStyleBackColor = true;
            this.BtnZhuCe.Click += new System.EventHandler(this.BtnZhuCe_Click);
            // 
            // GetN
            // 
            this.GetN.Font = new System.Drawing.Font("楷体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.GetN.Location = new System.Drawing.Point(53, 201);
            this.GetN.Name = "GetN";
            this.GetN.Size = new System.Drawing.Size(177, 36);
            this.GetN.TabIndex = 5;
            this.GetN.Text = "N";
            // 
            // GetR
            // 
            this.GetR.Font = new System.Drawing.Font("楷体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.GetR.Location = new System.Drawing.Point(236, 201);
            this.GetR.Name = "GetR";
            this.GetR.Size = new System.Drawing.Size(182, 36);
            this.GetR.TabIndex = 6;
            this.GetR.Text = "R";
            // 
            // ZhuCe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 350);
            this.Controls.Add(this.GetR);
            this.Controls.Add(this.GetN);
            this.Controls.Add(this.BtnZhuCe);
            this.Controls.Add(this.TextPwd);
            this.Controls.Add(this.LbPwd);
            this.Controls.Add(this.TextName);
            this.Controls.Add(this.LbName);
            this.Name = "ZhuCe";
            this.Text = "注册表";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LbName;
        private System.Windows.Forms.TextBox TextName;
        private System.Windows.Forms.Label LbPwd;
        private System.Windows.Forms.TextBox TextPwd;
        private System.Windows.Forms.Button BtnZhuCe;
        private System.Windows.Forms.TextBox GetN;
        private System.Windows.Forms.TextBox GetR;
    }
}