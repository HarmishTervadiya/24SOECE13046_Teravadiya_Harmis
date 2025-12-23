using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Programs
{
    internal class GetSet
    {
        class Student
        {
            private int id;
            public int getId()
            {
                return id;
            }

            public void setId(int id)
            {
                this.id = id;
            }

            public int ID
            {
                get { return id; }
                set { id = value; }
            }

        }

        class PrototypeDemo
        {
            public static void Main()
            {
                Student obj = new Student();
                Console.WriteLine(obj.ID);
                Console.WriteLine(obj.getId());
            }
        }
    }
}
