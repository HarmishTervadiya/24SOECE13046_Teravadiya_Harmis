//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CIE_1_SET_2
//{
//    internal class Task_3
//    {
//        public static void Main()
//        {
//            Console.Write("Enter Lenght of Array: ");
//            int size = Convert.ToInt32(Console.ReadLine());

//            int[] arr = new int[size];
//            int evenCount = 0, oddCount = 0;

//            for (int i = 0; i < size; i++)
//            {
//                Console.Write("Element " + (i + 1)+ ": ");
//                arr[i] = Convert.ToInt32(Console.ReadLine());
//            }

//            for (int i = 0; i < size; i++)
//            {
//                if (arr[i] % 2==0)
//                {
//                    evenCount++;
//                }
//                else
//                {
//                    oddCount++;
//                }
//            }

//            Console.WriteLine("Odd Count: " + oddCount);
//            Console.WriteLine("Even Count: " + evenCount);

//        }
//    }
//}
