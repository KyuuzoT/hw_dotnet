using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3Catalogue
{
    class ProgramFile : File
    {       
        public void Execute()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Not implemented yet.");
            Console.ResetColor();
        }

        public override string GetFileInformation()
        {
            return base.GetFileInformation();
        }
    }
}
