using System;

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
