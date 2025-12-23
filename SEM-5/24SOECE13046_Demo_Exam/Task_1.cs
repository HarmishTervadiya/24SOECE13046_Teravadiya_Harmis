using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE13046_Demo_Exam
{
    internal class Task_1
    {
        public static void Main()
        {
            for (int i = 1; i <= 6; i++)
            {
                for (int j = 1; j < i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine("");
            }
        }
    }
}
