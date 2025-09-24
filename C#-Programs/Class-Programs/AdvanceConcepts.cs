using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Programs
{
    internal class AdvanceConcept
    {
        class Base1
        {
            public int num1;
            public virtual void Display()
            {
                Console.WriteLine(num1);  
            }

            public void Show()
            {
                Console.WriteLine(num1);
            }
            public virtual void jump()
            {
            }
        }

        class Base2 : Base1
        {
            public int num2;
            sealed public override void Display()
            {
                base.Display(); 
                Console.WriteLine(num2); 
            }
            sealed public override void jump()
            {

            }
            public new void Show()
            {
                Console.WriteLine(num1); 
                Console.WriteLine(num2); 
            }
            public void Test()
            { }

        }

        class Derived : Base2
        {
            public override void Display()
            {
                base.Display(); 
                Console.WriteLine(u); 
            }

        }
        class MethodOverridingDemo
        {
            static void Main()
            {
                Base2 obj = new Base2();
                obj.Display();  
                obj.Test(); 

                Base1 obj2 = new Base2();  
                obj2.Display();  
                obj2.Show();     
                obj2.Test(); 
            }
        }
    }

}
