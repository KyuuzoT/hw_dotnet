using System;
using Newtonsoft.Json;

namespace Task_12_2
{
    class Program
    {
        public static string SongName = "Call of the Mountains";
        public static string Artist = "Eluvetie";
        public static int Duration = 255;
        public static DateTime ReleaseDate = new DateTime(2014, 7, 31);
        public static Genres Genre = Genres.FolkMetal;
        static void Main(string[] args)
        {
            ISong song = new Song();
            song.SetSongData(SongName, Artist, ReleaseDate, Duration, Genre);

            string json = JsonConvert.SerializeObject(song.GetSongData(song as Song));
            Console.WriteLine($"Serialized object: \n{json}");

            var deserialized = JsonConvert.DeserializeObject<Song>(json);
            deserialized.SetSongData(SongName, Artist, ReleaseDate, Duration, Genre);
            Console.WriteLine($"Deserialized object: \n{deserialized}");

            Console.ReadKey();
        }
    }
}
