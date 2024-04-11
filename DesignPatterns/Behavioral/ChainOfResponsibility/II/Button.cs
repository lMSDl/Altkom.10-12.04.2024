using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._10_12._04._2024.DesignPatterns.Behavioral.ChainOfResponsibility.II
{
    internal class Button : Control
    {
        public Func<bool> OnClick { get; set; }

        protected override void Click(bool handled)
        {
            if (!handled && OnClick())
                base.Click(true);
            else
                base.Click(handled);
        }
    }
}
