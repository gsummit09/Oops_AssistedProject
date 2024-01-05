using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops_StoreSchool_Data
{
    public class Subject
    {
        private string subName;
        private string subCode;
       // private string Teacher;

        public string Name
        {
            get { return subName; }
            set { subName = value; }
        }
        public string SubCode
        {
            get { return subCode; }
            set { subCode = value; }
        }

        public Subject(string N, string C)
        {
            this.Name = N;
            this.SubCode = C;
        }
    }
}
