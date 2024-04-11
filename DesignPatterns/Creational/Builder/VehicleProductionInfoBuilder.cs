﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._10_12._04._2024.DesignPatterns.Creational.Builder
{
    internal class VehicleProductionInfoBuilder : VehicleBuilderFasade
    {
        public VehicleProductionInfoBuilder()
        {
        }

        public VehicleProductionInfoBuilder(Vehicle vehicle) : base(vehicle)
        {
        }

        public VehicleProductionInfoBuilder SetManufacturer(string manufacturer)
        {
            Vehicle.Manufacturer = manufacturer;
            return this;
        }
        public VehicleProductionInfoBuilder SetProductionDate(DateTime date)
        {
            Vehicle.ProductionDate = date;
            return this;
        }
    }
}