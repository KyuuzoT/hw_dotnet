using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3Catalogue
{
    class VideoFile : File
    {
        protected string _director;
        protected string _mainActor;
        protected string _mainActress;
        protected int _duration;

        public string Director
        {
            get
            {
                return _director;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _director = value;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Field 'Director' could not be empty!");
                    Console.ResetColor();
                }
            }
        }

        public string MainActor
        {
            get
            {
                return _mainActor;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _mainActor = value;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Field 'Main Actor' could not be empty!");
                    Console.ResetColor();
                }
            }
        }

        public string MainActress
        {
            get
            {
                return _mainActress;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _mainActress = value;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Field 'Main Actress' could not be empty!");
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

        public override string GetFileInformation()
        {
            string result = base.GetFileInformation() +
                $"Film's director: {this._director}\n" +
                $"Main Actor: {this._mainActor}\n" +
                $"Main Actress: {this._mainActress}\n" +
                $"Film's duration: {this._duration}\n";
            return result;
        }
    }
}
