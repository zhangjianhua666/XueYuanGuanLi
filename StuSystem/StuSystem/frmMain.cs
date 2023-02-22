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
    public partial class frmMain : Form
    {
        //定义变量，接收当前登录的用户名
        string logName;
        //定义
        public List<StuInfo> stuInfos = null;
        public StuInfo StuInfo = null;
        public frmMain(string name)
        {
            InitializeComponent();
            this.logName = name;
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            frmLogin frmLogin = new frmLogin();
            LogNameTxt.Text = LogNameTxt.Text + logName;
            //获取学生的信息
            string sql = "select * from StuInfo";
            DataTable dt = DBHelper.GetDataTable(sql);

            //循环输出信息
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                //新建一行
                ListViewItem item = new ListViewItem(dt.Rows[i]["stuId"].ToString());
                //添加数据到这一行
                item.SubItems.Add(dt.Rows[i]["classId"].ToString());
                item.SubItems.Add(dt.Rows[i]["stuName"].ToString());
                item.SubItems.Add(dt.Rows[i]["stuSex"].ToString());
                item.SubItems.Add(dt.Rows[i]["stuPhone"].ToString());
                item.SubItems.Add(dt.Rows[i]["Remark"].ToString());
                //将新建的这一行添加到组件
                lvStu.Items.Add(item);

            }
            tvClass.Nodes.Add(new TreeNode("安职院"));
            //获取班级的信息
            string sql2 = "select className from ClassInfo ";
            DataTable dt2 = DBHelper.GetDataTable(sql2);
            // tvClass.Nodes[0].Nodes.Add(new TreeNode("NodeText"));
            for (int i = 0; i < dt2.Rows.Count; i++)
            {
                // tvClass.Nodes[i].Nodes.Add(new TreeNode(dt.Rows[i].ToString()));
                //创建一个节点
                TreeNode nd = new TreeNode();
                nd.Text = dt2.Rows[i]["className"].ToString();
                //treeView_TREE 为控件的name
                // 有关节点的操作使用 Nodes 如：添加根节点
                tvClass.Nodes.Add(nd);


            }



        }

        private void 添加学生信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmStudent frm = new frmStudent();
            frm.Show();
        }

        private void 添加班级信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClass frmClass = new frmClass();
            frmClass.Show();
        }
    }
}
