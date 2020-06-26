using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Jack");
            House appts = new SmallApartment();
            person.HouseOfPerson = appts;
            person.HouseOfPerson.SetDoor(new Door());
            person.HouseOfPerson.GetDoor().Color = Colors.Magenta;
            person.ShowData();

            Console.WriteLine("\n");

            Person yetAnotherPerson = new Person();
            House housing = new House(250,doorColor:Colors.MistyRose);
            yetAnotherPerson.HouseOfPerson = housing;
            yetAnotherPerson.ShowData();
            Console.ReadKey();
        }
    }
}
