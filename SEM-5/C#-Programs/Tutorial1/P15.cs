using System;

public class Class1
{
	public static void Main(string[] args)
	{
		Console.WriteLine("Enter a number");
		string num = Console.ReadLine();
		int rev = 0;
		int temp = Convert.ToInt32(num);
		Console.WriteLine(temp);
		while (temp!= 0)
		{
			int temp1 = temp % 10;
			rev = rev * 10 + temp1
			temp /= 10;
		}

		if (rev != Convert.ToInt32(num)) {
			Console.WriteLine(num+" is not armstrong");
		}
		else
		{
            Console.WriteLine(num + " is armstrong");
        }
        Console.Read();
    }
}
