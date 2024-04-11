using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._10_12._04._2024.DesignPatterns.Behavioral.ChainOfResponsibility.I
{
    internal class BaseHandler<T> : IHandler<T>
    {
        private readonly IHandler<T>? _handler;

        public BaseHandler(IHandler<T>? handler)
        {
            _handler = handler;
        }

        public virtual void Handle(T context)
        {
            _handler?.Handle(context);
        }
    }
}
