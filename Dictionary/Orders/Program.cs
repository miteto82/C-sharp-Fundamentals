using System;
using System.Collections.Generic;
using System.Linq;

namespace Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            Dictionary<string,double> products = new Dictionary<string, double>();
            Dictionary<string,double> total = new Dictionary<string, double>();



            while (input[0] != "buy")
            {
                string product = input[0];
                double price = double.Parse(input[1]);
                double quantity = double.Parse(input[2]);

               
                if (!(products.ContainsKey(product)))
                {
                    products.Add(product, quantity);
                }
                else
                {
                    products[product] += quantity;
                }

                if (!(total.ContainsKey(product)))
                {
                    total.Add(product, 0);
                }

                total[product] = price * products[product];

                input = Console.ReadLine().Split();
            }

            foreach (var item in total)
            {
                Console.WriteLine($"{item.Key} -> {item.Value:f2}");
            }
        }
    }
}
