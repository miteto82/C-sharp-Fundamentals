using System;
using System.Linq;

namespace Equal_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int FirstSum = 0;
            int SecondSum = array.Sum();

            for (int i = 0; i < array.Length; i++)
            {
                SecondSum -= array[i];

                if(FirstSum == SecondSum)
                {
                    Console.WriteLine(i);
                    return;
                }

                FirstSum += array[i];
            }

            Console.WriteLine("no");
        }
    }
}
