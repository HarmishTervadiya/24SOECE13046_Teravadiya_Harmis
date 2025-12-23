using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE13046_Demo_Exam
{
    internal class Task_3
    {

        public class Student
        {
            public string Name { get; set; }
            public string Enroll { get; set; }

            public int Sem { get; set; }

            public Student(string enroll, string name, int sem)
            {
                this.Enroll = enroll;
                this.Name = name;
                this.Sem = sem;
            }

        }


        public static void Main()
        {
            Student st = new Student("24SOECE13046", "HARMIS", 5);
            Console.WriteLine("Enroll: " + st.Enroll);
            Console.WriteLine("Name: " + st.Name);
            Console.WriteLine("Sem: " + st.Sem);


        }
    }
}
