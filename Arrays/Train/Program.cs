using System;
using System.Linq;

namespace Train
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] train = new int[n];
            

            for (int i = 0; i < n; i++)
            {
                int countPeople = int.Parse(Console.ReadLine());
                train[i] = countPeople;
            }

            int sum = train.Sum();

            Console.WriteLine(string.Join(" ", train));
            Console.WriteLine(sum);
        }
    }
}
