using System;

namespace Day_of_Week
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            string[] daysOfWeek = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

            if(num > 0 && num < 8)
            {
                Console.WriteLine(daysOfWeek[num-1]);
            }
            else
            {
                Console.WriteLine("Invalid day!");
            }
        }
    }
}
