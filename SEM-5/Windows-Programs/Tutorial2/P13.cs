using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial2
{
    internal class P13
    {
        static void Main()
        {
            Console.Write("Enter the amount: ");
            int amount = Convert.ToInt32(Console.ReadLine());

            int[] denominations = { 2000, 500, 200, 100, 50, 20, 10, 5, 2, 1 };

            foreach (int note in denominations)
            {
                int count = amount / note;
                if (count > 0)
                {
                    Console.WriteLine($"Notes of Rs.{note} = {count}");
                    amount %= note;
                }
            }
        }
    }
}
