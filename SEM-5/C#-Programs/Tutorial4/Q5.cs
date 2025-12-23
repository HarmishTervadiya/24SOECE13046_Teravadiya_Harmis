using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial4
{
    

        public class A 
        {
            public A(int value)
            {
                Console.WriteLine("Base constructor A()");
            }
        }

        public class B : A 
        {
            public B(int value) : base(value)
            {
                Console.WriteLine("Derived constructor B()");
            }
        }

        class Q5
        {
            static void Main()
            {
                A a = new A(0);
                B b = new B(1);
            }
        }
    
}
