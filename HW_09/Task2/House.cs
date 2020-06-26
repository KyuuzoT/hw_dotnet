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

        public float Area
        {
            get { return _area; }
            set
            {
                if(value<0)
                {
                    Console.WriteLine("Area couldn't be negative!");
                }
                else if(value > 1.5*1e11)
                {
                    Console.WriteLine("Area couldn't be greater than total surface area!");
                }
                else
                {
                    _area = value;
                }
            }
        }

        public House()
        {
            _area = 200.0f;
            Door door = GetDoor();
            door.Color = "Magenta";
        }

        public House(int area)
        {
            _area = area;
        }

        public void ShowData()
        {
            Console.WriteLine($"I'm a {this.GetType()}, my area equals to {_area} m²");
        }

        public Door GetDoor()
        {
            return new Door();
        }
    }
}
