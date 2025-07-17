using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial2
{
    internal class P9
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


            Console.WriteLine("Enter the position to delete the element: ");
            int deleteIndex = Convert.ToInt32(Console.ReadLine());

            int []newArr = new int[length-1];
            int j = 0;
            for (int i = 0; i < length; i++)
            {
                if(i!= deleteIndex)
                {
                    newArr[j] = arr[i];
                    j++;
                }
            }

            arr = newArr;

            Console.Write("Arrat: [");

            for (int i = 0; i < length-1; i++)
            {
                Console.Write(arr[i]+ " ");
            }
            Console.Write(" ]");

        }

    }
}
