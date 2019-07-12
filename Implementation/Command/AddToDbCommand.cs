namespace Implementation.Command
{
    using System;
    using System.Linq;
    using Core.Command;

    public class AddToDbCommand : ICommand, ICommandFactory
    {
        public string CommandName => "AddToDbCommand";
        public string Description => "Adds item to db";
        public string ItemToAdd { get; set; }
        private IRepo _repo;

        public AddToDbCommand(IRepo repo)
        {
            _repo = repo;
        }

        public void Validate()
        {
            Console.WriteLine($"Validating value of \"{ItemToAdd}\"");
        }

        public void Execute()
        {
            _repo.Add(ItemToAdd);
            Console.WriteLine($"Added {ItemToAdd} to DB");
        }

        public void Undo()
        {
            _repo.Remove(ItemToAdd);
            Console.WriteLine($"Undone {CommandName}, {ItemToAdd} was removed");
        }

        public ICommand MakeCommand(string[] args)
        {
            return new AddToDbCommand(Repo.GetInstance()) {ItemToAdd = args.FirstOrDefault()};
        }
    }
}