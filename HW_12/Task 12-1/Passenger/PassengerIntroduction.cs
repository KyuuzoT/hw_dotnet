using System;
using System.Collections.Generic;
using System.Text;

namespace Task_12_1.Passenger
{
    public static class PassengerIntroduction
    {
        internal static Passenger.Name IntroduceYourself(this Passenger passenger)
        {
            Passenger.Name fullName;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("What's your name?");
            fullName.FirstName = Console.ReadLine();
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("What's your surname?");
            fullName.Surname = Console.ReadLine();
            Console.ResetColor();

            passenger.FullName = fullName;
            return passenger.FullName;
        }

        internal static string SetAge(this Passenger passenger)
        {
            int age;
            while (!int.TryParse(Console.ReadLine(), out age))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Age is not valid!");
                Console.ResetColor();
            }
            passenger.Age = age;
            passenger.IsLegalAge = CheckAgeForLegality(passenger.Age);
            return passenger.Age.ToString();
        }

        internal static void LuggagePresenceCheck(this Passenger passenger)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("(y,n)?");

            string answer = Console.ReadLine();

            if(answer.ToLower().Equals("y"))
            {
                passenger.HasLuggage = true;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("You're flying without luggage.");
                Console.ResetColor();
                passenger.HasLuggage = false;
            }
        }

        internal static void CarryOnPresenceCheck(this Passenger passenger)
        {
            Console.WriteLine("(y,n)?");
            string answer = Console.ReadLine();

            if (answer.ToLower().Equals("y"))
            {
                passenger.HasCarryOn = true;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("You're flying without carryon.");
                Console.ResetColor();
                passenger.HasCarryOn = false;
            }
        }

        private static bool CheckAgeForLegality(int age)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            if (age >= 18)
            {
                Console.WriteLine("According to our notes you're legal age to flight!");
                Console.ResetColor();
                return true;
            }
            else
            {
                Console.WriteLine("You can attend flying only in the presence of parents or custodians.");
                Console.ResetColor();
                return false;
            }
        }

        internal static void CheckInPerformed(this Passenger passenger)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Do you want to perform your check-in via Internet? (y,n)");
            string answer = Console.ReadLine();

            if (answer.ToLower().Equals("y"))
            {
                passenger.OnlineCheckIn = true;
            }
            else
            {
                Console.WriteLine("Do you want to perform your check-in via Application? (y,n)");
                answer = Console.ReadLine();
                if (answer.ToLower().Equals("y"))
                {
                    passenger.AppCheckIn = true;
                }
                else
                {
                    Console.WriteLine("You need to perform check-in in the airport!");
                    passenger.OnlineCheckIn = false;
                    passenger.AppCheckIn = false;
                }
            }
            Console.ResetColor();
        }

        internal static void CheckAdditionalPayment(this Passenger passenger)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            if (passenger.SumOfPayment.Equals(0))
            {
                Console.WriteLine("You have no additional payments!");
            }
            else
            {
                Console.WriteLine($"Sum of payment for preponderance: {passenger.SumOfPayment}");
            }
            Console.ResetColor();
        }
    }
}
