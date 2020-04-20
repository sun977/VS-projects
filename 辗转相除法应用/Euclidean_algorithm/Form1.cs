using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Euclidean_algorithm
{
    public partial class 欧几里得算法 : Form
    {
        public 欧几里得算法()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Rcover_Click(object sender, EventArgs e)//清除
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";

        }

        private void calc_olg_Click(object sender, EventArgs e)//计算函数
        {

            if (textBox1.Text == "")
            {
                string stra = "输入不能为空！";
                MessageBox.Show(stra);
            }
            else if (textBox2.Text == "")
            {
                string stra = "输入不能为空！";
                MessageBox.Show(stra);
            }
            else
            {
                ulong x = ulong.Parse(textBox1.Text);  //没有限制最大程度输入，应该为6位限长
                ulong y = ulong.Parse(textBox2.Text);
                ulong m;
 
                while (JUST(x) == 1)
                {
                    //string strx = x.ToString();
                    string str1 = "输入的数N小于0！";
                    MessageBox.Show(str1);
                    break;
                }
                while (JUST(y) == 1 || JUST2(x, y) == 1)
                {
                   // string stry = y.ToString();
                    string str2 = "输入的数M小于0！或N<M!";
                    MessageBox.Show(str2);
                    break;
                }

                m = olg(y, x);
                textBox3.Text = m.ToString();               
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)//输入第一个正整数N的对话框
        {
            lblCount.Text = textBox1.Text.Count().ToString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)//输入第二个正整数A的对话框
        {
            lblCount2.Text = textBox2.Text.Count().ToString();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)//结果输出的对话框
        {

        }

        private void label1_Click(object sender, EventArgs e) //请输入一个正整数N-标签1
        {

        }

        private void label2_Click(object sender, EventArgs e) //请输入一个小于N的正整数-标签2
        {

        }

        private void lblCount_Click(object sender, EventArgs e)//计数器1
        {

        }

        private void lblCount2_Click(object sender, EventArgs e)//计数器2
        {

        }

        
        public ulong olg(ulong e,ulong h)//计算函数更改
        {
            ulong i;
            ulong k = 1;//计算商的个数
            ulong d=0;
            ulong[] a = new ulong[50];
            ulong[] r = new ulong[50];
            ulong[] b = new ulong[50];
            //ulong a[50]  = { 0 }, r[50] = { 0 }, b[50] = { 0 };//a 商 r 余
            if (e == 0)
            {
                return 0;
            }
            else
            {
                a[0] = h / e;   //取第一个商 
                r[0] = h % e;   //取第一个余数      
                if (r[0] == 0)
                {
                    return 0;
                }
                else
                {
                    a[1] = e / r[0];//取第二个商  
                    r[1] = e % r[0];//取第二个余数 
                    if (r[1] != 0)
                    {
                        for (i = 2; ; i++)
                        {
                            a[i] = r[i - 2] / r[i - 1]; //当r[i-1]=0时，程序会出错
                            r[i] = r[i - 2] % r[i - 1];
                            if (r[i] == 0)
                                break;
                            k++;
                        }
                        b[0] = a[k];
                        b[1] = b[0] * a[k - 1] + 1;
                        for (i = 2; i <= k; i++)
                        {
                            b[i] = a[k - i] * b[i - 1] + b[i - 2];
                        }
                        if ((k - 1) % 2 != 0)  // 计算商的时候最后一个余数为零的商除去
                            d = h - b[k]; //当K-1为奇数时
                        if ((k - 1) % 2 == 0)
                            d = b[k];  //当k-1为偶数时
                        return d;
                    }
                    else//r[1]=0时
                    {
                        return h - (a[0] + 1);
                    }
                }
            }
        }
      
        public ulong JUST(ulong a)  
        {
            if (a <= 0)
            {
                return 1;
            }
            else
                return 0;
        }

        public ulong JUST2(ulong a, ulong b)
        {
            if (a <= b)
            {
                return 1;
            }
            else
                return 0;
        }

    }
}
