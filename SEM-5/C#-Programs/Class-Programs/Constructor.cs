using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Programs
{
    internal class Constructor_Program
    {
       class Employee
        {
            int EmpId;
            string Name, City;

            public Employee()
            {

            }

            public Employee(int EmpId, string City)
            {
                this.EmpId = EmpId;
                this.City = City;
            }

            public Employee(int EmpId, string City, string Name) : this(EmpId, City) 
            {
                this.Name = Name;
            }

            public void Display()
            {
                Console.WriteLine(EmpId + " " + Name + " " + City);
            }

        }

        public static void Main()
        {
            Employee obj1 = new Employee();
            Employee obj2 = new Employee(4,"Rajkot", "John");

            obj1.Display();
            obj2.Display();
          
        }
    }
}
