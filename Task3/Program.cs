using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
            Console.WriteLine("\t2. Only day and month");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    break;
                case "2":
                    break;
                default:
                    Console.WriteLine("Input unresolved!");
                    break;
            }
            InputBirthdayDTFormatt(sName);
            Console.Read();
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
            if(currentDT.DayOfYear < birthdayDT.DayOfYear)
            {
                years--;                
            }
            else if(currentDT.DayOfYear == birthdayDT.DayOfYear)
            {
                bHappyBirthday = true;
            }            
            return years;
        }
    }
}
