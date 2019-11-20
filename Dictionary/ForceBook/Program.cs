using System;
using System.Collections.Generic;
using System.Linq;

namespace ForceBook
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            Dictionary<string, List<string>> forceSide = new Dictionary<string, List<string>>();

            while (text != "Lumpawaroo")
            {
                string side;
                string user;

                if (text.Contains("|"))
                {
                    string[] input = text.Split(" | ");
                    side = input[0];
                    user = input[1];

                    if (!forceSide.ContainsKey(side))
                    {
                        forceSide.Add(side, new List<string>());
                    }
                    if ((!forceSide[side].Contains(user)) && (!forceSide.Values.Any(x => x.Contains(user))))
                    {
                        forceSide[side].Add(user);
                    }
                }
                else
                {
                    string[] input = text.Split(" -> ");
                    side = input[1];
                    user = input[0];

                    if (!forceSide.Any(x => x.Value.Contains(user)))
                    {
                        if (!forceSide.ContainsKey(side))
                        {

                            forceSide.Add(side, new List<String>());
                        }

                        forceSide[side].Add(user);

                        Console.WriteLine($"{user} joins the {side} side!");
                    }

                    else
                    {
                        foreach (var item in forceSide)
                        {
                            if (item.Value.Contains(user))
                            {
                                item.Value.Remove(user);
                            }
                        }

                        if (!forceSide.ContainsKey(side))
                        {
                            forceSide.Add(side, new List<string>());
                        }
                        forceSide[side].Add(user);

                        Console.WriteLine($"{user} joins the {side} side!");
                    }
                }

                text = Console.ReadLine();
            }

            foreach (var item in forceSide.Where(x => x.Value.Count > 0).OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
            {
                Console.WriteLine($"Side: {item.Key}, Members: {item.Value.Count}");

                foreach (var name in item.Value.OrderBy(x => x))
                {
                    Console.WriteLine($"! {name}");
                }
            }
        }
    }
}
