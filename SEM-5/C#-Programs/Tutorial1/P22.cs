using System;

public class Class1
{
	public static void Main(string[] args)
	{
        for (int i = 0; i < 5; i++)
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

        for (int i = 3; i > 0; i--)
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

        Console.Read();
    }
}
