namespace Core.Command
{
    public interface ICommand
    {
        void Validate();
        void Execute();
        void Undo();
    }
}