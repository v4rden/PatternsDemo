namespace Implementation.Decorator
{
    public class SmallPizza : Pizza
    {
        public SmallPizza()
        {
            Description = "Small pizza";
            Price = 4.99m;
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