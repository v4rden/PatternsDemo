namespace Core.Composite.Abstract
{
    using System;
    using System.Collections.Generic;

    public abstract class Composite<T> : IComposite<T> where T : IIndividual
    {
        public List<T> Individuals { get; }

        public void PerformAction<TParam>(Action<TParam> action, TParam param)
        {
            action(param);
        }
    }
}