using System;
using System.Collections.Generic;
using System.Linq;

namespace Word_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> fruits = Console.ReadLine().Split().Where(x => x.Length % 2 == 0).ToList();

            foreach (var item in fruits)
            {
                Console.WriteLine(item);
            }
        }
    }
}
