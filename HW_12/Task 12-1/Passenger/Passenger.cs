﻿using System;
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

            public override string ToString()
            {
                return $"{FirstName} {Surname}";
            }
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
        private string _destination;
        private bool _hasDestination;
        private bool _hasVisa;
        
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
                }

            }
        }

        public bool IsLegalAge
        {
            get => _isLegalAge;
            set => _isLegalAge = value;
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

        public string Destination
        {
            get => _destination;
            set
            {
                if(string.IsNullOrEmpty(value))
                {
                    _hasDestination = false;
                }
                else
                {
                    _destination = value;
                    _hasDestination = true;
                }
            }
        }

        public bool HasDestination
        {
            get => _hasDestination;
        }

        public bool HasVisa
        {
            get; set;
        }

        public int SumOfPayment
        {
            get => _sumOfPayment;
        }

        public void PreponderancePayment()
        {
            if(_luggageWeight > MaxLuggageWeight)
            {
                _sumOfPayment += (_luggageWeight - MaxLuggageWeight) * AdditionalPaymentPerKilo;
            }

            if(_carryOnWeight > MaxCarryOnWeight)
            {
                _sumOfPayment += (_carryOnWeight - MaxCarryOnWeight) * AdditionalPaymentPerKilo;
            }
        }

        public string ProvidePassport()
        {
            return $"Passport in the name of citizen {FullName}";
        }

        public Passenger()
        {
        }

        public Passenger(Name fullName)
        {
            FullName = fullName;
        }

        public Passenger(string firstName, string surname)
        {
            _fullName.FirstName = firstName;
            _fullName.Surname = surname;
        }

        public Passenger(Name fullName, int age)
        {
            FullName = fullName;
            Age = age;
        }

        public Passenger(string firstName, string surname, int age)
        {
            _fullName.FirstName = firstName;
            _fullName.Surname = surname;
            _age = age;
        }
    }
}
