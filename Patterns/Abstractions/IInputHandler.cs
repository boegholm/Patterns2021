namespace Patterns
{
    interface IInputHandler
    {
        ICommand GetCommand(LightDisplay ld);
    }
}
