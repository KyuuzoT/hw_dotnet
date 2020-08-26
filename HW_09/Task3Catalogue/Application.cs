using System;

namespace Task3Catalogue
{
    class Application
    {
        private static int _arrayLength = 5;

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

            CreateArrayOfFiles();
            Console.ReadKey();
        }

        private static void CreateArrayOfFiles()
        {
            var music = CreateArrayOfMusicFiles();
            PrintArray(music);

            var video = CreateArrayOfVideoFiles();
            PrintArray(video);

            var prog = CreateArrayOfProgramFiles();
            PrintArray(prog);
        }

        private static ProgramFile[] CreateArrayOfProgramFiles()
        {
            ProgramFile[] programs = new ProgramFile[_arrayLength];
            for (int i = 0; i < programs.Length; i++)
            {
                var program = new ProgramFile();
                program.Category = "Game";
                program.ID = Guid.NewGuid();
                program.Name = "Aion: Tower of Eternity";
                program.Size = 37_580_963_840;
                programs[i] = program;
            }
            return programs;
        }

        private static VideoFile[] CreateArrayOfVideoFiles()
        {
            VideoFile[] videos = new VideoFile[_arrayLength];
            for (int i = 0; i < videos.Length; i++)
            {
                var video = new VideoFile();
                video.Category = "Films//Detective";
                video.ID = Guid.NewGuid();
                video.Name = "Psycho-Pass: Sinners of the System. First Guardian";
                video.Size = 1_084_361_728;
                video.Director = "Naoyoshi Shiotani";
                video.MainActor = "Seki Tomokazu";
                video.MainActress = "Hanazawa Kana";
                video.Duration = 60.06f;
                videos[i] = video;
            }
            return videos;
        }

        private static MusicFile[] CreateArrayOfMusicFiles()
        {
            MusicFile[] musics = new MusicFile[_arrayLength];
            for (int i = 0; i < musics.Length; i++)
            {
                var music = new MusicFile();
                music.Category = "Music//Rock";
                music.ID = Guid.NewGuid();
                music.Name = "Сказки Чёрного Города - Оборотень.mp3";
                music.Size = 10_234_101;
                music.Duration = 292;
                music.Singer = "Сказки Чёрного Города";
                musics[i] = music;
            }
            return musics;
        }

        private static void PrintArray(File[] arrayOfFiles)
        {
            Console.WriteLine($"Type of array: {arrayOfFiles.GetType()}");
            for (int i = 0; i < arrayOfFiles.Length; i++)
            {
                Console.WriteLine($"{i}. File: ");
                Console.WriteLine(arrayOfFiles[i].GetFileInformation());
            }
        }
    }
}
