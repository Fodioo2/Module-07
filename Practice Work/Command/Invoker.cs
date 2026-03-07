using System;
using System.Collections.Generic;

public class RemoteControl
{
    private readonly Dictionary<int, ICommand> _slots = new();
    private readonly Stack<ICommand> _history = new();
    private readonly Stack<ICommand> _redoStack = new();

    public void SetCommand(int slot, ICommand command)
    {
        _slots[slot] = command;
    }

    public void PressButton(int slot)
    {
        if (!_slots.ContainsKey(slot))
        {
            Console.WriteLine($"Slot {slot} is empty.");
            return;
        }

        ICommand command = _slots[slot];
        command.Execute();
        _history.Push(command);
        _redoStack.Clear();
    }

    public void Undo()
    {
        if (_history.Count == 0)
        {
            Console.WriteLine("Nothing to undo.");
            return;
        }

        ICommand lastCommand = _history.Pop();
        lastCommand.Undo();
        _redoStack.Push(lastCommand);
    }

    public void Redo()
    {
        if (_redoStack.Count == 0)
        {
            Console.WriteLine("Nothing to redo.");
            return;
        }

        ICommand command = _redoStack.Pop();
        command.Execute();
        _history.Push(command);
    }

    public void ShowMenu()
    {
        Console.WriteLine("\n=== SMART HOME REMOTE ===");
        Console.WriteLine("1 - Light ON");
        Console.WriteLine("2 - Light OFF");
        Console.WriteLine("3 - TV ON");
        Console.WriteLine("4 - TV OFF");
        Console.WriteLine("5 - AC ON");
        Console.WriteLine("6 - AC OFF");
        Console.WriteLine("7 - Curtains OPEN");
        Console.WriteLine("8 - Curtains CLOSE");
        Console.WriteLine("9 - Music PLAY");
        Console.WriteLine("10 - Music STOP");
        Console.WriteLine("11 - Evening macro");
        Console.WriteLine("12 - Undo");
        Console.WriteLine("13 - Redo");
        Console.WriteLine("0 - Exit");
        Console.Write("Choose: ");
    }
}