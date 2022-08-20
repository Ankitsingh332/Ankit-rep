
using System;
public class project12
{
    public static void Main()
    {
            string str = "";
            string str1 = string.Empty;
            string str2;
            Console.WriteLine("enter first number: ");
            string i1 = Console.ReadLine();
            Console.WriteLine("enter second number: ");
            string i2 = Console.ReadLine();
            bool b1 = string.IsNullOrEmpty(i1);
            Console.WriteLine(b1);
            bool b2 = string.IsNullOrEmpty(i2);
            Console.WriteLine(b1);
        }
    }

