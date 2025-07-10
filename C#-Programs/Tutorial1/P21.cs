using System;

public class Class1
{
	public static void Main(string[] args)
	{
        Console.WriteLine("Input the number od terms");
        int length = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Input number");
        int num = Convert.ToInt32(Console.ReadLine());

        int result = 0;
        int temp = num;

        for (int i = 0; i < length; i++)
        {
            Console.Write(temp+" + ");
            result += temp;
            temp = temp * 10 + num;
        }

        Console.WriteLine("The Sum is: "+result);

        Console.Read();
    }
}
