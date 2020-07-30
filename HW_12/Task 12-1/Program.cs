using System;
using Task_12_1.Airport;
using Task_12_1.Passenger;

namespace Task_12_1
{
    class Program
    {
        private static bool _statusOK;

        static void Main(string[] args)
        {
            var airport = Airport.Airport.GetAirportInstance();
            airport.AirportName = "Ben Gurion, TLV";

            var passenger = new Passenger.Passenger();
            passenger = passenger.CreatePassenger();
            Console.WriteLine("\n\n//-----------------AT THE AIRPORT-----------------//");
            Console.WriteLine($"{airport.GetAirportTimeOfDayGreeting()}" +
                $"{passenger.FullName}! Welcome to {airport.AirportName}");

            Console.WriteLine("\nPlease, proceed to check-in.");
            if (!airport.CheckPerformedCheckIn(passenger))
            {
                airport.PerformCheckIn();
            }
            
            if (passenger.HasLuggage)
            {
                Console.WriteLine("Please proceed to luggage control.");
                airport.PerformSecurityCheckOfLuggage();
            }

            if (passenger.HasCarryOn)
            {
                Console.WriteLine("Please proceed to security check.");
                airport.PerformSecurityCheckOfCarryOn();
            }

            Console.WriteLine("Please proceed to passport control");
            airport.PerformPassportControl(passenger, out _statusOK);

            if(_statusOK)
            {
                Console.WriteLine("WELCOME ON-BOARD!");
            }
            else
            {
                Console.WriteLine("You cannot attend this flight. Have a nice day.");
            }

            Console.ReadKey();
        }
    }
}
