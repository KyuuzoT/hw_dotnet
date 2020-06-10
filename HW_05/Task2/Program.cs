using System;

namespace Task2
{
    class Program
    {
        static int ArraySize = 10;
        static int ExcludedIndex = 0;
        static bool AlreadyExcluded = false;
        static void Main(string[] args)
        {
            double[] inputArray = new double[ArraySize];
            FillArrayWithInput(out inputArray, ArraySize);

            PrintArray(inputArray);
            Console.ReadKey();
        }

        private static void FillArrayWithInput(out double[] array, int size)
        {
            array = new double[size];

            GetExcludedIndex(size, ref ExcludedIndex);
            Console.WriteLine($"Please, input {size - 1} numbers to fill array:");
            for (int i = 0; i < size - 1; i++)
            {
                if (!AlreadyExcluded && i == ExcludedIndex)
                {
                    Console.WriteLine($"{ExcludedIndex} was excluded!");
                    AlreadyExcluded = true;
                }

                GetInputNumber(out array[i], ref i);
            }
        }

        private static void GetInputNumber(out double number, ref int position)
        {
            string tempStr;
            if (AlreadyExcluded)
            {
                Console.Write($"{position + 1} number: ");
            }
            else
            {
                Console.Write($"{position} number: ");
            }

            tempStr = Console.ReadLine();
            if (!Double.TryParse(tempStr, out number))
            {
                Console.WriteLine("Wrong input! Try again!");
                position--;
            }
        }

        private static void GetExcludedIndex(int size, ref int excludedIndex)
        {
            Random rnd = new Random();
            excludedIndex = rnd.Next(0, size);
        }

        private static void GetExcludedIndex(ref int excludedIndex)
        {
            Console.WriteLine("Input index to exclude: ");
            string tempStr;
            tempStr = Console.ReadLine();
            while (true)
            {
                if (!int.TryParse(tempStr, out excludedIndex))
                {
                    Console.WriteLine("Wrong input! Try again!");
                }
                else
                {
                    if(excludedIndex < 0 || excludedIndex > 9)
                    {
                        Console.WriteLine("Wrong input! Index should belong to range [0;9] Try again!");
                    }
                    else
                    {
                        break;
                    }                    
                }
            }
        }

        private static void PrintArray(double[] array)
        {
            foreach (double item in array)
            {
                Console.Write($"{item} ");
            }
        }

        private static void PrintArray(double[] array, string name)
        {
            Console.WriteLine($"\n{name}: ");
            foreach (double item in array)
            {
                Console.Write($"{item} ");
            }
        }
    }
}
