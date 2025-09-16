using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial_4
{
    internal class Q9
    {
        public static void Main()
        {
            try
            {
                
                int x = 0;
                Console.WriteLine("Attempting to divide by zero...");
                int div = 100 / x; 
                Console.WriteLine("Result of division: " + div);
            }
            catch (DivideByZeroException e)
            {
                
                Console.WriteLine("EXCEPTION CAUGHT!");
                Console.WriteLine("Error: You cannot divide a number by zero.");
                
                Console.WriteLine("System Message: " + e.Message);
            }
            finally
            {
                Console.WriteLine("The 'finally' block has executed. Program finished.");
            }
        }
    }
}
