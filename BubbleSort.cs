using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortApp
{
    public class BubbleSort
    {
        private readonly int Count;

        public BubbleSort(int count)
        {
            Count = count;
        }

        public void Sort()
        {
            Random rnd = new();
            List<int> numbers = new();

            for (int i = 0; i < Count; i++)
            {
                numbers.Add(rnd.Next(0, 100));
            }

            Console.WriteLine("Count of numbers {0}", Count);
            Console.WriteLine();

            Console.WriteLine("Unsorted Numbers");

            for (int i = 0; i < Count; i++)
            {
                Console.Write(numbers[i] + "\t");
            }

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Sorted numbers");

            for (int i = 0; i < numbers.Count; i++)
            {
                for (int j = i + 1; j < numbers.Count; j++)
                {
                    if (numbers[j] < numbers[i])
                    {
                        int temp   = numbers[i];
                        numbers[i] = numbers[j];
                        numbers[j] = temp;
                    }
                }

                Console.Write(numbers[i] + "\t");
            }
        }
    }
}
