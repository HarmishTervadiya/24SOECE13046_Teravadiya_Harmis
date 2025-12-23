using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutotial3
{
    using System;
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
    internal class P3
    {
        static void Main()
        {
            Student s1 = new Student(101, "Alice", 20);
            s1.Display();

            s1.UpdateName("Alice Johnson");
            s1.Age = 21;
            s1.Display();
        }
    }

}
