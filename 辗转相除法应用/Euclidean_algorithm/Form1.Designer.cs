namespace Euclidean_algorithm
{
    partial class 欧几里得算法
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(欧几里得算法));
            this.calc_olg = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.lblCount2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Rcover = new System.Windows.Forms.Button();
            this.Lblworn = new System.Windows.Forms.Label();
            this.Lblworn2 = new System.Windows.Forms.Label();
            this.Lblworn3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // calc_olg
            // 
            this.calc_olg.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.calc_olg.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.calc_olg.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.calc_olg.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.calc_olg.Font = new System.Drawing.Font("楷体", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.calc_olg.ForeColor = System.Drawing.SystemColors.Desktop;
            this.calc_olg.Location = new System.Drawing.Point(19, 401);
            this.calc_olg.Name = "calc_olg";
            this.calc_olg.Size = new System.Drawing.Size(201, 69);
            this.calc_olg.TabIndex = 0;
            this.calc_olg.Text = "计算结果";
            this.calc_olg.UseVisualStyleBackColor = false;
            this.calc_olg.Click += new System.EventHandler(this.calc_olg_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("楷体", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox1.Location = new System.Drawing.Point(18, 76);
            this.textBox1.MaxLength = 10;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(297, 46);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("楷体", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox2.Location = new System.Drawing.Point(18, 198);
            this.textBox2.MaxLength = 10;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(298, 46);
            this.textBox2.TabIndex = 2;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("楷体", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(321, 34);
            this.label1.TabIndex = 3;
            this.label1.Text = "请输入一个正整数N:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("楷体", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(13, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(338, 34);
            this.label2.TabIndex = 4;
            this.label2.Text = "请输入一个正整数M：";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Font = new System.Drawing.Font("楷体", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblCount.Location = new System.Drawing.Point(322, 86);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(32, 34);
            this.lblCount.TabIndex = 5;
            this.lblCount.Text = "0";
            this.lblCount.Click += new System.EventHandler(this.lblCount_Click);
            // 
            // lblCount2
            // 
            this.lblCount2.AutoSize = true;
            this.lblCount2.Font = new System.Drawing.Font("楷体", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblCount2.Location = new System.Drawing.Point(322, 210);
            this.lblCount2.Name = "lblCount2";
            this.lblCount2.Size = new System.Drawing.Size(32, 34);
            this.lblCount2.TabIndex = 6;
            this.lblCount2.Text = "0";
            this.lblCount2.Click += new System.EventHandler(this.lblCount2_Click);
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("楷体", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox3.Location = new System.Drawing.Point(19, 323);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(297, 46);
            this.textBox3.TabIndex = 7;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("楷体", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(13, 286);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(219, 34);
            this.label3.TabIndex = 8;
            this.label3.Text = "计算结果为：";
            // 
            // Rcover
            // 
            this.Rcover.Font = new System.Drawing.Font("楷体", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Rcover.Location = new System.Drawing.Point(260, 401);
            this.Rcover.Name = "Rcover";
            this.Rcover.Size = new System.Drawing.Size(183, 69);
            this.Rcover.TabIndex = 9;
            this.Rcover.Text = "清零";
            this.Rcover.UseVisualStyleBackColor = true;
            this.Rcover.Click += new System.EventHandler(this.Rcover_Click);
            // 
            // Lblworn
            // 
            this.Lblworn.AutoSize = true;
            this.Lblworn.Font = new System.Drawing.Font("楷体", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lblworn.Location = new System.Drawing.Point(456, 36);
            this.Lblworn.Name = "Lblworn";
            this.Lblworn.Size = new System.Drawing.Size(103, 33);
            this.Lblworn.TabIndex = 10;
            this.Lblworn.Text = "注意!";
            // 
            // Lblworn2
            // 
            this.Lblworn2.AutoSize = true;
            this.Lblworn2.Font = new System.Drawing.Font("楷体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lblworn2.Location = new System.Drawing.Point(456, 86);
            this.Lblworn2.Name = "Lblworn2";
            this.Lblworn2.Size = new System.Drawing.Size(545, 25);
            this.Lblworn2.TabIndex = 11;
            this.Lblworn2.Text = "1.在输入M和N的时候不要输入小于等于0的数。";
            // 
            // Lblworn3
            // 
            this.Lblworn3.AutoSize = true;
            this.Lblworn3.Font = new System.Drawing.Font("楷体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lblworn3.Location = new System.Drawing.Point(457, 139);
            this.Lblworn3.Name = "Lblworn3";
            this.Lblworn3.Size = new System.Drawing.Size(428, 25);
            this.Lblworn3.TabIndex = 12;
            this.Lblworn3.Text = "2.本程序设计上M的值应小于N的值。";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("楷体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(457, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(571, 25);
            this.label4.TabIndex = 13;
            this.label4.Text = "3.当N是M的整数倍时，逆元不存在，程序返回0。";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("楷体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(457, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(324, 25);
            this.label5.TabIndex = 14;
            this.label5.Text = "4.N和M的输入框不能为空。";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(518, 304);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(404, 149);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // 欧几里得算法
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 482);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Lblworn3);
            this.Controls.Add(this.Lblworn2);
            this.Controls.Add(this.Lblworn);
            this.Controls.Add(this.Rcover);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.lblCount2);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.calc_olg);
            this.Name = "欧几里得算法";
            this.Text = "辗转相除法求逆元";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calc_olg;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Label lblCount2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Rcover;
        private System.Windows.Forms.Label Lblworn;
        private System.Windows.Forms.Label Lblworn2;
        private System.Windows.Forms.Label Lblworn3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

