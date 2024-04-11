using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._10_12._04._2024.DesignPatterns.Structural.Bridge.II
{
    internal class ShortMessageAbstraction : MessageAbstraction
    {
        public ShortMessageAbstraction(IMessageSenderImplementation messageSender) : base(messageSender)
        {
        }

        public override void Send(string message)
        {
            if (message.Length > 10)
                Console.WriteLine("Message too long.");
            else
                base.Send(message);
        }
    }
}
