using System;

namespace SortApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new();
            int countOfElements = rnd.Next(5, 25);

            BubbleSort firstSet = new(countOfElements);
            firstSet.Sort();

            SelectionSort secondSet = new(countOfElements);
            secondSet.Sort();
         
            Console.ReadKey();
        }
    }
}
