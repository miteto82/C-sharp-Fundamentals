using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUni_Exam_Results
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split("-");
            Dictionary<string, int> results = new Dictionary<string, int>();
            Dictionary<string, int> submision = new Dictionary<string, int>();

            while (input[0] != "exam finished")
            {
                string name = input[0];
                string lenguige = input[1];
                

                if(lenguige == "banned")
                {
                    results.Remove(name);
                }
                else
                {
                    int points = int.Parse(input[2]);

                    if (!results.ContainsKey(name))
                    {
                        results.Add(name, points);
                    }
                    else
                    {
                        if (results[name] < points)
                        {
                            results[name] = points;
                        }
                    }

                    if (!submision.ContainsKey(lenguige))
                    {
                        submision.Add(lenguige, 1);
                    }
                    else
                    {
                        submision[lenguige]++;
                    }

                }

                input = Console.ReadLine().Split("-");
            }

            Console.WriteLine("Results:");

            foreach (var item in results.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key} | {item.Value}");
            }

            Console.WriteLine("Submissions:");

            foreach (var item in submision.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }
        }
    }
}
