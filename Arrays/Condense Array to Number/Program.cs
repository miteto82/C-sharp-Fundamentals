using System;
using System.Linq;

namespace Condense_Array_to_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayOne = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int count = arrayOne.Length;

            while (count > 1)
            {
                count -= 1;
                int[] arrayTwo = new int[count];

                for (int i = 1; i < count+1; i++)
                {
                    arrayTwo[i - 1] = arrayOne[i - 1] + arrayOne[i];
                }
                for (int i = 0; i < arrayTwo.Length; i++)
                {
                    arrayOne[i] = arrayTwo[i];
                    
                }
            }

            Console.WriteLine(arrayOne[0]);
        }
    }
}
