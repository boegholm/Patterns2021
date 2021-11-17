using System.Collections.Generic;

namespace Patterns
{
    class MultiCommand : ICommand
    {
        List<ICommand> Commands { get; } = new List<ICommand>();
        public void Add(ICommand c) => Commands.Add(c);
        public void Execute()
        {
            foreach (var command in Commands)
            {
                command.Execute();
            }
        }
    }
}
