using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial4
{
    class Employee
    {
        public string EmpCode;
        public string Name;
        public string Designation;
        public double BasicPay;

        public Employee(string empCode, string name, string designation, double basicPay)
        {
            EmpCode = empCode;
            Name = name;
            Designation = designation;
            BasicPay = basicPay;
        }

        public void CalculateAndPrintPayDetails()
        {
            double HRA = 0.10 * BasicPay;  
            double DA = 0.45 * BasicPay;   
            double totalPay = BasicPay + HRA + DA;

            Console.WriteLine($"Employee Code: {EmpCode}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Designation: {Designation}");
            Console.WriteLine($"Basic Pay: {BasicPay}");
            Console.WriteLine($"HRA (10%): {HRA}");
            Console.WriteLine($"DA (45%): {DA}");
            Console.WriteLine($"Total Pay: {totalPay}");
            Console.WriteLine("-----------------------------");
        }
    }

    class Q1
    {
        public static void Main(string[] args)
        {
            Employee emp1 = new Employee("E1", "Harshit", "Manager", 50000);
            Employee emp2 = new Employee("E2", "Tushar", "Developer", 40000);
            Employee emp3 = new Employee("E3", "Heet", "Analyst", 30000);

            emp1.CalculateAndPrintPayDetails();
            emp2.CalculateAndPrintPayDetails();
            emp3.CalculateAndPrintPayDetails();

            Console.ReadLine();
        }
    }
}
