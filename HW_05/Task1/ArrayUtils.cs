using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    class ArrayUtils
    {
        public static void ArrayFillWithRandoms(out double[] array, int size)
        {
            array = new double[size];
            Random rnd = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(1, 999);
            }
        }

        public static void ArrayFillWithConsole(out double[] array, int size)
        {
            array = new double[size];
            string tempStr;
            Console.WriteLine($"Please, input {size} number in order to fill array: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{i + 1} number: ");
                tempStr = Console.ReadLine();
                if (!double.TryParse(tempStr, out array[i]))
                {
                    Console.WriteLine("\nWrong number, try again!");
                    --i;
                }
            }
        }

        public static void ArrayFillWithSumOfArrays(double[] first, double[] second, out double[] sum, int size)
        {
            sum = new double[size];
            for (int i = 0; i < sum.Length; i++)
            {
                sum[i] = first[i] + second[i];
            }
        }
    }
}
