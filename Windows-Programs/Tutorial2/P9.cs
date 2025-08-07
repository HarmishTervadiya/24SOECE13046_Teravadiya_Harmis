using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial2
{
    internal class P9
    {
        static void FindTwoUniqueNumbers(int[] arr)
        {
            int xor = 0;
            foreach (int num in arr)
                xor ^= num;

            int diff = xor & -xor;

            int x = 0, y = 0;

            foreach (int num in arr)
            {
                if ((num & diff) == 0)
                    x ^= num;
                else
                    y ^= num;
            }

            if (x < y)
                Console.WriteLine($"{x} {y}");
            else
                Console.WriteLine($"{y} {x}");
        }

        static void Main(string[] args)
        {
            int[] arr1 = { 1, 2, 3, 2, 1, 4 };
            FindTwoUniqueNumbers(arr1);  

            int[] arr2 = { 2, 1, 3, 2 };
            FindTwoUniqueNumbers(arr2);  
        }
    }
}
