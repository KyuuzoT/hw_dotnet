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
        const long ArraySize = 1_000_000;
        const int triesArraySize = 10;
        static void Main(string[] args)
        {
            var timer = new Stopwatch();
            double[] initArray;
            double[] revArray;
            double[] sysArray;
            long[] elapsedFilling = new long[triesArraySize];
            long[] elapsedMyRev = new long[triesArraySize]; ;
            long[] elapsedSysRev = new long[triesArraySize]; ;
            for (int i = 0; i < triesArraySize; i++)
            {
                timer.Start();
                FillArray(out initArray);
                timer.Stop();
                sysArray = initArray;
                Console.WriteLine($"Filling an array time: {timer.ElapsedMilliseconds}");
                elapsedFilling[i] = timer.ElapsedMilliseconds;

                timer.Start();
                revArray = ReverseArray(initArray);
                timer.Stop();
                Console.WriteLine($"Time of reversing an array with my method equals to {timer.ElapsedMilliseconds}");
                elapsedMyRev[i] = timer.ElapsedMilliseconds;

                
                timer.Start();
                Array.Reverse(sysArray);
                timer.Stop();
                Console.WriteLine($"Time of reversing an array with system method equals to {timer.ElapsedMilliseconds}");
                elapsedSysRev[i] = timer.ElapsedMilliseconds;
                timer = new Stopwatch();
            }

            Console.WriteLine($"Mean time: \n Filling = {MeanValue(elapsedFilling)}" +
                $"\n My reverse = {MeanValue(elapsedMyRev)}" +
                $"\n System reverse = {MeanValue(elapsedSysRev)}");
            Console.ReadKey();
        }

        private static long MeanValue(long[] array)
        {
            long sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }

            return (sum / array.Length);
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
