
using System;

namespace  project31
{
    internal class Problem31
    {
        static void Main()
        {
            int i = 0, j = 25;
            while (i <= j)
            {
                Console.WriteLine($"i = {i} and j = {j}");
                i++;
                j--;
            }
            Console.WriteLine("Crossed Over");
            Console.ReadLine();

        }
    }
}
