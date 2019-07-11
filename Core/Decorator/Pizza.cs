namespace Core.Decorator
{
    public abstract class Pizza
    {
        protected abstract string Description { get; set; }
        protected abstract decimal Price { get; set; }

        public abstract string GetDescription();
        public abstract decimal GetPrice();
    }
}