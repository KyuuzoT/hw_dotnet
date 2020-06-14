using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4Additional
{
    class Program
    {
        const long ArraySize = 100_000_000;
        static void Main(string[] args)
        {
            var timer = new Stopwatch();
            double[] initArray;
            timer.Start();
            FillArray(out initArray);
            timer.Stop();
            Console.WriteLine($"Filling an array time: {timer.ElapsedMilliseconds}");

            timer.Start();
            double[] revArray = ReverseArray(initArray);
            timer.Stop();
            Console.WriteLine($"Time of reversing an array with my method equals to {timer.ElapsedMilliseconds}");

            double[] sysArray = initArray;
            timer.Start();
            Array.Reverse(sysArray);
            timer.Stop();
            Console.WriteLine($"Time of reversing an array with system method equals to {timer.ElapsedMilliseconds}");

            Console.ReadKey();
        }

        private static void FillArray(out double[] initArray)
        {
            initArray = new double[ArraySize];
            Random rnd = new Random();
            for (int i = 0; i < ArraySize; i++)
            {
                initArray[i] = rnd.Next(-100, 100);
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
