using System;
using System.Collections.Generic;
using System.Text;

namespace StringLettersCounting
{
    class Program
    {
        static SortedDictionary<char, int> LettersDictionary = new SortedDictionary<char, int>();

        struct Letters : IComparable
        {
            public char Letter;
            public int NumberInOrder;

            public int CompareTo(object obj)
            {
                Letters letters = (Letters)obj;
                return this.Letter.CompareTo(letters.Letter);
            }
        }

        static Letters[] LettersArray = { };

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
            foreach (var pair in LettersDictionary)
            {
                builder.Append(pair.Value).Append(pair.Key);
            }
            Console.WriteLine($"Result of counting: \"{builder.ToString()}\" -  using dictionary");

            builder = new StringBuilder();
            for (int i = 0; i < LettersArray.Length; i++)
            {
                builder.AppendFormat("{0}{1}", LettersArray[i].NumberInOrder, LettersArray[i].Letter);
            }
            Console.WriteLine($"Result of counting: \"{builder.ToString()}\" -  using array of structures");

            Console.ReadKey();
        }

        private static void ParseInputString(string text)
        {
            text = text.ToLower();
            foreach (char ch in text)
            {
                if(char.IsLetter(ch))
                {
                    CountLettersInText(ch); //with dictionary
                    CountLettersInTextWithArrays(ch); //With arrays
                }
            }
            Array.Sort(LettersArray);          
        }

        private static void CountLettersInTextWithArrays(char ch)
        {
            for (int i = 0; i < LettersArray.Length; i++)
            {
                if(LettersArray[i].Letter.Equals(ch))
                {
                    LettersArray[i].NumberInOrder++;
                    return;
                }
            }

            Array.Resize(ref LettersArray, LettersArray.Length + 1);
            LettersArray[LettersArray.Length - 1].Letter = ch;
            LettersArray[LettersArray.Length - 1].NumberInOrder = 1;
        }

        private static void CountLettersInText(char ch)
        {
            int value;
            if(LettersDictionary.TryGetValue(ch,out value))
            {
                LettersDictionary[ch]++;
            }
            else
            {
                value = 1;
                LettersDictionary.Add(ch, value);
            }
        }
    }
}
