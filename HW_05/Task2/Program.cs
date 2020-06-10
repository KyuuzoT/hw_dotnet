using System;

namespace Task2
{
    class Program
    {
        static int ArraySize = 10;
        static int ExcludedIndex = 0;
        static void Main(string[] args)
        {
            double[] inputArray = new double[ArraySize];
            FillArrayWithInput(out inputArray, ArraySize);

            Console.ReadKey();
        }

        private static void FillArrayWithInput(out double[] array, int size)
        {
            array = new double[size];
            string tempStr;
            GetExcludedIndex(size, ref ExcludedIndex);
            Console.WriteLine($"Please, input {size - 1} numbers to fill array:");
            for (int i = 0; i < size; i++)
            {
                if(i==ExcludedIndex)
                {
                    Console.WriteLine($"{ExcludedIndex} was excluded!");
                    continue;
                }
                Console.Write($"{i} number: ");
                tempStr = Console.ReadLine();
                if(!Double.TryParse(tempStr, out array[i]))
                {
                    Console.WriteLine("Wrong input! Try again!");
                    i--;
                }
            }
        }

        private static void GetExcludedIndex(int size, ref int excludedIndex)
        {
            Random rnd = new Random();
            excludedIndex = rnd.Next(0, size);
        }
    }
}
