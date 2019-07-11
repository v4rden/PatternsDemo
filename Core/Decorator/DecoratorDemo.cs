namespace Core.Decorator
{
    using System;

    public class DecoratorDemo
    {
        public void DoDemo()
        {
            Pizza largePizza = new LargePizza();
            largePizza = new CheeseTopping(largePizza);
            largePizza = new HamTopping(largePizza);

            Console.WriteLine(largePizza.GetDescription());
            Console.WriteLine(largePizza.GetPrice());
        }
    }
}