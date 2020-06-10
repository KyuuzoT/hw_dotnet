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

            Console.ReadKey();
        }

        private static void ArrayFillWithRandoms(out double[] array)
        {
            throw new NotImplementedException();
        }
    }
}
