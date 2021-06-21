using System;

namespace SortApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new();
            int countOfElements = rnd.Next(5, 25);

            BubbleSort numbers = new(countOfElements);
            numbers.Sort();
         
            Console.ReadKey();
        }
    }
}
