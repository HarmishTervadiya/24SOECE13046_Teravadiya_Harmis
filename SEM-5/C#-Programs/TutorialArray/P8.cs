using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial2
{
    internal class P8
    {
        public static void Main(string[] args)
        {
            int[] arr = new int[5];
            
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Enter " + (i + 1) + " element of array");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < 5; i++)
            {
                for (int j = i+1; j < 5; j++)
                {
                    if (arr[j] >= arr[i])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
                
            }


            Console.Write("Array: [");

            for (int i = 0; i < 5; i++)
            {
                Console.Write(arr[i] + " ");

            }
            Console.Write("]");

        }

    }
}
