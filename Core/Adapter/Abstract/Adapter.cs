namespace Core.Adapter.Abstract
{
    using System;

    public abstract class Adapter<T>
    {
        protected T Adaptee { get; }

        protected Adapter(T adaptee)
        {
            Adaptee = adaptee;
        }

        protected abstract TReturnValue AdaptedOperation<TReturnValue, TInputParameter>(TInputParameter param);
    }
}