using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._10_12._04._2024.DesignPatterns.Structural.Bridge.II
{
    internal class Client
    {
        public static void Execute()
        {


            Console.WriteLine("Send Email");
            MessageAbstraction message = new MessageAbstraction(new EmailGate());
            message.Send(Console.ReadLine());



            Console.WriteLine("Send SMS");
            message = new ShortMessageAbstraction(new SMSGate());
            message.Send(Console.ReadLine());
        }
        }
}
