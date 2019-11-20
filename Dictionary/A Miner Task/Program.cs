using System;
using System.Collections.Generic;

namespace A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, int> dict = new Dictionary<string, int>();

            string input = Console.ReadLine();

            while (input != "stop")
            {
                string resource = input;
                int quantity = int.Parse(Console.ReadLine());

                if (!(dict.ContainsKey(resource)))
                {
                    dict.Add(resource, 0);
                }

                dict[resource] += quantity;

                input = Console.ReadLine();
            }

            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
