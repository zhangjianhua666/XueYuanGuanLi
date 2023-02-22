using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StuSystem
{
   public class ClassInfo
    {
        private int classID;
        private string className;
        private string teacher;
        private string remark;

        public int ClassID { get => classID; set => classID = value; }
        public string ClassName { get => className; set => className = value; }
        public string Teacher { get => teacher; set => teacher = value; }
        public string Remark { get => remark; set => remark = value; }
    }
}
