
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22th_hands_on
{
    internal class Problem9
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            al.Add(7.5f);

            al.Add(2.3f);
            al.Add(1.5f);
            al.Add(3.4f);
            al.Add(4.4f);
            al.Add(4.6f);
            al.Add(1.2f);
            Console.WriteLine("IN Descending order: ");
            al.Sort();
            foreach (float i in al)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("IN asscending order: ");
            al.Sort();
            foreach (float i in al)
            {
                Console.WriteLine(i);
            }
            
            Console.ReadLine();
        }
    }
}
