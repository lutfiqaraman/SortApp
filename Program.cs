using System;

namespace SortApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[4] { 9, 0, 3, 1 };
            int temp = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[j] < numbers[i])
                    {
                        temp = numbers[i];
                        numbers[i] = numbers[j];
                        numbers[j] = temp;
                    }

                }

                Console.Write(numbers[i] + "\t");
            }

            Console.ReadKey();
        }
    }
}
