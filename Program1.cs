
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReusableCodeLibrary
{
    public class program1
    {
        public static void Compare(string str1, string str2)
        {
            if (str1.Equals(str2))
                Console.WriteLine("Both strings are equal.");
            else
                Console.WriteLine("Strings are not equal");

            Console.WriteLine();
        }
    }
}