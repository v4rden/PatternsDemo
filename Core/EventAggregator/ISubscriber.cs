namespace Core.EventAggregator
{
    public interface ISubscriber<T>
    {
        void OnEvent(T e);
    }
}