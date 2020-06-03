using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstValue;
            double secondValue;
            Console.WriteLine("Input parameters for calculating:\n");
            Console.WriteLine("First parameter: ");            
            string readFirst = Console.ReadLine();

            if(Double.TryParse(readFirst, out firstValue))
            {
                Console.WriteLine("\nFirst value adding - success!\n")
            }

            Console.WriteLine("Second parameter: ");
            string readSecond = Console.ReadLine();

            if (Double.TryParse(readSecond, out secondValue))
            {
                Console.WriteLine("\nSecond value adding - success!\n");
            }
        }
    }
}
