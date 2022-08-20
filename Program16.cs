

using System;
public class project16
{
    public static void Main()
    {
        Console.WriteLine("Enter the first name");
        string str = Console.ReadLine();
        Console.WriteLine("Enter the last name");
        string str1 = Console.ReadLine();
        if (string.IsNullOrEmpty(str) && string.IsNullOrEmpty(str1))
        {
            Console.WriteLine("Enter a valid FirstName and lastName");
        }
        else
            Console.WriteLine($"Welcome to my app {str} {str1}");
        Console.ReadLine();
    }
}
