using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._10_12._04._2024.DesignPatterns.Structural.Composite
{
    internal class Leaf : IComponent
    {
        public string Name => GetType().Name;
        public float Price { get; set; }

        public Leaf(float price)
        {
            Price = price;
        }

        public float GetValue()
        {
            Console.WriteLine($"Wartość {Name} to {Price}");
            return Price;
        }
    }
}
