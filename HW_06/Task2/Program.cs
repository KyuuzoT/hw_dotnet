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
            
            RemoveLongestWord(text);

            SwapLongestShortest(text);
            CountSymbols(text);            
            
            Console.ReadKey();
        }

        private static void RemoveLongestWord(string text)
        {
            int spaceIndex;
            string sorted = Utils.BuildString(StringToArray(text));
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
            string[] textArray = StringToArray(text);
            Utils.PrintArray(textArray, "\nBefore swap", false);
            string temp;
            temp = textArray[0];
            textArray[0] = textArray[textArray.Length - 1];
            textArray[textArray.Length - 1] = temp;
            Console.WriteLine($"\n\nSwap Longest word with shortest word:\n {Utils.BuildString(textArray)}");
        }

        private static void CountSymbols(string text)
        {
            int lettersCounter = 0;
            int marksCounter = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (Char.IsLetter(text[i]))
                {
                    lettersCounter++;
                }
                else if (Char.IsPunctuation(text[i]))
                {
                    marksCounter++;
                }
            }

            Console.WriteLine($"\nLetters quantity:{lettersCounter}\nPunctuation marks quantity:{marksCounter}");
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
