using System;

public class User : IUser
{
    private readonly IMediator _mediator;

    public string Name { get; }

    public User(string name, IMediator mediator)
    {
        Name = name;
        _mediator = mediator;
    }

    public void SendToChannel(string channelName, string message)
    {
        _mediator.SendMessage(channelName, message, this);
    }

    public void SendPrivate(User receiver, string message)
    {
        _mediator.SendPrivateMessage(this, receiver, message);
    }

    public void Receive(string message)
    {
        Console.WriteLine($"{Name} received: {message}");
    }
}
