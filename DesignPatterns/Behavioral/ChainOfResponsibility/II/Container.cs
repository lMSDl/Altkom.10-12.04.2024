using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._10_12._04._2024.DesignPatterns.Behavioral.ChainOfResponsibility.II
{
    internal abstract class Container : Control
    {
        protected ICollection<Control> Controls { get; } = new List<Control>();

        public void Add(Control control)
        {
            Controls.Add(control);
            control.Parent = this;
        }

    }
}
