using System;

namespace Task3Catalogue
{
    class MusicFile : File
    {
        protected string _singer;
        protected float _duration;
        
        public string Singer
        {
            get
            {
                return _singer;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _singer = value;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Singers usually have names!");
                    Console.ResetColor();
                }
            }
        }

        public float Duration
        {
            get
            {
                return _duration;
            }
            set
            {
                if (value > 0)
                {
                    _duration = value;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Duration can not be negative and must be greater than 0!");
                    Console.ResetColor();
                }
            }
        }

        public void Play()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Not implemented yet.");
            Console.ResetColor();
        }

        public void RetrieveInformation()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Establishing Internet connection. Stand by.");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Not implemented yet.");
            Console.ResetColor();
        }

        public override string GetFileInformation()
        {
            string result = base.GetFileInformation() +
                $"Singer: {this._singer}\n" +
                $"Duration: {this._duration}\n";
            return base.GetFileInformation();
        }
    }
}
