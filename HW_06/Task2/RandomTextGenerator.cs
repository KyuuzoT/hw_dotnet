using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class RandomTextGenerator
    {
        private static string CharSequence = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
        public static string MarksSequence = ".,:;";
        private static string Delimiter = " ";
        public static int WordsQuantity = 40;
        public static int WordMaxLength = 15;

        public static string GenerateText()
        {
            StringBuilder builder = new StringBuilder();
            Random rnd = new Random();
            for (int i = 0; i < WordsQuantity; i++)
            {
                for (int j = 0; j < rnd.Next(2,WordMaxLength+1); j++)
                {
                    builder.Append(CharSequence[rnd.Next(CharSequence.Length)]);
                }
                if(i<WordsQuantity-1)
                {
                    if(rnd.Next(1,100) > 75)
                    {
                        builder.Append(MarksSequence[rnd.Next(MarksSequence.Length)]).Append(Delimiter);
                    }
                    else
                    {
                        builder.Append(Delimiter);
                    }
                }
            }
            return builder.ToString();
        }
    }
}
