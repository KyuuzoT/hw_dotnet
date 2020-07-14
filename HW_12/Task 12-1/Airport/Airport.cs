using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Task_12_1.Airport
{
    class Airport
    {
        private static Airport _airportInstance;
        private static string _airportName;

        private Airport()
        {
        }

        public static Airport GetAirportInstance()
        {
            if(_airportInstance == null)
            {
                _airportInstance = new Airport();
            }

            return _airportInstance;
        }

        public static Airport GetAirportInstance(string name)
        {
            if (_airportInstance == null)
            {
                _airportInstance = new Airport();
            }

            _airportName = name;

            return _airportInstance;
        }

        public string AirportName
        {
            get => _airportName;
            set
            {
                if(!string.IsNullOrEmpty(value))
                {
                    _airportName = value;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("An airport should have a name!");
                    Console.ResetColor();
                }
            }
        }

        public string GetAirportTimeOfDayGreeting()
        {
            string greeting = string.Empty;
            TimeSpan currentTime = DateTime.Now.TimeOfDay;

            switch (currentTime.Hours)
            {
                case int hour when (hour >= 6 && hour < 12):
                    greeting = string.Concat(greeting, "Good morning, ");
                    break;
                case int hour when (hour >= 12 && hour < 18):
                    greeting = string.Concat(greeting, "Good afternoon, ");
                    break;
                case int hour when (hour >= 18 && hour < 22):
                    greeting = string.Concat(greeting, "Good evening, ");
                    break;
                case int hour when (hour >= 22 || (hour >= 0 && hour < 6)):
                    greeting = string.Concat(greeting, "Good night, ");
                    break;
                default:
                    string.Concat(greeting, "Guten Tag, ");
                    break;
            }

            return greeting;
        }

        public void PerformCheckIn()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Performing check-in...");
            Thread.Sleep(1000);
            Console.WriteLine("Performed!");
            Console.ResetColor();
        }

        public void CheckPerformedCheckIn(Passenger.Passenger passenger)
        {
            Console.WriteLine("Have you already performed check-in?");
            if (!passenger.OnlineCheckIn)
            {
                Console.WriteLine("Apparently nor via internet...");
            }
            else if (!passenger.AppCheckIn)
            {
                Console.WriteLine("Apparently neither via application");
            }
            Console.WriteLine();
        }
    }
}
