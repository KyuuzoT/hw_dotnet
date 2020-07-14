using System;
using Task_12_1.Airport;
using Task_12_1.Passenger;

namespace Task_12_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var airport = Airport.Airport.GetAirportInstance();
            airport.AirportName = "Ben Gurion, TLV";

            var passenger = CreatePassenger();

            Console.WriteLine($"{airport.GetAirportTimeOfDayGreeting()}" +
                $"{passenger.FullName}!");
            

            Console.ReadKey();
        }

        private static Passenger.Passenger CreatePassenger()
        {
            var pass = new Passenger.Passenger();
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

            return pass;
        }

        private static int InputWeight(Passenger.Passenger pass, string name)
        {
            Console.WriteLine($"Input weight of your {name}:");
            int weight;
            while (!int.TryParse(Console.ReadLine(), out weight))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid input, try again!");
                Console.ResetColor();
                Console.WriteLine($"Input weight of your {name}:");
            }

            return weight;
        }
    }
}
