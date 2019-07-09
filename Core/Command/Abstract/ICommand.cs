namespace Core.Command.Abstract
{
    public interface ICommand
    {
        void Validate();
        void Execute();
        void Undo();
    }
}