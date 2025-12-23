using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial_4
{
    internal class Q10
    {
        class MyException : Exception
        {
            public MyException(string str) : base(str)
            {
            }
        }
     
           
            public static void Main()
            {
                try
                {
                    
                    throw new MyException("my exception generated.");
                }
                catch (Exception e)
                {
                    
                    Console.WriteLine("Exception caught here: " + e.Message);
                }

                
                Console.WriteLine("LAST STATEMENT");
            
        }
    }
}
