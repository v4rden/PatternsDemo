namespace Implementation.Composite
{
    using System.Collections.Generic;
    using Core.Composite;

    public abstract class Party<T> : Composite<T> where T : IIndividual
    {
        public abstract void GetStats();

        public abstract void SplitLoot(int gold);
    }
}