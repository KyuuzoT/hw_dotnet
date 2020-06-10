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

            PrintArray(randomArray);
            Console.ReadKey();
        }

        private static void ArrayFillWithRandoms(out double[] array)
        {
            array = new double[ArraySize];
            Random rnd = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(1, 999);
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
            Console.WriteLine($"{name}: ");
            foreach (double item in array)
            {
                Console.Write($"{item} ");
            }
        }
    }
}
