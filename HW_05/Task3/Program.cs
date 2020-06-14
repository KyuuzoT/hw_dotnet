using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        const int ArraySize = 10;
        static void Main(string[] args)
        {
            double[] initArray;
            FillArray(out initArray);
            PrintArray(initArray, "Initial Array");
            double[] revArray = ReverseArray(initArray);
            PrintArray(revArray, "Reversed Array using my method");

            double[] sysArray = initArray;
            Array.Reverse(sysArray);
            PrintArray(sysArray,"Reversed with system's method");
            
            Console.ReadKey();
        }

        private static void FillArray(out double[] initArray)
        {
            initArray = new double[ArraySize];
            Random rnd = new Random();
            for (int i = 0; i < ArraySize; i++)
            {
                initArray[i] = rnd.Next(-100,100);
            }
        }

        private static double[] ReverseArray(double[] initArray)
        {
            double[] ret = new double[initArray.Length];
            for (int i = 0; i < initArray.Length; i++)
            {
                ret[i] = initArray[initArray.Length - 1 - i];
            }
            return ret;
        }

        private static void PrintArray(double[] array)
        {
            foreach (double item in array)
            {
                Console.Write($"{item} ");
            }
        }

        private static void PrintArray(double[] array, string name)
        {
            Console.WriteLine($"\n{name}: ");
            foreach (double item in array)
            {
                Console.Write($"{item} ");
            }
        }
    }
}
