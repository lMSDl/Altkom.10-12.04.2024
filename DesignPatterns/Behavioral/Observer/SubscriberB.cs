using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._10_12._04._2024.DesignPatterns.Behavioral.Observer
{
    internal class SubscriberB : Subscriber
    {
        public override void OnNext(int value)
        {
            if (value % 2 == 0)
                Console.WriteLine("SubscriberB zareagował");
        }
    }
}
