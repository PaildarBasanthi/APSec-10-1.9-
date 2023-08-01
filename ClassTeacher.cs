
using System;
using System.Collections.Generic;
using System.Text;

namespace Phase1Section5._8
{
    public class ClassTeacher : Teacher
    {
        public string ClassHandled { get; set; }

        public ClassTeacher(string name, string department, string classHandled) : base(name, department)
        {
            ClassHandled = classHandled;
        }
    }

}


