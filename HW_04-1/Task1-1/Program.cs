using System;

namespace Task1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo again;
            do
            {
                SumOfNumbers();
                Console.WriteLine("Again (Y,N)?");
                again = Console.ReadKey();
                Console.WriteLine();
            } while (again.Key != ConsoleKey.N);
        }

        private static void SumOfNumbers()
        {
            double firstVal;
            double secondVal;
            firstVal = InputValue("first");
            secondVal = InputValue("second");

            Console.WriteLine($"Sum of {firstVal} and {secondVal} equals to {firstVal + secondVal}");
        }

        private static double InputValue(string strVar)
        {
            double value = 0;
            string input;
            while (true)
            {
                Console.WriteLine($"Please, input {strVar} variable:");
                input = Console.ReadLine();
                if (Double.TryParse(input, out value))
                {
                    return value;
                }
                else
                {
                    Console.WriteLine($"{input} is not a valid number!");
                }
            }
        }
    }
}