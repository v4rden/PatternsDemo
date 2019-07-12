namespace Implementation.Decorator
{
    public class HamTopping : PizzaDecorator
    {
        public HamTopping(Pizza pizza) : base(pizza)
        {
            Description = "Ham";
            Price = 2.99m;
        }

        protected override string Description { get; set; }
        protected override decimal Price { get; set; }

        public override string GetDescription()
        {
            return $"{Decorated.GetDescription()}, {Description}";
        }

        public override decimal GetPrice()
        {
            return Decorated.GetPrice() + Price;
        }
    }
}