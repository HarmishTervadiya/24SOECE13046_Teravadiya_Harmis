using System;

public class Class1
{
    public static void Main(string[] args)
    {
       
        string[] n = new string[4];
        
        for (int i = 0; i < 4; i++)
        {
            Console.WriteLine("Enter element");
            n[i] = Console.ReadLine();
        }

        foreach (string s in n)
        {
            Console.Write(s+" ");
        }

        Console.Read();
    }
}
