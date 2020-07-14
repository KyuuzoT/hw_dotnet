using System;
using System.Collections.Generic;
using System.Text;

namespace Task_12_2
{
    class Song : ISong
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

        public int Duration
        {
            get => _duration;
            set
            {
                if(value <= 0)
                {
                    Console.WriteLine("Invalid field value. Should be greater then 0");
                }
                else
                {
                    _duration = value;
                }
            }
        }

        public Song()
        {

        }

        public Song(string songName)
        {
            _name = songName;
        }

        public Song(string songName, string songAuthor)
        {
            _name = songName;
            _author = songAuthor;
        }

        public Song(string songName, string songAuthor, DateTime releaseDate)
        {
            _name = songName;
            _author = songAuthor;
            _releaseDate = releaseDate;
        }

        private static void CheckString(string value, out string destination)
        {
            if (string.IsNullOrEmpty(value))
            {
                Console.WriteLine("This field could not be empty!");
            }
            destination = value;
        }

        public object GetSongData(Song song)
        {
            string title = $"{song.Author} - {song.Name}";
            return new { title, song.Duration, song.ReleaseDate.Year };
        }

        public void SetSongData(string songName, string songAuthor, DateTime releaseDate, int duration)
        {
            _name = songName;
            _author = songAuthor;
            _releaseDate = releaseDate;
            _duration = duration;
        }
    }
}
