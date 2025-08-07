using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial2
{
    internal class P12
    {
        static void Main()
        {
            Console.Write("Enter the number of elements (N): ");
            int N = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[N];

            for (int i = 0; i < N; i++)
            {
                Console.Write($"Enter element {i + 1}: ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("Enter the element to search: ");
            int target = Convert.ToInt32(Console.ReadLine());

            int found = 0;
            for (int i = 0; i < N; i++)
            {
                if (arr[i] == target)
                {
                    found = 1;
                    break;
                }
            }

            Console.WriteLine(found);
        }
    }
}
