using System;
using System.Threading;

namespace Task1
{
    class Program
    {
        private static bool bRepeateFlag = true;
        static void Main(string[] args)
        {            
            while (bRepeateFlag)
            {
                Menu();
            }
            Thread.Sleep(1000);
        }

        private static void Menu()
        {
            double firstValue = 0;
            double secondValue = 0;
            double radius = 0;
            double result;
            Calculator calc = new Calculator();
            Console.WriteLine("This program could perform several actions:");
            Console.WriteLine("\t1. Calculate sum of two numbers;");
            Console.WriteLine("\t2. Calculate difference of two numbers;");
            Console.WriteLine("\t3. Calculate product of two numbers;");
            Console.WriteLine("\t4. Calculate quotient of two numbers;");
            Console.WriteLine("\t5. Calculate area of circle using radius;");
            Console.WriteLine("Please input number represents menu item: ");
            string menuItem = Console.ReadLine();
            switch (menuItem)
            {
                case "1":
                    Console.WriteLine("Input parameters for calculating:\n");
                    InputTwoParametrs(out firstValue, out secondValue);
                    result = calc.Addition(firstValue, secondValue);
                    Console.WriteLine($"Sum of A={firstValue} and B={secondValue} equals to {result}");                    
                    break;
                case "2":
                    Console.WriteLine("Input parameters for calculating:\n");
                    InputTwoParametrs(out firstValue, out secondValue);
                    result = calc.Subtraction(firstValue, secondValue);
                    Console.WriteLine($"Difference of A={firstValue} and B={secondValue} equals to {result}");
                    break;
                case "3":
                    Console.WriteLine("Input parameters for calculating:\n");
                    InputTwoParametrs(out firstValue, out secondValue);
                    result = calc.Multiplication(firstValue, secondValue);
                    Console.WriteLine($"Product of A={firstValue} and B={secondValue} equals to {result}");
                    break;
                case "4":
                    Console.WriteLine("Input parameters for calculating:\n");
                    InputTwoParametrs(out firstValue, out secondValue);
                    result = calc.Division(firstValue, secondValue);
                    Console.WriteLine($"Quotient of A={firstValue} and B={secondValue} equals to {result}");
                    break;
                case "5":
                    Console.WriteLine("Input radius to perform calculation:\n");
                    radius = InputValue();
                    Console.WriteLine($"Area of circle with radius R={radius} equals to S={calc.AreaOfCircle(radius)}");
                    break;
                default:
                    Console.WriteLine("Input unresolved. Please try again!\n\n");
                    bRepeateFlag = true;
                    return;
            }

            Console.WriteLine("Calculations done! Want to calculate smth again? (Y,N)");
            if(Console.ReadKey().Key == ConsoleKey.Y)
            {
                bRepeateFlag = true;
                Console.WriteLine("\n");
            }
            else
            {
                bRepeateFlag = false;
            }
        }

        private static void InputTwoParametrs(out double firstValue, out double secondValue)
        {
            Console.WriteLine("First parameter: ");
            firstValue = InputValue();

            Console.WriteLine("Second parameter: ");
            secondValue = InputValue();
        }

        private static double InputValue()
        {
            
            double dValue;
            bool isNumber;
            do
            {
                string readVal = Console.ReadLine();
                if (isNumber = Double.TryParse(readVal, out dValue))
                {
                    Console.WriteLine("\nValue adding - success!\n");
                }
                else
                {
                    Console.WriteLine("Error! " + readVal + " is not a number!");
                }
            } while (!isNumber);


            return dValue;
        }
    }
}
