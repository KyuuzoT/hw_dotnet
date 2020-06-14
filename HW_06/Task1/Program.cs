using System;
using System.Text.RegularExpressions;

namespace Task1
{
    class Program
    {
        enum LanguageMode
        {
            English,
            Russian
        }
        static LanguageMode Mode = LanguageMode.English;

        static void Main(string[] args)
        {
            string verse = InputVerse(useDefaultVerse: true);
            Console.WriteLine($"Poem:\n {verse}");
            string[] poemArray = verse.Split(';');

            if(Regex.IsMatch(verse, @"[A-Z|a-z]+"))
            {
                Console.WriteLine("English mode on!");
                Mode = LanguageMode.English;               
            }
            else if(Regex.IsMatch(verse, @"[А-Я|а-я]+"))
            {
                Console.WriteLine("Russian mode on!");
                Mode = LanguageMode.Russian;
            }
            ReplaceLetters(ref poemArray, Mode);
            PrintArray(poemArray, "\nLetters replace");

            Console.ReadKey();
        }

        private static void ReplaceLetters(ref string[] poemArray, LanguageMode mode)
        {
            switch (mode)
            {
                case LanguageMode.English:
                    ReplaceEnglishLetters(ref poemArray);
                    break;
                case LanguageMode.Russian:
                    ReplaceRussianLetters(ref poemArray);
                    break;
                default:
                    break;
            }
        }

        private static void ReplaceEnglishLetters(ref string[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = array[i].Replace('O', 'A');
                array[i] = array[i].Replace('o','a');
            }
        }

        private static void ReplaceRussianLetters(ref string[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = array[i].Replace('О', 'А');
                array[i] = array[i].Replace('о', 'а');
            }
        }

        private static string InputVerse()
        {
            Console.WriteLine("Please, input your verse in one line. As a delimiter, please, use ';'.");
            string verse = Console.ReadLine();
            return verse;
        }

        private static string InputVerse(bool useDefaultVerse)
        {
            string verse = 
                "Награбленных денег хватило надолго; " +
                "Кабак стал обителью наших страстей; " +
                "Мы тратили время без всякого толка; " +
                "Запасы спиртного топили гостей; " +
                "Сидел я с бутылкой среди обалдевших; " +
                "Опухших, едва узнаваемых лиц; " +
                "Товарищей пьяных, увы, не сумевших; " +
                "В ту ночь поделить двух распутных девиц; " +
                "Начался дебош и хаос; " +
                "Принесли вина и рому; " +
                "Первый выстрел сделал Клаус; " +
                "Продырявив бок Немому; " +
                "Тут все, как с цепи сорвались; " +
                "Позабыли о том, что мы команда; " +
                "Девки под столы забрались; " +
                "Глядя, как уменьшалась наша банда;";
            return verse;
        }

        private static void PrintArray<T>(T[] array)
        {
            foreach (var item in array)
            {
                Console.Write($"{item} ");
            }
        }

        private static void PrintArray<T>(T[] array, string name)
        {
            Console.WriteLine($"\n{name}: ");
            foreach (var item in array)
            {
                Console.Write($"{item} ");
            }
        }
    }
}
