using System;

namespace AssemblyOne
{
    public class Motorcycle
    {
        private const UInt16 _maxSpeed = 180;
        private protected string _vinNumber;
        internal int _odometer;
        protected internal int _engineVolume = 1;
        public string CountryOfOrigin = "Serinistan";
        protected bool isRedisigned = false;

        public ushort MaxSpeed
        {
            get
            {
                return _maxSpeed;
            }
        }

        public string VinNumber
        {
            get
            {
                if(String.IsNullOrEmpty(_vinNumber))
                {
                    _vinNumber = Guid.NewGuid().ToString();
                }
                return _vinNumber;
            }
            set
            {
                if (!String.IsNullOrEmpty(value))
                {
                    _vinNumber = value;
                }
                else
                {
                    Console.WriteLine("Invalid vin-number!");
                }
            }
        }

        public Motorcycle()
        {
            _vinNumber = "00000000-0000-0000-0000-000000000000";
            _odometer = 5_000;
            _engineVolume = 50;
            CountryOfOrigin = "China";
            isRedisigned = false;
        }

        protected internal virtual void StartEngine()
        {
            Console.WriteLine("Start Engine:");
            Console.WriteLine("\tEngine goes \"Wroom-Wroom\"!");
        }

        internal virtual void StopEngine()
        {
            Console.WriteLine("Stop Engine:");
            Console.WriteLine("\tEngine goes \"Tphruuuuum\"! And... silence!");
        }

        protected internal void TurnOnCoolMusic()
        {
            Console.WriteLine("Cool Music:");
            Console.WriteLine("\t♫♪♫Back in black\t\nI hit the sack\t\n I’ve been too long I’m glad to be back!♫♪♫");
        }
    }
}
