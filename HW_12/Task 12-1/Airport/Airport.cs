using System;
using System.Collections.Generic;
using System.Text;

namespace Task_12_1.Airport
{
    class Airport
    {
        private static Airport _airportInstance;
        private static string _airportName;

        private Airport()
        {
        }

        public Airport GetAirportInstance()
        {
            if(_airportInstance.Equals(null))
            {
                _airportInstance = new Airport();
            }

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
                    string.Concat(greeting, "Good morning, ");
                    break;
                case int hour when (hour >= 12 && hour < 18):
                    string.Concat(greeting, "Good afternoon, ");
                    break;
                case int hour when (hour >= 18 && hour < 22):
                    string.Concat(greeting, "Good evening, ");
                    break;
                case int hour when (hour >= 22 || (hour >= 0 && hour < 6)):
                    string.Concat(greeting, "Good night, ");
                    break;
                default:
                    string.Concat(greeting, "Guten Tag, ");
                    break;
            }

            return greeting;
        }


    }
}
