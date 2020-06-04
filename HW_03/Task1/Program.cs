using System;

namespace Task1
{
    class Program
    {
        private static bool isNumber;
        static void Main(string[] args)
        {
            double firstValue;
            double secondValue;
            while (true)
            {
                Console.WriteLine("This program could perform several actions:");
                Console.WriteLine("\t1. Calculate sum of two numbers;");
                Console.WriteLine("\t2. Calculate difference of two numbers;");
                Console.WriteLine("\t3. Calculate product of two numbers;");
                Console.WriteLine("\t4. Calculate quotient of two numbers;");
                Console.WriteLine("\t5. Calculate area of circle using radius;");
                Console.WriteLine("Please input number represents menu item: ");
                switch (Console.Read())
                {
                    case 1:
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    default:
                        Console.WriteLine("Input unressolved. Please try again!");
                        break;
                }
                Console.WriteLine("Input parameters for calculating:\n");
                InputTwoParametrs(out firstValue, out secondValue);
                if(isNumber)
                {
                    continue;
                }
                else
                {
                    break;
                }
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
            string readVal = Console.ReadLine();
            double dValue;

            if (isNumber = Double.TryParse(readVal, out dValue))
            {
                Console.WriteLine("\nValue adding - success!\n");
            }
            else
            {
                Console.WriteLine("Error! " + readVal + " is not a number!");
            }

            return dValue;
        }
    }
}
