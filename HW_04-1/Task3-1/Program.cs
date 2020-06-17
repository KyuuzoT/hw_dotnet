using System;

namespace Task3_1
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

            Console.ReadKey();
        }

        private static void SumOfNumbers()
        {
            double firstVal;
            double secondVal;
            double result;
            firstVal = InputValue("first variable");
            secondVal = InputValue("second variable");
            result = InputValue($"result of addition {firstVal} and {secondVal}");
            if (result != firstVal + secondVal)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Your answer \"{result}\" is incorrect! ");
                CheckAnswer(firstVal, secondVal, result);
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Congratulations! Your answer \"{result}\" is correct!");
                Console.ResetColor();
            }
        }

        private static void CheckAnswer(double firstVal, double secondVal, double result)
        {
            if (result < (secondVal + firstVal))
            {
                Console.WriteLine($"Your answer should be greater than {result}");
            }
            else
            {
                Console.WriteLine($"Your answer should be less than {result}");
            }
        }

        private static double InputValue(string strVar)
        {
            double value = 0;
            string input;
            while (true)
            {
                Console.WriteLine($"Please, input {strVar}:");
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