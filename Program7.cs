
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project7
{
    internal class problem7
    {
        static void Main(string[] args)
        {

            Queue s = new Queue(2);
            s.Enqueue(1);
            s.Enqueue(2);
            s.Enqueue(3);
            s.Enqueue("Ankit");
            s.Enqueue("Singh");
            Console.WriteLine("Peek value");
            object t = s.Peek();
            Console.WriteLine(t);
            int cnt = s.Count;
            Console.WriteLine("Bofore deqeueing the size of stack");
            Console.WriteLine(cnt);
            object i = s.Dequeue();
            Console.WriteLine("deqeued value:");
            Console.WriteLine(i);
            int cnt2 = s.Count;
            Console.WriteLine("After perfome deqeueing the size of stack");
            Console.WriteLine(cnt2);
        }
    }
}

