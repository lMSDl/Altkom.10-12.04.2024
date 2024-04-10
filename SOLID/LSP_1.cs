using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._10_12._04._2024.SOLID.L
{
    public abstract class Vehicle
    {
        public string Name { get; set; }
        public abstract void Move();
    }

    public class Airplain : Vehicle
    {
        public override void Move()
        {
            Console.WriteLine("I am flying!");
        }
    }

    public class Car : Vehicle
    {
        public override void Move()
        {
            Console.WriteLine("I am driving!");
        }
    }


    /*abstract class Vehicle
    {
        public string Name { get; set; }
        public abstract void Fly();
    }
    class Airplane : Vehicle
    {
        public override void Fly()
        {
            Console.WriteLine("I am flying!");
        }
    }
    class Car : Vehicle
    {
        public override void Fly()
        {
            throw new NotImplementedException();
        }
    }*/
}
