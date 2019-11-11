using System;

namespace Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            var elements = Console.ReadLine().Split();
            
            int counter = 1;
            int maxCount = 1;
            string num = "";

            for (int i = 1; i < elements.Length; i++)
            {
                string thisElement = elements[i];
                string previosElement = elements[i - 1];

                if(thisElement == previosElement)
                {
                    counter++;

                    if(maxCount < counter)
                    {
                        maxCount = counter;
                        num = thisElement;
                    }
                  
                }
                else
                {
                    counter = 1;
                }
               
            }

            for (int i = 0; i < maxCount; i++)
            {
                Console.Write(num + " ");
            }

        }
    }
}
