using System;

public class User
{
    private IMediator mediator;
    public string Name { get; }

    public User(string name, IMediator mediator)
    {
        Name = name;
        this.mediator = mediator;
    }

    public void Send(string message)
    {
        mediator.SendMessage(message, this);
    }

    public void Receive(string message)
    {
        Console.WriteLine($"{Name} received: {message}");
    }
}