using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace Reverse_Array_of_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine().Split().ToArray();
            string[] newArr = new string[array.Length].ToArray();

            for (int i = 1; i <= array.Length; i++)
            {
                newArr[array.Length - i] = array[i-1];
            }

            Console.WriteLine(string.Join(" ", newArr));
        }
    }
}
