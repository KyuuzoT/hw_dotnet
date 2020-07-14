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

            var passenger = new Passenger.Passenger();
            passenger = passenger.CreatePassenger();
            Console.WriteLine("\n\n//-----------------AT THE AIRPORT-----------------//");
            Console.WriteLine($"{airport.GetAirportTimeOfDayGreeting()}" +
                $"{passenger.FullName}! Welcome to {airport.AirportName}");
            if (!airport.CheckPerformedCheckIn(passenger))
            {
                airport.PerformCheckIn();
            }

            if(passenger.HasLuggage)
            {
                Console.WriteLine("We should perform a small security check for your luggage:");
                airport.PerformSecurityCheckOfLuggage();
            }

            Console.WriteLine("Please proceed to security check");
            if (passenger.HasCarryOn)
            {
                Console.WriteLine("We should perform a security check for your carryon:");
                airport.PerformSecurityCheckOfCarryOn();
            }

            Console.WriteLine("Please proceed to passport control");

            Console.ReadKey();
        }

        
    }
}
