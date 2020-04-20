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

namespace 身份验证
{
    public partial class Server : Form
    {
        public Server()
        {
            InitializeComponent();
            //关闭对文本框的非法线程操作检查
            TextBox.CheckForIllegalCrossThreadCalls = false;
        }

        Thread threadWatch = null; //负责监听客户端的线程
        Socket socketWatch = null; //负责监听客户端的套接字     

        static Dictionary<string, Socket> clientConnectionItems = new Dictionary<string, Socket> { };

        /// 启动服务
        private void BtnStratSer_Click(object sender, EventArgs e)
        {
            try
            {
                //定义一个套接字用于监听客户端发来的信息  包含3个参数(IP4寻址协议,流式连接,TCP协议)
                socketWatch = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                //服务端发送信息 需要1个IP地址和端口号
                IPAddress ipaddress = IPAddress.Parse("127.0.0.1"); //获取文本框输入的IP地址
                //将IP地址和端口号绑定到网络节点endpoint上 
                IPEndPoint endpoint = new IPEndPoint(ipaddress, int.Parse("8888")); //获取文本框上输入的端口号
                //监听绑定的网络节点
                socketWatch.Bind(endpoint);
                //将套接字的监听队列长度限制为20
                socketWatch.Listen(20);
                //创建一个监听线程 
                threadWatch = new Thread(WatchConnecting);
                //将窗体线程设置为与后台同步
                threadWatch.IsBackground = true;
                //启动线程
                threadWatch.Start();
                //启动线程后 txtMsg文本框显示相应提示
                TextMsg.AppendText("开始监听客户端传来的信息!" + "\r\n");
                this.BtnStratSer.Enabled = false;
            }
            catch (Exception ex)
            {
                TextMsg.AppendText("服务端启动服务失败!" + "\r\n");
                this.BtnStratSer.Enabled = true;
            }
        }


        //创建一个负责和客户端通信的套接字 
        Socket socConnection = null;

        /// 监听客户端发来的请求
        private void WatchConnecting()
        {

            while (true)  //持续不断监听客户端发来的请求
            {
                socConnection = socketWatch.Accept();
                TextMsg.AppendText("客户端连接成功! " + "\r\n");
                //创建一个通信线程 
                ParameterizedThreadStart pts = new ParameterizedThreadStart(ServerRecMsg);
                Thread thr = new Thread(pts);
                thr.IsBackground = true;
                //启动线程
                thr.Start(socConnection);
            }
        }

        
        /// <summary>
        /// 发送消息函数
        /// </summary>
        /// <param name="sendMsg"></param>
        private void ServerSendMsg(string sendMsg)
        {
            try  //正常时顺序执行语句
            {
                //将输入的字符串转换成 机器可以识别的字节数组
                byte[] arrSendMsg = Encoding.UTF8.GetBytes(sendMsg);
                //向客户端发送字节数组信息
                socConnection.Send(arrSendMsg);
                //将发送的字符串信息附加到文本框txtMsg上
                TextMsg.AppendText("服务器：" + GetCurrentTime()+ "\r\n" + sendMsg + "\r\n");
            }
            catch (Exception ex) //异常时执行下面语句
            {
                TextMsg.AppendText("客户端已断开连接,无法发送信息！" + "\r\n");
            }
        }

