using System;

namespace AssemblyOne
{
    class SportBike : Motorcycle
    {
        private string _yamahaSound = "YA-MA-HA YAMA-YAMA YAMA-HAAA!";
        private string _suzukiSound = "SUUUUUU-ZUUUUUU-KIIIIIIIIiiiii";
        private string _hondaSound = "HWOoooo-NNNNN-DAaaaaaaa";
        public new ushort MaxSpeed { get; } = 220;
        protected new bool isRedisigned;
        public string Model;

        public SportBike()
        {
            Model = "Harley Davidson";
        }

        public SportBike(string model)
        {
            Model = model;
        }

        public SportBike (string model, bool redisigned)
        {
            Model = model;
            isRedisigned = redisigned;
        }

        protected internal override void StartEngine()
        {
            Console.WriteLine("Start Engine in class SportBike:");
            string sound = MakeSound();
            if(string.IsNullOrEmpty(sound))
            {
                base.StartEngine();
            }
            else
            {
                Console.WriteLine($"\t{sound}");
            }           
        }

        private string MakeSound()
        {
            switch (Model)
            {
                case string s when s.ToLower().Contains("yamaha"):
                    return _yamahaSound;                       
                case string s when s.ToLower().Contains("suzuki"):
                    return _suzukiSound;                            
                case string s when s.ToLower().Contains("honda"):
                    return _hondaSound;
                default:
                    return string.Empty;
            }
        }

        internal override void StopEngine()
        {
            base.StopEngine();
        }
    }
}
