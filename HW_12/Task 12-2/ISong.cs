using System;
using System.Collections.Generic;
using System.Text;

namespace Task_12_2
{
    interface ISong
    {
        object GetSongData(Song song);
        void SetSongData(string songName, string songAuthor, DateTime releaseDate, int duration);
        void SetSongData(string songName, string artist, DateTime releaseDate, int duration, Genres genre);
    }
}
