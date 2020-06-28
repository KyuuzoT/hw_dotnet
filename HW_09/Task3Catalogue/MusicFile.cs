using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3Catalogue
{
    class MusicFile : File
    {
        protected string _singer;
        protected int _duration;
        
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

        public int Duration
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
    }
}
