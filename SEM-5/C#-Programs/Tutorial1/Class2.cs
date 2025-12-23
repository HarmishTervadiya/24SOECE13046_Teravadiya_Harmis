using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial1
{
    internal class Class2
    {
        public static void Main(string[] args)
        {
            int a = 4;

            for(int i=0; i<=a; i++)
            {
                for (int j=0; j<3; j++)
                {
                    if (i == 0 || i == a)
                    {
                        Console.Write(a);
                    }else
                    {

                        if (j == 1){
                            Console.Write(i);
                        }
                        else
                        {
                            Console.Write(a);
                        }    
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
