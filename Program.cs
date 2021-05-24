using System;
using System.Linq;

namespace TestSorts
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] array = new int[10];
            for(int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(10, 100);
            }
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
            CountingSort counting = new CountingSort();
            int[] newArray = counting.Sort(array, array.Max());
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(newArray[i] + " ");
            }
            Console.WriteLine();

        }
    }
}
