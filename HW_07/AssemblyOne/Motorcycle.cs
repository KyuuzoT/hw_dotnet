using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssemblyOne
{
    class Motorcycle
    {
        private const UInt16 _maxSpeed = 180;
        private protected string _vinNumber;
        internal int _odometer;
        protected internal int _engineVolume;
        public string CountryOfOrigin;
        protected bool isRedisigned;

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
                _vinNumber = value;
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

        protected virtual void StartEngine()
        {
            Console.WriteLine("Engine goes \"Wroom-Wroom\"!");
        }

        internal virtual void StopEngine()
        {
            Console.WriteLine("Engine goes \"Tphruuuuum\"! And... silence!");
        }

        protected internal void TurnOnCoolMusic()
        {
            Console.WriteLine("♫♪♫Back in black\nI hit the sack\nI’ve been too long I’m glad to be back!♫♪♫");
        }
    }
}
