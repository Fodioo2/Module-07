using System;

public interface IMediator
{
    void SendMessage(string message, User sender);
    void AddUser(User user);
}