using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._10_12._04._2024.DesignPatterns.Structural.Flyweight
{
    internal class CarFlyweight : ICloneable
    {
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }

        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}
