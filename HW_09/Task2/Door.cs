using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Door
    {
        private string _color;

        public string Color
        {
            get { return _color; }
            set
            {
                if(!string.IsNullOrEmpty(value))
                {
                    _color = value;
                }
                else
                {
                    Console.WriteLine("Door couldn't be painted with void!");
                }
            }
        }

        public void ShowData()
        {
            Console.WriteLine($"I'm a {this.GetType()}, my color is {Color}");
        }
    }
}
