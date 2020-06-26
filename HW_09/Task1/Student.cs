using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Student : Person
    {
        public void ShowAge()
        {
            Console.WriteLine($"My age is: {GetAge} years old.");
        }

        public int GetAge
        {
            get { return Age; }
        }

        public void GoToClasses()
        {
            Console.WriteLine("I'm going to classes!");
        }
    }
}
