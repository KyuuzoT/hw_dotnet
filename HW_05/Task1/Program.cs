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

            ArrayFillWithRandoms(out randomArray);
            ArrayFillWithConsole(out inputArray);
            ArrayFillWithSumOfArrays(randomArray, inputArray, out sumArray);

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
            Console.WriteLine($"{name}: ");
            foreach (double item in array)
            {
                Console.Write($"{item} ");
            }
        }
    }
}
