namespace Altkom._10_12._04._2024.DesignPatterns.Behavioral.ChainOfResponsibility.I
{
    internal class DiscountHandler : BaseHandler<DiscountHandlerContext>
    {
        private string Name { get; }
        protected float MaxDiscount { get; }
        protected float MinPrice { get; }

        public DiscountHandler(string name, float maxDiscount, float minPrice, IHandler<DiscountHandlerContext>? handler) : base(handler)
        {
            Name = name;
            MaxDiscount = maxDiscount;
            MinPrice = minPrice;
        }

        public DiscountHandler(string name, float maxDiscount, float minPrice) : this(name, maxDiscount, minPrice, null)
        {
        }

        public override void Handle(DiscountHandlerContext context)
        {
            if (context.Price >= MinPrice && context.Value <= MaxDiscount)
            {
                context.Result = true;
                Console.WriteLine($"{Name} udzielił rabatu {context.Value}");
            }
            else
            {
                Console.WriteLine($"{Name} przekazał dalej");
                base.Handle(context);
            }
        }
    }
}
