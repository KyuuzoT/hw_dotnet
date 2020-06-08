using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        private enum Operations
        {
            Addition,
            Subtraction,
            Multiplication,
            Division,
            NoOperation
        };

        private static Operations CurrentOperation = Operations.NoOperation;
        static void Main(string[] args)
        {
            ConsoleKeyInfo again;
            do
            {
                Equation();
                Console.WriteLine("Again (Y,N)?");
                again = Console.ReadKey();
                Console.WriteLine();
            } while (again.Key != ConsoleKey.N);

            Console.ReadKey();
        }

        private static void Equation()
        {
            double firstVal;
            double secondVal;
            double result;
            double calculatedResult;
            firstVal = InputValue("first variable");
            secondVal = InputValue("second variable");
            calculatedResult = Calculate(firstVal, secondVal);
            result = InputValue($"result of choosen operation between {firstVal} and {secondVal}");
            if (result != calculatedResult)
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

        private static double Calculate(double firstVal, double secondVal)
        {
            double result;
            CurrentOperation = InputOperation();
            switch (CurrentOperation)
            {
                case Operations.Addition:
                    result = Arithmetic.Addition(firstVal, secondVal);
                    break;
                case Operations.Subtraction:
                    result = Arithmetic.Subtraction(firstVal, secondVal);
                    break;
                case Operations.Multiplication:
                    result = Arithmetic.Multiplication(firstVal, secondVal);
                    break;
                case Operations.Division:
                    result = Arithmetic.Division(firstVal, secondVal);
                    break;
                case Operations.NoOperation:
                    Console.WriteLine("Operation is invalid!");
                    result = 0;
                    break;
                default:
                    Console.WriteLine("Can not resolve operation");
                    result = double.NaN;
                    break;
            }
            return result;
        }

        private static Operations InputOperation()
        {
            Console.WriteLine("Input operation: ");
            string operation = Console.ReadLine();
            switch (operation)
            {
                case "+":
                    return Operations.Addition;
                case "-":
                    return Operations.Subtraction;
                case "*":
                    return Operations.Division;
                case "/":
                    return Operations.Multiplication;
                default:
                    return Operations.NoOperation;
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
