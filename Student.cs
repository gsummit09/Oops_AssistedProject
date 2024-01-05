using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops_StoreSchool_Data
{
    public class Student
    {
        private string sName;
        private int sClass;
        private char sSection;

        public string Name
        {
            get { return sName; }
            set { sName = value; }
        }
        public int Class
        {
            get { return sClass; }
            set { sClass = value; }
        }
        public char Section
        {
            get { return sSection; }
            set { sSection = value; }
        }

        public Student(string N,int C, char S)
        {
            this.sName = N;
            this.sClass = C;
            this.Section = S;
        }
    }
}
