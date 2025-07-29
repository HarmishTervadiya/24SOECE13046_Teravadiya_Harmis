using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Programs
{
    internal class ArrayMethods
    {
        public static void Main(string[] args)
        {
            int[] a = { 1, 2, 3, 4, 5, 6, 7, 8 };
            int max = a[0];                          
            int min = a[0];

            foreach (int i in a)
            {
                if (i > max)
                {
                    max = i;
                }
                if (i < min)
                {
                    min = i;
                }
            }
            Console.WriteLine(max);
            Console.WriteLine(min);


            Console.WriteLine("max number is :- " + a.Max());
            Console.WriteLine("min Number is :- " + a.Min());
            Console.WriteLine("sum of number is :- " + a.Sum());
            Console.WriteLine("Avg of number is :- " + a.Average());
            Console.WriteLine("Reverse of array" + string.Join(" ", a.Reverse()));
            Array.Sort(a);
            Console.WriteLine("Sort Array :- " + string.Join(" ", a));

        }
    }
}
