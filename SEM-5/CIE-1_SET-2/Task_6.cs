using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIE_1_SET_2
{
    internal class Task_6
    {
        class Student
        {
            private int rollNo;
            private string name;
            private double percentage;

            public static void Main()
            {
                Student s1 = new Student();
                s1.rollNo = 1;
                s1.name = "Rahul";
                s1.percentage = 88.5;

                Console.WriteLine("Name: " + s1.name);
                Console.WriteLine("Roll No: " + s1.rollNo);
                Console.WriteLine("Percentage: " + s1.percentage);
            }
        }
    }
}
