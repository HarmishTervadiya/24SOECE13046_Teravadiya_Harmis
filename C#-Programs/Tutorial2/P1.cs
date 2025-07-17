using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial2
{
    internal class P1
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter length of array");
            int length = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[length];

            for (int i = 0; i < length; i++)
            {
                Console.WriteLine("Enter " + (i+1) + " element of array");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("Array: [");

            for (int i = 0; i < length; i++)
            {
                Console.Write(arr[i] + " ");
                
            }
            Console.Write("]");

        }
    }
}
