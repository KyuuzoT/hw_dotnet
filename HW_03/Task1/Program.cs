﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        private static bool isNumber;
        static void Main(string[] args)
        {
            double firstValue;
            double secondValue;
            bool result;
            while (true)
            {
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
