namespace Core.ChainOfResponsibility
{
    public interface IMessageHandler<T, U>
    {
        T HandleMessage(U input);
    }
}