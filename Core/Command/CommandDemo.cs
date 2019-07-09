namespace Core.Command
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class CommandDemo
    {
        public void DoDemo(string[] args)
        {
            var commands = GetCommands();

            if (args.Length == 0)
            {
                PrintUsage(commands);
            }

            var parser = new CommandParser(commands);
            var command = parser.ParseCommand(args);
            if (command != null)
                command.Execute();
        }

        public IEnumerable<ICommandFactory> GetCommands()
        {
            return new ICommandFactory[]
            {
                new AddToDbCommand(Repo.GetInstance())
            };
        }

        public void PrintUsage(IEnumerable<ICommandFactory> commands)
        {
            Console.WriteLine("Commands:");
            foreach (var command in commands)
            {
                Console.WriteLine($" {command.Description}");
            }
        }
    }
}