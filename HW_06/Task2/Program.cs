using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = RandomTextGenerator.GenerateText();
            Console.WriteLine(text+"\n");
            string[] textArray;
            textArray = StringToArray(text);
            PrintArray(textArray);
            RemoveLongestWord(text);
            SwapLongestShortest(text);
            CountSymbols(text);            
            
            Console.ReadKey();
        }

        private static void RemoveLongestWord(string text)
        {
        }

        private static void SwapLongestShortest(string text)
        {
        }

        private static void CountSymbols(string text)
        {
        }

        private static string[] StringToArray(string text)
        {
            string[] textArray = text.Split(' ');
            textArray = textArray.OrderByDescending(x => x.Length).ToArray();
            return textArray;
        }

        private static void PrintArray<T>(T[] array, bool newLine)
        {
            if(newLine)
            {
                foreach (var item in array)
                {
                    Console.WriteLine($"{item} ");
                }
            }
            else
            {
                foreach (var item in array)
                {
                    Console.Write($"{item} ");
                }
            }
            
        }

        private static void PrintArray<T>(T[] array, string name, bool newLine)
        {
            Console.WriteLine($"\n{name}: ");
            if (newLine)
            {
                foreach (var item in array)
                {
                    Console.WriteLine($"{item} ");
                }
            }
            else
            {
                foreach (var item in array)
                {
                    Console.Write($"{item} ");
                }
            }
        }
    }
}
