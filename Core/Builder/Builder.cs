namespace Core.Builder
{
    public abstract class Builder<T>
    {
        public abstract void Create();
        public abstract T Get();
    }
}