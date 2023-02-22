using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StuSystem
{
   public class StuInfo
    {
        private int stuId;
        private int classId;
        private string stuName;
        private string stuSex;
        private int stuPhone;
        private string remark;

        public int StuId { get => stuId; set => stuId = value; }
        public int ClassId { get => classId; set => classId = value; }
        public string StuName { get => stuName; set => stuName = value; }
        public string StuSex { get => stuSex; set => stuSex = value; }
        public int StuPhone { get => stuPhone; set => stuPhone = value; }
        public string Remark { get => remark; set => remark = value; }
    }
}
