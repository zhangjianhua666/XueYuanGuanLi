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
    public partial class frmClass : Form
    {
        public frmClass()
        {
            InitializeComponent();
        }

        private void frmClass_Load(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            string sql = string.Format($"insert into ClassInfo(className,teacher,remark) values ({txtClassName.Text},'{txtTeacher.Text}','{txtRemark.Text}')");
            
            if (DBHelper.ExecuteNonQuery(sql))
            {
                MessageBox.Show("添加成功");
            }
        }
    }
}
