using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;   //引用MySql，记得引用库
using System.Security.Cryptography; //用于MD5加密

namespace 访问控制
{
    public partial class client : Form
    {
        public client()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 注册按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnRegister_Click(object sender, EventArgs e)
        {
            try
            {


                if (username.Text == "" || password.Text == "")//判空
                {
                    MessageBox.Show("用户名或密码不能为空！", "提示");
                }
                else//打开数据库插入用户名和密码
                {
                    string username = this.username.Text.Trim();//暂时备份用户名和密码
                    string password = this.password.Text.Trim();
                    string Enc = Md5(password);//md5加密密码

                    //首先检查用户是否已经被注册
                    string constructorString = "server = 127.0.0.1; port = 3306; user = gust; password = gust; database = sk_test;";
                    MySqlConnection myConnnect = new MySqlConnection(constructorString);
                    myConnnect.Open();//打开数据库

                    MySqlCommand myCmd = new MySqlCommand("SELECT times from user_table where username='" + username + "' and password='" + Enc/*password*/ + "'; ", myConnnect);//看select语句是否执行
                    MySqlDataReader dataReader = myCmd.ExecuteReader();//如存在times的，将会存在dataReader[0]中
                    if (dataReader.HasRows)
                    {
                        MessageBox.Show("该用户已被注册！","提示");
                    }
                    else
                    {
                        myConnnect.Close();//关闭上一个dataReader

                        string constructorString2 = "server = 127.0.0.1; port = 3306; user = gust; password = gust; database = sk_test;";
                        MySqlConnection myConnnect2 = new MySqlConnection(constructorString2);
                        myConnnect2.Open();//打开数据库

                        //插入用户名和密码到user_table表-----密码未加密
                        MySqlCommand myCmd2 = new MySqlCommand($"INSERT INTO user_table(username,password) VALUES('{username}','{Enc/*password*/}');", myConnnect2);
                        //插入用户名到resources表---数据库默认权限是0
                        MySqlCommand myCmd3 = new MySqlCommand($"INSERT INTO resources(username) VALUES('{username}');", myConnnect2);

                        if (myCmd2.ExecuteNonQuery() > 0 && myCmd3.ExecuteNonQuery() > 0)//用and（&&），两句同时满足才算插入成功
                                                                                         //ExecuteNonQuery()返回影响的行数（用于insert，update，delete），其他关键字返回-1
                        {
                            MessageBox.Show("注册成功！插入数据库成功！","提示");//插入数据库成功！
                        }
                        myConnnect2.Close();//及时关闭数据库连接

                    }

                }
            }
            catch (Exception ex) //异常时执行下面语句
            {
                MessageBox.Show("运行出现错误！","提示");
                //TextBox.AppendText("运行出现错误！" + "\r\n");
            }
        }

        string Username;
        string EnPwd;

