using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._10_12._04._2024.DesignPatterns.Behavioral.Mediator
{
    internal class ChatUser : ChatMemeber
    {
        public override void Receive(string from, string message, bool isPrivate)
        {
            Console.WriteLine($"{from}{(isPrivate ? $" to {Nick}" : "")}: {message}");
        }
    }
}
