using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Person
    {
        private House _personalHouse;
        public string Name
        {
            get; set;
        }

        public House HouseOfPerson
        {
            get { return _personalHouse; }
            set
            {
                if(value != null)
                {
                    _personalHouse = value;
                }
                else
                {
                    Console.WriteLine("Every person should have a house!");
                }
            }
        }

        public Person()
        {
            Name = "Gzegosh Breshtashikevich";
        }

        public Person(string name)
        {
            Name = name;
        }

        public void ShowData()
        {
            Console.WriteLine($"Hi, I'm {this.GetType()}, my name is {this.Name}, I live in {_personalHouse.GetType()} with this parameters: ");
            _personalHouse.ShowData();
            _personalHouse.GetDoor().ShowData();
        }
    }
}
