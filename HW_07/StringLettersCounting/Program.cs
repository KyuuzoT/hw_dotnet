using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringLettersCounting
{
    class Program
    {
        static SortedDictionary<char, int> Letters = new SortedDictionary<char, int>();

        static void Main(string[] args)
        {
            string input;
            StringBuilder builder = new StringBuilder();
            Console.WriteLine("Input string for letters counting:");
            input = Console.ReadLine();
            if(string.IsNullOrEmpty(input))
            {
                input = "This is some sort of test string, bouya";
            }

            ParseInputString(input);
            foreach (var pair in Letters)
            {
                builder.Append(pair.Value).Append(pair.Key);
            }

            Console.WriteLine($"Result of counting: \"{builder.ToString()}\"");
            Console.ReadKey();
        }

        private static void ParseInputString(string text)
        {
            text = text.ToLower();
            foreach (char ch in text)
            {
                if(char.IsLetter(ch))
                {
                    CountLettersInText(ch);
                }
            }
        }

        private static void CountLettersInText(char ch)
        {
            int value;
            if(Letters.TryGetValue(ch,out value))
            {
                Letters[ch]++;
            }
            else
            {
                value = 1;
                Letters.Add(ch, value);
            }
        }
    }
}
