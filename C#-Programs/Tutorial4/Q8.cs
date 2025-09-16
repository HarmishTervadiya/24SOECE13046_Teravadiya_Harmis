using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial4
{
    internal class T4Q8
    {
       
    class X
    {
        public virtual void F() { Console.WriteLine("X.F"); }

        public virtual void F2() { Console.WriteLine("X.F2"); }
    }

    class Y : X
    {
        public sealed override void F() { Console.WriteLine("Y.F"); }

        public override void F2() { Console.WriteLine("Y.F2"); }
    }

    class Z : Y
    {

        public override void F2() { Console.WriteLine("Z.F2"); }
    }

    class SealedMethodTest
    {
        static void Main()
        {
            X Obj1 = new X();
            Obj1.F();
            Obj1.F2();

            Console.WriteLine();

            Y Obj2 = new Y();
            Obj2.F();
            Obj2.F2();

            Console.WriteLine();

            Z Obj3 = new Z();
            Obj3.F();    
            Obj3.F2();  
        }
    }

}
}