        /// <summary>
        /// 接收消息函数
        /// </summary>
        /// <param name="socketClientPara"></param>
        private void ServerRecMsg(object socketClientPara)
        {
            Socket socketServer = socketClientPara as Socket;
            while (true)
            {
                //创建一个内存缓冲区 其大小为1024*1024字节 
                byte[] arrServerRecMsg = new byte[1024 * 1024];
                try
                {
                        //将接收到的信息存入到内存缓冲区,并返回其字节数组的长度
                    int length = socketServer.Receive(arrServerRecMsg);
                        //将机器接受到的字节数组转换为人可以读懂的字符串
                    string strSRecMsg = Encoding.UTF8.GetString(arrServerRecMsg, 0, length);
                        //将发送的字符串信息附加到文本框txtMsg上 
                    string[] RecMsg = strSRecMsg.Split('_');   //分成RecMsg[0]=标记符,RecMsg[1]=用户名和RecMsg[2]=密码
                    this.TextMsg.AppendText("客户端：" +GetCurrentTime() + "\r\n" + strSRecMsg + "\r\n");
                   


                    //这里要开始分情况；1 注册--插入语句 2 登录--查询语句 3 查询当前N,R值
                    //--------------------------------------------------------------------------------------------------
                    if (int.Parse(RecMsg[0]) == 1)//注册--插入MySQL --存入数据库username和password，pwd不需要加密
                    {
                        //首先检查用户是否已经被注册
                        string constructorString2 = "server = 127.0.0.1; port = 3306; user = gust; password = gust; database = sk_test;";//root权限太高，出于安全考虑 改用gust
                        MySqlConnection myConnnect2 = new MySqlConnection(constructorString2);
                        myConnnect2.Open();//打开
                        MySqlCommand myCmd2 = new MySqlCommand("SELECT N,R from login2 where username='" + RecMsg[1] + "'; ", myConnnect2);//查找N R sql语句 
                        MySqlDataReader dataReader = myCmd2.ExecuteReader();
                        if (dataReader.HasRows) 
                        {
                            MessageBox.Show("该用户已被注册！");
                        }
                        else
                        {
                            string Enc = Nmd5("1", RecMsg[2]);//MD5加密 可用
                            string constructorString = "server = 127.0.0.1; port = 3306; user = gust; password = gust; database = sk_test;";//root权限太高，出于安全考虑 改用gust
                            MySqlConnection myConnnect = new MySqlConnection(constructorString);
                            myConnnect.Open();//打开
                            MySqlCommand myCmd = new MySqlCommand($"INSERT INTO login2(username,password,N,R) VALUES('{RecMsg[1]}','{Enc}','{this.TextGetN.Text}','{this.TextGetR.Text}');", myConnnect);//sql语句构造成功！插入完成！！$不可少                                                                                                                      
                            if (myCmd.ExecuteNonQuery() > 0)//ExecuteNonQuery()返回影响的行数（用于insert，update，delete），其他关键字返回-1
                            {
                                MessageBox.Show("注册成功！插入数据库成功！");//插入数据库成功！
                            }
                            this.BtnStratSer.Enabled = true;
                        }
                    }


                    if(int.Parse(RecMsg[0]) == 2)//登录--查询MySQL                        
                    {

                        string Enc = Nmd5("1",RecMsg[2]);//新的算法
                        //本地再计算一次N次迭代

                        string constructorString = "server = 127.0.0.1; port = 3306; user = gust; password = gust; database = sk_test;";//root权限太高，出于安全考虑 改用gust
                        MySqlConnection myConnnect = new MySqlConnection(constructorString);
                        myConnnect.Open();//打开
                        MySqlCommand myCmd = new MySqlCommand("UPDATE login2 SET times = times+1,N=N-1,password='" + RecMsg[2] + "' where username = '" + RecMsg[1] + "' and password = '" + Enc + "';", myConnnect);
                        //更新pwd，N值自减1 times自增1(记录用户登录次数)
                        if (myCmd.ExecuteNonQuery() > 0)//通过影响的行数！=0 判断语句被执行
                        {
                            MessageBox.Show("登录成功！插入数据库成功！");//插入数据库成功！
                          
                        }
                        else
                        {
                            MessageBox.Show("登录失败！用户名或密码错误！");
                        }

                    }


                    if (int.Parse(RecMsg[0]) == 3)
                    {   //N=1提示重新注册 
                        string constructorString = "server = 127.0.0.1; port = 3306; user = gust; password = gust; database = sk_test;";//root权限太高，出于安全考虑 改用gust
                        MySqlConnection myConnnect = new MySqlConnection(constructorString);
                        myConnnect.Open();//打开
                        MySqlCommand myCmd = new MySqlCommand("SELECT N,R from login2 where username='" + RecMsg[1] + "'; ", myConnnect);//查找N R sql语句 
                        MySqlDataReader dataReader = myCmd.ExecuteReader();

                        if (dataReader.HasRows)//判断是否存在N,R
                        {
                            //存在N,R
                            dataReader.Read();
                            TextGetN.Text = dataReader[0].ToString();//查到的N 
                            TextGetR.Text = dataReader[1].ToString();//查到的R
                            if (int.Parse(TextGetN.Text) == 1)
                            {
                                
                                string constructorString2 = "server = 127.0.0.1; port = 3306; user = gust; password = gust; database = sk_test;";//root权限太高，出于安全考虑 改用gust
                                MySqlConnection myConnnect2 = new MySqlConnection(constructorString2);
                                myConnnect2.Open();
                                MySqlCommand myCmdDel = new MySqlCommand("DELETE  from login2 where username='" + RecMsg[1] + "'and N ='1'; ", myConnnect2);//语句正确
                                if (myCmdDel.ExecuteNonQuery() > 0)
                                {
                                    MessageBox.Show("N的值为“1”，请重新注册用户!");//插入数据库成功！
                                    int N2 = Ran();
                                    int R2 = Ran2();
                                    TextGetN.Text = N2.ToString();
                                    TextGetR.Text = R2.ToString();
                                    string SendNR = N2.ToString() + "_" + R2.ToString();
                                    ServerSendMsg(SendNR.Trim());//产生新的N R值并发送给客户端

                                }
                                else
                                {
                                    MessageBox.Show("删除语句未正常执行！");
                                }
                            }  

                        }
                        else
                        {
                            //不存在N,R
                            MessageBox.Show("该用户不存在！请先注册！");
                            //发送新的N,R给用户，方便注册
                            int N2 = Ran();
                            int R2 = Ran2();
                            TextGetN.Text = N2.ToString();
                            TextGetR.Text = R2.ToString();
                            string SendNR = N2.ToString() + "_" + R2.ToString();
                            ServerSendMsg(SendNR.Trim());//产生新的N R值并发送给客户端
                        }

                    }


                }
                catch (Exception ex)
                {

                    TextMsg.AppendText("客户端已断开连接！" + "\r\n");         
                    break;
                }
            }
        }


