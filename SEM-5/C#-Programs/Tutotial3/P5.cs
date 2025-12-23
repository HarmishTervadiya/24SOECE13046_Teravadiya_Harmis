using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutotial3
{
    class Product
    {
        int pcode;
        string pname, mname;

        public Product(int pcd, string pnm, string mnm)
        {
            pcode = pcd;
            pname = pnm;
            mname = mnm;
        }

        public void Display()
        {
            Console.WriteLine("\nProduct Code:= " + pcode);
            Console.WriteLine("\nProduct Name:= " + pname);
            Console.WriteLine("\nManufacturer Name:= " + mname);
        }
    }

    public class TestProduct
    {
        public static void Main(string[] args)
        {
            int n = args.Length;

            if (n < 3)
            {
                Console.WriteLine("Syntax Error\n");
                Console.WriteLine("Must Have THREE Arguments\n");
                Console.WriteLine("Please, Write as [csc TestProduct ProductCode ProductName Manufacturer] \n");
            }
            else
            {
                int pcd;
                bool success = int.TryParse(args[0], out pcd);
                if (!success)
                {
                    Console.WriteLine("Invalid Product Code. Please enter a numeric value.");
                    return;
                }

                string pnm = args[1];
                string mnm = args[2];

                Product p = new Product(pcd, pnm, mnm);
                p.Display();
                Console.Read();
            }
        }
    }
}
