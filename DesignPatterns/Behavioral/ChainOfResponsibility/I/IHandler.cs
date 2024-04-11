using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._10_12._04._2024.DesignPatterns.Behavioral.ChainOfResponsibility.I
{
    internal interface IHandler<T>
    {
        public void Handle(T context);
    }
}
