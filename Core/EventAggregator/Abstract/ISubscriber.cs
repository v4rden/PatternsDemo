namespace Core.EventAggregator.Abstract
{
    public interface ISubscriber<T>
    {
        void OnEvent(T e);
    }
}