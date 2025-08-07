using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial2
{
    internal class P14
    {
        static void Main()
        {
            Console.Write("Enter marks in Mathematics: ");
            int maths = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter marks in Physics: ");
            int physics = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter marks in Chemistry: ");
            int chemistry = Convert.ToInt32(Console.ReadLine());

            int totalAll = maths + physics + chemistry;
            int totalMathsPhysics = maths + physics;

            if (maths >= 65 && physics >= 55 && chemistry >= 50 &&
                (totalAll >= 180 || totalMathsPhysics >= 140))
            {
                Console.WriteLine("The candidate is eligible for admission.");
            }
            else
            {
                Console.WriteLine("The candidate is NOT eligible for admission.");
            }
        }
    }
}
