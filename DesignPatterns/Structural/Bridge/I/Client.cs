namespace Altkom._10_12._04._2024.DesignPatterns.Structural.Bridge.I
{
    internal class Client
    {
        public static void Execute()
        {
            Shape shape = new Square();
            shape.Color = new Red();
            Console.WriteLine(shape);


            Shape circle = new Circle();
            circle.Color = new Blue();
            circle.Color.Brightness = new Dark();
            Console.WriteLine(circle);
        }
    }
}
