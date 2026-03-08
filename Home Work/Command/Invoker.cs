public class Invoker
{
    private ICommand lastCommand;

    public void RunCommand(ICommand command)
    {
        command.Execute();
        lastCommand = command;
    }

    public void Undo()
    {
        if (lastCommand != null)
            lastCommand.Undo();
        else
            Console.WriteLine("No command to undo");
    }
}