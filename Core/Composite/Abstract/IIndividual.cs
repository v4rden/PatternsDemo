namespace Core.Composite.Abstract
{
    using System;

    public interface IIndividual
    {
        void PerformAction<TParam>(Action<TParam> action, TParam param);
    }
}