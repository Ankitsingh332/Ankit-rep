
using System;


namespace project30

{
    internal class Problem30
    {
        static void Main()
        {
            int i;
            Console.WriteLine("Enter a number : ");
            i = Convert.ToInt32(Console.ReadLine());
            switch (i % 2)
            {
                case 0:
                    Console.WriteLine("the number is even");
                    break;
                case 1:
                    Console.WriteLine("The number is odd");
                    break;
                default:
                    Console.WriteLine("the number is zero");
                    break;
            }
            Console.ReadLine();


        }
    }
}