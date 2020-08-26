using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AssemblyOne;

namespace AssemblyTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            Motorcycle moto = new Motorcycle();
            //SportBike bike = new SportBike(); //Inaccessable due to it's protection level!
            Console.WriteLine($"Class{moto.GetType()}");
            Console.WriteLine(moto.MaxSpeed);
            Console.WriteLine(moto.VinNumber);
            //Console.WriteLine(moto._odometr); //Inaccessable due to it's protection level!
            //Console.WriteLine(moto._engineVolume); //Inaccessable due to it's protection level!
            Console.WriteLine(moto.CountryOfOrigin);
            //Console.WriteLine(moto.isRedisigned); //Inaccessable due to it's protection level!

            //moto.StartEngine(); //Inaccessable due to it's protection level!
            //moto.StopEngine(); //Inaccessable due to it's protection level!
            //moto.TurnOnCoolMusic(); //Inaccessable due to it's protection level!
            
            HeavyBike heavy = new HeavyBike();
            Console.WriteLine($"\n\nClass{heavy.GetType()}");
            Console.WriteLine(heavy.MaxSpeed); //Original field inaccessable, but property IS accessable
            Console.WriteLine(heavy.MaxHeavySpeed); //Heavybike's field
            Console.WriteLine(heavy.VinNumber);//Original field inaccessable, but property IS accessable
            Console.WriteLine(heavy.VinHeavyNumber); //Heavybike's field
            Console.WriteLine(heavy._engineVolumeHeavy); //Heavybike's field
            Console.WriteLine(heavy.CountryOfOrigin); //Motorcycle's field
            Console.WriteLine(heavy.CountryOfOriginHeavy); //Heavybike's field
            //Console.WriteLine(heavy.isRedisigned); //Heavybike's field inaccessable
            //Console.WriteLine(heavy.isRedisignedHeavy); //Motorcycle's field inaccessable

            //heavy.StartEngine(); //Inaccessable due to it's protection level!
            heavy.StopEngine();
            heavy.TurnOnCoolMusic();

            Console.ReadKey();
        }
    }

    class HeavyBike : Motorcycle
    {
        private const UInt16 _maxSpeed = 150; //Original field inaccessable
        private protected string _vinNumber;
        internal int _odometer;
        protected internal int _engineVolumeHeavy;
        public string CountryOfOriginHeavy;
        protected bool isRedisignedHeavy;

        public ushort MaxHeavySpeed
        {
            get { return _maxSpeed; }
        }

        public string VinHeavyNumber
        {
            get
            {
                if (String.IsNullOrEmpty(_vinNumber))
                {
                    _vinNumber = Guid.NewGuid().ToString();
                }
                return _vinNumber;
            }
            set
            {
                if(!String.IsNullOrEmpty(value))
                {
                    _vinNumber = value;
                }
                else
                {
                    Console.WriteLine("Invalid vin-number!");
                }
            }
        }

        public HeavyBike()
        {
            _vinNumber = Guid.NewGuid().ToString(); //Original field inaccessable
            _odometer = 1500; //Original field inaccessable
            _engineVolumeHeavy = base._engineVolume; //Original field accessable here
            CountryOfOriginHeavy = base.CountryOfOrigin; //Original field accessable here
            isRedisignedHeavy = base.isRedisigned; //Original field accessable here
        }

        protected override void StartEngine()
        {
            Console.WriteLine("Start Engine Heavy:");
            Console.WriteLine("\tEngine goes \"Wroooooooom-Wrooooooooom\"!");
            base.StartEngine();
        }

        //Inaccessable due to it's protection level!
        //internal override void StopEngine()
        //{
        //    Console.WriteLine("Stop Engine:");
        //    Console.WriteLine("\tEngine goes \"Tphruuuuum\"! And... silence!");
        //}

        internal virtual void StopEngine()
        {
            Console.WriteLine("Stop Engine:");
            Console.WriteLine("\tEngine goes \"Tphruuuuum\"! And... silence!");
            //base.StopEngine(); //Inaccessable due to it's protection level!
        }

        //Original method accessable here
        internal protected new void TurnOnCoolMusic()
        {
            Console.WriteLine("Cool Music Heavy:");
            Console.WriteLine("\t♫♪♫Back in black\t\nI hit the sack\t\n I’ve been too long I’m glad to be back!♫♪♫\n\n");
            base.TurnOnCoolMusic();
        }
    }
}
