using System;
using System.Collections.Generic;
using System.Text;

namespace Task_12_1.Passenger
{
    public static class PassengerIntroduction
    {
        internal static Passenger CreatePassenger(this Passenger pass)
        {
            Console.WriteLine("Input information about yourself:");
            pass.IntroduceYourself();
            pass.SetAge();
            pass.CheckInPerformed();
            pass.LuggagePresenceCheck();
            if (pass.HasLuggage)
            {
                pass.LuggageWeight = InputWeight(pass, "luggage");
            }

            pass.CarryOnPresenceCheck();
            if (pass.HasCarryOn)
            {
                pass.CarryOnWeight = InputWeight(pass, "carryon");
            }

            pass.CheckAdditionalPayment();

            pass.FlightDestinationInput();
            if (string.IsNullOrEmpty(pass.Destination))
            {
                return pass;
            }
            else
            {
                VisaCheck(pass);
            }

            return pass;
        }

        private static void VisaCheck(this Passenger pass)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Do you has visa to {pass.Destination}? (y, n)");
            Console.ResetColor();
            string answer = Console.ReadLine();
            if (answer.ToLower().Equals("y"))
            {
                pass.HasVisa = true;
            }
            else
            {
                pass.HasVisa = false;
            }
        }

        private static void FlightDestinationInput(this Passenger pass)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("What's your flight destination?");
            Console.ResetColor();
            pass.Destination = Console.ReadLine();
        }

        private static int InputWeight(Passenger pass, string name)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Input weight of your {name}:");
            Console.ResetColor();
            int weight;
            while (!int.TryParse(Console.ReadLine(), out weight))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid input, try again!");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"Input weight of your {name}:");
                Console.ResetColor();
            }

            return weight;
        }

        internal static Passenger.Name IntroduceYourself(this Passenger passenger)
        {
            Passenger.Name fullName;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("What's your name?");
            Console.ResetColor();
            fullName.FirstName = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("What's your surname?");
            Console.ResetColor();
            fullName.Surname = Console.ReadLine();

            passenger.FullName = fullName;
            return passenger.FullName;
        }

        internal static string SetAge(this Passenger passenger)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Your age:");
            Console.ResetColor();
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
            Console.WriteLine("Are you flying with luggage?");
            Console.WriteLine("(y,n)?");
            Console.ResetColor();

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
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Are you flying with carry-on?");
            Console.WriteLine("(y,n)?");
            Console.ResetColor();
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
                Console.WriteLine("You're legal age to flight!");
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
            Console.ResetColor();
            string answer = Console.ReadLine();

            if (answer.ToLower().Equals("y"))
            {
                passenger.OnlineCheckIn = true;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Do you want to perform your check-in via Application? (y,n)");
                Console.ResetColor();
                answer = Console.ReadLine();
                if (answer.ToLower().Equals("y"))
                {
                    passenger.AppCheckIn = true;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("You need to perform check-in in the airport!");
                    Console.ResetColor();
                    passenger.OnlineCheckIn = false;
                    passenger.AppCheckIn = false;
                }
            }
            Console.ResetColor();
        }

        internal static void CheckAdditionalPayment(this Passenger passenger)
        {
            passenger.PreponderancePayment();
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
