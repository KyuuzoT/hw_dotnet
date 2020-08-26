using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            string text1 = RandomTextGenerator.GenerateText();
            string text = "1a!2.3!!.. 4.!.?6 7! ..?";
            Console.WriteLine(text);
            string result = RemoveMarks(text, '?');
            Console.WriteLine($"Result of all manipulations: {result}");
            Console.ReadKey();
        }

        private static string RemoveMarks(string text, char referenceMark)
        {
            StringBuilder builder = new StringBuilder();
            int counter;
            FindReferenceMarkIndex(referenceMark, out counter, text);            

            string subBefore = text.Substring(0, counter);
            string subAfter = text.Substring(counter);
            Console.WriteLine($"Before:\n{subBefore}\nAfter:\n{subAfter}");
            subBefore = ReplaceMark(".", "", subBefore);
            subBefore = ReplaceMark("!", "", subBefore);
            subAfter = ReplaceMark(" ", "_", subAfter);
            builder.Append(subBefore).Append(subAfter);

            return builder.ToString();
        }

        private static string ReplaceMark(string oldMark, string replacement, string strText)
        {
            return strText.Replace(oldMark, replacement);
        }

        private static void FindReferenceMarkIndex(char referenceMark, out int counter, string text)
        {
            counter = 0;

            foreach (char ch in text)
            {
                counter++;
                if (ch == referenceMark)
                {
                    break;
                }
            }
        }
    }
}
