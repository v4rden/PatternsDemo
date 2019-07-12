namespace Implementation.Command
{
    public interface IRepo
    {
        void Add(string itemToAdd);
        void Remove(string itemToRemove);
    }
}