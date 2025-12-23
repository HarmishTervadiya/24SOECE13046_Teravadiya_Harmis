using System;

public class Class1
{
    public static void Main(string[] args)
    {

        Console.WriteLine("Enter a name");
        string name = Console.ReadLine();

        Console.WriteLine("Enter your Gender : M or F");
        string input = Console.ReadLine();
        char gender = input[0];

        if(gender=='M' || gender == 'm')
        {
            Console.Write("Mr. " + name);
        }else if(gender=='F' || gender == 'f')
        {
            Console.Write("Ms. " + name);
        }
        else
        {
            Console.Write("Invald gender");
        }

            Console.Read();
    }
}
