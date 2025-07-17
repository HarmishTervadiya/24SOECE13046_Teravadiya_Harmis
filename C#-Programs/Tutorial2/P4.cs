using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial2
{
    internal class P4
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter length of array");
            int length = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[length];

            for (int i = 0; i < length; i++)
            {
                Console.WriteLine("Enter " + (i + 1) + " element of array");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }


            int[] copyArr = arr;
            Console.Write("Copied Array: [");

            for (int i = 0; i < length; i++)
            {
                Console.Write(copyArr[i] + " ");

            }
            Console.Write("]");

        }

    }
}
