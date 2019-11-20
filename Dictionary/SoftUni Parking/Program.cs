using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;

namespace SoftUni_Parking
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, string> carsLeft = new Dictionary<string, string>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();

                if(input[0] == "register")
                {
                    if (carsLeft.ContainsKey(input[1]))
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {input[2]}");
                    }
                    else
                    {
                        Console.WriteLine($"{input[1]} registered {input[2]} successfully");
                        carsLeft.Add(input[1], input[2]);
                    }
                }
                else
                {
                    if (carsLeft.ContainsKey(input[1]))
                    {
                        Console.WriteLine($"{input[1]} unregistered successfully");
                        carsLeft.Remove(input[1]);
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: user {input[1]} not found");
                    }
                   
                }
            }

            Console.WriteLine(string.Join(Environment.NewLine, carsLeft.Select(x => $"{x.Key} => {x.Value}")));

           
        }
    }
}
