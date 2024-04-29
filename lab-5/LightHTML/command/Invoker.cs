namespace LightHTML.command
{
    public class Invoker
    {
        private List<ICommand> commands;
        private Stack<ICommand> executedCommands = [];

        public Invoker(List<ICommand> commands)
        {
            this.commands = commands;
        }

        public void Run()
        {
            foreach (ICommand command in commands)
            {
                command.Execute();
                executedCommands.Push(command);
            }
        }

        public void Revert()
        {
            while (executedCommands.Count > 0)
            {
                executedCommands.Pop().Undo();
            }
        }
    }
}
