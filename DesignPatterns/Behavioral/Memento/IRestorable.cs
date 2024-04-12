using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._10_12._04._2024.DesignPatterns.Behavioral.Memento
{
    internal interface IRestorable<T>
    {
        void Restore(T state);
    }
}
