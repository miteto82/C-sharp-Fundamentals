using System;
using System.Collections.Generic;
using System.Linq;

namespace Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> softUni = new Dictionary<string, List<string>>();

            string[] input = Console.ReadLine().Split(" : ");

            while (input[0] != "end")
            {
                string lection = input[0];
                string name = input[1];

                if (!(softUni.ContainsKey(lection)))
                {
                    softUni.Add(lection, new List<string>());
                }

                softUni[lection].Add(name);

                input = Console.ReadLine().Split(" : ");
            }

            

            foreach (var item in softUni.OrderByDescending(x => x.Value.Count))
            {
                Console.WriteLine($"{item.Key}: {item.Value.Count}");

                foreach (var student in item.Value.OrderBy(x => x))
                {
                    Console.WriteLine($"-- {student}");
                }
            }
        }
    }
}
