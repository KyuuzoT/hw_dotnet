using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Person
    {
        private static int _age;

        protected int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        public void SetAge(int age)
        {
            Age = age;
        }

        public virtual void SayHello()
        {
            Console.WriteLine($"Hello, I'm {this.GetType()}");
        }
    }
}
