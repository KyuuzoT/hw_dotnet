using System;

namespace Task6_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("\t1. Press W - to move upwards");
            Console.WriteLine("\t2. Press S - to move downwards");
            Console.WriteLine("\t3. Press A - to move leftwards");
            Console.WriteLine("\t4. Press D - to move rightwards");
            Console.WriteLine("\t4. Press Esc - to exit the game");

            while (true)
            {
                ConsoleKeyInfo input = Console.ReadKey();
                Console.WriteLine();
                switch (input.Key)
                {
                    case ConsoleKey.W:
                        Console.WriteLine("Player moves upwards");
                        break;
                    case ConsoleKey.S:
                        Console.WriteLine("Player moves downwards");
                        break;
                    case ConsoleKey.A:
                        Console.WriteLine("Player moves leftwards");
                        break;
                    case ConsoleKey.D:
                        Console.WriteLine("Player moves rightwards");
                        break;
                    case ConsoleKey.Escape:
                        return;
                    default:
                        Console.WriteLine("Player stays where he is.");
                        break;
                }
            }
        }
    }
}