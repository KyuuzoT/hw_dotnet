using System;

namespace Task1
{
    class Program
    {
        private static int ArraySize = 10;
        static void Main(string[] args)
        {
            double[] randomArray = new double[ArraySize];
            double[] inputArray = new double[ArraySize];
            double[] sumArray = new double[ArraySize];

            ArrayUtils.ArrayFillWithRandoms(out randomArray, ArraySize);
            ArrayUtils.ArrayFillWithConsole(out inputArray, ArraySize);
            ArrayUtils.ArrayFillWithSumOfArrays(randomArray, inputArray, out sumArray, ArraySize);

            PrintArray(randomArray, "Random");
            PrintArray(inputArray, "From inputs");
            PrintArray(sumArray, "Sum of two arrays");
            Console.ReadKey();
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
