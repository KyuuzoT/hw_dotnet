using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class StudentAndTeacherTest
    {
        private static int _studentAge = 21;
        private static int _teacherAge = 30;
        private static string _teacherSubject = "Classic Literature";

        public static void Main(string[] args)
        {
            Person person = new Person();
            person.SayHello();

            Person student = new Student();
            student.SetAge(_studentAge);
            student.SayHello();
            ((Student)student).ShowAge();

            Person teacher = new Teacher();
            teacher.SetAge(_teacherAge);
            ((Teacher)teacher).Subject = _teacherSubject;
            teacher.SayHello();
            ((Teacher)teacher).Explain();

            Console.ReadKey();
        }
    }
}
