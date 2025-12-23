using System;

public class Class1
{
	public static void Main(string[] args)
	{
		int a = 0, b = 1;
		
		for (int i=0; i<=10; i++)
		{
			Console.Write(a + " " );
			int temp = a + b;
			a = b;
			b = temp;
		}

		Console.Read();
	}
}
