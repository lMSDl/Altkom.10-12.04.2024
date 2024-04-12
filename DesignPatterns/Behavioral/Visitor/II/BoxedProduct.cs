using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._10_12._04._2024.DesignPatterns.Behavioral.Visitor.II
{
    internal class BoxedProduct : Product
    {
        public override void PrintType()
        {
            Console.WriteLine("BoxedProduct");
        }

        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
