namespace Core.Command
{
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using Abstract;

    public class CommandParser
    {
        private readonly IEnumerable<ICommandFactory> _availableCommands;

        public CommandParser(IEnumerable<ICommandFactory> availableCommands)
        {
            _availableCommands = availableCommands;
        }

        public ICommand ParseCommand(string[] args)
        {
            var requestedCommand = args.First();

            var command = FindRequestedCommand(requestedCommand);

            return command.MakeCommand(args);
        }

        private ICommandFactory FindRequestedCommand(string requestedCommand)
        {
            return _availableCommands.FirstOrDefault(cmd => cmd.CommandName == requestedCommand);
        }
    }
}