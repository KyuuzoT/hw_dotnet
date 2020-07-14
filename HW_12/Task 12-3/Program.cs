using System;

namespace Task_12_3
{
    class Program
    {
        private static IRepository<Motorcycle> _db;
        private static Motorcycle _moto;

        static void Main(string[] args)
        {
            _db = new MotorcycleRepository();

            _moto = new Motorcycle();
            _moto.ID = Guid.NewGuid();
            _moto.Model = "Kawasaki";
            _moto.Name = "Ninja";
            _moto.Year = 2006;
            _moto.OdometerValue = 27_000;

            CreateMotorcycle(_moto);
            PrintMotorcycle(_moto);

            _moto = new Motorcycle();
            _moto.ID = Guid.NewGuid();
            _moto.Model = "Suzuki";
            _moto.Name = "Boulevard";
            _moto.Year = 2012;
            _moto.OdometerValue = 15_380;
            CreateMotorcycle(_moto);

            _moto.OdometerValue = 32_000;
            UpdateMotorcycle(_moto);

            Console.ReadKey();
        }

        private static void PrintMotorcycle(Motorcycle moto)
        {
            Console.WriteLine(_db.GetMotorcycleById(moto.ID));
        }

        private static void UpdateMotorcycle(Motorcycle moto)
        {
            _db.UpdateMotorcycle(_moto);
        }

        private static void CreateMotorcycle(Motorcycle moto)
        {
            _db.CreateMotorcycle(moto);
        }
    }
}
