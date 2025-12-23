using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIE_1_SET_2
{
    internal class Task_7
    {
        public class Student
        {
            public int marks;
            public static int maxMarks = 100;

            public  Student(int marks)
            {
                this.marks = marks;
            }
        }

        class StudentResult 
        {

            public static double getStudentResult(int marks)
            {
                
                double percentage = (marks *Student.maxMarks) / 100;
                return percentage;
            }   
        }

        class Demo
        {
            public static void Main()
            {

                Student s1 = new Student(86);
                Console.WriteLine("The result is: " +  StudentResult.getStudentResult(s1.marks) + "%");
            }
        }
    }
}
