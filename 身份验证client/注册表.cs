using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Configuration; //
using System.Data.SqlClient;//
using MySql.Data.MySqlClient; //引用MySql
using System.Security.Cryptography; //用于MD5加密


namespace 身份验证client
{
    public partial class ZhuCe : Form
    {
        public ZhuCe()
        {
            InitializeComponent();
            //关闭对文本框的非法线程操作检查
            TextBox.CheckForIllegalCrossThreadCalls = false;
        }

        //创建 1个客户端套接字 和1个负责监听服务端请求的线程  
        Socket socketClient = null;
        Thread threadClient = null;

        private void BtnZhuCe_Click(object sender, EventArgs e)
        {
            if (TextName.Text == "")
            {
                MessageBox.Show("用户名不能为空！");
            }
            if (TextPwd.Text == "")
            {
                MessageBox.Show("密码不能为空!");
            }
       
            //定义一个套字节监听  包含3个参数(IP4寻址协议,流式连接,TCP协议)
            socketClient = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            //需要获取文本框中的IP地址
/*临时指定*/ string IPadd = "127.0.0.1";
            IPAddress ipaddress = IPAddress.Parse(IPadd/*this.TextIP.Text.Trim()*/);
            //将获取的ip地址和端口号绑定到网络节点endpoint上
/*临时指定*/ string Portadd = "8888"; 
            IPEndPoint endpoint = new IPEndPoint(ipaddress, int.Parse(Portadd));
            //这里客户端套接字连接到网络节点(服务端)用的方法是Connect 而不是Bind
            try
            {
                socketClient.Connect(endpoint);        
                this.BtnZhuCe.Enabled = false;
                threadClient.IsBackground = true;
                //启动线程
                threadClient.Start();
            }
            catch (Exception ex)
            {
                              
            }

            //发送给服务器username和password ----------------后面加密在这里改

            //接收函数未写 --先接收N和R，然后在加密

            //加密函数需要修改，两个参数
            // string md5MsgPwd = GetMd5(this.TextPwd.Text);
             string Enc = GetMd522(this.GetN.Text,this.TextPwd.Text,this.GetR.Text );//N PWD R 
             //string Dmd5MsgPwd = DGetMd5("2",this.TextPwd.Text,"3");
             string r = "1";//作为标记
             string sendTxt = r + '_' +this.TextName.Text + '_' + Enc;//server端把RecMsg[0]作为标识符
             ClientSendMsg(sendTxt.Trim()); //整体发送,然后根据_分割成三部分 标记符号_用户名_密码   
             this.Close();
        }

        /// 发送信息函数
        private void ClientSendMsg(string sendMsg)
        {
            try
            {
                //将输入的内容字符串转换为机器可以识别的字节数组
                byte[] arrClientSendMsg = Encoding.UTF8.GetBytes(sendMsg);
                //调用客户端套接字发送字节数组
                socketClient.Send(arrClientSendMsg);
                MessageBox.Show("注册信息提交成功！");
            }
            catch (Exception ex)
            {
                MessageBox.Show("注册信息提交失败！");
            }
        }

/// ----------------------------------------------------------------------------------------
        //md5加密字符串函数
        public static string GetMd5(string str)
        {
            string pwd = string.Empty;

            //实例化一个md5对像
            MD5 md5 = MD5.Create();

            // 加密后是一个字节类型的数组，这里要注意编码UTF8/Unicode等的选择　
            byte[] s = md5.ComputeHash(Encoding.UTF8.GetBytes(str));

            // 通过使用循环，将字节类型的数组转换为字符串，此字符串是常规字符格式化所得
            for (int i = 0; i < s.Length; i++)
            {
                // 将得到的字符串使用十六进制类型格式。格式后的字符是小写的字母，如果使用大写（X）则格式后的字符是大写字符 
                pwd = pwd + s[i].ToString("X");
            }

            return pwd;
        }
/// ----------------------------------------------------------------------------------------
        ///MD5N次迭代函数  a=N str1=pwd  str2=R
        public static string GetMd522(string a, string str1, string str2)//完成迭代加密  
        {
            int n = int.Parse(a);      
            string str = str1 + str2;
            MD5 md5 = MD5.Create();
            byte[] p = Encoding.UTF8.GetBytes(str);//转换成byte[]
            for (int i = 0; i < n; i++)
            {
                p = md5.ComputeHash(p); //循环N次
            }
            StringBuilder sb = new StringBuilder();

            foreach (byte b in p)//遍历每一个，X大写2位输出
            {
                sb.Append(b.ToString("X2"));
            }
            return sb.ToString();
        }
        /// ----------------------------------------------------------------------------------------

    }
}
