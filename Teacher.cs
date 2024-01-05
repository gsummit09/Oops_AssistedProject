using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops_StoreSchool_Data
{
    public class Teacher
    {
        private string tName;
        private string tSubject;
        private string tTeacherClass;
        private string tSection;

        public string Name
        { 
            get { return tName; }
            set { tName = value; }
        }
        public string Subject
        {
            get { return tSubject; }
            set { tSubject = value; }
        }
        public string TeacherClass
        { 
            get { return tTeacherClass; }
            set {  tTeacherClass = value; }
        }
        public string Section
        {
            get { return tSection; }
            set { tSection = value; }
        }

        public Teacher(string name, string subject, string teacherClass, string section)
        {
            this.Name = name;
            this.Subject = subject;
            this.TeacherClass = teacherClass;
            this.Section = section;
        }
    }
}
