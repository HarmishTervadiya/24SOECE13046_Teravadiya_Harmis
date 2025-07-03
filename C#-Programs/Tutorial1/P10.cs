using System;

public class Class1
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter mobile number");
        string input = Console.ReadLine();
            int visibleLength = input.Length - 5;

        for (int i=0; i<input.Length; i++)
        {
            if (i < visibleLength)
            {
                Console.Write(input[i]);
            }
            else
            {
                Console.Write("X");
            }
        }
        Console.Read();
    }
}
