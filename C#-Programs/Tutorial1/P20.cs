using System;

public class Class1
{
	public static void Main(string[] args)
	{
        int num = 1;
        for (int i = 0; i < 5; i++)
        {
            
                for (int k = 4; k >= i; k--)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < i; j++)
                {
                    Console.Write(num+" ");
                    num++;
                }
                Console.WriteLine("");
            
        }

        Console.Read();
    }
}
