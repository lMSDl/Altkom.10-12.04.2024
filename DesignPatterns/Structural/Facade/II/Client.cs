using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._10_12._04._2024.DesignPatterns.Structural.Facade.II
{
    internal class Client
    {
        public static void Execute()
        {
            var shop = new Facade();

            int[] productIds = new[] { 2, 63, 21, 7 };
            shop.Buy(productIds);

        }
    }
}
