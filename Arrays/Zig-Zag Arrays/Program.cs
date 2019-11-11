using System;
using System.Linq;

namespace Zig_Zag_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] zigZag1 = new int[n];
            int[] zigZag2 = new int[n];

            for (int i = 0; i < n; i++)
            {
                int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

                if(i % 2 == 0)
                {
                    zigZag1[i] = arr[0];
                    zigZag2[i] = arr[1];
                }
                else
                {
                    zigZag1[i] = arr[1];
                    zigZag2[i] = arr[0];
                }
            }

            Console.WriteLine(string.Join(" ", zigZag1));
            Console.WriteLine(string.Join(" ", zigZag2));
        }
    }
}