        /// 发送消息到客户端----------------------主要用于给客户端回显消息
        private void BtnSendMsg_Click(object sender, EventArgs e)
        {
            int N = Ran(); //N这里设定为1-10，支持N足够大
            int R = Ran2();
            this.TextGetN.Text = N.ToString();
            this.TextGetR.Text = R.ToString();//从这里  可以拿到N R
            string SendNR = N.ToString() + "_" + R.ToString();
            ServerSendMsg(SendNR.Trim());//发送N R

        }


        private void SelectNR_Click(object sender, EventArgs e)
        {
            string GN = this.TextGetN.Text;
            string GR = this.TextGetR.Text;
            string SendNR = GN + "_" + GR;
            ServerSendMsg(SendNR.Trim());//发送N R
        }

        //服务器端只需要把收到的H^N(pwd||R)在做一次md5就好

        //11.15 新的尝试 H^2(p)==H(H(P))
        public static string Nmd5(string a, string text)
        {
            int n = int.Parse(a);
            StringBuilder sb = new StringBuilder();
            while (n >= 1)
            {
                for (int k = 0; k < n; k++)
                {
                    MD5 md5 = MD5.Create();//创建MD5实例
                    byte[] buffer = System.Text.Encoding.Default.GetBytes(text);//转换成byte[]
                    byte[] Md5buffer = md5.ComputeHash(buffer);//加密
                    //转换成16进制
                    for (int i = 0; i < Md5buffer.Length; i++)
                    {
                        sb.Append(Md5buffer[i].ToString("X2"));  //x-->将10进制转换为16进制。2-->每次都是两位数输出。
                    }
                    md5.Clear();//释放MD5计算空间
                    text = sb.ToString();
                    sb.Length = 0;//清空sb，以便下次给text赋值
                    n -= 1;//n自减1
                }
            }
            return text;
        }

        /// ----------------------------------------------------------------------------------------
        ///MD5N次迭代函数  a=N str1=pwd  str2=R   不可用   H^2(p)！=H(H(P))
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

        //错误 H^2(p)！=H(H(P))
        public static string GetMd523(string a, string str)//完成迭代加密  本地只需要加密一次
        {
            int n = int.Parse(a);
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

        //调用 int N =Ran(); 
        //调用 int R =Ran();
        public int Ran()  //随机数不发送1 
        {
            int num = new int();
            Random Random = new Random();
            num = Random.Next(5, 21);//5-20 随机数
            return num;
        }  //随机数支持int型数值上限

        public int Ran2() //随机数不发送1
        {
            int num = new int();
            Random Random = new Random();
            num = Random.Next(5, 31);//5-30 随机数
            return num;
        }


        /// 获取当前系统时间的方法
        private DateTime GetCurrentTime()
        {
            DateTime currentTime = new DateTime();
            currentTime = DateTime.Now;
            return currentTime;
        }

    }
}
