using System;

namespace Task3Catalogue
{
    class Application
    {
        public static void Main(string[] args)
        {
            File music = new MusicFile();
            music.Category = "Music//Rock";
            music.ID = Guid.NewGuid();
            music.Name = "Сказки Чёрного Города - Оборотень.mp3";
            music.Size = 10_234_101;
            Console.WriteLine(music.GetFileInformation());

            VideoFile video = new VideoFile();
            video.Category = "Films//Detective";
            video.ID = Guid.NewGuid();
            video.Name = "Psycho-Pass: Sinners of the System. First Guardian";
            video.Size = 1_084_361_728;
            video.Director = "Naoyoshi Shiotani";
            video.MainActor = "Seki Tomokazu";
            video.MainActress = "Hanazawa Kana";
            video.Duration = 60.06f;
            Console.WriteLine(video.GetFileInformation());
            video.Play();
            video.RetrieveInformation();

            Console.ReadKey();
        }
    }
}
