namespace Core.Decorator.Abstract
{
    public interface IDecorator<T>
    {
        T Decorated { get; }
    }
}