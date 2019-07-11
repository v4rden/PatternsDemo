namespace Core.Decorator
{
    public class CheeseTopping : PizzaDecorator
    {
        public CheeseTopping(Pizza pizza) : base(pizza)
        {
            Description = "Cheese";
            Price = 1.25m;
        }

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