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
        private Door _door;

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
        }

        public House(int area)
        {
            _area = area;
        }

        public House(int area, Colors doorColor)
        {
            _area = area;
            SetDoor(new Door());
            GetDoor().Color = doorColor;
        }

        public void ShowData()
        {
            Console.WriteLine($"I'm a {this.GetType()}, my area equals to {_area} m².");
        }

        public Door GetDoor()
        {
            return _door;
        }

        public void SetDoor(Door door)
        {
            _door = door;
        }
    }
}
