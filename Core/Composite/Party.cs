namespace Core.Composite
{
    using System.Collections.Generic;
    using Abstract;

    public abstract class Party<T> : Composite<T> where T : IIndividual
    {
        public abstract void GetStats();

        public abstract void SplitLoot(int gold);
    }
}