using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Teacher : Person
    {
        public string Subject { get; set; }

        public void Explain()
        {
            Console.WriteLine("Explanation begins.");
        }

        public override void SayHello()
        {
            Console.WriteLine($"Hello, I'm {this.GetType()} and I'm explaining on {Subject}");
        }
    }
}
