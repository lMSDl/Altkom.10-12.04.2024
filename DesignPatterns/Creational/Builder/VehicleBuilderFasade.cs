using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._10_12._04._2024.DesignPatterns.Creational.Builder
{
    internal class VehicleBuilderFasade : BaseVehicleBuilder
    {
        public VehicleBuilderFasade()
        {
        }

        public VehicleBuilderFasade(Vehicle vehicle) : base(vehicle)
        {
        }

        public VehicleBuilder Parts => new VehicleBuilder(Vehicle);

        public VehicleProductionInfoBuilder Info => new VehicleProductionInfoBuilder(Vehicle);
    }
}
