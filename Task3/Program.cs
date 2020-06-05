using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static bool bHappyBirthday;
        static void Main(string[] args)
        {
            Console.WriteLine("Please input your name:");
            string sName = Console.ReadLine();
            Console.WriteLine($"Hello, {sName}, how would you like to input your birthday date?");
            Console.WriteLine("\t1. Full date of birth in format: {0:d}", new DateTime(1970, 1, 1));
            Console.WriteLine("\t2. Only year and month");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    InputBirthdayDTFormatt(sName);
                    break;
                case "2":
                    InputYearAndMonth(sName);
                    break;
                default:
                    Console.WriteLine("Input unresolved!");
                    Thread.Sleep(1000);
                    return;
            }

            Console.Read();
        }

        private static void InputYearAndMonth(string sName)
        {
            int year;
            int month;
            do
            {
                Console.WriteLine("\nInput month: ");
                string sMonth = Console.ReadLine();
                if (int.TryParse(sMonth, out month))
                {
                    if (month >= 1 && month <= 12)
                    {
                        break;
                    }
                }
                Console.WriteLine("\nIncorrect month. Try again.\n");
            } while (true);

            do
            {
                Console.WriteLine("\nInput year: ");
                string sYear = Console.ReadLine();
                if (int.TryParse(sYear, out year))
                {
                    if (year >= 1820 && year <= 2020)
                    {
                        break;
                    }
                }
                Console.WriteLine("\nIncorrect year. Try again.\n");
            } while (true);
        }

        private static void InputBirthdayDTFormatt(string sName)
        {
            int age;
            DateTime currentDT = DateTime.Now;
            DateTime birthdayDT;
            do
            {
                Console.WriteLine("Please input your date of birth in format: {0:d}", new DateTime(1970, 1, 1));
            } while (!DateTime.TryParse(Console.ReadLine(), out birthdayDT));

            Console.WriteLine(currentDT);
            age = GetAge(birthdayDT, currentDT);
            Console.WriteLine($"Hello again, {sName}! Your age is {age}!");
            if (bHappyBirthday)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"So, {sName}, today is your birthday! We wish you best luck!");
                Console.ResetColor();
            }
        }

        private static int GetAge(DateTime birthdayDT, DateTime currentDT)
        {
            bHappyBirthday = false;
            int years = currentDT.Year - birthdayDT.Year;
            if (currentDT.DayOfYear < birthdayDT.DayOfYear)
            {
                years--;
            }
            else if (currentDT.DayOfYear == birthdayDT.DayOfYear)
            {
                bHappyBirthday = true;
            }
            return years;
        }
    }
}
