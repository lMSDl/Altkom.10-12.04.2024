using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._10_12._04._2024.DesignPatterns.Behavioral.State
{
    internal abstract class State
    {
        protected CoffeeMachine CoffeeMachine { get; }

        protected State(CoffeeMachine coffeeMachine)
        {
            CoffeeMachine = coffeeMachine;
        }

        public abstract void Small();
        public abstract void Large();
    }
}
