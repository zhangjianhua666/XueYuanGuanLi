using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StuSystem
{
    public partial class frmLogin : Form
    {
        //定义公开的用户名
        public string LogName = null;
        //定义用户登陆类
        public UserInfo userInfo = null;
        //定义用户登陆泛型集合字典
        public Dictionary<string, string> userInfoDic = null;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
           
            try
            {
                try
                {
                    //实例化
                    userInfo = new UserInfo();
                    userInfoDic = new Dictionary<string, string>();
                    string sql = "select * from UserInfo";
                    DataTable dt = new DataTable();
                    dt = DBHelper.GetDataTable(sql);
                    //循环将数据存入数组
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        userInfo.UserName = dt.Rows[i]["userName"].ToString();
                        userInfo.UserPwd = dt.Rows[i]["userPwd"].ToString();
                        userInfoDic.Add(userInfo.UserName, userInfo.UserPwd);
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
                if ((txtName.Text == "") || (txtPwd.Text == ""))
                {
                    MessageBox.Show("你tm请输入用户名，密码");
                }
                else if (userInfoDic[txtName.Text] == txtPwd.Text)
                {
                    frmMain frmMain = new frmMain(txtName.Text);
                    frmMain.Show();
                    LogName = txtName.Text;
                    this.Hide();
                }
            }
            catch (Exception ex2)
            {

                MessageBox.Show("用户未注册");
            }

            


        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }

    internal class StuInfo<T>
    {
    }
}
