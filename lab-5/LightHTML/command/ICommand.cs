namespace LightHTML.command
{
    public interface ICommand
    {
        Action Execute { get; }
        Action Undo { get; }
    }
}