        /// <summary>
        /// 登录按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (username.Text == "" || password.Text == "")//判空
                {
                    MessageBox.Show("用户名或密码不能为空！", "提示");
                }
                else
                {
                    string username = this.username.Text.Trim();//暂时备份用户名和密码
                    string password = this.password.Text.Trim();
                    string Enc = Md5(password);//md5加密密码

                    string constructor = "server = 127.0.0.1; port = 3306; user = gust; password = gust; database = sk_test;";
                    MySqlConnection myCon = new MySqlConnection(constructor);
                    myCon.Open();//打开数据库

                    MySqlCommand myCmd = new MySqlCommand("UPDATE user_table SET times = times+1 where username = '" +username+ "' and password = '" + Enc + "';", myCon);
                    //更新pwd，N值自减1 times自增1(记录用户登录次数)
                    if (myCmd.ExecuteNonQuery() > 0)//通过影响的行数！=0 判断语句被执行
                    {
                        MessageBox.Show("登录成功！","提示");//插入数据库成功！
                        Username = username;// 用户名和密码变成全局变量
                        EnPwd = Enc;
                    }
                    else
                    {
                        MessageBox.Show("登录失败！用户名或密码错误！","提示");
                    }
                    myCon.Close();
                }

            }
            catch (Exception ex) //异常时执行下面语句
            {
                MessageBox.Show("运行出现错误！", "提示");
                //TextBox.AppendText("运行出现错误！" + "\r\n");
            }

        }

        /// <summary>
        /// 查看用户当前权限
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Check_Click(object sender, EventArgs e)
        {
            try
            {
                string constructorString = "server = 127.0.0.1; port = 3306; user = gust; password = gust; database = sk_test;";
                MySqlConnection myConnnect = new MySqlConnection(constructorString);
                myConnnect.Open();//打开
                MySqlCommand myCmd = new MySqlCommand("SELECT * from resources where username='" +Username+ "'; ", myConnnect);
                MySqlDataReader dataReader = myCmd.ExecuteReader();//从数据库中读出当前的权限值（1，0），dataRearder[0-4]
                if (dataReader.HasRows)//如果存在数据
                {
                    dataReader.Read();//读取数据
                    string d1 = dataReader[0].ToString();//用户名
                    string d2 = dataReader[1].ToString();
                    string d3 = dataReader[2].ToString();
                    string d4 = dataReader[3].ToString();
                    string d5 = dataReader[4].ToString();
                    string d6 = dataReader[5].ToString();
                    TextBox.AppendText("用户"+d1+"拥有的权限"+"\r\n");
                    TextBox.AppendText("文件 1 2 3 4 5\r\n");//\r\n换行
                    TextBox.AppendText("权限 "+d2+" "+d3+" "+d4+" "+d5+" "+d6+"\r\n");
                    //一行输出//TextBox.AppendText("用户"+dataReader[0].ToString()+"的权限："+"FILE1"+":"+dataReader[1].ToString()+" "+"FILE2"+":"+dataReader[2].ToString()+" "+"FILE3" +":"+dataReader[3].ToString() + " " + "FILE4"+":"+dataReader[4].ToString() + " " + "FILE5"+":"+dataReader[5].ToString()+"\r\n");
                }
                else
                {
                    MessageBox.Show("访问数据不存在！","提示");
                }
                myConnnect.Close();
            }
            catch (Exception ex) //异常时执行下面语句
            {
              MessageBox.Show("运行出现错误！", "提示");
                //TextBox.AppendText("运行出现错误！" + "\r\n");
            }


        }

        /// <summary>
        /// 访问文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void VisitFile_Click(object sender, EventArgs e)
        {
            try
            {

                string constructorString = "server = 127.0.0.1; port = 3306; user = gust; password = gust; database = sk_test;";
                MySqlConnection myConnnect = new MySqlConnection(constructorString);
                myConnnect.Open();//打开

                string filenum = this.FileBox.Text.Trim();
                if (filenum == "")
                {
                    MessageBox.Show("文件名为空！", "提示");
                }
                else if (int.Parse(filenum) > 5|| int.Parse(filenum) <= 0)
                {
                    MessageBox.Show("没有此文件！", "提示");
                }
                else
                {
                    MySqlCommand myCmd = new MySqlCommand("SELECT FILE" + filenum + " from resources where username='" + Username + "'; ", myConnnect);
                    MySqlDataReader dataReader = myCmd.ExecuteReader();
                    if (dataReader.HasRows)//如果存在数据
                    {
                        dataReader.Read();//读取数据
                        string auth = dataReader[0].ToString();
                        if (auth.CompareTo("0") == 0)//比较，如果权限=0，提示无权访问
                        {
                            MessageBox.Show("用户无权访问该文件！", "提示");
                        }
                        else
                        {
                            MessageBox.Show("访问成功！", "提示");
                            //可以根据文件编号打开对应的TXT文件
                            System.Diagnostics.ProcessStartInfo info = new System.Diagnostics.ProcessStartInfo();//定义一个ProcessStartInfo实例
                            info.WorkingDirectory = Application.StartupPath;//设置启动进程的初始目录
                            //info.FileName = @"test.txt";
                            string path = "E:\\专业课程文件\\网络安全\\访问控制实验\\file"+filenum+".txt";
                            info.FileName = path;
                            info.Arguments = "";//设置启动进程的参数
                            try
                            {
                                System.Diagnostics.Process.Start(info);//打开文件
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("文件打开失败！");
                            }

                        }

                    }
                }
            }
            catch (Exception ex) //异常时执行下面语句
            {
                MessageBox.Show("运行出现错误！", "提示");
                //TextBox.AppendText("运行出现错误！" + "\r\n");
            }
        }
        /// <summary>
        /// MD5加密函数
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static string Md5(string text)
        {
        
            StringBuilder sb = new StringBuilder();
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
            return text;
        }
    }

   
}
