using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Utils
    {
        public static void RemovePunctuationMarks(ref string text)
        {
            for (int i = 0; i < RandomTextGenerator.MarksSequence.Length; i++)
            {
                text = text.Replace(RandomTextGenerator.MarksSequence[i].ToString(), string.Empty);
            }
        }

        public static string BuildString(string[] textArray)
        {
            StringBuilder sb = new StringBuilder();
            foreach (string s in textArray)
            {
                sb.Append(s).Append(" ");
            }

            return sb.ToString();
        }

        public static void PrintArray<T>(T[] array, bool newLine)
        {
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

        public static void PrintArray<T>(T[] array, string name, bool newLine)
        {
            Console.WriteLine($"\n{name}: ");
            PrintArray(array, newLine);
        }
    }
}
