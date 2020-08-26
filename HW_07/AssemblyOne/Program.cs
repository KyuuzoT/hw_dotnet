using System;


namespace AssemblyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Motorcycle yamaha = new SportBike(model: "Yamaha", redisigned: true);
            yamaha.CountryOfOrigin = "Japan";
            yamaha.StartEngine();
            UseBike(yamaha);
            yamaha.StopEngine();
            yamaha.TurnOnCoolMusic();
            
            SportBike unknownBike = new SportBike();
            unknownBike.StartEngine();
            unknownBike.StopEngine();
            unknownBike.TurnOnCoolMusic();

            Console.WriteLine($"Class {yamaha.GetType()}; Model {((SportBike)yamaha).Model}; Max Speed {((SportBike)yamaha).MaxSpeed}; Vin {yamaha.VinNumber}; Odometr {yamaha._odometer}; Country: {yamaha.CountryOfOrigin}; Engine {yamaha._engineVolume}");
            Console.WriteLine($"Class {unknownBike.GetType()}; Model {unknownBike.Model}; Max Speed {unknownBike.MaxSpeed}; Vin {unknownBike.VinNumber}; Odometr {unknownBike._odometer}; Country: {unknownBike.CountryOfOrigin}; Engine {unknownBike._engineVolume}");

            Console.ReadKey();
        }

        private static void UseBike(Motorcycle motorcycle)
        {
            ConsoleKey key;
            Console.WriteLine($"Press 'E' to use this bike \"{motorcycle}\" or 'Esc' to finish using it:");
            while (true)
            {
                key = Console.ReadKey().Key;
                if (key == ConsoleKey.E)
                {
                    Console.WriteLine("\nЭтот парень был из тех... +100km");
                    motorcycle._odometer += 100;
                }
                else
                {
                    return;
                }
            }           
        }
    }
}
