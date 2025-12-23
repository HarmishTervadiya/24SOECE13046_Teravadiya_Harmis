using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutotial3
{
    class Line
    {
        private double length; 

        public Line()
        {
            Console.WriteLine("Object is being created, length = 10");
            length = 10;     
            setLength(length);
        }

        public void setLength(double len)
        {
            length = len;    
        }

        public double getLength()
        {
            return length;   
        }
    }

    class TestLine
    {
        static void Main(string[] args)
        {
            Line line = new Line();
            Console.WriteLine("Length of line : {0}", line.getLength());

            line.setLength(6);
            Console.WriteLine("Length of line : {0}", line.getLength());

            Console.ReadKey();
        }
    }
}
