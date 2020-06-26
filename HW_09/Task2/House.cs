using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class House
    {
        private float _area;

        public House()
        {
            _area = 200.0f;
        }

        public House(int area)
        {
            _area = area;
        }

        public void ShowData()
        {
            Console.WriteLine($"I'm a {this.GetType()}, my area equals to {_area} m²");
        }
    }
}
