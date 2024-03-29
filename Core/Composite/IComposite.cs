namespace Core.Composite
{
    using System.Collections.Generic;

    public interface IComposite<T> : IIndividual where T : IIndividual
    {
        List<T> Individuals { get; }
    }
}