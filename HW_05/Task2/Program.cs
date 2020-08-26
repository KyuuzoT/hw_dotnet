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
            double excludedNumber;
            double[] inputArray = new double[ArraySize];
            GetExcludedIndex(ref ExcludedIndex);
            GetNumberOnExcludedIndex(out excludedNumber);

            FillArrayWithInput(out inputArray, ArraySize);
            PrintArray(inputArray);



            PrintArray(ShiftArray(inputArray, excludedNumber), "Shifted array");
            Console.ReadKey();
        }

        private static double[] ShiftArray(double[] array, double number)
        {
            double[] outputArray = new double[array.Length];
            for (int i = 0, j = 0; i < outputArray.Length; i++)
            {
                if(i == ExcludedIndex)
                {
                    outputArray[i] = number;
                    continue;
                }

                outputArray[i] = array[i];
            }

            return outputArray;
        }

        private static void FillArrayWithInput(out double[] array, int size)
        {
            array = new double[size];
            Console.WriteLine($"Please, input {size - 1} numbers to fill array:");
            for (int i = 0; i < size; i++)
            {
                if (!AlreadyExcluded && i == ExcludedIndex)
                {
                    Console.WriteLine($"{ExcludedIndex} was excluded!");
                    AlreadyExcluded = true;
                    array[i] = double.NaN;
                    continue;
                }
                GetInputNumber(out array[i], ref i);
            }
            Console.WriteLine();
        }

        private static void GetNumberOnExcludedIndex(out double number)
        {
            while (true)
            {
                Console.WriteLine("Please, input the number you want to insert in array.");
                if (!Double.TryParse(Console.ReadLine(), out number))
                {
                    Console.WriteLine("Wrong input! Try again, please!");
                }
                else
                {
                    break;
                }
            }           
        }

        private static void GetInputNumber(out double number, ref int position)
        {
            string tempStr;
            Console.Write($"{position} number: ");

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
