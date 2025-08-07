using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial2
{
    internal class P4
    {
        static void Main()
        {
            Console.Write("Enter first number (A): ");
            double A = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter second number (B): ");
            double B = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\n--- Arithmetic Operators ---");
            Console.WriteLine($"Addition: {A + B}");
            Console.WriteLine($"Subtraction: {A - B}");
            Console.WriteLine($"Multiplication: {A * B}");
            Console.WriteLine($"Division: {A / B}");
            Console.WriteLine($"Modulus: {A % B}");

            Console.WriteLine("\n--- Relational (Comparison) Operators ---");
            Console.WriteLine($"A == B : {A == B}");
            Console.WriteLine($"A != B : {A != B}");
            Console.WriteLine($"A > B  : {A > B}");
            Console.WriteLine($"A < B  : {A < B}");
            Console.WriteLine($"A >= B : {A >= B}");
            Console.WriteLine($"A <= B : {A <= B}");

            Console.WriteLine("\n--- Logical Operators ---");
            bool isPositiveA = A > 0;
            bool isPositiveB = B > 0;
            Console.WriteLine($"A > 0 && B > 0 : {isPositiveA && isPositiveB}");
            Console.WriteLine($"A > 0 || B > 0 : {isPositiveA || isPositiveB}");
            Console.WriteLine($"!(A > 0) : {!isPositiveA}");

            Console.WriteLine("\n--- Bitwise Operators (on integers) ---");
            int x = (int)A;
            int y = (int)B;
            Console.WriteLine($"x & y = {x & y}");
            Console.WriteLine($"x | y = {x | y}");
            Console.WriteLine($"x ^ y = {x ^ y}");
            Console.WriteLine($"~x = {~x}");

            Console.WriteLine("\n--- Assignment Operators ---");
            double C = A;
            Console.WriteLine($"C = {C}");
            C += B;
            Console.WriteLine($"C += B => {C}");
            C -= B;
            Console.WriteLine($"C -= B => {C}");
            C *= B;
            Console.WriteLine($"C *= B => {C}");
            C /= B;
            Console.WriteLine($"C /= B => {C}");
            C %= B;
            Console.WriteLine($"C %= B => {C}");

            Console.WriteLine("\n--- Unary Operators ---");
            int num = (int)A;
            Console.WriteLine($"num = {num}");
            Console.WriteLine($"++num = {++num}");
            Console.WriteLine($"--num = {--num}");
            Console.WriteLine($"-num = {-num}");
            Console.WriteLine($"+num = {+num}");

            Console.WriteLine("\n--- Other Data Types ---");
            byte byteValue = (byte)x;
            char charValue = (char)(65 + (x % 26));  // A-Z
            string str = $"Values: A = {A}, B = {B}";
            bool isEqual = A == B;

            Console.WriteLine($"byte: {byteValue}");
            Console.WriteLine($"char: {charValue}");
            Console.WriteLine($"string: {str}");
            Console.WriteLine($"bool: {isEqual}");

            Console.WriteLine("\n--- Conditional Operator ---");
            string result = (A > B) ? "A is greater" : "B is greater or equal";
            Console.WriteLine(result);
        
    }
    }
}
