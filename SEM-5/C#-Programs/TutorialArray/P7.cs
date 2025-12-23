using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial2
{
    internal class P7
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

            int oddCount = 0;
            int evenCount = 0;
            for (int i = 0; i < length; i++)
            {
                if (arr[i] % 2 == 0) evenCount++;
                else oddCount++;
            }

            int[] oddArr = new int[oddCount];
            int[] evenArr = new int[evenCount];
            int oddIndex = 0;
            int evenIndex = 0;

            for (int i = 0; i < length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    evenArr[evenIndex] = arr[i];
                    evenIndex++;
                }
                else
                {
                    oddArr[oddIndex] = arr[i];
                    oddIndex++;
                }
            }


            Console.Write("Odd Array: ");

            for (int i = 0; i < oddArr.Length; i++)
            {
                Console.Write(oddArr[i]+ " ");
                
            }

            Console.WriteLine("Even Array: ");

            for (int i = 0; i < evenArr.Length; i++)
            {
                Console.Write(evenArr[i]+ " ");
            }
        }

    }
}
