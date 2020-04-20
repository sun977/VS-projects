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

namespace 访问控制_管理员
{
    public partial class admin : Form
    {
        MySqlConnection SQLCon;
        MySqlCommand SQLCmd;
        public admin()
        {
            InitializeComponent();
        }


        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnDLAd_Click(object sender, EventArgs e)
        {
            string Con = "server = 127.0.0.1; port = 3306; user = gust; password = gust; database = sk_test;";
            SQLCon = new MySqlConnection(Con);

            try
            {
                SQLCon.Open(); //连接数据库
                string searchStr = "SELECT * from resources";//sql语句
                MySqlDataAdapter adapter = new MySqlDataAdapter(searchStr, SQLCon);
                DataTable a = new DataTable();
                adapter.Fill(a);   //将查询的结果存到虚拟数据库a中的虚拟表tabuser中                                 
                this.DataGridView.DataSource = a;//将读取出来的内容显示到对话框
            }
            catch (Exception ex) //异常时执行下面语句
            {
                MessageBox.Show("运行出现错误！", "提示");
            }

        }

      
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Check_Click(object sender, EventArgs e)
        {
            string username = this.TextUser.Text.Trim();
            string filenum = this.TextFile.Text.Trim();
            string quan = this.TextQuan.Text.Trim();//数字1或0
            if (TextUser.Text == "" || TextFile.Text == "" || TextQuan.Text == "")//判空
            {
                MessageBox.Show("警告：用户名或文件名或权限值为空！", "提示");
            }
            else
            {
                try
                {
                    string searchStr = ("update resources set FILE" + filenum + "=" + quan + " where username='" + username + "';");
                    SQLCmd = new MySqlCommand(searchStr, SQLCon);
                    SQLCmd.ExecuteNonQuery();//执行
                    MessageBox.Show("修改成功！", "提示");
                    // bt_CONNECT_Click(sender, e);
                    TextUser.Text = "";
                    TextFile.Text = "";
                    TextQuan.Text = "";
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("运行出现错误！", "提示");
                }
            }
        }

    }
}
