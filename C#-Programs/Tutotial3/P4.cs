using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutotial3
{



    internal class P4
    {
        class Student
        {
            private int id;
            private string name;
            private int age;

            public int Id
            {
                get { return id; }
                set { if (value > 0) id = value; }
            }

            public string Name
            {
                get { return name; }
                set { if (!string.IsNullOrEmpty(value)) name = value; }
            }

            public int Age
            {
                get { return age; }
                set { if (value > 0) age = value; }
            }

            public Student()
            {
                id = 0;
                name = "Unknown";
                age = 0;
            }

            public Student(int id, string name, int age)
            {
                this.Id = id;
                this.Name = name;
                this.Age = age;
            }

            public void Display()
            {
                Console.WriteLine($"ID: {Id}, Name: {Name}, Age: {Age}");
            }

            public void UpdateName(string newName)
            {
                Name = newName;
            }
        }
        static void Main()
        {
            Student[] students = new Student[5];

            students[0] = new Student(101, "Alice", 20);
            students[1] = new Student(102, "Bob", 22);
            students[2] = new Student(103, "Charlie", 19);
            students[3] = new Student(104, "Diana", 21);
            students[4] = new Student(105, "Ethan", 23);

            foreach (Student s in students)
            {
                s.Display();
            }

            students[2].UpdateName("Charles");
            students[2].Age = 20;

            Console.WriteLine("\nAfter update:");
            students[2].Display();
        }
    }

}
