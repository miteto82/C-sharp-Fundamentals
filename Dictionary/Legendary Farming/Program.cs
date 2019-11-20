using System;
using System.Collections.Generic;
using System.Linq;

namespace Legendary_Farming
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> LegendaryItems = new Dictionary<string, int>();
            Dictionary<string, int> junk = new Dictionary<string, int>();
            LegendaryItems.Add("fragments", 0);
            LegendaryItems.Add("shards", 0);
            LegendaryItems.Add("motes", 0);
            string win = "";

            while (win == "")
            {
                string[] input = Console.ReadLine().ToLower().Split(" ");
               
                 for (int i = 0; i < input.Length; i+=2)
                 {
                     int quantity = int.Parse(input[i]);
                     string material = input[i + 1];
                   

                    if (material == "shards" || material == "fragments" || material == "motes")
                    {
                        LegendaryItems[material] += quantity;

                        if(LegendaryItems[material] >= 250)
                        {
                           
                            if(material == "motes")
                            {
                                win = "Dragonwrath";
                            }
                            else if (material == "fragments")
                            {
                                win = "Valanyr";
                            }
                            else
                            {
                                win = "Shadowmourne";
                            }

                            Console.WriteLine($"{win} obtained!");
                            LegendaryItems[material] -= 250;
                            break;
                        }
                    }
                    
                    else
                    {
                        if (!(junk.ContainsKey(material)))
                        {
                            junk.Add(material, 0);
                        }

                        junk[material] += quantity;
                    }
                 }
            }

            LegendaryItems = LegendaryItems.OrderByDescending(x => x.Value).ThenBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);

            foreach (var item in LegendaryItems)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
            junk = junk.OrderBy(x => x.Key).ThenBy(x => x.Value).ToDictionary(x => x.Key, x => x.Value);

            foreach (var item in junk)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}
