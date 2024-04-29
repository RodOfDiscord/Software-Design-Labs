namespace LightHTML.command
{
    public class NodeCommand : ICommand
    {
        public Action Execute {  get; private set; }
        public Action Undo {  get; private set; }

        public NodeCommand(Action execute, Action undo)
        {
            Execute = execute;
            Undo = undo;
        }
    }
}
