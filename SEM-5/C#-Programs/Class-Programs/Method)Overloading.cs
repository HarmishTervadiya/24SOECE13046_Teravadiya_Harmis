using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Programs
{
    internal class Method_Overloading
    {
        static int Add(int x, int y)
        {
            return x + y;
        }

        static int Add(int x, int y, int z)
        {
            return x + y + z;
        }

        static double Add(double x, double y)
        {
            return x + y;
        }

        static double Add(double x, double y, double z)
        {
            return x + y + z;
        }
        public static void Main()
        {
            Console.WriteLine("Method with 2 Int params: " + Add(4, 5));
            Console.WriteLine("Method with 3 Int params: " + Add(4, 5, 9));

            Console.WriteLine("Method with 2 Double params: " + Add(415.5, 5));
            Console.WriteLine("Method with 3 Double params: " + Add(4, 5.6, 9));

        }
    }
}
