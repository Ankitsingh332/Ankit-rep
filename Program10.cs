
using System;


namespace Ex10
{
    internal class problem10
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> dic = new Dictionary<int, string>();
            dic.Add(1, "Ankit");
            dic.Add(2, "Amit");
            dic.Add(3, "Pushkar");
            dic.Add(4, "vini");

            foreach (KeyValuePair<int, string> item in dic)
            {
                Console.WriteLine(item.Key + " " + item.Value);

            }
            Console.ReadKey();
        }
    }
}
