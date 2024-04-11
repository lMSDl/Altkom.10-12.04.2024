using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._10_12._04._2024.DesignPatterns.Behavioral.ChainOfResponsibility.I
{
    internal class Client
    {
        public static void Execute()
        {

            var handler4 = new DiscountHandler("Kierownik sklepu", 1000, 7000);
            var handler3 = new DiscountHandler("Kierownik sali", 500, 7000, handler4);
            //var handler2 = new DiscountHandler("Kierownik kas", 500, 10000, handler3);
            var handler1 = new DiscountHandler("Kasjer", 100, 10000, handler3);



            var context = new DiscountHandlerContext(15000, 500);

            handler1.Handle(context);

            handler3.Handle(context);

            context = new DiscountHandlerContext(15000, 10000);
            handler1.Handle(context);
        }
    }
}
