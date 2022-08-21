
using System;


namespace ex16
{
    class Test
    {
        static void Main(string[] args)
        {
            string str1;
            string str2;

            
            Console.Write("Enter a string: ");
            str1 = Console.ReadLine();
            Console.Write("Enter another string: ");
            str2 = Console.ReadLine();

             
            if (str1 == str2)
                Console.WriteLine("\"{0}\" and \"{1}\" are equal", str1, str2);
            else
                Console.WriteLine("\"{0}\" and \"{1}\" are not equal", str1, str2);

           
            if ((str1 == str2) == true)
                Console.WriteLine("\"{0}\" and \"{1}\" are equal", str1, str2);
            else
                Console.WriteLine("\"{0}\" and \"{1}\" are not equal", str1, str2);

            
            Console.WriteLine("By ignoring case...");
            if (str1.ToUpper() == str2.ToUpper())
                Console.WriteLine("\"{0}\" and \"{1}\" are equal", str1, str2);
            else
                Console.WriteLine("\"{0}\" and \"{1}\" are not equal", str1, str2);

            
            Console.ReadLine();
        }
    }
}