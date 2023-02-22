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
    public partial class frmStudent : Form
    {
        public frmStudent()
        {
            InitializeComponent();
        }

        private void frmStudent_Load(object sender, EventArgs e)
        {
            string sql2 = "select className from ClassInfo ";
            //  DataTable dt2 = DBHelper.GetDataTable(sql2);
            DBHelper dB = new DBHelper();

            cboClass.DataSource = dB.GetDataSet(sql2);
            cboClass.DisplayMember = "Name";
            //cboClass.ValueMember = "className";

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
           
            
            string sql3 = string.Format($"insert into StuInfo(classId,stuName,stuSex,stuPhone,Remark) values (1,'{txtName.Text}','男',12345678912,'')");
        }

        private void btnCanel_Click(object sender, EventArgs e)
        {

        }

        private void radM_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
