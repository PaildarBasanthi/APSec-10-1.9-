using System;
using System.Collections.Generic;
using System.Text;

namespace Phase1Section5._8
{
    public class SubjectTeacher : Teacher
    {
        public string SubjectTaught { get; set; }

        public SubjectTeacher(string name, string department, string subjectTaught) : base(name, department)
        {
            SubjectTaught = subjectTaught;
        }
    }

}




