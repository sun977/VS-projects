using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;   //引用MySql
using System.Security.Cryptography; //用于MD5加密

namespace 身份验证client
{
    public partial class Client : Form
    {
        public Client()
        {
            InitializeComponent();
            //关闭对文本框的非法线程操作检查
            TextBox.CheckForIllegalCrossThreadCalls = false;
        }
        //创建 1个客户端套接字 和1个负责监听服务端请求的线程  
        Socket socketClient = null;
        Thread threadClient = null;


        /// 连接服务端事件
        private void BtnConnectSer_Click(object sender, EventArgs e)
        {
            //定义一个套字节监听  包含3个参数(IP4寻址协议,流式连接,TCP协议)
            socketClient = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            //需要获取文本框中的IP地址
 
            IPAddress ipaddress = IPAddress.Parse("127.0.0.1");
            //将获取的ip地址和端口号绑定到网络节点endpoint上
         
           IPEndPoint endpoint = new IPEndPoint(ipaddress, int.Parse("8888"));
            //这里客户端套接字连接到网络节点(服务端)用的方法是Connect 而不是Bind
           try
            {
                socketClient.Connect(endpoint);
                MessageBox.Show("客户端连接服务端成功！");
                //this.TextMsg.AppendText("客户端连接服务端成功！" + "\r\n");//\r\n换行
                this.BtnConnectSer.Enabled = false;
                //创建一个线程 用于监听服务端发来的消息
                threadClient = new Thread(RecMsg);//后面有函数RecMsg
                //将窗体线程设置为与后台同步
                threadClient.IsBackground = true;
                //启动线程
                threadClient.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show("远程服务端断开，连接失败！");
     
            }
        }
         
        /// 接收信息函数
        
        public void RecMsg()       //----------------------------------------------接收信息函数
        {
            while (true) //持续监听服务端发来的消息
            {
                try
                {
                    //定义一个1M的内存缓冲区 用于临时性存储接收到的信息
                    byte[] arrRecMsg = new byte[1024 * 1024];
                    //将客户端套接字接收到的数据存入内存缓冲区, 并获取其长度
                    int length = socketClient.Receive(arrRecMsg);
                    //将套接字获取到的字节数组转换为人可以看懂的字符串
                    string strRecMsg = Encoding.UTF8.GetString(arrRecMsg, 0, length);
                    //string[] RecMsg = strRecMsg.Split('_');

                    //将发送的信息追加到聊天内容文本框中   GetCurrentTime()获取现在时间的函数
                    TextMsg.Text= strRecMsg;  //只用来接收N R 后面接收的覆盖掉前面的
                 
                }
                catch (Exception ex)
                {
                    MessageBox.Show("远程服务器已中断连接！");
                    //this.TextMsg.AppendText("远程服务器已中断连接！" + "\r\n");
                    this.BtnConnectSer.Enabled = true;
                    break;
                }
            }
        }

       
        /// 发送信息函数
        private void ClientSendMsg(string sendMsg)//--------------------------------发送信息函数
        {
            try
            {
                //将输入的内容字符串转换为机器可以识别的字节数组
                byte[] arrClientSendMsg = Encoding.UTF8.GetBytes(sendMsg);
                //调用客户端套接字发送字节数组
                socketClient.Send(arrClientSendMsg);
                //将发送的信息追加到聊天内容文本框中
                //TextMsg.AppendText("客户端" + GetCurrentTime() + "\r\n" + sendMsg + "\r\n");
            }
            catch (Exception ex)
            {
                MessageBox.Show("远程服务器已中断连接,无法发送消息！");
                //this.TextMsg.AppendText("远程服务器已中断连接,无法发送消息！" + "\r\n");
            }
        }

