using System;

public class Class1
{
	public static void Main(string[] args)
	{
        int num = 1;
        for (int i = 1; i < 5; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write(num);
                num++;
            }
            Console.WriteLine("");
        }
        Console.Read();
    }
}
