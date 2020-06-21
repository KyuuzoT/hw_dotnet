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

        protected override void StartEngine()
        {
            string sound = MakeSound();
            if(string.IsNullOrEmpty(sound))
            {
                base.StartEngine();
            }
            else
            {
                Console.WriteLine(sound);
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
