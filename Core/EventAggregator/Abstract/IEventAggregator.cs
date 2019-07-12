namespace Core.EventAggregator.Abstract
{
    public interface IEventAggregator
    {
        void Subscribe(object subscriber);
        void Publish<TEvent>(TEvent eventToPublish);
    }
}