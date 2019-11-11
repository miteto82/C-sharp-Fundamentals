using System;
using System.Linq;

namespace Common_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            var first = Console.ReadLine().Split();
            var second = Console.ReadLine().Split();

            for (int i = 0; i < second.Length; i++)
            {
                if (first.Contains(second[i]))
                {
                    Console.Write(second[i] + " ");
                }
            }
            Console.WriteLine();
        }
    }
}
