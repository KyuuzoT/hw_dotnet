using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input your name:");
            string sName = Console.ReadLine();
            DateTime birthday;
            do
            {
                Console.WriteLine("Please input your date of birth in format: {0:d}", new DateTime(1970,1,1));
            } while (!DateTime.TryParse(Console.ReadLine(), out birthday));
            
            
        }
    }
}