        //注册按钮
        private void BtnZC_Click(object sender, EventArgs e)  
        {

            //界面转换成注册表
            // ZhuCe zhuCe = new ZhuCe();
            //zhuCe.Show();

            if (TextName.Text == "")
            {
                MessageBox.Show("用户名不能为空！");
            }
            if (TextPwd.Text == "")
            {
                MessageBox.Show("密码不能为空!");
            }

            string RecNR = TextMsg.Text;
            string[] GetNR = RecNR.Split('_');//GetNR[0]=N GetNR[1]=R
            string Enc = Nmd52(GetNR[0], this.TextPwd.Text, GetNR[1]);                                                             
            string r = "1";//作为标记
            string sendTxt = r + '_' + this.TextName.Text + '_' + Enc;//server端把RecMsg[0]作为标识符
            ClientSendMsg(sendTxt.Trim()); //整体发送,然后根据_分割成三部分 标记符号_用户名_密码   
            MessageBox.Show("注册信息提交成功！");
        }

        //登录的时候接收服务端发来的N和R，然后本地加密之后发送给服务器
        private void BtnDL_Click(object sender, EventArgs e)
        {
            if (TextName.Text == "")
            {
                MessageBox.Show("用户名不能为空！");
            }
            if (TextPwd.Text == "")
            {
                MessageBox.Show("密码不能为空!");
            }
            if (TextMsg.Text == "")
            {
                MessageBox.Show("N和R不能为空!");
            }
            else
            {

                string RecNR = TextMsg.Text;
                string[] GetNR = RecNR.Split('_');//GetNR[0]=N GetNR[1]=R

                string r = "2";//作为标记       
                string Enc = Nmd52(GetNR[0], this.TextPwd.Text, GetNR[1]);
                string sendTxt = r + '_' + this.TextName.Text + '_' + Enc/*md5MsgPwd*/;//server端把RecMsg[0]作为标记符
                ClientSendMsg(sendTxt.Trim()); //整体发送,然后根据_分割成三部分 标记符_用户名_密码（密码部分后面加密）
                MessageBox.Show("用户名和密码提交成功！");
            
            }
        }

        private void BtnCheck_Click(object sender, EventArgs e)
        {
            if (TextName.Text == "")
            {
                MessageBox.Show("用户名不能为空!");
            }

            else
            {
                string r = "3";//作为标记
                string sendTxt = r + '_' + this.TextName.Text;//根据用户名查找N R 
                ClientSendMsg(sendTxt.Trim());
                MessageBox.Show("检查信息提交成功！");
            }

        }



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


        //11.15 新的尝试 H^2(p)==H(H(P)) N P+R
        public static string Nmd5(string a, string text)
        {
            int n = int.Parse(a);
            StringBuilder sb = new StringBuilder();

            while (n >= 1)
            {

                for (int k = 0; k < n; k++)
                {
                    MD5 md5 = MD5.Create();

                    byte[] buffer = System.Text.Encoding.Default.GetBytes(text);//转换
                    byte[] Md5buffer = md5.ComputeHash(buffer);//加密
                    //转换成16进制
                    for (int i = 0; i < Md5buffer.Length; i++)
                    {
                        sb.Append(Md5buffer[i].ToString("X2"));  //x-->将10进制转换为16进制。2-->每次都是两位数输出。
                    }
                    md5.Clear();
                    //sb.ToString();
                    text = sb.ToString();
                    sb.Length = 0;//清空sb
                    n -= 1;//n自减1
                }


            }
            return text;
        }


        //11.15        三个参数  N pwd R
        public static string Nmd52(string a, string str1, string str2)
        {
            int n = int.Parse(a);
            string text = str1 + str2;
            StringBuilder sb = new StringBuilder();

            while (n >= 1)
            {

                for (int k = 0; k < n; k++)
                {
                    MD5 md5 = MD5.Create();

                    byte[] buffer = System.Text.Encoding.Default.GetBytes(text);//转换
                    byte[] Md5buffer = md5.ComputeHash(buffer);//加密
                    //转换成16进制
                    for (int i = 0; i < Md5buffer.Length; i++)
                    {
                        sb.Append(Md5buffer[i].ToString("X2"));  //x-->将10进制转换为16进制。2-->每次都是两位数输出。
                    }
                    md5.Clear();
                    //sb.ToString();
                    text = sb.ToString();
                    sb.Length = 0;//清空sb
                    n -= 1;//n自减1
                }


            }
            return text;
        }

        /// ----------------------------------------------------------------------------------------
        ///MD5N次迭代函数  a=N str1=pwd  str2=R  可用
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
