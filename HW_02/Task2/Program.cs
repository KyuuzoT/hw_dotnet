using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isTrue = true;
            Boolean isFalse = false;
            short sh1 = 5;
            Int16 sh2 = 6;
            int i1 = 33;
            Int32 i2 = 22;
            long l1 = 4444;
            Int64 l2 = 5555;
            byte b1 = 12;
            Byte b2 = 13;
            float f1 = 66.66f;
            Single f2 = 77.77f;
            double d1 = 888.888;
            Double d2 = 878.788;
            decimal dec1 = 99999999.99M;
            Decimal dec2 = 9888999.98M;
            object o1 = new object[1, 2, 3];
            Object o2 = new Object[3, 2, 1];
            char ch1 = 'A';
            Char ch2 = 'B';
            string s1 = "Hello there!";
            String s2 = "General Kenobi!";

            Console.WriteLine($"Bool:\n C#: {isTrue.GetType()}\n CLR: {isFalse.GetType()}");
            Console.WriteLine($"Short:\n C#: {sh1.GetType()}\n CLR: {sh2.GetType()}");
            Console.WriteLine($"Int:\n C#: {i1.GetType()}\n CLR: {i2.GetType()}");
            Console.WriteLine($"Long:\n C#: {l1.GetType()}\n CLR: {l2.GetType()}");
            Console.WriteLine($"Byte:\n C#: {b1.GetType()}\n CLR: {b2.GetType()}");
            Console.WriteLine($"Float:\n C#: {f1.GetType()}\n CLR: {f2.GetType()}");
            Console.WriteLine($"Double:\n C#: {d1.GetType()}\n CLR: {d2.GetType()}");
            Console.WriteLine($"Decimal:\n C#: {dec1.GetType()}\n CLR: {dec2.GetType()}");
            Console.WriteLine($"Object (array):\n C#: {o1.GetType()}\n CLR: {o2.GetType()}");
            Console.WriteLine($"Char:\n C#: {ch1.GetType()}\n CLR: {ch2.GetType()}");
            Console.WriteLine($"String:\n C#: {s1.GetType()}\n CLR: {s2.GetType()}");


            Console.ReadKey();
        }
    }
}
