using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23Aug
{
    class Program
    {
        static void add(int i, int j)
        {
            int sum = i + j;
            Console.WriteLine("The sum of two integer given by the user: " + sum);
        }
        static void Main(string[] args)
        {
            Console.Write("Enter the first number: ");
            int i = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second number: ");
            int j = Convert.ToInt32(Console.ReadLine());
            add(i, j);
            Console.ReadLine();

        }
    }
}

