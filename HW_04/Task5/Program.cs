using System;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0x5A, j = 0x7A; i >= 0x41 && j >= 0x61; i--, j--)
            {
                Console.Write(Char.ConvertFromUtf32(i) + Char.ConvertFromUtf32(j) + " ");
            }

            Console.ReadKey();
        }
    }
}
