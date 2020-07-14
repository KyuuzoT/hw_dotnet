using System;
using System.Collections.Generic;
using System.Text;

namespace Task_12_2
{
    class Song
    {
        private string _name;
        private int _duration;
        private string _author;
        private DateTime _releaseDate;

        public string Name
        {
            get => _name;
            set
            {
                CheckString(value, out _name);
            }
        }

        public string Author
        {
            get => _author;
            set
            {
                CheckString(value, out _author);
            }
        }

        public DateTime ReleaseDate
        {
            get => _releaseDate;
            set
            {
                if(value == default)
                {
                    Console.WriteLine("What's this? Ancient release? Suggest you to change it.");
                }
                else
                {
                    _releaseDate = value;
                }
            }
        }

        private static void CheckString(string value, out string destination)
        {
            if (string.IsNullOrEmpty(value))
            {
                Console.WriteLine("This field could not be empty!");
            }
            destination = value;
        }
    }
}
