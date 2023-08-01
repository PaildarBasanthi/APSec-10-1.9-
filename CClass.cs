using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace Phase1Section5._8
{
    public class CClass
    {
        public string ClassName { get; set; }
        public List<Teacher> Teachers { get; set; }

        public CClass(string className)
        {
            ClassName = className;
            Teachers = new List<Teacher>();
        }

        public void AddTeacher(Teacher teacher)
        {
            Teachers.Add(teacher);
        }
    }

}

