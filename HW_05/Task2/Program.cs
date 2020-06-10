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
            Console.ReadKey();
        }


        private static void GetExcludedIndex(int size, ref int excludedIndex)
        {
            Random rnd = new Random();
            excludedIndex = rnd.Next(0, size);
        }
    }
}
