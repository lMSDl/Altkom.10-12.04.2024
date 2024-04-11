namespace Altkom._10_12._04._2024.DesignPatterns.Structural.Flyweight
{
    internal class Car
    {
        public required string Owner { get; set; }
        public required string Number { get; set; }
        public string Manufacturer
        {
            get => CarFlyweight.Manufacturer;
            set => SetValue(x => x.Manufacturer = value);
        }
        public string Model
        {
            get => CarFlyweight.Model;
            set => SetValue(x => x.Model = value);
        }
        public string Color
        {
            get => CarFlyweight.Color;
            set => SetValue(x => x.Color = value);
        }

        public CarFlyweight CarFlyweight { get; set; } = new CarFlyweight();

        private void SetValue(Action<CarFlyweight> action)
        {
            var clone = (CarFlyweight)CarFlyweight.Clone();
            action(clone);
            CarFlyweight = FlyweightFactory.Instance.GetFlyweight(clone);
        }
    }
}
