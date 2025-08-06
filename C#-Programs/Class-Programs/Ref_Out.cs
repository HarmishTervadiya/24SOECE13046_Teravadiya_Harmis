using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Programs
{
    internal class Constructor
    {
        public static void Swap1(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        public static void Swap2(ref int a, ref int b)
        {
            a = a + b;
            b = a - b;
            a = a - b;
        }

        public static void Change(out int a, out int b)
        {
            //a = b;  Unassigned out variable cannot be used
            //All out variables are unassiged initially
            //Can accept and return multiple types of variables
            //Compulsory to assign all the out variables
            a = 100;
            b = 500;
           
            
        }
        public static void Main()
        {
            int a = 5, b = 7;
            Console.WriteLine("Before A, B = " + a + ", "+ b);

            Swap1(ref a, ref b);
            Console.WriteLine("After Swap 1: A, B = " + a + ", " + b);


            Swap2(ref a, ref b);
            Console.WriteLine("After Swap 2: A, B = " + a + ", " + b);


            Change(out a, out b);
            Console.WriteLine("After using out parameter: A, B = " + a + ", " + b);
        }
    }
}
