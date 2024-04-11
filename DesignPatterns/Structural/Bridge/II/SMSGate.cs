using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._10_12._04._2024.DesignPatterns.Structural.Bridge.II
{
    internal class SMSGate : IMessageSenderImplementation
    {
        public const int MaxLength = 10;

        public void SendMessage(string message)
        {
            var splittedMessage = Enumerable.Range(0, message.Length / MaxLength)
            .Select(i => message.Substring(i * MaxLength, MaxLength));

            foreach (var m in splittedMessage)
            {
                Console.WriteLine($"Wiadomość została wysłana przez bramkę SMS: {m}");
            }
        }
    }
}
