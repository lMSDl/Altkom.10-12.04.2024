using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._10_12._04._2024.DesignPatterns.Creational.Builder
{
    internal abstract class BaseVehicleBuilder
    {
        protected Vehicle Vehicle { get; }

        protected BaseVehicleBuilder() : this(new Vehicle())
        {
        }

        protected BaseVehicleBuilder(Vehicle vehicle)
        {
            Vehicle = vehicle;
        }

        public Vehicle Build()
        {
            return (Vehicle)Vehicle.Clone();
        }
    }
}
