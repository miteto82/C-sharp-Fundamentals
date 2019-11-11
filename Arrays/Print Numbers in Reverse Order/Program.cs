using System;

namespace Print_Numbers_in_Reverse_Order
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];

            for (int i = 1; i <= n; i++)
            {
                int number = int.Parse(Console.ReadLine());

                array[n-i] = number;
            }

            Console.WriteLine(string.Join(" ", array));
        }
    }
}
