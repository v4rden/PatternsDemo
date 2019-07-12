namespace Implementation.Command
{
    using Core.Command;

    public interface ICommandFactory
    {
        string CommandName { get; }
        string Description { get; }

        ICommand MakeCommand(string[] args);
    }
}