namespace Core.Decorator
{
    public class LargePizza : Pizza
    {
        public LargePizza()
        {
            Description = "Large pizza";
            Price = 9.99m;
        }

        protected override string Description { get; set; }
        protected override decimal Price { get; set; }

        public override string GetDescription()
        {
            return Description;
        }

        public override decimal GetPrice()
        {
            return Price;
        }
    }
}