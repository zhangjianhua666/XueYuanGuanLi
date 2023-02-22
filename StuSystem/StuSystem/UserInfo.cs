using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StuSystem
{
   public class UserInfo
    {
        //创建UserInfo类和封装字段
        private int userId;
        private string userName;
        private string userPwd;

        public int UserId { get => userId; set => userId = value; }
        public string UserName { get => userName; set => userName = value; }
        public string UserPwd { get => userPwd; set => userPwd = value; }
    }
}
