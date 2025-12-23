using System;

public class Class1
{
	public static void Main(string[] args)
	{
        for (int i = 0; i <= 5; i++)
        {
            if (i % 2 != 0)
            {
                for (int k = 4; k >= i; k--)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine("");
            }
        }

        Console.Read();
    }
}
