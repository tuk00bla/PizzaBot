using System;
using System.Collections.Generic;


namespace PizzaBot
{
    class Program
    {
        public static void Main()
        {
            string line = Console.ReadLine();
            string path = BotActions.FindPath(line);
            Console.WriteLine(path);
            Console.ReadKey(); // for debug
        }
            
    }
}
