
using Phase1Section5._8;
using System;
using System.Runtime.CompilerServices;

namespace Phase1Section5._8
{
    class Program
    {
        static void Main(string[] args)
        {
            runApp();
        }
        static void runApp()
        {
            CClass mathClass = new CClass("Math Class");

            SubjectTeacher mathTeacher1 = new SubjectTeacher("John Smith", "Mathematics", "Algebra");
            SubjectTeacher mathTeacher2 = new SubjectTeacher("Alice Johnson", "Mathematics", "Geometry");
            ClassTeacher classTeacher = new ClassTeacher("Michael Brown", "Mathematics", "Math Class");

            mathClass.AddTeacher(mathTeacher1);
            mathClass.AddTeacher(mathTeacher2);
            mathClass.AddTeacher(classTeacher);

            Console.WriteLine("Math Class Details:");
            Console.WriteLine($"Class Name: {mathClass.ClassName}");
            Console.WriteLine("Teachers:");
            foreach (var teacher in mathClass.Teachers)
            {
                if (teacher is SubjectTeacher)
                {
                    var subjectTeacher = (SubjectTeacher)teacher;
                    Console.WriteLine($"- Subject Teacher: {subjectTeacher.Name} (Department: {subjectTeacher.Department})");
                    Console.WriteLine($"  Subject Taught: {subjectTeacher.SubjectTaught}");
                }
                else if (teacher is ClassTeacher)
                {
                    var classTeacher1 = (ClassTeacher)teacher;
                    Console.WriteLine($"- Class Teacher: {classTeacher1.Name} (Department: {classTeacher1.Department})");
                    Console.WriteLine($"  Class Handled: {classTeacher1.ClassHandled}");
                }
            }
        }
    }
}














