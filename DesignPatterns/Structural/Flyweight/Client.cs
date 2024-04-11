using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._10_12._04._2024.DesignPatterns.Structural.Flyweight
{
    internal class Client
    {
        public static void Execute()
        {
            FlyweightFactory.Instance.Initialize(
    new CarFlyweight { Manufacturer = "Chevrolet", Model = "Camaro2018", Color = "Pink" },
    new CarFlyweight { Manufacturer = "Mercedes Benz", Model = "C300", Color = "Black" },
    new CarFlyweight { Manufacturer = "Mercedes Benz", Model = "C500", Color = "Red" },
    new CarFlyweight { Manufacturer = "BMW", Model = "M5", Color = "Red" },
    new CarFlyweight { Manufacturer = "BMW", Model = "X6", Color = "White" });

            Console.WriteLine(FlyweightFactory.Instance);

            var car1 = new Car
            {
                Number = "CL234IR",
                Owner = "James Doe",
                Manufacturer = "BMW",
                Model = "M5",
                Color = "Red"
            };
            //car1.CarFlyweight = FlyweightFactory.Instance.GetFlyweight(car1.CarFlyweight);

            var car2 = new Car
            {
                Number = "CL4127A",
                Owner = "Tom Downton",
                Manufacturer = "BMW",
                Model = "M6",
                Color = "Red"
            };
            //car2.CarFlyweight = FlyweightFactory.Instance.GetFlyweight(car2.CarFlyweight);

            Console.WriteLine(FlyweightFactory.Instance);

            car2.Color = "green";

            Console.WriteLine(FlyweightFactory.Instance);
        }
    }
}
