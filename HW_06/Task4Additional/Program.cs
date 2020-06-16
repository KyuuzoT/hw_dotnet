using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4Additional
{
    class Program
    {
        static void Main(string[] args)
        {
            object objInt = 132;
            object objString = "smth";
            Console.WriteLine($"Test int-box: {objInt} string-box: {objString}  {18}");
            Console.WriteLine("Test int-box: " + objInt + " string-box: " + objString + "  " + 18);

            Console.ReadKey();
        }
    }
}
