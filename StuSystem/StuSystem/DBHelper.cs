using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Data.Common;

namespace StuSystem
{
    class DBHelper
    {
        //数据库连接字符串
        public static string connstring = "server=.;database=MySchool;uid=sa;pwd=123456";
        //创建连接对象
        public static SqlConnection conn = null;
        //初始化数据库连接
        //public static void InitConnection()
        //{
        //    //如果连接对象不存在，则创建连接
        //    if (conn == null)
        //        conn = new SqlConnection(connstring);
        //    //如果连接对象关闭，则打开连接
        //    if (conn.State == ConnectionState.Closed)
        //        conn.Open();
        //    //如果连接中断，则重新启动连接
        //    if (conn.State == ConnectionState.Broken)
        //    {
        //        conn.Open();
        //        conn.Close();
        //    }
        //}
        //查询，获取DataReader
        public static SqlDataReader GetDataReader1(string sqlstr)
        {
            conn = new SqlConnection(connstring);
            SqlCommand cmd = new SqlCommand(sqlstr, conn);
            //CommandBehavior.CloseConnection命令行为：当DataReader对象被关闭时，自动关闭
            //占用的连接对象
            return cmd.ExecuteReader(CommandBehavior.CloseConnection);
        }
        //查询，获取DataTabe
        public static DataAdapter GetDataReader(string sqlstr)
        {
            conn = new SqlConnection(connstring);
            DataTable dt = new DataTable();

            SqlDataAdapter dap = new SqlDataAdapter(sqlstr, conn);
            dap.Fill(dt);
            conn.Close();
            //conn.Dispose();
            return dap;
            //CommandBehavior.CloseConnection命令行为：当DataReader对象被关闭时，自动关闭
            //占用的连接对象


        }
        public static DataTable GetDataTable(string sqlstr)
        {
            conn = new SqlConnection(connstring);
            DataTable dt = new DataTable();
           
            SqlDataAdapter dap = new SqlDataAdapter(sqlstr,conn);
            dap.Fill(dt);
            conn.Close();
            //conn.Dispose();
            return dt;
            //CommandBehavior.CloseConnection命令行为：当DataReader对象被关闭时，自动关闭
            //占用的连接对象

            
        }
        //增、删、改
        public static bool ExecuteNonQuery(string sqlstr)
        {
            conn = new SqlConnection(connstring);
            conn.Open();
            SqlCommand cmd = new SqlCommand(sqlstr, conn);
            int result = cmd.ExecuteNonQuery();
            conn.Close();
            return result > 0;
        }
        //执行聚合函数
        public static object ExecuteScalar(string sqlstr)
        {
            conn = new SqlConnection(connstring);
            SqlCommand cmd = new SqlCommand(sqlstr, conn);
            object result = cmd.ExecuteScalar();
            conn.Close();
            return result;
        }
        
        public DataSet GetDataSet(string sql)
        {
            conn = new SqlConnection(connstring);
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
        
    }
}
