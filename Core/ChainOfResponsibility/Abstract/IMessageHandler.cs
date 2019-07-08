namespace Core.ChainOfResponsibility.Abstract
{
    public interface IMessageHandler<T, U>
    {
        T HandleMessage(U input);
    }
}