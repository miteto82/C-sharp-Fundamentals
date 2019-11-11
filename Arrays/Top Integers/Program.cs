using System;
using System.Collections.Generic;
using System.Linq;

namespace Top_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            for (int i = 0; i < array.Length; i++)
            {
                bool top = true;

                for (int j = i+1; j < array.Length; j++)
                {
                    if (array[i] <= array[j])
                    {
                        top = false;
                        break;
                    }
                }

                if(top)
                {
                    Console.Write(array[i] + " ");
                }
            }
        }
    }
}
