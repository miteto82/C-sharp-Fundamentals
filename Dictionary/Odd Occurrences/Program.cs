using System;
using System.Collections.Generic;

namespace Odd_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();
            string[] words = input.Split();

            Dictionary<string, int> dict = new Dictionary<string, int>();

            foreach (var item in words)
            {
                if (dict.ContainsKey(item))
                {
                    dict[item]++;
                }
                else
                {
                    dict.Add(item, 1);
                }
            }

            foreach (var item in dict)
            {
                if(item.Value % 2 == 1)
                {
                    Console.Write(item.Key + " ");
                }
            }
        }
    }
}
