using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial1
{
    internal class Class1
    {
        public static void Main(String[] args)
        {
            int n, fact = 1;

            Console.WriteLine("Enter Number : ");

            string str = Console.ReadLine();

            n = Convert.ToInt32(str);

            for (int i = 1; i <= n; i++)
            {
                fact = fact * i;
            }
            Console.WriteLine("Factorial : {0}", fact);
            Console.Read();
        }
    }
}
