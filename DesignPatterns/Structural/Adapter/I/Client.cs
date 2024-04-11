using Altkom._10_12._04._2024.SOLID;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._10_12._04._2024.DesignPatterns.Structural.Adapter.I
{
    internal class Client
    {
        public static void Execute()
        {
            var circle = new Circle() { R = 5 };

            CheckR(circle);

            var square = new Square() { A = 8 };
            

            CheckR(new SquareToCircleAdapter(square));
        }


        public static void CheckR(ICircle circle)
        {
            Console.WriteLine(circle.R <= 5);
        }
    }
}
