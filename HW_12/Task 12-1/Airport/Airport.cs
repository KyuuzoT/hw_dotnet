using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using Task_12_1.Passenger;

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

        internal void PerformPassportControl(Passenger.Passenger passenger, out bool statusOk)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Please, provide a passport for the control.");
            Thread.Sleep(1000);
            Console.WriteLine("Control in progress, please stand by...");
            Thread.Sleep(2000);
            if(!passenger.HasDestination)
            {
                Console.WriteLine("If you're not gonna fly anywhere then why are you here?");
            }
            if(!passenger.HasVisa)
            {
                statusOk = false;
            }
            else
            {
                statusOk = true;
            }

            Console.WriteLine("Done.");
            Console.ResetColor();
        }

        public void PerformCheckIn()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Performing check-in...");
            Thread.Sleep(1000);
            Console.WriteLine("Performed!\n");
            Console.ResetColor();
        }

        public bool CheckPerformedCheckIn(Passenger.Passenger passenger)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Have you already performed check-in?");
            if (!passenger.OnlineCheckIn)
            {
                Console.WriteLine("Apparently nor via internet...");

                if (!passenger.AppCheckIn)
                {
                    Console.WriteLine("Apparently neither via application");
                    Console.ResetColor();
                    return false;
                }
                else
                {
                    Console.WriteLine("See your check-in in our application!");
                    Console.ResetColor();
                    return true;
                }
            }
            else
            {
                Console.WriteLine("See your check-in on our site.");
                Console.ResetColor();
                return true;
            }
        }


        internal void PerformSecurityCheckOfLuggage()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("We should perform a small security check for your luggage:");
            string answer;
            Console.WriteLine("\nYou should answer 'y' or 'n' to every question in this list!");
            Console.WriteLine("\t1. Do you have any guns?");
            Console.ResetColor();
            answer = Console.ReadLine();
            CheckAnswer(answer);

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\t2. Do you have any explosives?");
            Console.ResetColor();
            answer = Console.ReadLine();
            CheckAnswer(answer);

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\t3. Do you have any domestic or industrial gases?");
            Console.ResetColor();
            answer = Console.ReadLine();
            CheckAnswer(answer);

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\t4. Do you have any flammable liquids?");
            Console.ResetColor();
            answer = Console.ReadLine();
            CheckAnswer(answer);

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\t5. Do you have any flammable matters?");
            Console.ResetColor();
            answer = Console.ReadLine();
            CheckAnswer(answer);

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\t6. Do you have any poisonous matters?");
            Console.ResetColor();
            answer = Console.ReadLine();
            CheckAnswer(answer);

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\t7. Do you have any toxic matters?");
            Console.ResetColor();
            answer = Console.ReadLine();
            CheckAnswer(answer);

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\t8. Do you have any caustic substances?");
            Console.ResetColor();
            answer = Console.ReadLine();
            CheckAnswer(answer);            
        }

        internal void PerformSecurityCheckOfCarryOn()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("We should perform a security check for your carryon:");
            string answer;
            Console.WriteLine("\nYou should answer 'y' or 'n' to every question in this list!");
            Console.WriteLine("\t1. Do you have any guns?");
            Console.ResetColor();
            answer = Console.ReadLine();
            CheckAnswer(answer);

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\t2. Do you have any explosives?");
            Console.ResetColor();
            answer = Console.ReadLine();
            CheckAnswer(answer);

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\t3. Do you have any domestic or industrial gases?");
            Console.ResetColor();
            answer = Console.ReadLine();
            CheckAnswer(answer);

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\t4. Do you have any flammable liquids?");
            Console.ResetColor();
            answer = Console.ReadLine();
            CheckAnswer(answer);

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\t5. Do you have any flammable matters?");
            Console.ResetColor();
            answer = Console.ReadLine();
            CheckAnswer(answer);

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\t6. Do you have any poisonous matters?");
            Console.ResetColor();
            answer = Console.ReadLine();
            CheckAnswer(answer);

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\t7. Do you have any toxic matters?");
            Console.ResetColor();
            answer = Console.ReadLine();
            CheckAnswer(answer);

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\t8. Do you have any caustic substances?");
            Console.ResetColor();
            answer = Console.ReadLine();
            CheckAnswer(answer);

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\t9. Do you have any knives, axes, other steel arms?");
            Console.ResetColor();
            answer = Console.ReadLine();
            CheckAnswer(answer);

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\t10. Do you have any caustic mercury thermometers?");
            Console.ResetColor();
            answer = Console.ReadLine();
            CheckAnswer(answer);

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\t11. Do you have any small vehicles e.g. monowheel, gyroscuter etc.?");
            Console.ResetColor();
            answer = Console.ReadLine();
            CheckAnswer(answer);
        }

        private void CheckAnswer(string answer)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            if (answer.ToLower().Equals("y"))
            {
                Console.WriteLine("You should throw this away 'cause you can not fly with it.");
                ThrowingAwayForbiddenSubstance();
                Console.WriteLine("Ok, next question:");
            }
            else
            {
                Console.WriteLine("Ok, next question:");
            }
            Console.ResetColor();
        }

        private void ThrowingAwayForbiddenSubstance()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Throwing it away...");
            Thread.Sleep(2000);
            Console.WriteLine("Done.");
            Console.ResetColor();
        }
    }
}
