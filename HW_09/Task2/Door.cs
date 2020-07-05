using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Door
    {
        private Colors _color;

        public Colors Color
        {
            get { return _color; }
            set
            {
                _color = value;
            }
        }

        public void ShowData()
        {
            Console.WriteLine($"I'm a {this.GetType()}, my color is {Color}");
        }
    }
}
