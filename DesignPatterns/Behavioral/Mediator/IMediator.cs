using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._10_12._04._2024.DesignPatterns.Behavioral.Mediator
{
    internal interface IMediator
    {
        void Join(ChatMemeber member);
        void Quit(ChatMemeber member);
        void Send(string from, string message);
        void Send(string from, string to, string message);
    }
}
