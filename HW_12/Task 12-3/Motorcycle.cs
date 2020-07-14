using System;
using System.Collections.Generic;
using System.Text;

namespace Task_12_3
{
    class Motorcycle
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public string Model { get; set; }
        public short Year { get; set; }
        public int OdometerValue { get; set; }

        public override string ToString()
        {
            return $"ID: {ID}. {Model} {Name} assembled in {Year} year. Odometer Value = {OdometerValue} km.";
        }
    }
}
