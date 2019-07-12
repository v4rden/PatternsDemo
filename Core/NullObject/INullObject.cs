namespace Core.NullObject
{
    //todo implement in strategy, command
    public interface INullObject<T>
    {
        T NullObject { get; }
    }
}