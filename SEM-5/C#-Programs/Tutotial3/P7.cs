using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutotial3
{

    internal class P7
    {
        class Student
        {
            private int enrolmentNo;
            private string name;

            public int EnrolmentNo
            {
                get { return enrolmentNo; }
                set { if (value > 0) enrolmentNo = value; }
            }

            public string Name
            {
                get { return name; }
                set { if (!string.IsNullOrEmpty(value)) name = value; }
            }

            public Student()
            {
                enrolmentNo = 0;
                name = "Unknown";
            }

            public Student(int enrolmentNo, string name)
            {
                EnrolmentNo = enrolmentNo;
                Name = name;
            }

            public void Display()
            {
                Console.WriteLine($"Enrolment No: {EnrolmentNo}, Name: {Name}");
            }
        }
        static void Main()
        {
            Student s1 = new Student(12345, "John Doe");
            s1.Display();

            Student s2 = new Student();
            s2.EnrolmentNo = 67890;
            s2.Name = "Jane Smith";
            s2.Display();
        }
    }

}
