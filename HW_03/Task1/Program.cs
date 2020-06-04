using System;

namespace Task1
{
    class Program
    {
        private static bool isNumber;
        private static bool isMenuItemExists;
        static void Main(string[] args)
        {
            double firstValue = 0;
            double secondValue = 0;
            double radius = 0;
            while (true)
            {
                Menu(ref firstValue, ref secondValue, ref radius);

                if (isNumber && isMenuItemExists)
                {
                    continue;
                }
                else
                {
                    continue;
                }
            }

            Console.ReadKey();

        }

        private static void Menu(ref double firstValue, ref double secondValue, ref double radius)
        {
            isMenuItemExists = true;
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
                    break;
                case "2":
                    Console.WriteLine("Input parameters for calculating:\n");
                    InputTwoParametrs(out firstValue, out secondValue);
                    break;
                case "3":
                    Console.WriteLine("Input parameters for calculating:\n");
                    InputTwoParametrs(out firstValue, out secondValue);
                    break;
                case "4":
                    Console.WriteLine("Input parameters for calculating:\n");
                    InputTwoParametrs(out firstValue, out secondValue);
                    break;
                case "5":
                    Console.WriteLine("Input radius to perform calculation:\n");
                    radius = InputValue();
                    break;
                default:
                    Console.WriteLine("Input unressolved. Please try again!\n\n");
                    isMenuItemExists = false;
                    break;
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
