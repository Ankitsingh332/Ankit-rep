
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex11
{
    internal class Problem11
    {
        static void Main(string[] args)
        {
            SortedList s1 = new SortedList();
            s1.Add(3, "Ankit");
            s1.Add(2, "Amit");
            s1.Add(1, "pushkar");
            s1.Add(4, "vini");
            foreach (DictionaryEntry item in s1)
            {
                Console.WriteLine(item.Key + "  " + item.Value);
            }
        }
    }
}
