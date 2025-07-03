using System;

public class Class1
{
	public static void Main(string[] args)
	{

        Console.WriteLine("Enter a name");
        string input = Console.ReadLine();

        for (int i = 0; i < input.Length; i++)        {
            char c = input[i];
            if (char.IsUpper(c))
                Console.Write(char.ToLower(c));
            else if (char.IsLower(c))
                Console.Write(char.ToUpper(c));
            else
                Console.Write(c);
        }

        Console.Read();
    }
}
