﻿namespace Altkom._10_12._04._2024.SOLID
{
    internal abstract class Shape
    {
        public abstract double GetArea();
    }

    internal class Square : Shape
    {
        public int A { get; set; }

        public override double GetArea()
        {
            return A * A;
        }
    }

    internal class Rectangle : Shape
    {
        public int A { get; set; }
        public int B { get; set; }

        public override double GetArea()
        {
            return A * B;
        }
    }
    class Circle : Shape
    {
        public int R { get; set; }

        public override double GetArea()
        {
            return R * R * Math.PI;
        }
    }

    internal class ShapeCalculator
    {
        private double Area(Shape shape)
        {
            return shape.GetArea();
        }
    }


    /*abstract class Shape
    {
    }

    class Square : Shape
    {
        public int A { get; set; }
    }

    class Rectangle : Shape
    {
        public int A { get; set; }
        public int B { get; set; }
    }

    class Circle : Shape
    {
        public int R { get; set; }
    }

    class ShapeCalculator
    {
        double Area(Shape shape)
        {
            switch (shape)
            {
                case Square square:
                    return square.A * square.A;
                case Rectangle rectangle:
                    return rectangle.A * rectangle.B;
                case Circle circle:
                    return circle.R * circle.R * Math.PI;
                default:
                    return 0;
            }
        }
    }*/
}
