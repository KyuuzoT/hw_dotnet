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
            Utils.PrintArray(textArray, true);

            string sorted = Utils.BuildString(textArray);
            RemoveLongestWord(sorted);

            SwapLongestShortest(text);
            CountSymbols(text);            
            
            Console.ReadKey();
        }

        private static void RemoveLongestWord(string text)
        {
            int spaceIndex;
            for (spaceIndex = 0; spaceIndex < text.Length; spaceIndex++)
            {
                if(text[spaceIndex] == ' ')
                {
                    break;
                }
            }
            text = text.Remove(0, spaceIndex);
            Console.WriteLine($"\n{text}");
        }

        private static void SwapLongestShortest(string text)
        {
        }

        private static void CountSymbols(string text)
        {
        }

        private static string[] StringToArray(string text)
        {
            Utils.RemovePunctuationMarks(ref text);
            string[] textArray = text.Split(' ');
            textArray = textArray.OrderByDescending(x => x.Length).ToArray();
            return textArray;
        }        
    }
}
