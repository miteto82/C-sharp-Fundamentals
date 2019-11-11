using System;
using System.Linq;

namespace Array_Rotation
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine().Split().ToArray();
            int n = int.Parse(Console.ReadLine());

            
            for (int i = 0; i < n % array.Length; i++)
            {
                string firstIndex = array[0];

                for (int j = 0; j < array.Length-1; j++)
                {
                    array[j] = array[j + 1];
                }

                array[array.Length - 1] = firstIndex;

            }

            Console.WriteLine(string.Join(" ", array));
        }
    }
}
