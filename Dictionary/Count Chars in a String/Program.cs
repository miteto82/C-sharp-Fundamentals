using System;
using System.Collections.Generic;
using System.Linq;

namespace Count_Chars_in_a_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().Replace(" ", String.Empty);
            char[] text = input.ToCharArray();
            
            Dictionary<char, int> dict = new Dictionary<char, int>();

            for (int i = 0; i < text.Length; i++)
            {
                if (!(dict.ContainsKey(text[i])))
                {
                    dict.Add(text[i], 0);
                }

                dict[text[i]]++;
            }

            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
