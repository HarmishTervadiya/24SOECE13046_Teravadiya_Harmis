using System;

public class Class1
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter a number");
        string input = Console.ReadLine();
        string[] words = { "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine" };

        for (int i = 0; i < input.Length; i++)
        {
            int num = int.Parse(input[i].ToString());
            Console.Write(words[num] + " ");
        }

        Console.Read();
    }
}
