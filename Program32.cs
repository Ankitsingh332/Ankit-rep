
using System;


namespace project32
{
    internal class Problem32
    {
        static void Main()
        {
            int player = 100;
            string str;
            for (int i = 0; i < 4; i++)
            {
                Console.Write("Enter HIT or MISS : ");
                str = Console.ReadLine();
                if (str == "HIT")
                    player += 10;
                else if (str == "MISS")
                    player -= 20;

            }
            Console.WriteLine($"The player score after 4 shoot: {player}");
        }
    }
}