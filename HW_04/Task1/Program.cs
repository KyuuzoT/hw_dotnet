using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            SumOfNumbers();
            Console.ReadKey();
        }

        private static void SumOfNumbers()
        {
            double firstVal;
            double secondVal;
            firstVal = InputValue("first");
            secondVal = InputValue("second");

            Console.WriteLine($"Sum of {firstVal} and {secondVal} equals to {firstVal+secondVal}");
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
