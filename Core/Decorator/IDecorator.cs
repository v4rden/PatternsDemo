namespace Core.Decorator
{
    public interface IDecorator<T>
    {
        T Decorated { get; }
    }
}