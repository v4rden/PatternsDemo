namespace Core.Decorator
{
    using Abstract;

    public class PizzaDecorator : Pizza, IDecorator<Pizza>
    {
        public Pizza Decorated { get; }
        protected override string Description { get; set; }
        protected override decimal Price { get; set; }

        public PizzaDecorator(Pizza pizza)
        {
            Decorated = pizza;
        }

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