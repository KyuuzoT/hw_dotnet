using System;
using System.Collections.Generic;
using System.Text;

namespace Task_12_2
{
    interface ISong
    {
        void SetSongData(string songName, string songAuthor, DateTime releaseDate, int duration);
        object GetSongData(Song song);
    }
}
