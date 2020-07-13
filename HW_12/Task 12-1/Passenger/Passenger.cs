using System;
using System.Collections.Generic;
using System.Text;
using static Task_12_1.Passenger.GlobalVars;

namespace Task_12_1.Passenger
{
    class Passenger : IPassenger
    {
        public struct Name
        {
            public string FirstName;
            public string Surname;
        }

        private Name _fullName;
        private int _age;
        private bool _isLegalAge;
        private bool _onlineCheckIn;
        private bool _appCheckIn;
        private bool _hasLuggage;
        private int _luggageWeight;
        private bool _hasCarryOn;
        private int _carryOnWeight;
        
        private int _sumOfPayment;

        public Name FullName
        {
            get => _fullName;
            set
            {
                if (string.IsNullOrEmpty(value.FirstName))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Everyone has it's own name!");
                    Console.ResetColor();
                }
                else if (string.IsNullOrEmpty(value.FirstName))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Did you forget about surname!");
                    Console.ResetColor();
                }
                else
                {
                    _fullName = value;
                }
            }
        }

        public int Age
        {
            get => _age;
            set
            {
                if(value < 1)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Your age could not be less then 1");
                    Console.ResetColor();
                }
                else
                {
                    _age = value;
                    if (value < 18)
                    {
                        _isLegalAge = true;
                    }
                }

            }
        }

        public bool IsLegalAge
        {
            get => _isLegalAge;
        }

        public bool OnlineCheckIn
        {
            get => _onlineCheckIn;
            set
            {
                _onlineCheckIn = value;
                if(_onlineCheckIn)
                {
                    _appCheckIn = false;
                }
            }
        }

        public bool AppCheckIn
        {
            get => _appCheckIn;
            set
            {
                _appCheckIn = value;
                if(_appCheckIn)
                {
                    _onlineCheckIn = false;
                }
            }
        }

        public bool HasLuggage
        {
            get => _hasLuggage;
            set => _hasLuggage = value;
        }

        public int LuggageWeight
        {
            get => _luggageWeight;
            set
            {
                if(value < 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Are you carrying an antimatter!");
                    Console.ResetColor();
                }
                else
                {
                    if(value >= 1_000)
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("Perhaps, you should consider booking a cargo plane...");
                        Console.ResetColor();
                    }

                    _luggageWeight = value;
                }
            }
        }

        public bool HasCarryOn
        {
            get => _hasCarryOn;
            set => _hasCarryOn = value;
        }

        public int CarryOnWeight
        {
            get => _carryOnWeight;
            set
            {
                if (value < 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Are you carrying an antimatter!");
                    Console.ResetColor();
                }
                else
                {
                    if(value > 15)
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("That should be going to standart luggage, but whatever.");
                        Console.ResetColor();
                    }
                    _carryOnWeight = value;
                }
            }
        }

        public void PreponderancePayment()
        {
            if(_luggageWeight > MaxLuggageWeight)
            {
                _sumOfPayment += (MaxLuggageWeight - _luggageWeight) * AdditionalPaymentPerKilo;
            }

            if(_carryOnWeight > MaxCarryOnWeight)
            {
                _sumOfPayment += (MaxCarryOnWeight - _carryOnWeight) * AdditionalPaymentPerKilo;
            }
        }
    }
}
