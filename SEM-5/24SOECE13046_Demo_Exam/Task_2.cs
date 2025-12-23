using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE13046_Demo_Exam
{
    internal class Task_2
    {
        public static void Main()
        {
            Console.Write("Enter the size of the array: ");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[size];

            for (int i = 0; i < size; i++)
            {
                Console.Write("Enter array element "+ (i+1) + ": ");
                arr[i]=Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < size; i++)
            {
                Console.Write(arr[i]);
            }

            Console.WriteLine();

            for (int i = 0; i < size; i++)
            {
                for (int j = i; j < size; j++)
                {
                    if (arr[j] <= arr[i])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }

            for (int i = 0; i < size; i++)
            {
                Console.WriteLine(arr[i]);
            }


        }
    }
}
