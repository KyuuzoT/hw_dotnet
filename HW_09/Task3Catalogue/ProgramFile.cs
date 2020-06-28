using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3Catalogue
{
    class ProgramFile
    {
        protected long _size;

        public long Size
        {
            get
            {
                return _size;
            }
            set
            {
                if (value > 0)
                {
                    _size = value;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Size of file can not be negative and must be greater than 0!");
                    Console.ResetColor();
                }
            }
        }

        public void Execute()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Not implemented yet.");
            Console.ResetColor();
        }
    }
}
