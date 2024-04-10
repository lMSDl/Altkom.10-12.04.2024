﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._10_12._04._2024.DesignPatterns.Creational.Builder
{
    internal class Client
    {
        public static void Execute()
        {
            var vehicle = new Vehicle(4, 5, 4, 500, 100);

            Console.WriteLine(vehicle);

            var vehicleBuilder = new VehicleBuilder();
            vehicleBuilder.SetWeels(4);
            vehicleBuilder.SetSeats(5);
            vehicleBuilder.SetDoors(4);
            vehicleBuilder.SetEngine(100);
            vehicleBuilder.SetTrunk(500);

            vehicle = vehicleBuilder.Build();
            Console.WriteLine(vehicle);


            vehicle = new Vehicle() { Doors = 4, Seats = 5, Wheels = 4, TrunkCapacity = 500, EnginePower = 100 };
            Console.WriteLine(vehicle);

            vehicle = new VehicleBuilder()
                        .SetWeels(4)
                        .SetSeats(5)
                        .SetDoors(4)
                        .SetEngine(100)
                        .SetTrunk(500)
                        .Build();

            Console.WriteLine(vehicle);
        }
    }
}