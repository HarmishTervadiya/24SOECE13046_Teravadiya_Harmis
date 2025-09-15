//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CIE_1_SET_2
//{
//    internal class Task_1
//    {
//        public class Product
//        {
//            public string code, name;
//            public int quantity, price;
//            public float totalAmount;

//            public Product(string code, string name, int price, int quantity)
//            {
//                this.code = code;
//                this.price = price;
//                this.quantity = quantity;
//                this.name = name;
//            }

//            public void calculateTotalAmount()
//            {
//                if (this.quantity > 10) {
//                    float temp = this.price * this.quantity;
//                    float discount = ((5 * temp) / 100);
//                    this.totalAmount = temp - discount;
//                }
//                else
//                {
//                    this.totalAmount = this.price * this.quantity;
//                }
//            }
//        }

//        class Q1
//        {
//            public static void Main()
//            {

//                Console.Write("Enter product code: ");
//                string code = Console.ReadLine();


//                Console.Write("Enter product name: ");
//                string name = Console.ReadLine();

//                Console.Write("Enter product price: ");
//                int price = Convert.ToInt32(Console.ReadLine());


//                Console.Write("Enter product quantity: ");
//                int quantity = Convert.ToInt32(Console.ReadLine());


//                Product p = new Product(code, name, price, quantity);

//                p.calculateTotalAmount();

//                Console.WriteLine("Product Code: " + p.code);
//                Console.WriteLine("Product Name: " + p.name);
//                Console.WriteLine("Price per unit: " + p.price);
//                Console.WriteLine("Quantity: " + p.quantity);

//                Console.WriteLine("Total Amount: " + p.totalAmount);


//            }
//        }
        
//    }
//}
