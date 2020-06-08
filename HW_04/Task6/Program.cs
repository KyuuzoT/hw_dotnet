using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
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
