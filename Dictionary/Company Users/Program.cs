using System;
using System.Collections.Generic;
using System.Linq;

namespace Company_Users
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> dataCompany = new Dictionary<string, List<string>>();

            string[] input = Console.ReadLine().Split(" -> ");

            while (input[0] != "End")
            {
                string company = input[0];
                string emploeey = input[1];

                if (!(dataCompany.ContainsKey(company)))
                {
                    dataCompany.Add(company, new List<string>());
                }

                if (!(dataCompany[company].Contains(emploeey)))
                {
                    dataCompany[company].Add(emploeey);
                }

                input = Console.ReadLine().Split(" -> ");
            }

            foreach (var item in dataCompany.OrderBy(x => x.Key))
            {
                Console.WriteLine(item.Key);

                foreach (var eml in item.Value)
                {
                    Console.WriteLine($"-- {eml}");
                }
            }
        }
    }
}
